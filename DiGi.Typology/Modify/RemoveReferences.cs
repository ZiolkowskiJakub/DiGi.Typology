using System.Collections.Generic;

namespace DiGi.Typology
{
    public static partial class Modify
    {
        /// <summary>
        /// Removes every reference held by the given typology, optionally descending into its nested typologies.
        /// <para>Structure and node metadata are left untouched, so what remains is the metadata-only form of the same tree. Use it to strip a solved tree whose node to object association is held elsewhere, rather than re-solving one.</para>
        /// <para>Applied to a sub-typology this strips that branch alone, because Query.SubTypology returns the instance the tree holds rather than a clone of it.</para>
        /// </summary>
        /// <param name="typology">The typology to strip.</param>
        /// <param name="includeNested">A value indicating whether nested typologies are stripped as well.</param>
        /// <returns>True when at least one reference was removed; otherwise, false.</returns>
        public static bool RemoveReferences(this Classes.Typology? typology, bool includeNested = true)
        {
            if (typology is null)
            {
                return false;
            }

            bool result = false;

            foreach (string reference in typology.References)
            {
                if (typology.RemoveReference(reference))
                {
                    result = true;
                }
            }

            if (!includeNested || typology.SubTypologies is not List<Classes.Typology> subTypologies)
            {
                return result;
            }

            foreach (Classes.Typology subTypology in subTypologies)
            {
                if (subTypology.RemoveReferences(includeNested))
                {
                    result = true;
                }
            }

            return result;
        }
    }
}
