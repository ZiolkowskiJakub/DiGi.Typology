using DiGi.Typology.Classes;
using DiGi.Typology.Visual.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Typology.Visual.Classes
{
    /// <summary>
    /// A typology tree whose nodes carry a <see cref="VisualTypologyItem"/>, so each node has an appearance next to its
    /// name and description. All behaviour is inherited from <see cref="Typology{TTypology, TTypologyItem}"/>; this type
    /// only exposes the constructors.
    /// </summary>
    public class VisualTypology : Typology<VisualTypology, VisualTypologyItem>, ITypologyVisualSerializableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VisualTypology"/> class by cloning an existing typology.
        /// </summary>
        /// <param name="visualTypology">The source typology to clone.</param>
        public VisualTypology(VisualTypology? visualTypology)
            : base(visualTypology)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VisualTypology"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing typology data.</param>
        public VisualTypology(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VisualTypology"/> class with a specified typology item.
        /// <para>Use <see cref="Modify.AddSubTypologies{TTypology, TTypologyItem}(Typology{TTypology, TTypologyItem}, System.Collections.Generic.IEnumerable{TTypology})"/>
        /// to file sub-typologies under it: filing each one resolves an index against the indexes already taken, which
        /// does not belong in a constructor.</para>
        /// </summary>
        /// <param name="visualTypologyItem">The typology item to assign; it is cloned.</param>
        public VisualTypology(VisualTypologyItem? visualTypologyItem)
            : base(visualTypologyItem)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VisualTypology"/> class with a specified name and description and
        /// no appearance.
        /// </summary>
        /// <param name="name">The name of the typology.</param>
        /// <param name="description">The description of the typology.</param>
        public VisualTypology(string? name, string? description)
            : base(new VisualTypologyItem(null, name, description, null))
        {
        }
    }
}
