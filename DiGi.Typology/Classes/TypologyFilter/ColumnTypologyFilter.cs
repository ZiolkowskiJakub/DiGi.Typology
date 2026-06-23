using DiGi.Core.IO.Table.Classes;
using DiGi.Core.IO.Table.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Typology.Classes
{
    /// <summary>
    /// Represents a typology filter based on columns of type <see cref="IColumn"/>.
    /// </summary>
    /// <typeparam name="UColumn">The column type implementing <see cref="IColumn"/>.</typeparam>
    public class ColumnTypologyFilter<UColumn> : TypologyFilter<ColumnTypologyFilter<UColumn>, UColumn> where UColumn : IColumn
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ColumnTypologyFilter{UColumn}"/> class.
        /// </summary>
        public ColumnTypologyFilter()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ColumnTypologyFilter{UColumn}"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing the filter data.</param>
        public ColumnTypologyFilter(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ColumnTypologyFilter{UColumn}"/> class by copying another instance.
        /// </summary>
        /// <param name="columnTypologyFilter">The column typology filter to copy.</param>
        public ColumnTypologyFilter(ColumnTypologyFilter<UColumn>? columnTypologyFilter)
            : base(columnTypologyFilter)
        {
        }
    }

    /// <summary>
    /// Represents a concrete column-based typology filter using the standard <see cref="Column"/> type.
    /// </summary>
    public class ColumnTypologyFilter : ColumnTypologyFilter<Column>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ColumnTypologyFilter"/> class.
        /// </summary>
        public ColumnTypologyFilter()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ColumnTypologyFilter"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing the filter data.</param>
        public ColumnTypologyFilter(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ColumnTypologyFilter"/> class by copying another instance.
        /// </summary>
        /// <param name="columnTypologyFilter">The column typology filter to copy.</param>
        public ColumnTypologyFilter(ColumnTypologyFilter? columnTypologyFilter)
            : base(columnTypologyFilter)
        {
        }
    }
}