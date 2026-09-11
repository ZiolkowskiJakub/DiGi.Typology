using DiGi.Core.Classes;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.Typology.Visual.Classes
{
    /// <summary>
    /// A <see cref="VisualRangeValueFilterRule{TValueType}"/> for <see cref="int"/> ranges, carrying an appearance per
    /// bucket.
    /// </summary>
    public class VisualIntegerRangeFilterRule : VisualRangeValueFilterRule<int>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VisualIntegerRangeFilterRule"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing the rule data.</param>
        public VisualIntegerRangeFilterRule(JsonObject jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new, empty instance of the <see cref="VisualIntegerRangeFilterRule"/> class; ranges and
        /// appearances are filed afterwards.
        /// </summary>
        public VisualIntegerRangeFilterRule()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VisualIntegerRangeFilterRule"/> class by copying another instance,
        /// its ranges included.
        /// </summary>
        /// <param name="visualIntegerRangeFilterRule">The source rule to copy.</param>
        public VisualIntegerRangeFilterRule(VisualIntegerRangeFilterRule visualIntegerRangeFilterRule)
            : base(visualIntegerRangeFilterRule)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VisualIntegerRangeFilterRule"/> class with a collection of ranges.
        /// </summary>
        /// <param name="ranges">The collection of integer ranges to assign.</param>
        public VisualIntegerRangeFilterRule(IEnumerable<Range<int>>? ranges)
            : base(ranges)
        {
        }
    }
}