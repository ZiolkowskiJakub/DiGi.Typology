using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Typology.Classes
{
    /// <summary>
    /// Represents the resulting data for a unique value filter rule.
    /// </summary>
    public class UniqueValueRuleData : TypologyFilterRuleData<UniqueValueRuleData>
    {
        [JsonInclude, JsonPropertyName("Value")]
        private readonly object? value = null;

        /// <summary>
        /// Initializes a new instance of the <see cref="UniqueValueRuleData"/> class with a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing unique value rule data.</param>
        public UniqueValueRuleData(JsonObject jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UniqueValueRuleData"/> class.
        /// </summary>
        public UniqueValueRuleData()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UniqueValueRuleData"/> class with a specific value.
        /// </summary>
        /// <param name="object">The value to wrap.</param>
        public UniqueValueRuleData(object? @object)
        {
            value = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UniqueValueRuleData"/> class by copying another instance.
        /// </summary>
        /// <param name="uniqueValueRuleData">The source unique value rule data to copy.</param>
        public UniqueValueRuleData(UniqueValueRuleData uniqueValueRuleData)
            : base(uniqueValueRuleData)
        {
        }

        /// <summary>
        /// Determines whether this instance and another specified unique value rule data have the same value.
        /// </summary>
        /// <param name="uniqueValueRuleData">The unique value rule data to compare with this instance.</param>
        /// <returns>True if they are equal; otherwise, false.</returns>
        public override bool Equals(UniqueValueRuleData uniqueValueRuleData)
        {
            if (uniqueValueRuleData is null)
            {
                return false;
            }

            if (value is null && uniqueValueRuleData.value is null)
            {
                return true;
            }

            if (value is null || uniqueValueRuleData.value is null)
            {
                return false;
            }

            return uniqueValueRuleData.value.Equals(value);
        }

        /// <summary>
        /// Determines whether this instance and a specified object have the same value.
        /// </summary>
        /// <param name="object">The object to compare with this instance.</param>
        /// <returns>True if the object is equal to this instance; otherwise, false.</returns>
        public override bool Equals(object? @object)
        {
            if (@object is UniqueValueRuleData uniqueValueRuleData_Other)
            {
                return Equals(uniqueValueRuleData_Other);
            }
            return false;
        }

        /// <summary>
        /// Returns the hash code for this instance.
        /// </summary>
        /// <returns>A 32-bit signed integer hash code.</returns>
        public override int GetHashCode()
        {
            return value != null ? value.GetHashCode() : 0;
        }

        /// <summary>
        /// Returns a string representation of the unique value rule data.
        /// </summary>
        /// <returns>A string representation of the value.</returns>
        public override string ToString()
        {
            if (value is null)
            {
                return "null";
            }

            return value.ToString();
        }
    }
}