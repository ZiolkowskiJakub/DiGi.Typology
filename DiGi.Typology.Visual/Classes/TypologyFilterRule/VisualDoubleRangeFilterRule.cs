using DiGi.Core.Classes;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.Typology.Visual.Classes
{
    /// <summary>
    /// A <see cref="VisualRangeValueFilterRule{TValueType}"/> for <see cref="double"/> ranges, carrying an appearance per
    /// bucket.
    /// </summary>
    public class VisualDoubleRangeFilterRule : VisualRangeValueFilterRule<double>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VisualDoubleRangeFilterRule"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing the rule data.</param>
        public VisualDoubleRangeFilterRule(JsonObject jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new, empty instance of the <see cref="VisualDoubleRangeFilterRule"/> class; ranges and
        /// appearances are filed afterwards.
        /// </summary>
        public VisualDoubleRangeFilterRule()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VisualDoubleRangeFilterRule"/> class by copying another instance,
        /// its ranges included.
        /// </summary>
        /// <param name="visualDoubleRangeFilterRule">The source rule to copy.</param>
        public VisualDoubleRangeFilterRule(VisualDoubleRangeFilterRule visualDoubleRangeFilterRule)
            : base(visualDoubleRangeFilterRule)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VisualDoubleRangeFilterRule"/> class with a collection of ranges.
        /// </summary>
        /// <param name="ranges">The collection of double ranges to assign.</param>
        public VisualDoubleRangeFilterRule(IEnumerable<Range<double>>? ranges)
            : base(ranges)
        {
        }
    }
}