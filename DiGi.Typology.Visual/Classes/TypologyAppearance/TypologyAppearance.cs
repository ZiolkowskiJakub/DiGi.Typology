using DiGi.Core.Classes;
using DiGi.Geometry.Visual.Core.Interfaces;
using DiGi.Typology.Visual.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Typology.Visual.Classes
{
    /// <summary>
    /// The appearance of one typology bucket or node: a set of shape appearances, one per kind, such as a
    /// <see cref="DiGi.Geometry.Visual.Core.Classes.FaceAppearance"/> for faces and a
    /// <see cref="DiGi.Geometry.Visual.Core.Classes.CurveAppearance"/> for curves.
    /// <para>This is a container of <see cref="IAppearance"/> instances, not an appearance itself. Each is filed under
    /// its exact runtime type and matched exactly: with only a <c>CurveAppearance</c> filed, asking for a
    /// <c>PointAppearance</c> yields null even though the former derives from the latter, because an assignable-to
    /// lookup could answer with either of two filed kinds.</para>
    /// <para>The serialized form lists the appearances in the ordinal order of their type names whatever order they
    /// were filed in, so two containers holding the same appearances serialize identically.</para>
    /// </summary>
    public class TypologyAppearance : SerializableObject, ITypologyVisualSerializableObject
    {
        [JsonIgnore]
        private readonly Dictionary<Type, IAppearance> dictionary = [];

        /// <summary>
        /// Initializes a new, empty instance of the <see cref="TypologyAppearance"/> class.
        /// </summary>
        public TypologyAppearance()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TypologyAppearance"/> class filing the given appearances.
        /// <para>The instances are filed as given, not cloned; where two share a runtime type the later one wins.</para>
        /// </summary>
        /// <param name="appearances">The appearances to file; null entries are skipped.</param>
        public TypologyAppearance(IEnumerable<IAppearance?>? appearances)
        {
            Appearances = appearances;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TypologyAppearance"/> class by copying another instance: every
        /// appearance is cloned.
        /// </summary>
        /// <param name="typologyAppearance">The source appearance to copy.</param>
        public TypologyAppearance(TypologyAppearance? typologyAppearance)
            : base(typologyAppearance)
        {
            if (typologyAppearance is null)
            {
                return;
            }

            foreach (IAppearance appearance in typologyAppearance.dictionary.Values)
            {
                if (Core.Query.Clone(appearance) is IAppearance appearance_Temp)
                {
                    dictionary[appearance_Temp.GetType()] = appearance_Temp;
                }
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TypologyAppearance"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing the appearance data.</param>
        public TypologyAppearance(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Gets the number of appearances filed.
        /// </summary>
        [JsonIgnore]
        public int Count
        {
            get
            {
                return dictionary.Count;
            }
        }

        /// <summary>
        /// Gets the runtime types of the appearances filed, in the ordinal order of their full names. A new list is
        /// built on every call.
        /// </summary>
        [JsonIgnore]
        public List<Type> Types
        {
            get
            {
                return [.. dictionary.Keys.OrderBy(x => x.FullName, StringComparer.Ordinal)];
            }
        }

        [JsonInclude, JsonPropertyName(nameof(Appearances))]
        private IEnumerable<IAppearance?>? Appearances
        {
            get
            {
                return [.. dictionary.Values.OrderBy(x => x.GetType().FullName, StringComparer.Ordinal)];
            }

            set
            {
                dictionary.Clear();

                if (value is null)
                {
                    return;
                }

                foreach (IAppearance? appearance in value)
                {
                    Add(appearance);
                }
            }
        }

        /// <summary>
        /// Gets the appearance filed under exactly the given runtime type, or null when there is none.
        /// </summary>
        /// <param name="type">The runtime type of the appearance.</param>
        /// <returns>The appearance filed under the type, or null when there is none or the type is null.</returns>
        [JsonIgnore]
        public IAppearance? this[Type? type]
        {
            get
            {
                if (type is null || !dictionary.TryGetValue(type, out IAppearance? result))
                {
                    return null;
                }

                return result;
            }
        }

        /// <summary>
        /// Files an appearance under its runtime type, replacing the one already filed under that type.
        /// </summary>
        /// <param name="appearance">The appearance to file.</param>
        /// <returns>True if the appearance was filed; otherwise, false (null).</returns>
        public bool Add(IAppearance? appearance)
        {
            if (appearance is null)
            {
                return false;
            }

            dictionary[appearance.GetType()] = appearance;
            return true;
        }

        /// <summary>
        /// Determines whether an appearance is filed under exactly the given runtime type.
        /// </summary>
        /// <param name="type">The runtime type of the appearance.</param>
        /// <returns>True if an appearance is filed under the type; otherwise, false (absent or null).</returns>
        public bool Contains(Type? type)
        {
            if (type is null)
            {
                return false;
            }

            return dictionary.ContainsKey(type);
        }

        /// <summary>
        /// Removes the appearance filed under exactly the given runtime type.
        /// </summary>
        /// <param name="type">The runtime type of the appearance.</param>
        /// <returns>True if an appearance was removed; otherwise, false (absent or null).</returns>
        public bool Remove(Type? type)
        {
            if (type is null)
            {
                return false;
            }

            return dictionary.Remove(type);
        }
    }
}