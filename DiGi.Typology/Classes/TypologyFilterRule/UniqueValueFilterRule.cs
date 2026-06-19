using DiGi.Typology.Interfaces;

namespace DiGi.Typology.Classes
{
    /// <summary>
    /// Represents a typology filter rule that matches unique values.
    /// </summary>
    public class UniqueValueFilterRule : TypologyFilterRule, ITypologyFilterRule<UniqueValueRuleData>
    {
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