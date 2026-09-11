using DiGi.Typology.Classes;
using DiGi.Typology.Interfaces;
using DiGi.Typology.Visual.Interfaces;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Typology.Visual.Classes
{
    /// <summary>
    /// A <see cref="UniqueValueFilterRule"/> carrying an appearance per value.
    /// <para>The rule itself is stateless and its rule data is created at solve time, so the appearances live here, in a
    /// <see cref="Classes.TypologyAppearanceCollection"/> keyed by the value - see
    /// <see cref="TypologyAppearanceCollection.Key(object)"/> for the key a value resolves to. A consumer holding a
    /// <see cref="UniqueValueRuleData"/> reads <c>rule.TypologyAppearanceCollection[uniqueValueRuleData]</c>.</para>
    /// <para>This type adds no <c>RuleData</c> member: <see cref="Query.RuleData(ITypologyFilterRule, object)"/>
    /// resolves that method by name, and a hiding overload would make the lookup ambiguous.</para>
    /// </summary>
    public class VisualUniqueValueFilterRule : UniqueValueFilterRule, ITypologyVisualSerializableObject
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
        /// Gets the appearances of the buckets of this rule, keyed by value. Never null; file entries through its indexer.
        /// </summary>
        [JsonIgnore]
        public TypologyAppearanceCollection TypologyAppearanceCollection
        {
            get
            {
                return typologyAppearanceCollection;
            }
        }
    }
}
