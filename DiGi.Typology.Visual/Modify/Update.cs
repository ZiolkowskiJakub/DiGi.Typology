using DiGi.Typology.Visual.Classes;
using System.Collections.Generic;

namespace DiGi.Typology.Visual
{
    /// <summary>
    /// Argument-free <c>Modify.Update</c> overloads for the <see cref="VisualTypology"/> receiver.
    /// <para>The base generic overloads take the item type in no parameter on their string-based shapes, so at a
    /// <see cref="VisualTypology"/> call site the type arguments cannot be inferred and would have to be stated
    /// explicitly. These overloads name the type for the caller and delegate to the base generic form, which builds
    /// every created node through <c>VisualTypology</c>'s own <c>CreateNode</c>, so a created node's appearance is
    /// taken from the source item rather than flattened away.</para>
    /// </summary>
    public static partial class Modify
    {
        /// <summary>Updates or creates a sub-typology using specified path values, name, and description.</summary>
        /// <param name="typology">The typology to update.</param>
        /// <param name="values">The sequence of indices representing the typology path, relative to <paramref name="typology"/>.</param>
        /// <param name="name">The name of the typology.</param>
        /// <param name="description">The description of the typology.</param>
        /// <returns>The updated or created typology instance, or null if update failed.</returns>
        public static VisualTypology? Update(this VisualTypology? typology, IEnumerable<int>? values, string? name, string? description)
        {
            return DiGi.Typology.Modify.Update<VisualTypology, VisualTypologyItem>(typology, values, name, description);
        }

        /// <summary>Updates or creates a sub-typology using specified name and description at the current level.</summary>
        /// <param name="typology">The typology to update.</param>
        /// <param name="name">The name of the typology.</param>
        /// <param name="description">The description of the typology.</param>
        /// <returns>The updated or created typology instance, or null if update failed.</returns>
        public static VisualTypology? Update(this VisualTypology? typology, string? name, string? description)
        {
            return DiGi.Typology.Modify.Update<VisualTypology, VisualTypologyItem>(typology, name, description);
        }

        /// <summary>Updates or creates a sub-typology using specified name at the current level.</summary>
        /// <param name="typology">The typology to update.</param>
        /// <param name="name">The name of the typology.</param>
        /// <returns>The updated or created typology instance, or null if update failed.</returns>
        public static VisualTypology? Update(this VisualTypology? typology, string? name)
        {
            return DiGi.Typology.Modify.Update<VisualTypology, VisualTypologyItem>(typology, name);
        }

        /// <summary>Updates or creates a sub-typology using specified path values and name.</summary>
        /// <param name="typology">The typology to update.</param>
        /// <param name="values">The sequence of indices representing the typology path, relative to <paramref name="typology"/>.</param>
        /// <param name="name">The name of the typology.</param>
        /// <returns>The updated or created typology instance, or null if update failed.</returns>
        public static VisualTypology? Update(this VisualTypology? typology, IEnumerable<int>? values, string? name)
        {
            return DiGi.Typology.Modify.Update<VisualTypology, VisualTypologyItem>(typology, values, name);
        }
    }
}
