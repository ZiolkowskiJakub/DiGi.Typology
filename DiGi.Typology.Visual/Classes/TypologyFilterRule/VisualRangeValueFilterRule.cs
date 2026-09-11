using DiGi.Core.Classes;
using DiGi.Typology.Classes;
using DiGi.Typology.Interfaces;
using DiGi.Typology.Visual.Interfaces;
using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Typology.Visual.Classes
{
    /// <summary>
    /// A <see cref="RangeValueFilterRule{TValueType}"/> that also carries the appearance of each of its buckets.
    /// <para>Like its base it files its ranges keyed on <see cref="Range{T}.Min"/> and enumerates them in ascending
    /// <c>Min</c> order, so the order they were declared in does not affect which bucket a value resolves to; matching is
    /// a closed interval on both ends, so ranges that touch at a boundary both contain it and the lower one wins. The
    /// difference is the appearance: the base rule is stateless and a consumer reads it back off the matched range,
    /// whereas here each bucket's appearance is filed on the rule itself, in a <see cref="TypologyAppearanceCollection"/>
    /// keyed by the range (see <see cref="Query.Key(object)"/>), so it survives a round trip, and
    /// <see cref="RuleData(object)"/> hands it to the rule data it produces.</para>
    /// <para>This rule does not derive from <see cref="RangeValueFilterRule{TValueType}"/>:
    /// <see cref="Typology.Query.RuleData(ITypologyFilterRule, object)"/> binds <c>RuleData</c> by name through
    /// reflection, so hiding the base method to change its return type is not an option.</para>
    /// </summary>
    /// <typeparam name="TValueType">The type of the range values, which must implement <see cref="IComparable{T}"/>.</typeparam>
    public abstract class VisualRangeValueFilterRule<TValueType> : TypologyFilterRule, IVisualTypologyFilterRule, ITypologyFilterRule<VisualRangeValueRuleData<TValueType>> where TValueType : IComparable<TValueType>
    {
        [JsonIgnore]
        private readonly SortedDictionary<TValueType, Range<TValueType>> dictionary = [];

        [JsonInclude, JsonPropertyName(nameof(TypologyAppearanceCollection))]
        private readonly TypologyAppearanceCollection typologyAppearanceCollection = new();

        /// <summary>
        /// Initializes a new instance of the <see cref="VisualRangeValueFilterRule{TValueType}"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing the rule data.</param>
        public VisualRangeValueFilterRule(JsonObject jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new, empty instance of the <see cref="VisualRangeValueFilterRule{TValueType}"/> class; ranges
        /// and appearances are filed through <see cref="Ranges"/> and <see cref="TypologyAppearanceCollection"/>.
        /// </summary>
        public VisualRangeValueFilterRule()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VisualRangeValueFilterRule{TValueType}"/> class by copying another
        /// instance: every range is cloned under its minimum and the appearances are cloned under their keys.
        /// </summary>
        /// <param name="visualRangeValueFilterRule">The source rule to copy.</param>
        public VisualRangeValueFilterRule(VisualRangeValueFilterRule<TValueType> visualRangeValueFilterRule)
            : base(visualRangeValueFilterRule)
        {
            typologyAppearanceCollection = Core.Query.Clone(visualRangeValueFilterRule.typologyAppearanceCollection) ?? new();

            foreach (Range<TValueType> range in visualRangeValueFilterRule.Ranges)
            {
                if (Core.Query.Clone(range) is Range<TValueType> range_Temp)
                {
                    Add(range_Temp);
                }
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VisualRangeValueFilterRule{TValueType}"/> class with a collection
        /// of ranges.
        /// </summary>
        /// <param name="ranges">The ranges to file; null entries are skipped.</param>
        public VisualRangeValueFilterRule(IEnumerable<Range<TValueType>>? ranges)
        {
            if (ranges is not null)
            {
                Ranges = ranges;
            }
        }

        /// <summary>
        /// Gets or sets the ranges of this rule, enumerated in ascending <see cref="Range{T}.Min"/> order. Assigning a
        /// sequence replaces the current ranges; null clears them.
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

        /// <summary>
        /// Gets the appearances of the buckets of this rule, keyed by range: file an entry as
        /// <c>rule.TypologyAppearanceCollection[range] = appearance</c>. Never null.
        /// </summary>
        [JsonIgnore]
        public TypologyAppearanceCollection TypologyAppearanceCollection
        {
            get
            {
                return typologyAppearanceCollection;
            }
        }

        /// <summary>
        /// Files a range under its <see cref="Range{T}.Min"/>, replacing any range already filed under that minimum.
        /// </summary>
        /// <param name="range">The range to file.</param>
        /// <returns>True if the range was filed; otherwise, false (null).</returns>
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
        /// Resolves the value to the bucket it falls into and returns the rule data for that bucket.
        /// <para>The value is converted to <typeparamref name="TValueType"/> and matched against the ranges in ascending
        /// <see cref="Range{T}.Min"/> order; the first range that contains it wins. The rule data carries the appearance
        /// filed for that range in <see cref="TypologyAppearanceCollection"/>, by reference, or null when none is filed.</para>
        /// </summary>
        /// <param name="object_Value">The value to match against the ranges.</param>
        /// <returns>The rule data wrapping the matched range and its appearance, or null when the value is not convertible or no range contains it.</returns>
        public VisualRangeValueRuleData<TValueType>? RuleData(object? object_Value)
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

                if (keyValuePair.Value.In(tValueType_Converted))
                {
                    return new VisualRangeValueRuleData<TValueType>(keyValuePair.Value, typologyAppearanceCollection[keyValuePair.Value]);
                }
            }

            return null;
        }
    }
}