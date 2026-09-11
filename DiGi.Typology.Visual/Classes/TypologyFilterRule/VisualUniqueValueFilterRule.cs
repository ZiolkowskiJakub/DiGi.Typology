using DiGi.Typology.Classes;
using DiGi.Typology.Interfaces;
using DiGi.Typology.Visual.Interfaces;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Typology.Visual.Classes
{
    /// <summary>
    /// The Visual counterpart of <see cref="UniqueValueFilterRule"/>: buckets a value by equality and carries an
    /// appearance per value.
    /// <para>The rule data is created at solve time, so the appearances live here, in a
    /// <see cref="Classes.TypologyAppearanceCollection"/> keyed by the value - see <see cref="Query.Key(object)"/> for
    /// the key a value resolves to - and <see cref="RuleData(object)"/> hands the value's appearance to the
    /// <see cref="VisualUniqueValueRuleData"/> it produces. A consumer holding rule data of either kind can also read
    /// <c>rule.TypologyAppearanceCollection[ruleData]</c>.</para>
    /// <para>This rule does not derive from <see cref="UniqueValueFilterRule"/>:
    /// <see cref="Typology.Query.RuleData(ITypologyFilterRule, object)"/> binds <c>RuleData</c> by name through
    /// reflection, so hiding the base method to change its return type is not an option.</para>
    /// </summary>
    public class VisualUniqueValueFilterRule : TypologyFilterRule, IVisualTypologyFilterRule, ITypologyFilterRule<VisualUniqueValueRuleData>
    {
        [JsonInclude, JsonPropertyName(nameof(TypologyAppearanceCollection))]
        private readonly TypologyAppearanceCollection typologyAppearanceCollection = new();

        /// <summary>
        /// Initializes a new instance of the <see cref="VisualUniqueValueFilterRule"/> class with a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing the rule data.</param>
        public VisualUniqueValueFilterRule(JsonObject jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VisualUniqueValueFilterRule"/> class with no appearances.
        /// </summary>
        public VisualUniqueValueFilterRule()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VisualUniqueValueFilterRule"/> class by copying another instance,
        /// its appearances included.
        /// </summary>
        /// <param name="visualUniqueValueFilterRule">The source rule to copy.</param>
        public VisualUniqueValueFilterRule(VisualUniqueValueFilterRule visualUniqueValueFilterRule)
            : base(visualUniqueValueFilterRule)
        {
            typologyAppearanceCollection = Core.Query.Clone(visualUniqueValueFilterRule.typologyAppearanceCollection) ?? new();
        }

        /// <summary>
        /// Gets the appearances of the buckets of this rule, keyed by value: file an entry as
        /// <c>rule.TypologyAppearanceCollection[value] = appearance</c>. Never null.
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
        /// Wraps the value in the rule data of its bucket, together with the appearance filed for the value in
        /// <see cref="TypologyAppearanceCollection"/>, by reference, or null when none is filed.
        /// <para>Every value gets a bucket, as in <see cref="UniqueValueFilterRule"/>; <c>null</c> is the NULL bucket.</para>
        /// </summary>
        /// <param name="object">The value to bucket.</param>
        /// <returns>The rule data wrapping the value and its appearance.</returns>
        public VisualUniqueValueRuleData? RuleData(object? @object)
        {
            return new VisualUniqueValueRuleData(@object, typologyAppearanceCollection[@object]);
        }
    }
}