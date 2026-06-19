using DiGi.Core.IO.Table.Classes;
using DiGi.Core.IO.Table.Interfaces;
using DiGi.Typology.Interfaces;
using System.Collections.Generic;

namespace DiGi.Typology.Classes
{
    public class ColumnTypologyFilterSolver<TColumn, TRow> : TypologyFilterSolver<ColumnTypologyFilter<TColumn>, TRow> where TColumn : IColumn where TRow : IRow<TRow>
    {
        public ColumnTypologyFilterSolver()
            : base()
        {

        }

        public ColumnTypologyFilterSolver(ColumnTypologyFilter<TColumn> columnTypologyFilter, Table<TColumn, TRow> table)
            : base(columnTypologyFilter, table?.Rows)
        {

        }

        public ColumnTypologyFilterSolver(ColumnTypologyFilter<TColumn> columnTypologyFilter, IEnumerable<TRow> rows)
            : base(columnTypologyFilter, rows)
        {

        }

        protected override TypologyItem? GetTypologyItem(ColumnTypologyFilter<TColumn>? typologyFilter, ITypologyFilterRuleData? typologyFilterRuleData)
        {
            if(typologyFilter is null || typologyFilterRuleData is null || typologyFilter.Value is not TColumn column)
            {
                return null;
            }

            string name = $"{column.Name ?? string.Empty} {typologyFilterRuleData.ToString()}";
            
            string? description = null;
            if(column is IExtendedColumn extendedColumn)
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
            if(@object is null || typologyFilter is null || typologyFilter.Value is not TColumn column)
            {
                return null;
            }

            return @object[column.Index];
        }
    }
}
