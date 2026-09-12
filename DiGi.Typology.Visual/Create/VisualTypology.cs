using DiGi.Core.IO.Table.Classes;
using DiGi.Core.IO.Table.Interfaces;
using DiGi.Typology.Classes;
using DiGi.Typology.Interfaces;
using DiGi.Typology.Visual.Classes;
using DiGi.Typology.Visual.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Typology.Visual
{
    public static partial class Create
    {
        /// <summary>
        /// Classifies the rows of a table into a Visual typology tree, grouping them by the chained columns of a Visual
        /// column typology filter, so that each node also carries the appearance of the bucket it came from.
        /// <para>Each level of the chain resolves its column against the table by unique id, so a chain may be declared
        /// from columns that carry no table index: an index belongs to the table a column was added to rather than to
        /// the column itself. The caller's chain is never modified - a new chain is built over the table's own column
        /// instances, reusing the rule of each level rather than copying it, so a Visual rule's appearance collection is
        /// the one read at solve time.</para>
        /// <para>A node is named and described exactly as the base solver names it: the level's column name and the rule
        /// data's text, and the column's description when the column carries one. Its appearance is the one the rule data
        /// carries - see <see cref="IVisualTypologyFilterRuleData"/> - or null when the rule maps none for that
        /// bucket, or when the level carries a base rule: no member of the level itself carries a fallback.</para>
        /// <para>A row whose value resolves to no bucket at a level is excluded from that level's subtree, and from every
        /// level below it. A range rule resolves nothing for a null value, a value it cannot convert, and a value outside
        /// every declared range, so rows with no value in a range column are absent below that point. A unique value rule
        /// buckets nulls instead, under the name "null". There is no catch-all bucket.</para>
        /// <para>With <paramref name="includeReferences"/> set, every node from the matched one up to the root stores the
        /// reference - the reference column's cell value, read from the resolved column - so an ancestor's references are
        /// those of its whole subtree. Clear it to solve structure, node metadata and appearance only, for a tree whose
        /// node to object association is held elsewhere.</para>
        /// <para>A chain this cannot honour in full is refused rather than solved in part: a level naming a column the
        /// table does not hold, a level carrying no rule, and a chain linking back on itself all return null, because
        /// each would otherwise answer with a tree ending above the level that was asked for. An empty table returns null
        /// for the same reason - there is nothing to answer with.</para>
        /// </summary>
        /// <param name="table">The table whose rows are classified.</param>
        /// <param name="columnTypologyFilter">The root of the Visual filter chain describing the grouping levels.</param>
        /// <param name="column_Reference">The column identifying a row. Resolved against the table by unique id, and required unless <paramref name="includeReferences"/> is cleared.</param>
        /// <param name="typologyItem_Root">The item naming the root node. When null the root is left unnamed.</param>
        /// <param name="includeReferences">A value indicating whether the identified references are stored on the nodes.</param>
        /// <returns>The solved Visual typology, or null when the table or the chain is null, when the table holds no rows, when a column named by the chain is absent from the table, when a level of the chain carries no rule, when the chain links back on itself, or when a required reference column is absent or unresolvable.</returns>
        public static VisualTypology? VisualTypology(this Table? table, VisualColumnTypologyFilter<Column>? columnTypologyFilter, Column? column_Reference, VisualTypologyItem? typologyItem_Root = null, bool includeReferences = true)
        {
            if (table is null || columnTypologyFilter is null || !table.Any())
            {
                return null;
            }

            Dictionary<string, Column> columns = [];
            foreach (Column column in table.Columns)
            {
                // Fully qualified: DiGi.Core.IO.Table.Query and DiGi.Core.Query both declare an applicable UniqueId,
                // and which one an unqualified call binds to is decided by the using block rather than by the call site.
                string? uniqueId_Column = Core.IO.Query.UniqueId(column);

                if (string.IsNullOrWhiteSpace(uniqueId_Column) || columns.ContainsKey(uniqueId_Column!))
                {
                    continue;
                }

                columns[uniqueId_Column!] = column;
            }

            VisualColumnTypologyFilter<Column>? columnTypologyFilter_Result = null;
            VisualColumnTypologyFilter<Column>? columnTypologyFilter_Last = null;

            HashSet<VisualColumnTypologyFilter<Column>> columnTypologyFilters_Visited = [];
            VisualColumnTypologyFilter<Column>? columnTypologyFilter_Current = columnTypologyFilter;

            while (columnTypologyFilter_Current is not null)
            {
                if (!columnTypologyFilters_Visited.Add(columnTypologyFilter_Current))
                {
                    // The chain links back on a level it already passed. Solving what was collected up to here
                    // would answer with a tree quietly missing the levels below it, so the chain is refused.
                    return null;
                }

                if (columnTypologyFilter_Current.Rule is null)
                {
                    // A level with no rule groups nothing, and the solve stops at it rather than reporting it -
                    // the tree would simply end above the level the caller asked for.
                    return null;
                }

                if (!TryResolveColumn(columnTypologyFilter_Current.Value, out Column? column_Level))
                {
                    return null;
                }

                VisualColumnTypologyFilter<Column> columnTypologyFilter_Temp = new()
                {
                    Value = column_Level,
                    Rule = columnTypologyFilter_Current.Rule
                };

                if (columnTypologyFilter_Result is null)
                {
                    columnTypologyFilter_Result = columnTypologyFilter_Temp;
                }
                else
                {
                    columnTypologyFilter_Last!.Filter = columnTypologyFilter_Temp;
                }

                columnTypologyFilter_Last = columnTypologyFilter_Temp;
                columnTypologyFilter_Current = columnTypologyFilter_Current.Filter;
            }

            if (columnTypologyFilter_Result is null)
            {
                return null;
            }

            Column? column_Reference_Table = null;
            if (includeReferences && !TryResolveColumn(column_Reference, out column_Reference_Table))
            {
                return null;
            }

            VisualTypology visualTypology = typologyItem_Root is null ? new(string.Empty, string.Empty) : new(typologyItem_Root);

            Solve(visualTypology, columnTypologyFilter_Result, table, column_Reference_Table);

            return visualTypology;

            void Solve(VisualTypology typology, VisualColumnTypologyFilter<Column> typologyFilter, IEnumerable<Row> rows, Column? column_Reference_Level)
            {
                if (typologyFilter.Value is not Column column || typologyFilter.Rule is not ITypologyFilterRule typologyFilterRule)
                {
                    return;
                }

                Dictionary<ITypologyFilterRuleData, List<Row>> dictionary = [];

                foreach (Row row in rows)
                {
                    object? object_Value = row[column.Index];

                    // DiGi.Typology is stated in full so the call pins the base Query.RuleData - the reflection path
                    // the base solver dispatches through, reaching the rule data of a base rule and of a Visual rule
                    // alike - rather than whichever RuleData the using block happens to import.
                    ITypologyFilterRuleData? typologyFilterRuleData = DiGi.Typology.Query.RuleData(typologyFilterRule, object_Value);
                    if (typologyFilterRuleData is null)
                    {
                        continue;
                    }

                    if (!dictionary.TryGetValue(typologyFilterRuleData, out List<Row>? rows_Temp) || rows_Temp is null)
                    {
                        rows_Temp = [];
                        dictionary[typologyFilterRuleData] = rows_Temp;
                    }

                    rows_Temp.Add(row);
                }

                foreach (KeyValuePair<ITypologyFilterRuleData, List<Row>> keyValuePair in dictionary)
                {
                    if (!typology.TryGetLastIndex(out int index_Max))
                    {
                        // Seed -1 so the first bucket of a level lands at index [0], consistent with Modify.Update
                        // and the -1 "no path" sentinel in TypologyPath.Index.
                        index_Max = -1;
                    }

                    int index = index_Max + 1;

                    // The item carries the full parent-relative path, exactly as Modify.Update would build it, so the
                    // solved tree answers path queries the same way the base solver's output does.
                    VisualTypologyItem visualTypologyItem = GetTypologyItem(column, keyValuePair.Key, typology.TypologyPath + new TypologyPath([index]));

                    VisualTypology typology_Temp = new(visualTypologyItem);
                    typology[index] = typology_Temp;

                    if (includeReferences && column_Reference_Level is not null)
                    {
                        foreach (Row row in keyValuePair.Value)
                        {
                            string? string_Reference = row[column_Reference_Level.Index]?.ToString();

                            // A blank cell is no identity. Left as an empty string it would be stored as a reference on
                            // every node from the matched one up to the root, where it says nothing about any object.
                            if (string.IsNullOrWhiteSpace(string_Reference))
                            {
                                continue;
                            }

                            typology_Temp.AddReference(string_Reference);
                        }
                    }

                    if (typologyFilter.Filter is VisualColumnTypologyFilter<Column> typologyFilter_Nested)
                    {
                        Solve(typology_Temp, typologyFilter_Nested, keyValuePair.Value, column_Reference_Level);
                    }
                }
            }

            VisualTypologyItem GetTypologyItem(Column column, ITypologyFilterRuleData typologyFilterRuleData, TypologyPath? typologyPath)
            {
                string name = $"{column.Name ?? string.Empty} {typologyFilterRuleData}";

                string? description = null;
                if (column is IExtendedColumn extendedColumn)
                {
                    description = extendedColumn.Description;
                }

                // The appearance rides on the rule data of a Visual rule, by reference to the rule's collection entry;
                // a base rule attached to a Visual level resolves no appearance.
                TypologyAppearance? typologyAppearance = typologyFilterRuleData is IVisualTypologyFilterRuleData visualTypologyFilterRuleData ? visualTypologyFilterRuleData.Appearance : null;

                return new VisualTypologyItem(typologyPath, name, description, typologyAppearance);
            }

            bool TryResolveColumn(Column? column, out Column? column_Resolved)
            {
                column_Resolved = null;

                string? uniqueId = Core.IO.Query.UniqueId(column);
                if (string.IsNullOrWhiteSpace(uniqueId))
                {
                    return false;
                }

                return columns.TryGetValue(uniqueId!, out column_Resolved);
            }
        }

        /// <summary>
        /// Creates a <see cref="T:DiGi.Typology.Visual.Classes.VisualTypology"/> carrying the given item and the given sub-typologies.
        /// <para>The sub-typologies are filed by <c>AddSubTypologies</c>: each is cloned and filed under the last index
        /// of its own path, or under the next free index when it carries no path or its index is already taken.
        /// Resolving those indexes is why this is a factory rather than a constructor. This is the
        /// <see cref="T:DiGi.Typology.Visual.Classes.VisualTypology"/> sibling of the base <c>Create.Typology</c>, which would file a plain node and
        /// drop the item's appearance.</para>
        /// </summary>
        /// <param name="typologyItem">The typology item to assign.</param>
        /// <param name="subTypologies">A collection of sub-typologies to associate with the new instance.</param>
        /// <returns>The created typology, or null when both arguments are null.</returns>
        public static VisualTypology? VisualTypology(this VisualTypologyItem? typologyItem, IEnumerable<VisualTypology>? subTypologies)
        {
            if (typologyItem is null && subTypologies is null)
            {
                return null;
            }

            VisualTypology result = new(typologyItem);

            result.AddSubTypologies(subTypologies);

            return result;
        }
    }
}
