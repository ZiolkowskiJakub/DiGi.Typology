using DiGi.Core.Classes;
using DiGi.Typology.Classes;
using DiGi.Typology.Visual.Interfaces;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Typology.Visual.Classes
{
    /// <summary>
    /// The resulting data for a <see cref="VisualRangeValueFilterRule{TValueType}"/>: the <see cref="Range{T}"/> a value
    /// fell into, together with the appearance of that bucket.
    /// <para>The appearance is metadata, not identity: equality, ordering and the hash consider the
    /// <see cref="Range{T}"/> alone (as in the base <see cref="RangeValueRuleData{TValueType}"/>), so two rule data
    /// instances are equal when they wrap equal ranges whatever they look like. So is <see cref="MaxExclusive"/>, which
    /// records whether the rule hands the range's <c>Max</c> to the range starting there, and drives the text form:
    /// <c>[min, max)</c> for a range another one follows on, <c>[min, max]</c> for the last.</para>
    /// </summary>
    /// <typeparam name="TValueType">The underlying type of the range values.</typeparam>
    public class VisualRangeValueRuleData<TValueType> : TypologyFilterRuleData<VisualRangeValueRuleData<TValueType>>, IVisualTypologyFilterRuleData
    {
        [JsonInclude, JsonPropertyName(nameof(Range))]
        private readonly Range<TValueType>? range = null;

        [JsonInclude, JsonPropertyName(nameof(Appearance))]
        private TypologyAppearance? appearance;

        [JsonInclude, JsonPropertyName(nameof(MaxExclusive))]
        private readonly bool maxExclusive = false;

        /// <summary>
        /// Initializes a new instance of the <see cref="VisualRangeValueRuleData{TValueType}"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing the rule data.</param>
        public VisualRangeValueRuleData(JsonObject jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new, empty instance of the <see cref="VisualRangeValueRuleData{TValueType}"/> class; the range
        /// and the appearance are set afterwards.
        /// </summary>
        public VisualRangeValueRuleData()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VisualRangeValueRuleData{TValueType}"/> class wrapping a range and
        /// an appearance.
        /// <para>Both are stored as given, not cloned, so the caller retains ownership of the instances it passes.</para>
        /// </summary>
        /// <param name="range">The range the value fell into.</param>
        /// <param name="appearance">The appearance of the bucket; may be null.</param>
        /// <param name="maxExclusive">A value indicating whether the range's <c>Max</c> belongs to the next range rather than to this one.</param>
        public VisualRangeValueRuleData(Range<TValueType>? range, TypologyAppearance? appearance, bool maxExclusive = false)
        {
            this.appearance = appearance;
            this.range = range;
            this.maxExclusive = maxExclusive;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VisualRangeValueRuleData{TValueType}"/> class by copying another
        /// instance: the range and the appearance are cloned.
        /// </summary>
        /// <param name="visualRangeValueRuleData">The source rule data to copy.</param>
        public VisualRangeValueRuleData(VisualRangeValueRuleData<TValueType> visualRangeValueRuleData)
            : base(visualRangeValueRuleData)
        {
            range = Core.Query.Clone(visualRangeValueRuleData.range);
            appearance = Core.Query.Clone(visualRangeValueRuleData.appearance);
            maxExclusive = visualRangeValueRuleData.maxExclusive;
        }

        /// <summary>
        /// Gets or sets the appearance of the bucket this rule data describes, or null when it has none.
        /// <para>Rule data produced by a <see cref="VisualRangeValueFilterRule{TValueType}"/> shares the instance filed on
        /// the rule, so mutating it mutates the rule's entry.</para>
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
        /// Gets the range the value fell into, or null when this instance wraps none.
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
        /// Determines whether this instance and another range rule data wrap the same range; the appearance is not
        /// considered.
        /// </summary>
        /// <param name="visualRangeValueRuleData">The rule data to compare with this instance.</param>
        /// <returns>True if both wrap equal ranges; otherwise, false.</returns>
        public override bool Equals(VisualRangeValueRuleData<TValueType> visualRangeValueRuleData)
        {
            if (visualRangeValueRuleData is null)
            {
                return false;
            }

            if (range is null && visualRangeValueRuleData.range is null)
            {
                return true;
            }

            if (range is null || visualRangeValueRuleData.range is null)
            {
                return false;
            }

            return visualRangeValueRuleData.range.Equals(range);
        }

        /// <summary>
        /// Determines whether this instance and a specified object wrap the same range.
        /// </summary>
        /// <param name="object">The object to compare with this instance.</param>
        /// <returns>True if the object is a <see cref="VisualRangeValueRuleData{TValueType}"/> of equal range; otherwise, false.</returns>
        public override bool Equals(object? @object)
        {
            if (@object is VisualRangeValueRuleData<TValueType> visualRangeValueRuleData_Other)
            {
                return Equals(visualRangeValueRuleData_Other);
            }
            return false;
        }

        /// <summary>
        /// Returns the hash code for this instance, based on the range alone.
        /// </summary>
        /// <returns>A 32-bit signed integer hash code.</returns>
        public override int GetHashCode()
        {
            return range != null ? range.GetHashCode() : 0;
        }

        /// <summary>
        /// Returns a string representation of the range rule data.
        /// <para>The range is rendered as the interval the rule actually matches: <c>[min, max)</c> when the <c>Max</c>
        /// belongs to the next range (<see cref="MaxExclusive"/>), <c>[min, max]</c> otherwise.</para>
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