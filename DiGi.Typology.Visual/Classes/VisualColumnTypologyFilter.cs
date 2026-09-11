using DiGi.Core.IO.Table.Classes;
using DiGi.Typology.Classes;
using DiGi.Typology.Visual.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Typology.Visual.Classes
{
    /// <summary>
    /// A <see cref="ColumnTypologyFilter{UColumn}"/> level carrying a fallback appearance for the buckets its rule
    /// produces.
    /// <para>The appearance of a bucket is normally carried by the rule - a <see cref="VisualRange{T}"/> inside a range
    /// rule, an entry of a <see cref="VisualUniqueValueFilterRule"/> - and this level appearance stands in where the rule
    /// carries none. It is definition metadata for the editing client only today: a solver rebuilding the chain keeps the
    /// <see cref="TypologyFilter{TTypologyFilter}.Rule"/> instance and drops the node, so nothing in a solved tree reflects
    /// it. The nested <see cref="TypologyFilter{TTypologyFilter}.Filter"/> stays typed as the base level; a nested Visual
    /// level is Visual by its <c>_type</c> discriminator only.</para>
    /// </summary>
    public class VisualColumnTypologyFilter : ColumnTypologyFilter<Column>, ITypologyVisualSerializableObject
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
        /// Initializes a new instance of the <see cref="VisualColumnTypologyFilter"/> class by copying another instance,
        /// its appearance included.
        /// </summary>
        /// <param name="visualColumnTypologyFilter">The filter to copy.</param>
        public VisualColumnTypologyFilter(VisualColumnTypologyFilter? visualColumnTypologyFilter)
            : base(visualColumnTypologyFilter)
        {
            if (visualColumnTypologyFilter != null)
            {
                Appearance = Core.Query.Clone(visualColumnTypologyFilter.Appearance);
            }
        }

        /// <summary>
        /// Gets or sets the fallback appearance of the buckets this level produces, or null when it has none.
        /// </summary>
        public TypologyAppearance? Appearance { get; set; }
    }
}
