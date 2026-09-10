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
    /// <para>Ranges are held keyed on <c>Range.Min</c> and enumerated in ascending <c>Min</c> order, so the order they were declared in does not affect which bucket a value resolves to.</para>
    /// <para>Matching is a closed interval on both ends, so ranges that touch at a boundary both contain it and the lower one wins.</para>
    /// </summary>
    /// <typeparam name="TValueType">The type of the range values, which must implement <see cref="IComparable{T}"/>.</typeparam>
    public abstract class RangeValueFilterRule<TValueType> : TypologyFilterRule, ITypologyFilterRule<RangeValueRuleData<TValueType>> where TValueType : IComparable<TValueType>
    {
        [JsonIgnore]
        private readonly SortedDictionary<TValueType, Range<TValueType>> dictionary = [];

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
        /// <para>Returns null for a null value, a value that cannot be converted to the range type, and a value outside every declared range. A solver consuming this rule drops such an object rather than bucketing it, so there is no catch-all bucket.</para>
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
        /// <para>Ranges are keyed on <c>Range.Min</c>, so adding a range whose <c>Min</c> is already present replaces the existing one rather than joining it.</para>
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