using System.Collections.Generic;
using System.Linq;

namespace DiGi.Typology
{
    public static partial class Query
    {
        /// <summary>Attempts to retrieve the highest index a sub-typology of the given typology is filed under.</summary>
        /// <param name="typology">The typology whose filing indexes are inspected.</param>
        /// <param name="index">When this method returns, contains the highest index if successful; otherwise, -1.</param>
        /// <returns>True if the typology carries at least one sub-typology; otherwise, false.</returns>
        public static bool TryGetLastIndex(this Classes.Typology? typology, out int index)
        {
            index = -1;

            if (typology?.Indexes is not List<int> indexes || indexes.Count == 0)
            {
                return false;
            }

            index = indexes.Max();
            return true;
        }
    }
}
