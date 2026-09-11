using DiGi.Core.Classes;
using DiGi.Typology.Classes;
using DiGi.Typology.Visual.Classes;
using System;
using System.Globalization;
using System.Reflection;

namespace DiGi.Typology.Visual
{
    /// <summary>
    /// Static partial class containing query extension methods for typology entities.
    /// </summary>
    public static partial class Query
    {
        /// <summary>
        /// Renders a value as the key its appearance is filed under.
        /// <para>The form is culture-invariant and agrees with <see cref="object.Equals(object)"/>: two values get the
        /// same key exactly when a <see cref="UniqueValueRuleData"/> would bucket them together. <c>null</c> renders as
        /// <c>"null"</c>; a <see cref="UniqueValueRuleData"/> or a <see cref="VisualUniqueValueRuleData"/> as the key of
        /// its value; a string as itself; a <see cref="decimal"/> with its scale stripped (<c>1.10m</c> and <c>1.1m</c>
        /// are equal); a <see cref="double"/> or <see cref="float"/> as its shortest round-trip form with negative zero
        /// folded to zero; a <see cref="DateTime"/> to the tick with its kind ignored, as its equality ignores it; a
        /// <see cref="DateTimeOffset"/> as the UTC instant its equality compares; any other <see cref="IFormattable"/> -
        /// integers of any width, <see cref="TimeSpan"/>, <see cref="Guid"/>, enums - in the invariant culture; and
        /// anything else through <see cref="object.ToString()"/>. A <see cref="bool"/> renders as <c>True</c> or
        /// <c>False</c> whichever branch its runtime takes. For the categorical types a unique value rule is meant for,
        /// the key equals <see cref="UniqueValueRuleData.ToString()"/>.</para>
        /// <para>A range bucket is keyed by its bounds: a <see cref="Range{T}"/> (any closed type, derived types such as
        /// <see cref="DateTimeRange"/> included) renders as <c>[min, max]</c> with each bound rendered by this method, so
        /// the key is invariant where <see cref="Range{T}.ToString()"/> is not; a <see cref="RangeValueRuleData{TValueType}"/>
        /// or a <see cref="VisualRangeValueRuleData{TValueType}"/> renders as the key of its range. The range, the rule
        /// data and the Visual rule data of one bucket therefore share a key.</para>
        /// </summary>
        /// <param name="object">The value, or the rule data produced for it.</param>
        /// <returns>The key.</returns>
        public static string Key(this object? @object)
        {
            // Reads the property of the given name off the closed generic type the object derives from, or returns
            // false when the object is not an instance of that open generic definition.
            static bool TryGetValue(object @object, Type type_GenericDefinition, string name, out object? value)
            {
                value = null;

                Type? type = @object.GetType();
                while (type is not null)
                {
                    if (type.IsGenericType && type.GetGenericTypeDefinition() == type_GenericDefinition)
                    {
                        value = type.GetProperty(name, BindingFlags.Public | BindingFlags.Instance)?.GetValue(@object);
                        return true;
                    }

                    type = type.BaseType;
                }

                return false;
            }

            switch (@object)
            {
                case null:
                    return Core.Constants.UniqueId.Null;

                case UniqueValueRuleData uniqueValueRuleData:
                    return Key(uniqueValueRuleData.Value);

                case VisualUniqueValueRuleData visualUniqueValueRuleData:
                    return Key(visualUniqueValueRuleData.Value);

                case string @string:
                    return @string;

                case decimal @decimal:
                    return @decimal.ToString("G29", CultureInfo.InvariantCulture);

                case double @double:
                    return (@double == 0 ? 0d : @double).ToString("R", CultureInfo.InvariantCulture);

                case float @float:
                    return (@float == 0 ? 0f : @float).ToString("R", CultureInfo.InvariantCulture);

                case DateTime dateTime:
                    return dateTime.ToString(Constants.Format.DateTime, CultureInfo.InvariantCulture);

                case DateTimeOffset dateTimeOffset:
                    return dateTimeOffset.UtcDateTime.ToString(Constants.Format.DateTime, CultureInfo.InvariantCulture) + "Z";

                case IFormattable formattable:
                    return formattable.ToString(null, CultureInfo.InvariantCulture);
            }

            if (TryGetValue(@object, typeof(RangeValueRuleData<>), nameof(RangeValueRuleData<int>.Range), out object? range) || TryGetValue(@object, typeof(VisualRangeValueRuleData<>), nameof(VisualRangeValueRuleData<int>.Range), out range))
            {
                return Key(range);
            }

            if (TryGetValue(@object, typeof(Range<>), nameof(Range<int>.Min), out object? min) && TryGetValue(@object, typeof(Range<>), nameof(Range<int>.Max), out object? max))
            {
                return $"[{Key(min)}, {Key(max)}]";
            }

            return @object.ToString() ?? Core.Constants.UniqueId.Null;
        }
    }
}
