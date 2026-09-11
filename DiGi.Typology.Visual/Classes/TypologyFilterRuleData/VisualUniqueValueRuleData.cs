using DiGi.Typology.Classes;
using DiGi.Typology.Visual.Interfaces;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Typology.Visual.Classes
{
    /// <summary>
    /// The resulting data for a <see cref="VisualUniqueValueFilterRule"/>: the value a bucket was keyed by, together with
    /// the appearance of that bucket.
    /// <para>The appearance is metadata, not identity: equality and the hash consider the <see cref="Value"/> alone (as
    /// in the base <see cref="UniqueValueRuleData"/>), so two rule data instances are equal when they wrap equal values
    /// whatever they look like.</para>
    /// </summary>
    public class VisualUniqueValueRuleData : TypologyFilterRuleData<VisualUniqueValueRuleData>, IVisualTypologyFilterRuleData
    {
        [JsonInclude, JsonPropertyName(nameof(Value))]
        private readonly object? value = null;

        [JsonInclude, JsonPropertyName(nameof(Appearance))]
        private TypologyAppearance? appearance;

        /// <summary>
        /// Initializes a new instance of the <see cref="VisualUniqueValueRuleData"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing the rule data.</param>
        public VisualUniqueValueRuleData(JsonObject jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new, empty instance of the <see cref="VisualUniqueValueRuleData"/> class; the value and the
        /// appearance are set afterwards.
        /// </summary>
        public VisualUniqueValueRuleData()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VisualUniqueValueRuleData"/> class wrapping a value.
        /// <para>The value is stored by reference, not cloned, so the caller retains ownership of the instance it passes.</para>
        /// </summary>
        /// <param name="object">The value to wrap.</param>
        public VisualUniqueValueRuleData(object? @object)
        {
            value = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VisualUniqueValueRuleData"/> class wrapping a value and an
        /// appearance.
        /// <para>Both are stored as given, not cloned, so the caller retains ownership of the instances it passes.</para>
        /// </summary>
        /// <param name="object">The value to wrap.</param>
        /// <param name="appearance">The appearance of the bucket; may be null.</param>
        public VisualUniqueValueRuleData(object? @object, TypologyAppearance? appearance)
        {
            value = @object;
            this.appearance = appearance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VisualUniqueValueRuleData"/> class by copying another instance.
        /// <para>The value is shared by reference, as unique values are expected to be immutable; the appearance is cloned.</para>
        /// </summary>
        /// <param name="visualUniqueValueRuleData">The source rule data to copy.</param>
        public VisualUniqueValueRuleData(VisualUniqueValueRuleData visualUniqueValueRuleData)
            : base(visualUniqueValueRuleData)
        {
            value = visualUniqueValueRuleData.value;
            appearance = Core.Query.Clone(visualUniqueValueRuleData.appearance);
        }

        /// <summary>
        /// Gets or sets the appearance of the bucket this rule data describes, or null when it has none.
        /// <para>Rule data produced by a <see cref="VisualUniqueValueFilterRule"/> shares the instance filed on the rule,
        /// so mutating it mutates the rule's entry.</para>
        /// </summary>
        [JsonIgnore]
        public TypologyAppearance? Appearance
        {
            get
            {
                return appearance;
            }

            set
            {
                appearance = value;
            }
        }

        /// <summary>
        /// Gets the value the bucket was keyed by, or null when this instance wraps none.
        /// </summary>
        [JsonIgnore]
        public object? Value
        {
            get
            {
                return value;
            }
        }

        /// <summary>
        /// Determines whether this instance and another unique value rule data wrap the same value; the appearance is not
        /// considered.
        /// </summary>
        /// <param name="visualUniqueValueRuleData">The rule data to compare with this instance.</param>
        /// <returns>True if both wrap equal values; otherwise, false.</returns>
        public override bool Equals(VisualUniqueValueRuleData visualUniqueValueRuleData)
        {
            if (visualUniqueValueRuleData is null)
            {
                return false;
            }

            if (value is null && visualUniqueValueRuleData.value is null)
            {
                return true;
            }

            if (value is null || visualUniqueValueRuleData.value is null)
            {
                return false;
            }

            return visualUniqueValueRuleData.value.Equals(value);
        }

        /// <summary>
        /// Determines whether this instance and a specified object wrap the same value.
        /// </summary>
        /// <param name="object">The object to compare with this instance.</param>
        /// <returns>True if the object is a <see cref="VisualUniqueValueRuleData"/> of equal value; otherwise, false.</returns>
        public override bool Equals(object? @object)
        {
            if (@object is VisualUniqueValueRuleData visualUniqueValueRuleData_Other)
            {
                return Equals(visualUniqueValueRuleData_Other);
            }
            return false;
        }

        /// <summary>
        /// Returns the hash code for this instance, based on the value alone.
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