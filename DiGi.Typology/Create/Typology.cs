using DiGi.Typology.Classes;
using System.Collections.Generic;

namespace DiGi.Typology
{
    public static partial class Create
    {
        /// <summary>
        /// Creates a typology carrying the given item and the given sub-typologies.
        /// <para>The sub-typologies are filed by <see cref="Modify.AddSubTypologies{TTypology, TTypologyItem}(Classes.Typology{TTypology, TTypologyItem}, IEnumerable{TTypology})"/>:
        /// each is cloned and filed under the last index of its own path, or under the next free index
        /// when it carries no path or its index is already taken. Resolving those indexes is why this is
        /// a factory rather than a constructor.</para>
        /// </summary>
        /// <param name="typologyItem">The typology item to assign.</param>
        /// <param name="subTypologies">A collection of sub-typologies to associate with the new instance.</param>
        /// <returns>The created typology, or null when both arguments are null.</returns>
        public static Classes.Typology? Typology(this TypologyItem? typologyItem, IEnumerable<Classes.Typology>? subTypologies)
        {
            if (typologyItem is null && subTypologies is null)
            {
                return null;
            }

            Classes.Typology result = new(typologyItem);

            result.AddSubTypologies(subTypologies);

            return result;
        }
    }
}
