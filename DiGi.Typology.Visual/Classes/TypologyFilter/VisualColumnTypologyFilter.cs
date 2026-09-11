using DiGi.Core.IO.Table.Classes;
using DiGi.Core.IO.Table.Interfaces;
using DiGi.Typology.Classes;
using DiGi.Typology.Visual.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Typology.Visual.Classes
{
    /// <summary>
    /// The Visual counterpart of <see cref="ColumnTypologyFilter{UColumn}"/>: a filter level over a single column, held
    /// in a typology so a client can render it.
    /// <para>All behaviour is inherited from its base; this type only exposes the constructors and pins the level to the
    /// Visual family, so it is recognised by its <c>_type</c> discriminator in a serialized tree.</para>
    /// </summary>
    /// <typeparam name="UColumn">The column type implementing <see cref="IColumn"/>.</typeparam>
    public class VisualColumnTypologyFilter<UColumn> : TypologyFilter<VisualColumnTypologyFilter<UColumn>, UColumn>, ITypologyVisualSerializableObject where UColumn : IColumn
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VisualColumnTypologyFilter{UColumn}"/> class.
        /// </summary>
        public VisualColumnTypologyFilter()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VisualColumnTypologyFilter{UColumn}"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing the filter data.</param>
        public VisualColumnTypologyFilter(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VisualColumnTypologyFilter{UColumn}"/> class by copying another
        /// instance.
        /// </summary>
        /// <param name="visualColumnTypologyFilter">The column typology filter to copy.</param>
        public VisualColumnTypologyFilter(VisualColumnTypologyFilter<UColumn>? visualColumnTypologyFilter)
            : base(visualColumnTypologyFilter)
        {
        }
    }

    /// <summary>
    /// A concrete column-based Visual typology filter using the standard <see cref="Column"/> type.
    /// </summary>
    public class VisualColumnTypologyFilter : VisualColumnTypologyFilter<Column>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VisualColumnTypologyFilter"/> class.
        /// </summary>
        public VisualColumnTypologyFilter()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VisualColumnTypologyFilter"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing the filter data.</param>
        public VisualColumnTypologyFilter(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VisualColumnTypologyFilter"/> class by copying another instance.
        /// </summary>
        /// <param name="visualColumnTypologyFilter">The column typology filter to copy.</param>
        public VisualColumnTypologyFilter(VisualColumnTypologyFilter? visualColumnTypologyFilter)
            : base(visualColumnTypologyFilter)
        {
        }
    }
}