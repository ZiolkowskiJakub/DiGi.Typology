using System.Collections.Generic;

namespace DiGi.Typology
{
    public static partial class Query
    {
        /// <summary>
        /// Retrieves the set of references associated with the given typology, optionally including those
        /// carried by its nested typologies.
        /// <para>With <paramref name="includeNested"/> false this is the content of
        /// <see cref="Classes.Typology.References"/> as a set; the recursive form is what this method adds.
        /// It is named for the set it returns because the typology already exposes a References property.</para>
        /// </summary>
        /// <param name="typology">The typology whose references are collected.</param>
        /// <param name="includeNested">A value indicating whether to include references from nested typologies.</param>
        /// <returns>A <see cref="HashSet{T}"/> containing the references, empty when the typology is null.</returns>
        public static HashSet<string> ReferenceSet(this Classes.Typology? typology, bool includeNested = false)
        {
            HashSet<string> result = [];

            if (typology is null)
            {
                return result;
            }

            result.UnionWith(typology.References);

            if (!includeNested || typology.SubTypologies is not List<Classes.Typology> subTypologies)
            {
                return result;
            }

            foreach (Classes.Typology subTypology in subTypologies)
            {
                result.UnionWith(subTypology.ReferenceSet(includeNested));
            }

            return result;
        }
    }
}
