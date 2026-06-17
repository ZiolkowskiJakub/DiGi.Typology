using System.Collections.Generic;

namespace DiGi.Typology
{
    public static partial class Modify
    {
        /// <summary>
        /// Attempts to update a typology by its name or create a new one if it does not exist.
        /// </summary>
        /// <param name="in">The source typology instance.</param>
        /// <param name="values">A collection of integer values associated with the typology.</param>
        /// <param name="name">The unique name used to identify or create the typology.</param>
        /// <param name="description">The description to be assigned to the typology.</param>
        /// <param name="out">When this method returns, contains the updated or newly created typology instance if successful; otherwise, null.</param>
        /// <returns>True if the typology was successfully updated or created; otherwise, false.</returns>
        public static bool TryUpdateByName(this Classes.Typology? @in, IEnumerable<int>? values, string? name, string? description, out Classes.Typology? @out)
        {
            @out = null;

            if (name is null || @in is null)
            {
                return false;
            }

            if (!@in.TryGetTypologies(name, out List<Classes.Typology>? typologies) || typologies == null || typologies.Count == 0)
            {
                @out = @in.Update(values, name, description);
            }
            else
            {
                @out = typologies[0];
                @out.Description = description;
            }

            if (@out is null)
            {
                return false;
            }

            return true;
        }
    }
}