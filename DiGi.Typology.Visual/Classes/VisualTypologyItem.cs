using DiGi.Typology.Classes;
using DiGi.Typology.Visual.Interfaces;
using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Typology.Visual.Classes
{
    /// <summary>
    /// A <see cref="TypologyItem"/> carrying the appearance of its node.
    /// <para>The appearance is node metadata, not link data: like the name and the description it is settable, it
    /// survives <see cref="DiGi.Typology.Modify.RemoveReferences{TTypology, TTypologyItem}(Typology{TTypology, TTypologyItem}, bool)"/>
    /// and a re-sync of the references, and it takes part in equality, ordering and the hash. Appearances have no value
    /// equality of their own, so they are compared through their serialized form, which
    /// <see cref="TypologyAppearance"/> keeps canonical.</para>
    /// </summary>
    public class VisualTypologyItem : TypologyItem, ITypologyVisualSerializableObject
    {
        [JsonInclude, JsonPropertyName(nameof(Appearance))]
        private TypologyAppearance? appearance;

        /// <summary>
        /// Initializes a new, empty instance of the <see cref="VisualTypologyItem"/> class.
        /// </summary>
        public VisualTypologyItem()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VisualTypologyItem"/> class using a collection of path values, a
        /// name, a description and an appearance.
        /// </summary>
        /// <param name="values">The sequence of integers defining the typology path.</param>
        /// <param name="name">The name of the item.</param>
        /// <param name="description">The description of the item.</param>
        /// <param name="appearance">The appearance of the node; it is cloned.</param>
        public VisualTypologyItem(IEnumerable<int>? values, string? name, string? description, TypologyAppearance? appearance)
            : base(values, name, description)
        {
            this.appearance = Core.Query.Clone(appearance);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VisualTypologyItem"/> class using a typology path, a name, a
        /// description and an appearance.
        /// </summary>
        /// <param name="typologyPath">The path associated with this item.</param>
        /// <param name="name">The name of the item.</param>
        /// <param name="description">The description of the item.</param>
        /// <param name="appearance">The appearance of the node; it is cloned.</param>
        public VisualTypologyItem(TypologyPath? typologyPath, string? name, string? description, TypologyAppearance? appearance)
            : base(typologyPath, name, description)
        {
            this.appearance = Core.Query.Clone(appearance);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VisualTypologyItem"/> class using a specific typology path and
        /// the name, description and appearance of another item.
        /// </summary>
        /// <param name="typologyPath">The path to assign to this item.</param>
        /// <param name="visualTypologyItem">The source item to copy the name, the description and the appearance from.</param>
        public VisualTypologyItem(TypologyPath? typologyPath, VisualTypologyItem visualTypologyItem)
            : base(typologyPath, visualTypologyItem)
        {
            appearance = Core.Query.Clone(visualTypologyItem.appearance);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VisualTypologyItem"/> class by cloning an existing item.
        /// </summary>
        /// <param name="visualTypologyItem">The source item to clone.</param>
        public VisualTypologyItem(VisualTypologyItem? visualTypologyItem)
            : base(visualTypologyItem)
        {
            if (visualTypologyItem is not null)
            {
                appearance = Core.Query.Clone(visualTypologyItem.appearance);
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VisualTypologyItem"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing item data.</param>
        public VisualTypologyItem(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Gets or sets the appearance of the node, or null when it has none.
        /// </summary>
        [JsonIgnore]
        public TypologyAppearance? Appearance
        {
            get
            {
                return appearance;
            }

            set
            {
                appearance = value;
            }
        }

        /// <summary>
        /// Compares by the base item first, then by the serialized form of the appearance, ordinally, an absent
        /// appearance first; a plain <see cref="TypologyItem"/> orders before an equal-valued visual item.
        /// </summary>
        /// <param name="typologyItem">The item to compare with this instance.</param>
        /// <returns>A value indicating the relative order of the objects being compared.</returns>
        public override int CompareTo(TypologyItem typologyItem)
        {
            int compare = base.CompareTo(typologyItem);
            if (compare != 0)
            {
                return compare;
            }

            if (typologyItem is not VisualTypologyItem visualTypologyItem)
            {
                return 1; // visual > plain
            }

            return string.CompareOrdinal(Core.Convert.ToSystem_String(appearance), Core.Convert.ToSystem_String(visualTypologyItem.appearance));
        }

        /// <summary>
        /// Determines whether the specified item is value-equal to the current item, the appearance included.
        /// </summary>
        /// <param name="typologyItem">The item to compare with the current instance.</param>
        /// <returns>True if the item is a <see cref="VisualTypologyItem"/> equal in base value and in appearance; otherwise, false.</returns>
        public override bool Equals(TypologyItem? typologyItem)
        {
            if (typologyItem is not VisualTypologyItem visualTypologyItem || !base.Equals(visualTypologyItem))
            {
                return false;
            }

            return string.Equals(Core.Convert.ToSystem_String(appearance), Core.Convert.ToSystem_String(visualTypologyItem.appearance), StringComparison.Ordinal);
        }

        /// <summary>
        /// Returns a hash code combining the base item hash with the serialized form of the appearance.
        /// <para>The appearance is mutable, so the hash follows it - an item must not be mutated while it is held as a
        /// key of a dictionary or a set.</para>
        /// </summary>
        /// <returns>A 32-bit signed integer hash code.</returns>
        public override int GetHashCode()
        {
            unchecked // allow arithmetic overflow
            {
                return base.GetHashCode() * 31 + (Core.Convert.ToSystem_String(appearance)?.GetHashCode() ?? 0);
            }
        }
    }
}
