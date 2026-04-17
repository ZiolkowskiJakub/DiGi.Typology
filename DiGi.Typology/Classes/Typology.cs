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
    public class Typology : SerializableObject, ITypologyObject, INamedObject, IDescribableObject, IComparable<Typology>
    {
        [JsonInclude, JsonPropertyName("References")]
        private readonly HashSet<string> references = [];

        [JsonIgnore]
        private readonly Dictionary<int, Typology> subTypologies = [];

        [JsonInclude, JsonPropertyName("TypologyItem")]
        private TypologyItem? typologyItem;

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

        public Typology(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        public Typology(TypologyItem? typologyItem)
        {
            this.typologyItem = Core.Query.Clone(typologyItem);
        }

        public Typology(TypologyItem? typologyItem, IEnumerable<Typology>? subTypologies)
        {
            this.typologyItem = Core.Query.Clone(typologyItem);

            if (subTypologies != null)
            {
                SubTypologies = [.. subTypologies];
            }
        }

        public Typology(string? name, string? description)
        {
            typologyItem = new TypologyItem(null, name, description);
        }

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

        [JsonIgnore]
        public List<string> References
        {
            get
            {
                return [.. references];
            }
        }

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

        [JsonIgnore]
        public TypologyPath? TypologyPath
        {
            get
            {
                return typologyItem?.TypologyPath;
            }
        }

        public bool AddReference(string? reference)
        {
            if (reference == null)
            {
                return false;
            }

            return references.Add(reference);
        }

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

        public Typology? GetTypology(IEnumerable<int>? values)
        {
            if (values is null)
            {
                return null;
            }

            return GetTypology(new TypologyPath(values));
        }

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

        public override string ToString()
        {
            return typologyItem?.ToString() ?? base.ToString();
        }

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

        public bool TryGetTypologies(IEnumerable<int> values, string name, out List<Typology>? typologies)
        {
            typologies = null;

            if (values == null)
            {
                return false;
            }

            return TryGetTypologies(new TypologyPath(values), name, out typologies);
        }

        public bool TryGetTypologies(string name, out List<Typology>? typologies)
        {
            return TryGetTypologies(new TypologyPath((IEnumerable<int>)[]), name, out typologies);
        }

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

        public Typology? Update(IEnumerable<int>? values, string? name, string? description)
        {
            return Update(new TypologyItem(values == null ? null : new TypologyPath(values), name, description));
        }

        public Typology? Update(string? name, string? description)
        {
            return Update(new TypologyItem(null, name, description));
        }

        public Typology? Update(string? name)
        {
            return Update(new TypologyItem(null, name));
        }

        public Typology? Update(IEnumerable<int>? values, string? name)
        {
            return Update(new TypologyItem(values, name));
        }
    }
}