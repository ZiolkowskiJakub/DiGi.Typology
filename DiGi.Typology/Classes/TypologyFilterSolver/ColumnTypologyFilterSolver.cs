using DiGi.Core.IO.Table.Classes;
using DiGi.Core.IO.Table.Interfaces;
using DiGi.Typology.Interfaces;
using System.Collections.Generic;

namespace DiGi.Typology.Classes
{
    /// <summary>
    /// Solver that applies a <see cref="ColumnTypologyFilter{UColumn}"/> to a collection of rows to resolve typologies.
    /// </summary>
    /// <typeparam name="TColumn">The column type implementing <see cref="IColumn"/>.</typeparam>
    /// <typeparam name="TRow">The row type implementing <see cref="IRow{TRow}"/>.</typeparam>
    public class ColumnTypologyFilterSolver<TColumn, TRow> : TypologyFilterSolver<ColumnTypologyFilter<TColumn>, TRow> where TColumn : IColumn where TRow : IRow<TRow>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ColumnTypologyFilterSolver{TColumn, TRow}"/> class.
        /// </summary>
        public ColumnTypologyFilterSolver()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ColumnTypologyFilterSolver{TColumn, TRow}"/> class using a specified column filter and data table.
        /// </summary>
        /// <param name="columnTypologyFilter">The column typology filter to apply.</param>
        /// <param name="table">The data table containing rows to evaluate.</param>
        public ColumnTypologyFilterSolver(ColumnTypologyFilter<TColumn> columnTypologyFilter, Table<TColumn, TRow> table)
            : base(columnTypologyFilter, table?.Rows)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ColumnTypologyFilterSolver{TColumn, TRow}"/> class using a specified column filter and a collection of rows.
        /// </summary>
        /// <param name="columnTypologyFilter">The column typology filter to apply.</param>
        /// <param name="rows">The collection of rows to evaluate.</param>
        public ColumnTypologyFilterSolver(ColumnTypologyFilter<TColumn> columnTypologyFilter, IEnumerable<TRow> rows)
            : base(columnTypologyFilter, rows)
        {
        }

        protected override TypologyItem? GetTypologyItem(ColumnTypologyFilter<TColumn>? typologyFilter, ITypologyFilterRuleData? typologyFilterRuleData)
        {
            if (typologyFilter is null || typologyFilterRuleData is null || typologyFilter.Value is not TColumn column)
            {
                return null;
            }

            string name = $"{column.Name ?? string.Empty} {typologyFilterRuleData.ToString()}";

            string? description = null;
            if (column is IExtendedColumn extendedColumn)
            {
                description = extendedColumn.Description;
            }

            return new TypologyItem()
            {
                Name = name,
                Description = description,
            };
        }

        protected override object? GetValue(ColumnTypologyFilter<TColumn>? typologyFilter, TRow? @object)
        {
            if (@object is null || typologyFilter is null || typologyFilter.Value is not TColumn column)
            {
                return null;
            }

            return @object[column.Index];
        }
    }
}