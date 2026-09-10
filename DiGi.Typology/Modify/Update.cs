using DiGi.Typology.Classes;
using System.Collections.Generic;

namespace DiGi.Typology
{
    public static partial class Modify
    {
        /// <summary>Updates the given typology based on the provided typology item.
        /// <para>The path carried by the item is relative to <paramref name="typology"/>. Missing intermediate
        /// nodes are created; an existing node is updated in place, keeping its sub-typologies and
        /// its references. When the item carries no path, it is filed under a new index.</para>
        /// </summary>
        /// <param name="typology">The typology to update.</param>
        /// <param name="typologyItem">The typology item containing updated information.</param>
        /// <returns>The updated Typology instance, or null if either input was null.</returns>
        public static Classes.Typology? Update(this Classes.Typology? typology, TypologyItem? typologyItem)
        {
            if (typology is null || typologyItem is null)
            {
                return null;
            }

            if (typologyItem.TypologyPath is not TypologyPath typologyPath || typologyPath.Count == 0)
            {
                if (!typology.TryGetLastIndex(out int index))
                {
                    // Seed -1 so the first generated child lands at index [0], consistent
                    // with the SubTypologies setter and the -1 "no path" sentinel in TypologyPath.Index.
                    index = -1;
                }

                typologyPath = new TypologyPath([index + 1]);
            }

            if (typologyPath.Count == 1)
            {
                Classes.Typology? result = typology.SubTypology(typologyPath);
                if (result is null)
                {
                    result = new Classes.Typology(new TypologyItem(typology.TypologyPath + typologyPath, typologyItem));
                }
                else
                {
                    result.Name = typologyItem.Name;
                    result.Description = typologyItem.Description;
                }

                typology[typologyPath.Index] = result;
                return result;
            }

            if (typologyPath.GetTypologyPath(0, 1) is not TypologyPath typologyPath_Child)
            {
                return null;
            }

            Classes.Typology? typology_Child = typology.SubTypology(typologyPath_Child);
            if (typology_Child is null)
            {
                typology_Child = new Classes.Typology(new TypologyItem(typology.TypologyPath + typologyPath_Child, null, null));
                typology[typologyPath_Child.Index] = typology_Child;
            }

            return typology_Child.Update(new TypologyItem(typologyPath.GetTypologyPath(1, typologyPath.Count - 1), typologyItem));
        }

        /// <summary>Updates or creates a sub-typology using specified path values, name, and description.</summary>
        /// <param name="typology">The typology to update.</param>
        /// <param name="values">The sequence of indices representing the typology path.</param>
        /// <param name="name">The name of the typology.</param>
        /// <param name="description">The description of the typology.</param>
        /// <returns>The updated or created Typology instance, or null if update failed.</returns>
        public static Classes.Typology? Update(this Classes.Typology? typology, IEnumerable<int>? values, string? name, string? description)
        {
            return typology.Update(new TypologyItem(values == null ? null : new TypologyPath(values), name, description));
        }

        /// <summary>Updates or creates a sub-typology using specified name and description at the current level.</summary>
        /// <param name="typology">The typology to update.</param>
        /// <param name="name">The name of the typology.</param>
        /// <param name="description">The description of the typology.</param>
        /// <returns>The updated or created Typology instance, or null if update failed.</returns>
        public static Classes.Typology? Update(this Classes.Typology? typology, string? name, string? description)
        {
            return typology.Update(new TypologyItem(null, name, description));
        }

        /// <summary>Updates or creates a sub-typology using specified name at the current level.</summary>
        /// <param name="typology">The typology to update.</param>
        /// <param name="name">The name of the typology.</param>
        /// <returns>The updated or created Typology instance, or null if update failed.</returns>
        public static Classes.Typology? Update(this Classes.Typology? typology, string? name)
        {
            return typology.Update(new TypologyItem(null, name));
        }

        /// <summary>Updates or creates a sub-typology using specified path values and name.</summary>
        /// <param name="typology">The typology to update.</param>
        /// <param name="values">The sequence of indices representing the typology path.</param>
        /// <param name="name">The name of the typology.</param>
        /// <returns>The updated or created Typology instance, or null if update failed.</returns>
        public static Classes.Typology? Update(this Classes.Typology? typology, IEnumerable<int>? values, string? name)
        {
            return typology.Update(new TypologyItem(values, name));
        }
    }
}
