using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using DiGi.Typology.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Typology.Classes
{
    /// <summary>
    /// Represents a typology object that can be serialized and compared.
    /// </summary>
    public class Typology : SerializableObject, ITypologyObject, INamedObject, IDescribableObject, IComparable<Typology>
    {
        [JsonInclude, JsonPropertyName("References")]
        private readonly HashSet<string> references = [];

        [JsonIgnore]
        private readonly Dictionary<int, Typology> subTypologies = [];

        [JsonInclude, JsonPropertyName("TypologyItem")]
        private TypologyItem? typologyItem;

        /// <summary>
        /// Initializes a new instance of the <see cref="Typology"/> class by cloning an existing typology.
        /// </summary>
        /// <param name="typology">The source typology object to clone.</param>
        public Typology(Typology? typology)
            : base(typology)
        {
            if (typology != null)
            {
                typologyItem = Core.Query.Clone(typology.typologyItem);

                references = [.. typology.references];

                SubTypologies = typology.SubTypologies;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Typology"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing typology data.</param>
        public Typology(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Typology"/> class with a specified typology item.
        /// </summary>
        /// <param name="typologyItem">The typology item to assign.</param>
        public Typology(TypologyItem? typologyItem)
        {
            this.typologyItem = Core.Query.Clone(typologyItem);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Typology"/> class with a specified typology item and sub-typologies.
        /// </summary>
        /// <param name="typologyItem">The typology item to assign.</param>
        /// <param name="subTypologies">A collection of sub-typologies to associate with this instance.</param>
        public Typology(TypologyItem? typologyItem, IEnumerable<Typology>? subTypologies)
        {
            this.typologyItem = Core.Query.Clone(typologyItem);

            if (subTypologies != null)
            {
                SubTypologies = [.. subTypologies];
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Typology"/> class with a specified name and description.
        /// </summary>
        /// <param name="name">The name of the typology.</param>
        /// <param name="description">The description of the typology.</param>
        public Typology(string? name, string? description)
        {
            typologyItem = new TypologyItem(null, name, description);
        }

        /// <summary>
        /// Gets or sets the description of the typology.
        /// </summary>
        public string? Description
        {
            get
            {
                return typologyItem?.Description;
            }

            set
            {
                typologyItem ??= new TypologyItem();

                typologyItem.Description = value;
            }
        }

        /// <summary>
        /// Gets or sets the name of the typology.
        /// </summary>
        public string? Name
        {
            get
            {
                return typologyItem?.Name;
            }

            set
            {
                typologyItem ??= new TypologyItem();

                typologyItem.Name = value;
            }
        }

        /// <summary>
        /// Gets the list of references associated with this typology.
        /// </summary>
        [JsonIgnore]
        public List<string> References
        {
            get
            {
                return [.. references];
            }
        }

        /// <summary>
        /// Gets or sets the list of sub-typologies associated with this typology.
        /// </summary>
        [JsonInclude, JsonPropertyName("SubTypologies")]
        public List<Typology>? SubTypologies
        {
            get
            {
                return [.. subTypologies.Values];
            }

            private set
            {
                subTypologies?.Clear();
                if (value != null)
                {
                    foreach (Typology typology in value)
                    {
                        if (typology?.typologyItem?.TypologyPath?.Index is int index)
                        {
                            subTypologies![index] = typology;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Gets the path information for this typology.
        /// </summary>
        [JsonIgnore]
        public TypologyPath? TypologyPath
        {
            get
            {
                return typologyItem?.TypologyPath;
            }
        }
/// <summary>
        /// Adds a reference to the typology.
        /// </summary>
        /// <param name="reference">The reference string to add.</param>
        /// <returns>True if the reference was added successfully; otherwise, false.</returns>
        public bool AddReference(string? reference)
        {
            if (reference == null)
            {
                return false;
            }

            return references.Add(reference);
        }

        /// <summary>
        /// Compares the current typology instance with another typology instance.
        /// </summary>
        /// <param name="typology">The typology instance to compare against.</param>
        /// <returns>A signed integer that indicates the relative order of the objects being compared.</returns>
        public int CompareTo(Typology typology)
        {
            if (typologyItem == null)
            {
                return int.MinValue;
            }

            if (typology?.typologyItem == null)
            {
                return 1; // non-null > null
            }

            return typologyItem.CompareTo(typology.typologyItem);
        }

        /// <summary>
        /// Determines whether the typology contains a specific reference, optionally including references from nested typologies.
        /// </summary>
        /// <param name="reference">The reference string to search for.</param>
        /// <param name="includeNested">A value indicating whether to include nested typologies in the search.</param>
        /// <returns>True if the reference is found; otherwise, false.</returns>
        public bool Contains(string reference, bool includeNested = false)
        {
            if (reference is null)
            {
                return false;
            }

            if (references is not null)
            {
                if (references.Contains(reference))
                {
                    return true;
                }
            }

            if (!includeNested)
            {
                return false;
            }

            foreach (Typology subTypology in subTypologies.Values)
            {
                if (subTypology.Contains(reference, includeNested))
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Retrieves a set of all references associated with this typology, optionally including those from nested typologies.
        /// </summary>
        /// <param name="includeNested">A value indicating whether to include references from nested typologies.</param>
        /// <returns>A <see cref="HashSet{T}"/> containing the references.</returns>
        public HashSet<string> GetReferences(bool includeNested)
        {
            HashSet<string> result = [.. references];

            if (!includeNested || subTypologies is null || subTypologies.Count == 0)
            {
                return result;
            }

            foreach (Typology subTypology in subTypologies.Values)
            {
                if (subTypology.GetReferences(includeNested) is not HashSet<string> subReferences)
                {
                    continue;
                }

                result.UnionWith(subReferences);
            }

            return result;
        }

        /// <summary>
        /// Retrieves a typology instance based on the provided typology path.
        /// </summary>
        /// <param name="typologyPath">The path used to locate the typology.</param>
        /// <returns>The <see cref="Typology"/> instance if found; otherwise, null.</returns>
        public Typology? GetTypology(TypologyPath? typologyPath)
        {
            if (typologyPath is null)
            {
                return null;
            }

            if (typologyPath.Count == 0)
            {
                return this;
            }

            if (typologyPath.ParentCount <= 0)
            {
                if (!subTypologies.TryGetValue(typologyPath.Index, out Typology? result))
                {
                    result = null;
                }

                return result;
            }

            if (typologyPath.GetParent(0) is not TypologyPath typologyPath_Parent)
            {
                return null;
            }

            if (!subTypologies.TryGetValue(typologyPath_Parent.Index, out Typology? typology_Parent))
            {
                return null;
            }

            return typology_Parent.GetTypology(typologyPath.GetTypologyPath(1, typologyPath.Count - 1));
        }

        /// <summary>
        /// Retrieves a typology instance based on a sequence of integer identifiers representing the path.
        /// </summary>
        /// <param name="values">An enumerable collection of integers representing the typology path.</param>
        /// <returns>The <see cref="Typology"/> instance if found; otherwise, null.</returns>
        public Typology? GetTypology(IEnumerable<int>? values)
        {
            if (values is null)
            {
                return null;
            }

            return GetTypology(new TypologyPath(values));
        }

        /// <summary>
        /// Retrieves a list of typology paths for all sub-typologies, optionally including nested ones.
        /// </summary>
        /// <param name="includeNested">A value indicating whether to recursively retrieve paths from nested typologies.</param>
        /// <returns>A <see cref="List{T}"/> of <see cref="TypologyPath"/> objects, or null if no sub-typologies exist.</returns>
        public List<TypologyPath>? GetTypologyPaths(bool includeNested = false)
        {
            if (SubTypologies == null)
            {
                return null;
            }

            List<TypologyPath> result = [];
            foreach (Typology subTypology in subTypologies.Values)
            {
                if (subTypology?.typologyItem?.TypologyPath is not TypologyPath typologyPath)
                {
                    continue;
                }

                result.Add(typologyPath);

                if (includeNested)
                {
                    List<TypologyPath>? typologyPaths = subTypology.GetTypologyPaths(includeNested);
                    if (typologyPaths != null)
                    {
                        result.AddRange(typologyPaths);
                    }
                }
            }

            return result;
        }
        /// <summary>Returns a string representation of the current typology.</summary>
        /// <returns>A string representing the typology item or the base object string.</returns>
        public override string ToString()
        {
            return typologyItem?.ToString() ?? base.ToString();
        }

        /// <summary>Attempts to retrieve the last index from the sub-typologies collection.</summary>
        /// <param name="index">When this method returns, contains the maximum index if successful; otherwise, -1.</param>
        /// <returns>True if the last index was successfully retrieved; otherwise, false.</returns>
        public bool TryGetLastIndex(out int index)
        {
            index = -1;
            if (subTypologies is null || subTypologies.Count == 0)
            {
                return false;
            }

            index = subTypologies.Keys.Max();
            return true;
        }

        /// <summary>Attempts to retrieve a list of typologies that match the specified path and name.</summary>
        /// <param name="typologyPath">The path to search within.</param>
        /// <param name="name">The name of the typologies to find.</param>
        /// <param name="typologies">When this method returns, contains a list of matching typologies if successful; otherwise, null.</param>
        /// <returns>True if one or more matching typologies were found; otherwise, false.</returns>
        public bool TryGetTypologies(TypologyPath? typologyPath, string name, out List<Typology>? typologies)
        {
            typologies = null;

            if (typologyPath is null)
            {
                return false;
            }

            Typology? typology = GetTypology(typologyPath);
            if (typology?.subTypologies is null)
            {
                return false;
            }

            typologies = [];

            foreach (Typology subTypology in typology.subTypologies.Values)
            {
                if (subTypology.Name != name)
                {
                    continue;
                }

                typologies.Add(subTypology);
            }

            return typologies is not null && typologies.Count > 0;
        }

        /// <summary>Attempts to retrieve a list of typologies that match the specified index values and name.</summary>
        /// <param name="values">The sequence of indices representing the typology path.</param>
        /// <param name="name">The name of the typologies to find.</param>
        /// <param name="typologies">When this method returns, contains a list of matching typologies if successful; otherwise, null.</param>
        /// <returns>True if one or more matching typologies were found; otherwise, false.</returns>
        public bool TryGetTypologies(IEnumerable<int> values, string name, out List<Typology>? typologies)
        {
            typologies = null;

            if (values == null)
            {
                return false;
            }

            return TryGetTypologies(new TypologyPath(values), name, out typologies);
        }

        /// <summary>Attempts to retrieve a list of typologies that match the specified name at the root level.</summary>
        /// <param name="name">The name of the typologies to find.</param>
        /// <param name="typologies">When this method returns, contains a list of matching typologies if successful; otherwise, null.</param>
        /// <returns>True if one or more matching typologies were found; otherwise, false.</returns>
        public bool TryGetTypologies(string name, out List<Typology>? typologies)
        {
            return TryGetTypologies(new TypologyPath((IEnumerable<int>)[]), name, out typologies);
        }

        /// <summary>Updates the typology based on the provided typology item.</summary>
        /// <param name="typologyItem">The typology item containing updated information.</param>
        /// <returns>The updated Typology instance, or null if the input was null.</returns>
        public Typology? Update(TypologyItem? typologyItem)
        {
            if (typologyItem is null)
            {
                return null;
            }

            if (typologyItem.TypologyPath is not TypologyPath typologyPath)
            {
                if (!TryGetLastIndex(out int index))
                {
                    index = 0;
                }

                typologyPath = new TypologyPath([index + 1]);
            }

            Typology? result;

            if (typologyPath.Parent is not TypologyPath typologyPath_Parent)
            {
                typologyPath_Parent = (this.typologyItem?.TypologyPath + typologyPath)!;

                result = GetTypology(typologyPath_Parent);
                if (result is null)
                {
                    result = new Typology(new TypologyItem(typologyPath_Parent, typologyItem));
                }
                else
                {
                    result.Name = typologyItem.Name;
                    result.Description = typologyItem.Description;
                }

                subTypologies[typologyPath.Index] = result;
                return result;
            }

            Typology? typology_Parent = GetTypology(typologyPath_Parent);
            if (typology_Parent is null)
            {
                typology_Parent = new Typology(new TypologyItem(this.typologyItem?.TypologyPath + typologyPath_Parent, null, null));
                subTypologies[typologyPath_Parent.Index] = typology_Parent;
            }

            return typology_Parent.Update(new TypologyItem(typologyPath.GetTypologyPath(1, typologyPath.Count - 1), typologyItem));
        }

        /// <summary>Updates or creates a typology using specified path values, name, and description.</summary>
        /// <param name="values">The sequence of indices representing the typology path.</param>
        /// <param name="name">The name of the typology.</param>
        /// <param name="description">The description of the typology.</param>
        /// <returns>The updated or created Typology instance, or null if update failed.</returns>
        public Typology? Update(IEnumerable<int>? values, string? name, string? description)
        {
            return Update(new TypologyItem(values == null ? null : new TypologyPath(values), name, description));
        }

        /// <summary>Updates or creates a typology using specified name and description at the current level.</summary>
        /// <param name="name">The name of the typology.</param>
        /// <param name="description">The description of the typology.</param>
        /// <returns>The updated or created Typology instance, or null if update failed.</returns>
        public Typology? Update(string? name, string? description)
        {
            return Update(new TypologyItem(null, name, description));
        }

        /// <summary>Updates or creates a typology using specified name at the current level.</summary>
        /// <param name="name">The name of the typology.</param>
        /// <returns>The updated or created Typology instance, or null if update failed.</returns>
        public Typology? Update(string? name)
        {
            return Update(new TypologyItem(null, name));
        }

        /// <summary>Updates or creates a typology using specified path values and name.</summary>
        /// <param name="values">The sequence of indices representing the typology path.</param>
        /// <param name="name">The name of the typology.</param>
        /// <returns>The updated or created Typology instance, or null if update failed.</returns>
        public Typology? Update(IEnumerable<int>? values, string? name)
        {
            return Update(new TypologyItem(values, name));
        }
    }
}
