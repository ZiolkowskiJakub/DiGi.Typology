#### [DiGi\.Typology](DiGi.Typology.Overview.md 'DiGi\.Typology\.Overview')

## DiGi\.Typology Namespace
### Classes

<a name='DiGi.Typology.Modify'></a>

## Modify Class

```csharp
public static class Modify
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Modify
### Methods

<a name='DiGi.Typology.Modify.TryUpdateByName(thisDiGi.Typology.Classes.Typology,System.Collections.Generic.IEnumerable_int_,string,string,DiGi.Typology.Classes.Typology)'></a>

## Modify\.TryUpdateByName\(this Typology, IEnumerable\<int\>, string, string, Typology\) Method

Attempts to update a typology by its name or create a new one if it does not exist\.

```csharp
public static bool TryUpdateByName(this DiGi.Typology.Classes.Typology? @in, System.Collections.Generic.IEnumerable<int>? values, string? name, string? description, out DiGi.Typology.Classes.Typology? @out);
```
#### Parameters

<a name='DiGi.Typology.Modify.TryUpdateByName(thisDiGi.Typology.Classes.Typology,System.Collections.Generic.IEnumerable_int_,string,string,DiGi.Typology.Classes.Typology).in'></a>

`in` [Typology](DiGi.Typology.Classes.md#DiGi.Typology.Classes.Typology 'DiGi\.Typology\.Classes\.Typology')

The source typology instance\.

<a name='DiGi.Typology.Modify.TryUpdateByName(thisDiGi.Typology.Classes.Typology,System.Collections.Generic.IEnumerable_int_,string,string,DiGi.Typology.Classes.Typology).values'></a>

`values` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

A collection of integer values associated with the typology\.

<a name='DiGi.Typology.Modify.TryUpdateByName(thisDiGi.Typology.Classes.Typology,System.Collections.Generic.IEnumerable_int_,string,string,DiGi.Typology.Classes.Typology).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The unique name used to identify or create the typology\.

<a name='DiGi.Typology.Modify.TryUpdateByName(thisDiGi.Typology.Classes.Typology,System.Collections.Generic.IEnumerable_int_,string,string,DiGi.Typology.Classes.Typology).description'></a>

`description` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The description to be assigned to the typology\.

<a name='DiGi.Typology.Modify.TryUpdateByName(thisDiGi.Typology.Classes.Typology,System.Collections.Generic.IEnumerable_int_,string,string,DiGi.Typology.Classes.Typology).out'></a>

`out` [Typology](DiGi.Typology.Classes.md#DiGi.Typology.Classes.Typology 'DiGi\.Typology\.Classes\.Typology')

When this method returns, contains the updated or newly created typology instance if successful; otherwise, null\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the typology was successfully updated or created; otherwise, false\.

<a name='DiGi.Typology.Query'></a>

## Query Class

Static partial class containing query extension methods for typology entities\.

```csharp
public static class Query
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Query
### Methods

<a name='DiGi.Typology.Query.RuleData(thisDiGi.Typology.Interfaces.ITypologyFilterRule,object)'></a>

## Query\.RuleData\(this ITypologyFilterRule, object\) Method

Retrieves the typology filter rule data from a typology filter rule by invoking its generic method using reflection\.

```csharp
public static DiGi.Typology.Interfaces.ITypologyFilterRuleData? RuleData(this DiGi.Typology.Interfaces.ITypologyFilterRule? typologyFilterRule, object? @object);
```
#### Parameters

<a name='DiGi.Typology.Query.RuleData(thisDiGi.Typology.Interfaces.ITypologyFilterRule,object).typologyFilterRule'></a>

`typologyFilterRule` [ITypologyFilterRule](DiGi.Typology.Interfaces.md#DiGi.Typology.Interfaces.ITypologyFilterRule 'DiGi\.Typology\.Interfaces\.ITypologyFilterRule')

The typology filter rule to evaluate\.

<a name='DiGi.Typology.Query.RuleData(thisDiGi.Typology.Interfaces.ITypologyFilterRule,object).object'></a>

`object` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The value to evaluate against the rule\.

#### Returns
[ITypologyFilterRuleData](DiGi.Typology.Interfaces.md#DiGi.Typology.Interfaces.ITypologyFilterRuleData 'DiGi\.Typology\.Interfaces\.ITypologyFilterRuleData')  
The resolved typology filter rule data, or null if the rule is null or invalid\.