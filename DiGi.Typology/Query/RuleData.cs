using DiGi.Typology.Interfaces;
using System;

namespace DiGi.Typology
{
    /// <summary>
    /// Static partial class containing query extension methods for typology entities.
    /// </summary>
    public static partial class Query
    {
        /// <summary>
        /// Retrieves the typology filter rule data from a typology filter rule by invoking its generic method using reflection.
        /// </summary>
        /// <param name="typologyFilterRule">The typology filter rule to evaluate.</param>
        /// <param name="object">The value to evaluate against the rule.</param>
        /// <returns>The resolved typology filter rule data, or null if the rule is null or invalid.</returns>
        public static ITypologyFilterRuleData? RuleData(this ITypologyFilterRule? typologyFilterRule, object? @object)
        {
            if (typologyFilterRule is null)
            {
                return null;
            }

            // We need to use reflection because the base, non-generic interface ITypologyFilterRule
            // does not expose the TypologyFilterRuleData method.
            Type type_Rule = typologyFilterRule.GetType();

            // Retrieve the method information by its name
            System.Reflection.MethodInfo? methodInfo = type_Rule.GetMethod(nameof(Classes.RangeValueFilterRule<>.RuleData));

            if (methodInfo is null)
            {
                return null;
            }

            // Safely cast the result to the expected base interface
            return methodInfo.Invoke(typologyFilterRule, [@object]) as ITypologyFilterRuleData;
        }
    }
}