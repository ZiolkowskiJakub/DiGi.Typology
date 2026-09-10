using System.Collections.Generic;

namespace DiGi.Typology
{
    public static partial class Query
    {
        /// <summary>
        /// Determines whether the given typology carries a specific reference, optionally searching its
        /// nested typologies as well.
        /// </summary>
        /// <param name="typology">The typology to search.</param>
        /// <param name="reference">The reference string to search for.</param>
        /// <param name="includeNested">A value indicating whether to include nested typologies in the search.</param>
        /// <returns>True if the reference is found; otherwise, false.</returns>
        public static bool Contains(this Classes.Typology? typology, string? reference, bool includeNested = false)
        {
            if (typology is null || reference is null)
            {
                return false;
            }

            if (typology.ContainsReference(reference))
            {
                return true;
            }

            if (!includeNested || typology.SubTypologies is not List<Classes.Typology> subTypologies)
            {
                return false;
            }

            foreach (Classes.Typology subTypology in subTypologies)
            {
                if (subTypology.Contains(reference, includeNested))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
