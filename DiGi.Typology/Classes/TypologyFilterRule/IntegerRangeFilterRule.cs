using DiGi.Core.Classes;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.Typology.Classes
{
    /// <summary>
    /// Represents a typology filter rule for int range values.
    /// </summary>
    public class IntegerRangeFilterRule : RangeValueFilterRule<int>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IntegerRangeFilterRule"/> class with a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing the double range filter rule data.</param>
        public IntegerRangeFilterRule(JsonObject jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IntegerRangeFilterRule"/> class.
        /// </summary>
        public IntegerRangeFilterRule()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IntegerRangeFilterRule"/> class by copying another instance.
        /// </summary>
        /// <param name="integerRangeFilterRule">The source filter rule to copy.</param>
        public IntegerRangeFilterRule(IntegerRangeFilterRule integerRangeFilterRule)
            : base(integerRangeFilterRule)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IntegerRangeFilterRule"/> class with a collection of ranges.
        /// </summary>
        /// <param name="ranges">The collection of double ranges to assign.</param>
        public IntegerRangeFilterRule(IEnumerable<Range<int>>? ranges)
            : base(ranges)
        {
        }
    }
}