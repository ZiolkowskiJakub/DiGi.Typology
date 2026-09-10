using DiGi.Typology.Classes;
using System.Collections.Generic;

namespace DiGi.Typology
{
    public static partial class Query
    {
        /// <summary>
        /// Retrieves the sub-typology found at the provided path, relative to the given typology.
        /// <para>An empty path resolves to <paramref name="typology"/> itself. Each step of the path is
        /// resolved against the filing keys of the typology reached so far, so a sub-typology filed under
        /// a key differing from the one its own path reports is still found.</para>
        /// </summary>
        /// <param name="typology">The typology the path is resolved against.</param>
        /// <param name="typologyPath">The path used to locate the sub-typology.</param>
        /// <returns>The <see cref="Classes.Typology"/> instance if found; otherwise, null.</returns>
        public static Classes.Typology? SubTypology(this Classes.Typology? typology, TypologyPath? typologyPath)
        {
            if (typology is null || typologyPath is null)
            {
                return null;
            }

            if (typologyPath.Count == 0)
            {
                return typology;
            }

            if (typologyPath.ParentCount <= 0)
            {
                return typology[typologyPath.Index];
            }

            if (typologyPath.GetParent(0) is not TypologyPath typologyPath_Parent)
            {
                return null;
            }

            if (typology[typologyPath_Parent.Index] is not Classes.Typology typology_Parent)
            {
                return null;
            }

            return typology_Parent.SubTypology(typologyPath.GetTypologyPath(1, typologyPath.Count - 1));
        }

        /// <summary>
        /// Retrieves the sub-typology found at the path described by a sequence of integer indexes,
        /// relative to the given typology.
        /// </summary>
        /// <param name="typology">The typology the path is resolved against.</param>
        /// <param name="values">An enumerable collection of integers representing the typology path.</param>
        /// <returns>The <see cref="Classes.Typology"/> instance if found; otherwise, null.</returns>
        public static Classes.Typology? SubTypology(this Classes.Typology? typology, IEnumerable<int>? values)
        {
            if (typology is null || values is null)
            {
                return null;
            }

            return typology.SubTypology(new TypologyPath(values));
        }
    }
}
