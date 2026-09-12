using DiGi.Typology.Visual.Classes;
using System.Collections.Generic;

namespace DiGi.Typology.Visual
{
    /// <summary>
    /// Argument-free <c>Modify.TryUpdateByName</c> overload for the <see cref="VisualTypology"/> receiver.
    /// <para>The base generic overload takes the item type in no parameter, so at a <see cref="VisualTypology"/> call
    /// site the type arguments cannot be inferred and would have to be stated explicitly. This overload names the
    /// type for the caller and delegates to the base generic form, which builds a created node through
    /// <c>VisualTypology</c>'s own <c>CreateNode</c>, so a created node's appearance is taken from the source item
    /// rather than flattened away.</para>
    /// </summary>
    public static partial class Modify
    {
        /// <summary>
        /// Updates an existing direct child of the receiving typology whose name matches, or creates a new one when
        /// no match exists.
        /// <para>Matching is limited to the direct children of <paramref name="in"/>; their sub-trees are not
        /// searched. When a match is found, only <paramref name="description"/> is applied to the matched child;
        /// <paramref name="values"/> and <paramref name="name"/> are ignored, and if several children share the name,
        /// the first one is used. When no match exists, a new child is created from <paramref name="values"/>,
        /// <paramref name="name"/> and <paramref name="description"/>.</para>
        /// </summary>
        /// <param name="in">The parent typology whose direct children are searched.</param>
        /// <param name="values">Integer values used to create the new child when no match is found; ignored when a match exists.</param>
        /// <param name="name">The name matched against the direct children of <paramref name="in"/>; also the name assigned to a new child.</param>
        /// <param name="description">The description applied to the matched child, or assigned to a new child.</param>
        /// <param name="out">When this method returns, contains the updated or newly created child typology if successful; otherwise, null.</param>
        /// <returns>True if a direct child was updated or created; otherwise, false.</returns>
        public static bool TryUpdateByName(this VisualTypology? @in, IEnumerable<int>? values, string? name, string? description, out VisualTypology? @out)
        {
            return DiGi.Typology.Modify.TryUpdateByName<VisualTypology, VisualTypologyItem>(@in, values, name, description, out @out);
        }
    }
}
