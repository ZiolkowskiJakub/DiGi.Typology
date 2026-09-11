#### [DiGi\.Typology\.Visual](DiGi.Typology.Visual.Overview.md 'DiGi\.Typology\.Visual\.Overview')

## DiGi\.Typology\.Visual Namespace
### Classes

<a name='DiGi.Typology.Visual.Query'></a>

## Query Class

Static partial class containing query extension methods for typology entities\.

```csharp
public static class Query
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Query
### Methods

<a name='DiGi.Typology.Visual.Query.Key(thisobject)'></a>

## Query\.Key\(this object\) Method

Renders a value as the key its appearance is filed under\.

The form is culture-invariant and agrees with [System\.Object\.Equals\(System\.Object\)](https://learn.microsoft.com/en-us/dotnet/api/system.object.equals#system-object-equals(system-object) 'System\.Object\.Equals\(System\.Object\)'): two values get the
            same key exactly when a [DiGi\.Typology\.Classes\.UniqueValueRuleData](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.classes.uniquevalueruledata 'DiGi\.Typology\.Classes\.UniqueValueRuleData') would bucket them together. `null` renders as
            `"null"`; a [DiGi\.Typology\.Classes\.UniqueValueRuleData](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.classes.uniquevalueruledata 'DiGi\.Typology\.Classes\.UniqueValueRuleData') or a [VisualUniqueValueRuleData](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualUniqueValueRuleData 'DiGi\.Typology\.Visual\.Classes\.VisualUniqueValueRuleData') as the key of
            its value; a string as itself; a [System\.Decimal](https://learn.microsoft.com/en-us/dotnet/api/system.decimal 'System\.Decimal') with its scale stripped (`1.10m` and `1.1m`
            are equal); a [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') or [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single') as its shortest round-trip form with negative zero
            folded to zero; a [System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime') to the tick with its kind ignored, as its equality ignores it; a
            [System\.DateTimeOffset](https://learn.microsoft.com/en-us/dotnet/api/system.datetimeoffset 'System\.DateTimeOffset') as the UTC instant its equality compares; any other [System\.IFormattable](https://learn.microsoft.com/en-us/dotnet/api/system.iformattable 'System\.IFormattable') -
            integers of any width, [System\.TimeSpan](https://learn.microsoft.com/en-us/dotnet/api/system.timespan 'System\.TimeSpan'), [System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid'), enums - in the invariant culture; and
            anything else through [System\.Object\.ToString](https://learn.microsoft.com/en-us/dotnet/api/system.object.tostring 'System\.Object\.ToString'). A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') renders as `True` or
            `False` whichever branch its runtime takes. For the categorical types a unique value rule is meant for,
            the key equals [DiGi\.Typology\.Classes\.UniqueValueRuleData\.ToString](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.classes.uniquevalueruledata.tostring 'DiGi\.Typology\.Classes\.UniqueValueRuleData\.ToString').

A range bucket is keyed by its bounds: a [DiGi\.Core\.Classes\.Range&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1') (any closed type, derived types such as
            [DiGi\.Core\.Classes\.DateTimeRange](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.datetimerange 'DiGi\.Core\.Classes\.DateTimeRange') included) renders as `[min, max]` with each bound rendered by this method, so
            the key is invariant where [DiGi\.Core\.Classes\.Range&lt;&gt;\.ToString](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1.tostring 'DiGi\.Core\.Classes\.Range\`1\.ToString') is not; a [DiGi\.Typology\.Classes\.RangeValueRuleData&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.classes.rangevalueruledata-1 'DiGi\.Typology\.Classes\.RangeValueRuleData\`1')
            or a [VisualRangeValueRuleData&lt;TValueType&gt;](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualRangeValueRuleData_TValueType_ 'DiGi\.Typology\.Visual\.Classes\.VisualRangeValueRuleData\<TValueType\>') renders as the key of its range. The range, the rule
            data and the Visual rule data of one bucket therefore share a key.

```csharp
public static string Key(this object? @object);
```
#### Parameters

<a name='DiGi.Typology.Visual.Query.Key(thisobject).object'></a>

`object` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The value, or the rule data produced for it\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
The key\.