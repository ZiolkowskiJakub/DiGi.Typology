using DiGi.Core.Classes;
using DiGi.Typology.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Typology.Classes
{
    /// <summary>
    /// Represents a path within a typology hierarchy as a sequence of integer values.
    /// </summary>
    public class TypologyPath : SerializableObject, ITypologyObject, IEnumerable<int>, IComparable<TypologyPath>
    {
        [JsonInclude, JsonPropertyName("Values")]
        private readonly List<int> values = [];

        /// <summary>
        /// Initializes a new instance of the <see cref="TypologyPath"/> class using a collection of integer values.
        /// </summary>
        /// <param name="values">The sequence of integers representing the path.</param>
        public TypologyPath(IEnumerable<int>? values)
        {
            if (values != null)
            {
                this.values = [.. values];
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TypologyPath"/> class by copying an existing path.
        /// </summary>
        /// <param name="typologyPath">The source typology path to copy.</param>
        public TypologyPath(TypologyPath? typologyPath)
        {
            if (typologyPath != null)
            {
                values = typologyPath.values != null ? [.. typologyPath.values] : [];
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TypologyPath"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing path data.</param>
        public TypologyPath(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Gets the total number of elements in the typology path.
        /// </summary>
        public int Count
        {
            get
            {
                return values.Count;
            }
        }

        /// <summary>
        /// Gets the value of the last element in the path, or -1 if the path is empty.
        /// </summary>
        public int Index
        {
            get
            {
                return values.Count == 0 ? -1 : values.Last();
            }
        }

        /// <summary>
        /// Gets the immediate parent of the current typology path.
        /// </summary>
        public TypologyPath? Parent
        {
            get
            {
                int parentCount = ParentCount;
                if (parentCount == 0)
                {
                    return null;
                }

                return GetParent(parentCount - 1);
            }
        }

        /// <summary>
        /// Gets the number of ancestor levels above the current path.
        /// </summary>
        public int ParentCount
        {
            get
            {
                return values.Count == 0 ? 0 : values.Count - 1;
            }
        }

        /// <summary>
        /// Gets the value at the specified index of the typology path.
        /// </summary>
        /// <param name="index">The zero-based index of the element to get.</param>
        /// <returns>The integer value at the specified position.</returns>
        public int this[int index]
        {
            get
            {
                return values[index];
            }
        }

        /// <summary>
        /// Explicitly converts a <see cref="TypologyPath"/> to a list of integers.
        /// </summary>
        /// <param name="typologyPath">The typology path to convert.</param>
        /// <returns>A new list containing the values of the path, or null if the input is null.</returns>
        public static explicit operator List<int>?(TypologyPath? typologyPath)
        {
            if (typologyPath is null)
            {
                return null;
            }

            return [.. typologyPath.values];
        }

        /// <summary>
        /// Explicitly converts a list of integers to a <see cref="TypologyPath"/>.
        /// </summary>
        /// <param name="values">The list of integers representing the path.</param>
        /// <returns>A new <see cref="TypologyPath"/> instance, or null if the input is null.</returns>
        public static explicit operator TypologyPath?(List<int>? values)
        {
            if (values == null)
            {
                return null;
            }

            return new TypologyPath(values);
        }

        /// <summary>
        /// Concatenates two typology paths into a single path.
        /// </summary>
        /// <param name="typologyPath_1">The first path segment.</param>
        /// <param name="typologyPath_2">The second path segment to append.</param>
        /// <returns>A new <see cref="TypologyPath"/> representing the combined sequence, or null if both inputs are null.</returns>
        public static TypologyPath? operator +(TypologyPath? typologyPath_1, TypologyPath? typologyPath_2)
        {
            if (typologyPath_1 is null && typologyPath_2 is null)
            {
                return null;
            }

            if (typologyPath_1?.values is not List<int> values_1)
            {
                return new TypologyPath(typologyPath_2);
            }

            if (typologyPath_2?.values is not List<int> values_2)
            {
                return new TypologyPath(typologyPath_1);
            }

            values_1 = [.. values_1];

            values_1.AddRange(values_2);

            return new TypologyPath(values_1);
        }

        /// <summary>
        /// Compares the current path with another typology path.
        /// </summary>
        /// <param name="typologyPath">The path to compare against.</param>
        /// <returns>A value indicating whether this instance precedes, follows, or is equal to the specified path.</returns>
        public int CompareTo(TypologyPath typologyPath)
        {
            if (typologyPath == null)
            {
                return 1; // non-null > null
            }

            int count = values.Count;
            int count_Temp = typologyPath.values.Count;

            int minLength = Math.Min(count, count_Temp);

            for (int i = 0; i < minLength; i++)
            {
                int cmp = values[i].CompareTo(typologyPath.values[i]);
                if (cmp != 0)
                    return cmp;
            }

            // If all elements equal, shorter array comes first
            return count.CompareTo(count_Temp);
        }

        /// <summary>
        /// Determines whether the specified object is equal to the current typology path based on sequence equality.
        /// </summary>
        /// <param name="obj">The object to compare with the current instance.</param>
        /// <returns>True if the objects are equal; otherwise, false.</returns>
        public override bool Equals(object obj)
        {
            if (obj is not TypologyPath typologyPath)
            {
                return false;
            }

            return values.SequenceEqual(typologyPath.values);
        }

        /// <summary>
        /// Returns an enumerator that iterates through the integer values of the path.
        /// </summary>
        /// <returns>An enumerator for the sequence of integers.</returns>
        public IEnumerator<int> GetEnumerator()
        {
            return values?.GetEnumerator() ?? Enumerable.Empty<int>().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        /// <summary>
        /// Returns a hash code for the current typology path based on its sequence of values.
        /// </summary>
        /// <returns>A 32-bit signed integer hash code.</returns>
        public override int GetHashCode()
        {
            unchecked // allow arithmetic overflow
            {
                int hash = 17;
                foreach (int value in values)
                {
                    hash = hash * 31 + value.GetHashCode();
                }

                return hash;
            }
        }

        /// <summary>
        /// Retrieves a path representing the hierarchy up to and including the specified index.
        /// </summary>
        /// <param name="index">The end index of the parent path.</param>
        /// <returns>A new <see cref="TypologyPath"/> instance, or null if the index is out of range.</returns>
        public TypologyPath? GetParent(int index)
        {
            int parentCount = ParentCount;
            if (index > parentCount - 1)
            {
                return null;
            }

            return new TypologyPath(values.GetRange(0, index + 1));
        }

        /// <summary>
        /// Extracts a specific segment of the typology path.
        /// </summary>
        /// <param name="index">The starting zero-based index of the segment.</param>
        /// <param name="count">The number of elements to include in the segment.</param>
        /// <returns>A new <see cref="TypologyPath"/> containing the extracted range.</returns>
        public TypologyPath? GetTypologyPath(int index, int count)
        {
            return new TypologyPath(values.GetRange(index, count));
        }

        /// <summary>
        /// Generates a list of all ancestor paths for the current typology path.
        /// </summary>
        /// <returns>A list containing all parent <see cref="TypologyPath"/> instances.</returns>
        public List<TypologyPath> GetTypologyPaths()
        {
            List<TypologyPath> result = [];
            for (int i = 0; i < ParentCount; i++)
            {
                if (GetParent(i) is not TypologyPath typologyPath)
                {
                    continue;
                }

                result.Add(typologyPath);
            }

            return result;
        }

        /// <summary>
        /// Returns a string representation of the path, with values separated by dots.
        /// </summary>
        /// <returns>A dot-separated string of the typology path values.</returns>
        public override string ToString()
        {
            return string.Join(".", values);
        }
    }
}