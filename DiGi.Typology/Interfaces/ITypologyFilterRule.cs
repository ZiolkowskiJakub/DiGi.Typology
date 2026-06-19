using DiGi.Core.Interfaces;

namespace DiGi.Typology.Interfaces
{
    /// <summary>
    /// Defines the base contract for a typology filter rule.
    /// </summary>
    public interface ITypologyFilterRule : ISerializableObject, ITypologyObject
    {
    }

    /// <summary>
    /// Defines the generic contract for a typology filter rule that yields a specific filter rule data type.
    /// </summary>
    /// <typeparam name="TTypologyFilterRuleData">The type of the filter rule data returned by this rule.</typeparam>
    public interface ITypologyFilterRule<TTypologyFilterRuleData> : ITypologyFilterRule where TTypologyFilterRuleData : ITypologyFilterRuleData
    {
        /// <summary>
        /// Retrieves the typology filter rule data based on the provided object value.
        /// </summary>
        /// <param name="value">The object value to evaluate against the rule.</param>
        /// <returns>The matching typology filter rule data instance, or null if no match is found.</returns>
        TTypologyFilterRuleData? RuleData(object? value);
    }
}