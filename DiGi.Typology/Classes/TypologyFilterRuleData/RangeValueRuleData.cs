using DiGi.Core.Classes;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Typology.Classes
{
    /// <summary>
    /// Represents the resulting data for a range value rule.
    /// <para>Besides the range, it records whether the rule hands the range's <c>Max</c> to the range starting there (<see cref="MaxExclusive"/>), so the text form says what the bucket actually matches: <c>[min, max)</c> for a range another one follows on, <c>[min, max]</c> for the last. The flag is metadata: equality and the hash consider the range alone.</para>
    /// </summary>
    /// <typeparam name="TValueType">The underlying type of the range values.</typeparam>
    public class RangeValueRuleData<TValueType> : TypologyFilterRuleData<RangeValueRuleData<TValueType>>
    {
        [JsonInclude, JsonPropertyName(nameof(Range))]
        private readonly Range<TValueType>? range = null;

        [JsonInclude, JsonPropertyName(nameof(MaxExclusive))]
        private readonly bool maxExclusive = false;

        /// <summary>
        /// Gets the range of values.
        /// </summary>
        [JsonIgnore]
        public Range<TValueType>? Range
        {
            get
            {
                return range;
            }
        }

        /// <summary>
        /// Gets a value indicating whether a value equal to the range's <c>Max</c> resolves to the next range rather than to this one - the rule that produced this data has a range starting exactly there.
        /// </summary>
        [JsonIgnore]
        public bool MaxExclusive
        {
            get
            {
                return maxExclusive;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RangeValueRuleData{TValueType}"/> class with a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing range rule data.</param>
        public RangeValueRuleData(JsonObject jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RangeValueRuleData{TValueType}"/> class.
        /// </summary>
        public RangeValueRuleData()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RangeValueRuleData{TValueType}"/> class with a specific range.
        /// </summary>
        /// <param name="range">The range values.</param>
        /// <param name="maxExclusive">A value indicating whether the range's <c>Max</c> belongs to the next range rather than to this one.</param>
        public RangeValueRuleData(Range<TValueType>? range, bool maxExclusive = false)
        {
            this.range = range;
            this.maxExclusive = maxExclusive;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RangeValueRuleData{TValueType}"/> class by copying another instance.
        /// </summary>
        /// <param name="rangeValueRuleData">The source range rule data to copy.</param>
        public RangeValueRuleData(RangeValueRuleData<TValueType> rangeValueRuleData)
            : base(rangeValueRuleData)
        {
            range = Core.Query.Clone(rangeValueRuleData.range);
            maxExclusive = rangeValueRuleData.maxExclusive;
        }

        /// <summary>
        /// Determines whether this instance and another specified range rule data have the same value.
        /// </summary>
        /// <param name="rangeValueRuleData">The range rule data to compare with this instance.</param>
        /// <returns>True if the values are equal; otherwise, false.</returns>
        public override bool Equals(RangeValueRuleData<TValueType> rangeValueRuleData)
        {
            if (rangeValueRuleData is null)
            {
                return false;
            }

            if (range is null && rangeValueRuleData.range is null)
            {
                return true;
            }

            if (range is null || rangeValueRuleData.range is null)
            {
                return false;
            }

            return rangeValueRuleData.range.Equals(range);
        }

        /// <summary>
        /// Determines whether this instance and a specified object have the same value.
        /// </summary>
        /// <param name="object">The object to compare with this instance.</param>
        /// <returns>True if the object is equal to this instance; otherwise, false.</returns>
        public override bool Equals(object? @object)
        {
            if (@object is RangeValueRuleData<TValueType> rangeValueRuleData_Other)
            {
                return Equals(rangeValueRuleData_Other);
            }
            return false;
        }

        /// <summary>
        /// Returns the hash code for this instance.
        /// </summary>
        /// <returns>A 32-bit signed integer hash code.</returns>
        public override int GetHashCode()
        {
            return range != null ? range.GetHashCode() : 0;
        }

        /// <summary>
        /// Returns a string representation of the range rule data.
        /// <para>The range is rendered as the interval the rule actually matches: <c>[min, max)</c> when the <c>Max</c> belongs to the next range (<see cref="MaxExclusive"/>), <c>[min, max]</c> otherwise.</para>
        /// </summary>
        /// <returns>A string representation of the range.</returns>
        public override string ToString()
        {
            if (range is null)
            {
                return "null";
            }

            return $"[{range.Min}, {range.Max}{(maxExclusive ? ")" : "]")}";
        }
    }
}