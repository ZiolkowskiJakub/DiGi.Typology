using DiGi.Core.Interfaces;
using System;

namespace DiGi.Typology.Interfaces
{
    /// <summary>
    /// Defines the base contract for typology filter rule data.
    /// </summary>
    public interface ITypologyFilterRuleData : ISerializableObject, ITypologyObject
    {
    }

    /// <summary>
    /// Defines the generic contract for typology filter rule data with equatable functionality.
    /// </summary>
    /// <typeparam name="TTypologyFilterRuleData">The specific type of the typology filter rule data for comparison.</typeparam>
    public interface ITypologyFilterRuleData<TTypologyFilterRuleData> : ITypologyFilterRuleData, IEquatable<TTypologyFilterRuleData> where TTypologyFilterRuleData : ITypologyFilterRuleData<TTypologyFilterRuleData>
    {
    }
}