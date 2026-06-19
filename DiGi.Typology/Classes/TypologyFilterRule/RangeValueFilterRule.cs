using DiGi.Core.Classes;
using DiGi.Typology.Interfaces;
using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Typology.Classes
{
    /// <summary>
    /// Represents a generic base class for range value filter rules.
    /// </summary>
    /// <typeparam name="TValueType">The type of the range values, which must implement <see cref="IComparable{T}"/>.</typeparam>
    public abstract class RangeValueFilterRule<TValueType> : TypologyFilterRule, ITypologyFilterRule<RangeValueRuleData<TValueType>> where TValueType : IComparable<TValueType>
    {
        [JsonIgnore]
        private readonly Dictionary<TValueType, Range<TValueType>> dictionary = [];

        /// <summary>
        /// Initializes a new instance of the <see cref="RangeValueFilterRule{TValueType}"/> class with a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing the range filter rule data.</param>
        public RangeValueFilterRule(JsonObject jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RangeValueFilterRule{TValueType}"/> class.
        /// </summary>
        public RangeValueFilterRule()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RangeValueFilterRule{TValueType}"/> class by copying another instance.
        /// </summary>
        /// <param name="rangeValueFilterRule">The source range filter rule to copy.</param>
        public RangeValueFilterRule(RangeValueFilterRule<TValueType> rangeValueFilterRule)
            : base(rangeValueFilterRule)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RangeValueFilterRule{TValueType}"/> class with a collection of ranges.
        /// </summary>
        /// <param name="ranges">The collection of ranges to assign.</param>
        public RangeValueFilterRule(IEnumerable<Range<TValueType>>? ranges)
        {
            if (ranges is not null)
            {
                Ranges = ranges;
            }
        }

        /// <summary>
        /// Resolves the filter rule data for the specified value.
        /// </summary>
        /// <param name="object_Value">The value to test against the ranges.</param>
        /// <returns>The matching range rule data, or null if no range matches.</returns>
        public RangeValueRuleData<TValueType>? RuleData(object? object_Value)
        {
            if (!Core.Query.TryConvert(object_Value, out TValueType? tValueType_Converted) || tValueType_Converted is null)
            {
                return null;
            }

            foreach (KeyValuePair<TValueType, Range<TValueType>> keyValuePair in dictionary)
            {
                if (keyValuePair.Key.CompareTo(tValueType_Converted) > 0)
                {
                    return null;
                }

                if (keyValuePair.Value.In(tValueType_Converted) || keyValuePair.Value.Max.CompareTo(tValueType_Converted) == 0)
                {
                    return new RangeValueRuleData<TValueType>(keyValuePair.Value);
                }
            }

            return null;
        }

        /// <summary>
        /// Adds a range to the filter rule.
        /// </summary>
        /// <param name="range">The range to add.</param>
        /// <returns>True if the range was successfully added; otherwise, false.</returns>
        public bool Add(Range<TValueType>? range)
        {
            if (range is null)
            {
                return false;
            }

            dictionary[range.Min] = range;
            return true;
        }

        /// <summary>
        /// Gets or sets the collection of ranges managed by this rule.
        /// </summary>
        [JsonInclude, JsonPropertyName(nameof(Ranges))]
        public IEnumerable<Range<TValueType>> Ranges
        {
            get
            {
                return [.. dictionary.Values];
            }

            set
            {
                dictionary.Clear();
                if (value is null)
                {
                    return;
                }

                foreach (Range<TValueType> range in value)
                {
                    Add(range);
                }
            }
        }
    }
}