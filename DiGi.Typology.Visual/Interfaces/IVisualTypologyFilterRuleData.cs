using DiGi.Typology.Interfaces;
using DiGi.Typology.Visual.Classes;

namespace DiGi.Typology.Visual.Interfaces
{
    /// <summary>
    /// Defines the contract for the rule data of a bucket that carries the bucket's appearance.
    /// <para>A consumer holding an <see cref="ITypologyFilterRuleData"/> - a solver's <c>GetTypologyItem</c> hook, for
    /// one - reads the appearance through this interface without knowing which rule kind, or which closed generic
    /// type, produced it.</para>
    /// </summary>
    public interface IVisualTypologyFilterRuleData : ITypologyVisualSerializableObject, ITypologyFilterRuleData
    {
        /// <summary>
        /// Gets or sets the appearance of the bucket this rule data describes, or null when it has none.
        /// </summary>
        TypologyAppearance? Appearance { get; set; }
    }
}
