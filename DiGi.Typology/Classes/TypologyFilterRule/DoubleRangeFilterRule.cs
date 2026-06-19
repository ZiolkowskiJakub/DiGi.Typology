using DiGi.Core.Classes;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.Typology.Classes
{
    /// <summary>
    /// Represents a typology filter rule for double range values.
    /// </summary>
    public class DoubleRangeFilterRule : RangeValueFilterRule<double>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DoubleRangeFilterRule"/> class with a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing the double range filter rule data.</param>
        public DoubleRangeFilterRule(JsonObject jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DoubleRangeFilterRule"/> class.
        /// </summary>
        public DoubleRangeFilterRule()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DoubleRangeFilterRule"/> class by copying another instance.
        /// </summary>
        /// <param name="doubleRangeFilterRule">The source filter rule to copy.</param>
        public DoubleRangeFilterRule(DoubleRangeFilterRule doubleRangeFilterRule)
            : base(doubleRangeFilterRule)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DoubleRangeFilterRule"/> class with a collection of ranges.
        /// </summary>
        /// <param name="ranges">The collection of double ranges to assign.</param>
        public DoubleRangeFilterRule(IEnumerable<Range<double>>? ranges)
            : base(ranges)
        {
        }
    }
}