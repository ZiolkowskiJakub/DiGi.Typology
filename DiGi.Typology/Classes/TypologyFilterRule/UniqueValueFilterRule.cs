using DiGi.Typology.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Typology.Classes
{
    /// <summary>
    /// Represents a typology filter rule that matches unique values.
    /// <para>The rule is stateless: its rule data is created per value at solve time and nothing is stored on the rule itself. The constructors exist so that a derived rule carrying state can chain them.</para>
    /// </summary>
    public class UniqueValueFilterRule : TypologyFilterRule, ITypologyFilterRule<UniqueValueRuleData>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UniqueValueFilterRule"/> class with a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing the unique value filter rule data.</param>
        public UniqueValueFilterRule(JsonObject jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UniqueValueFilterRule"/> class.
        /// </summary>
        public UniqueValueFilterRule()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UniqueValueFilterRule"/> class by copying another instance.
        /// </summary>
        /// <param name="uniqueValueFilterRule">The source filter rule to copy.</param>
        public UniqueValueFilterRule(UniqueValueFilterRule uniqueValueFilterRule)
            : base(uniqueValueFilterRule)
        {
        }

        /// <summary>
        /// Resolves the filter rule data for the specified value.
        /// </summary>
        /// <param name="object">The value to wrap in unique value data.</param>
        /// <returns>A new instance of unique value rule data wrapping the value.</returns>
        public UniqueValueRuleData? RuleData(object? @object)
        {
            return new UniqueValueRuleData(@object);
        }
    }
}