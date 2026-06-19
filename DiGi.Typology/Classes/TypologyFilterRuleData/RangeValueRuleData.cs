using DiGi.Core.Classes;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Typology.Classes
{
    /// <summary>
    /// Represents the resulting data for a range value rule.
    /// </summary>
    /// <typeparam name="TValueType">The underlying type of the range values.</typeparam>
    public class RangeValueRuleData<TValueType> : TypologyFilterRuleData<RangeValueRuleData<TValueType>>
    {
        [JsonInclude, JsonPropertyName("Range")]
        private readonly Range<TValueType>? range = null;

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
        public RangeValueRuleData(Range<TValueType>? range)
        {
            this.range = range;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RangeValueRuleData{TValueType}"/> class by copying another instance.
        /// </summary>
        /// <param name="rangeValueRuleData">The source range rule data to copy.</param>
        public RangeValueRuleData(RangeValueRuleData<TValueType> rangeValueRuleData)
            : base(rangeValueRuleData)
        {
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
        /// </summary>
        /// <returns>A string representation of the range.</returns>
        public override string ToString()
        {
            if (range is null)
            {
                return "null";
            }

            return $"({range.Min},{range.Max}>";
        }
    }
}