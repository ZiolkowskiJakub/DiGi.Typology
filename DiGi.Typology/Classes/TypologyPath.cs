using DiGi.Core.Classes;
using DiGi.Core.Enums;
using DiGi.Core.Interfaces;
using DiGi.Typology.Interfaces;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Typology.Classes
{
    public class TypologyPath : Core.Classes.SerializableObject, ITypologyObject, IEnumerable<int>
    {
        [JsonInclude, JsonPropertyName("Values")]
        private readonly List<int> values = [];

        public TypologyPath(IEnumerable<int>? values)
        {
            if(values != null)
            {
                this.values = [.. values];
            }
        }

        public TypologyPath(TypologyPath? typologyPath)
        {
            if (typologyPath != null)
            {
                values = typologyPath.values != null ? [.. typologyPath.values] : [];
            }
        }

        public TypologyPath(JsonObject? jsonObject)
            : base(jsonObject)
        {

        }

        public int Count
        {
            get
            {
                return values.Count;
            }
        }

        public int Index
        {
            get
            {
                return values.Count == 0 ? -1 : values.Last();
            }

        }

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

        public int ParentCount
        {
            get
            {
                return values.Count == 0 ? 0 : values.Count - 1;
            }
        }

        public int this[int index]
        {
            get
            {
                return values[index];
            }
        }

        
        public static explicit operator List<int>?(TypologyPath? typologyPath)
        {
            if (typologyPath is null)
            {
                return null;
            }

            return [.. typologyPath.values];
        }

        
        public static explicit operator TypologyPath?(List<int>? values)
        {
            if (values == null)
            {
                return null;
            }

            return new TypologyPath(values);
        }

        public override bool Equals(object obj)
        {
            if (obj is not TypologyPath typologyPath)
            {
                return false;
            }

            return values.SequenceEqual(typologyPath.values);
        }

        public IEnumerator<int> GetEnumerator()
        {
            return values?.GetEnumerator() ?? Enumerable.Empty<int>().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

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

        public TypologyPath? GetParent(int index)
        {
            int parentCount = ParentCount;
            if (index > parentCount - 1)
            {
                return null;
            }

            return new TypologyPath(values.GetRange(0, index + 1));
        }

        public TypologyPath? GetTypologyPath(int index, int count)
        {
            return new TypologyPath(values.GetRange(index, count));
        }

        public override string ToString()
        {
            return string.Join(".", values);
        }

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
    }
}
