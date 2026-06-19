using DiGi.Core.IO.Table.Classes;
using DiGi.Core.IO.Table.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Typology.Classes
{
    public class ColumnTypologyFilter<UColumn> : TypologyFilter<ColumnTypologyFilter<UColumn>, UColumn> where UColumn : IColumn
    {
        public ColumnTypologyFilter() 
            :base()
        { 
        }

        public ColumnTypologyFilter(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        public ColumnTypologyFilter(ColumnTypologyFilter<UColumn>? columnTypologyFilter)
            : base(columnTypologyFilter)
        {
        }
    }

    public class ColumnTypologyFilter : ColumnTypologyFilter<Column>
    {
        public ColumnTypologyFilter()
            : base()
        {
        }

        public ColumnTypologyFilter(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        public ColumnTypologyFilter(ColumnTypologyFilter? columnTypologyFilter)
            : base(columnTypologyFilter)
        {
        }
    }
}
