using DiGi.Core.Classes;
using DiGi.Typology.Classes;
using DiGi.Typology.Visual.Interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Typology.Visual.Classes
{
    /// <summary>
    /// A collection of <see cref="TypologyAppearance"/>, one per value, filed under the key <see cref="Key(object)"/>
    /// renders for the value.
    /// <para>The indexer performs that normalisation, so <c>[2010]</c>, <c>["2010"]</c>, <c>[2010L]</c> and
    /// <c>[uniqueValueRuleData]</c> address the same entry. Keys are not kept as <see cref="object"/>: a JSON round trip
    /// turns every key into a string, and a boxed number does not compare equal to its string form or to the same number
    /// of another width.</para>
    /// <para>Two values get the same key exactly when they are <see cref="object.Equals(object)"/>-equal, which is how
    /// <see cref="UniqueValueRuleData"/> buckets them; see <see cref="Key(object)"/> for the forms. Two limitations are
    /// inherent: a text value that is literally <c>"null"</c> shares the key of the NULL bucket, and floating-point keys
    /// are not guaranteed across a .NET Framework host, whose <c>double.ToString</c> differs - use a range rule for
    /// floating-point columns.</para>
    /// </summary>
    public class TypologyAppearanceCollection : SerializableObject, ITypologyVisualSerializableObject
    {
        private const string DateTimeFormat = "yyyy-MM-ddTHH:mm:ss.fffffff";

        [JsonInclude, JsonPropertyName(nameof(Appearances))]
        private readonly Dictionary<string, TypologyAppearance> appearances = [];

        /// <summary>
        /// Initializes a new, empty instance of the <see cref="TypologyAppearanceCollection"/> class. Entries are filed
        /// through the indexer.
        /// </summary>
        public TypologyAppearanceCollection()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TypologyAppearanceCollection"/> class by copying another
        /// instance: every appearance is cloned under its key.
        /// </summary>
        /// <param name="typologyAppearanceCollection">The source collection to copy.</param>
        public TypologyAppearanceCollection(TypologyAppearanceCollection? typologyAppearanceCollection)
            : base(typologyAppearanceCollection)
        {
            if (typologyAppearanceCollection is null)
            {
                return;
            }

            foreach (KeyValuePair<string, TypologyAppearance> keyValuePair in typologyAppearanceCollection.appearances)
            {
                if (Core.Query.Clone(keyValuePair.Value) is TypologyAppearance typologyAppearance)
                {
                    appearances[keyValuePair.Key] = typologyAppearance;
                }
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TypologyAppearanceCollection"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing the collection data.</param>
        public TypologyAppearanceCollection(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Gets the appearances held, in key order. A new list is built on every call.
        /// </summary>
        [JsonIgnore]
        public List<TypologyAppearance> Appearances
        {
            get
            {
                return [.. appearances.Values];
            }
        }

        /// <summary>
        /// Gets the number of appearances held.
        /// </summary>
        [JsonIgnore]
        public int Count
        {
            get
            {
                return appearances.Count;
            }
        }

        /// <summary>
        /// Gets the keys that carry an appearance. A new list is built on every call.
        /// </summary>
        [JsonIgnore]
        public List<string> Keys
        {
            get
            {
                return [.. appearances.Keys];
            }
        }

        /// <summary>
        /// Gets or sets the appearance of the bucket the given value falls into.
        /// <para>The value is normalised through <see cref="Key(object)"/>, so any value type is accepted: <c>null</c>
        /// addresses the NULL bucket, a number its invariant text form whatever its width, and a
        /// <see cref="UniqueValueRuleData"/> its own bucket. The getter returns null when no appearance is filed for the
        /// value; assigning null removes the entry.</para>
        /// </summary>
        /// <param name="object">The value, its string form, or the rule data produced for it.</param>
        /// <returns>The appearance of the bucket, or null when there is none.</returns>
        [JsonIgnore]
        public TypologyAppearance? this[object? @object]
        {
            get
            {
                if (!appearances.TryGetValue(Key(@object), out TypologyAppearance? result))
                {
                    return null;
                }

                return result;
            }

            set
            {
                string key = Key(@object);

                if (value is null)
                {
                    appearances.Remove(key);
                    return;
                }

                appearances[key] = value;
            }
        }

        /// <summary>
        /// Determines whether an appearance is filed for the given value.
        /// </summary>
        /// <param name="object">The value, its string form, or the rule data produced for it.</param>
        /// <returns>True if an appearance is filed for the value; otherwise, false.</returns>
        public bool Contains(object? @object)
        {
            return appearances.ContainsKey(Key(@object));
        }

        /// <summary>
        /// Renders a value as the key its appearance is filed under.
        /// <para>The form is culture-invariant and agrees with <see cref="object.Equals(object)"/>: two values get the
        /// same key exactly when a <see cref="UniqueValueRuleData"/> would bucket them together. <c>null</c> renders as
        /// <c>"null"</c>; a <see cref="UniqueValueRuleData"/> as the key of its value; a string as itself; a
        /// <see cref="decimal"/> with its scale stripped (<c>1.10m</c> and <c>1.1m</c> are equal); a <see cref="double"/> or
        /// <see cref="float"/> as its shortest round-trip form with negative zero folded to zero; a <see cref="DateTime"/> to
        /// the tick with its kind ignored, as its equality ignores it; a <see cref="DateTimeOffset"/> as the UTC instant its
        /// equality compares; any other <see cref="IFormattable"/> in the invariant culture; and anything else -
        /// <see cref="bool"/>, <see cref="Guid"/>, enums - through <see cref="object.ToString()"/>, which is culture-free for
        /// those. For the categorical types a unique value rule is meant for, the key equals
        /// <see cref="UniqueValueRuleData.ToString()"/>.</para>
        /// </summary>
        /// <param name="object">The value, or the rule data produced for it.</param>
        /// <returns>The key.</returns>
        public static string Key(object? @object)
        {
            switch (@object)
            {
                case null:
                    return Core.Constants.UniqueId.Null;

                case UniqueValueRuleData uniqueValueRuleData:
                    return Key(uniqueValueRuleData.Value);

                case string @string:
                    return @string;

                case decimal @decimal:
                    return @decimal.ToString("G29", CultureInfo.InvariantCulture);

                case double @double:
                    return (@double == 0 ? 0d : @double).ToString("R", CultureInfo.InvariantCulture);

                case float @float:
                    return (@float == 0 ? 0f : @float).ToString("R", CultureInfo.InvariantCulture);

                case DateTime dateTime:
                    return dateTime.ToString(DateTimeFormat, CultureInfo.InvariantCulture);

                case DateTimeOffset dateTimeOffset:
                    return dateTimeOffset.UtcDateTime.ToString(DateTimeFormat, CultureInfo.InvariantCulture) + "Z";

                case IFormattable formattable:
                    return formattable.ToString(null, CultureInfo.InvariantCulture);

                default:
                    return @object.ToString() ?? Core.Constants.UniqueId.Null;
            }
        }
    }
}
