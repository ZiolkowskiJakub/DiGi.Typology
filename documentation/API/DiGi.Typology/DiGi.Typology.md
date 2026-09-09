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

Updates an existing direct child of the receiving typology whose name matches, or creates a new one when no match exists\.

Matching is limited to the direct children of [in](DiGi.Typology.md#DiGi.Typology.Modify.TryUpdateByName(thisDiGi.Typology.Classes.Typology,System.Collections.Generic.IEnumerable_int_,string,string,DiGi.Typology.Classes.Typology).in 'DiGi\.Typology\.Modify\.TryUpdateByName\(this DiGi\.Typology\.Classes\.Typology, System\.Collections\.Generic\.IEnumerable\<int\>, string, string, DiGi\.Typology\.Classes\.Typology\)\.in'); their sub-trees are not searched. When a match is found, only [description](DiGi.Typology.md#DiGi.Typology.Modify.TryUpdateByName(thisDiGi.Typology.Classes.Typology,System.Collections.Generic.IEnumerable_int_,string,string,DiGi.Typology.Classes.Typology).description 'DiGi\.Typology\.Modify\.TryUpdateByName\(this DiGi\.Typology\.Classes\.Typology, System\.Collections\.Generic\.IEnumerable\<int\>, string, string, DiGi\.Typology\.Classes\.Typology\)\.description') is applied to the matched child; [values](DiGi.Typology.md#DiGi.Typology.Modify.TryUpdateByName(thisDiGi.Typology.Classes.Typology,System.Collections.Generic.IEnumerable_int_,string,string,DiGi.Typology.Classes.Typology).values 'DiGi\.Typology\.Modify\.TryUpdateByName\(this DiGi\.Typology\.Classes\.Typology, System\.Collections\.Generic\.IEnumerable\<int\>, string, string, DiGi\.Typology\.Classes\.Typology\)\.values') and [name](DiGi.Typology.md#DiGi.Typology.Modify.TryUpdateByName(thisDiGi.Typology.Classes.Typology,System.Collections.Generic.IEnumerable_int_,string,string,DiGi.Typology.Classes.Typology).name 'DiGi\.Typology\.Modify\.TryUpdateByName\(this DiGi\.Typology\.Classes\.Typology, System\.Collections\.Generic\.IEnumerable\<int\>, string, string, DiGi\.Typology\.Classes\.Typology\)\.name') are ignored, and if several children share the name, the first one is used. When no match exists, a new child is created from [values](DiGi.Typology.md#DiGi.Typology.Modify.TryUpdateByName(thisDiGi.Typology.Classes.Typology,System.Collections.Generic.IEnumerable_int_,string,string,DiGi.Typology.Classes.Typology).values 'DiGi\.Typology\.Modify\.TryUpdateByName\(this DiGi\.Typology\.Classes\.Typology, System\.Collections\.Generic\.IEnumerable\<int\>, string, string, DiGi\.Typology\.Classes\.Typology\)\.values'), [name](DiGi.Typology.md#DiGi.Typology.Modify.TryUpdateByName(thisDiGi.Typology.Classes.Typology,System.Collections.Generic.IEnumerable_int_,string,string,DiGi.Typology.Classes.Typology).name 'DiGi\.Typology\.Modify\.TryUpdateByName\(this DiGi\.Typology\.Classes\.Typology, System\.Collections\.Generic\.IEnumerable\<int\>, string, string, DiGi\.Typology\.Classes\.Typology\)\.name') and [description](DiGi.Typology.md#DiGi.Typology.Modify.TryUpdateByName(thisDiGi.Typology.Classes.Typology,System.Collections.Generic.IEnumerable_int_,string,string,DiGi.Typology.Classes.Typology).description 'DiGi\.Typology\.Modify\.TryUpdateByName\(this DiGi\.Typology\.Classes\.Typology, System\.Collections\.Generic\.IEnumerable\<int\>, string, string, DiGi\.Typology\.Classes\.Typology\)\.description').

```csharp
public static bool TryUpdateByName(this DiGi.Typology.Classes.Typology? @in, System.Collections.Generic.IEnumerable<int>? values, string? name, string? description, out DiGi.Typology.Classes.Typology? @out);
```
#### Parameters

<a name='DiGi.Typology.Modify.TryUpdateByName(thisDiGi.Typology.Classes.Typology,System.Collections.Generic.IEnumerable_int_,string,string,DiGi.Typology.Classes.Typology).in'></a>

`in` [Typology](DiGi.Typology.Classes.md#DiGi.Typology.Classes.Typology 'DiGi\.Typology\.Classes\.Typology')

The parent typology whose direct children are searched\.

<a name='DiGi.Typology.Modify.TryUpdateByName(thisDiGi.Typology.Classes.Typology,System.Collections.Generic.IEnumerable_int_,string,string,DiGi.Typology.Classes.Typology).values'></a>

`values` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

Integer values used to create the new child when no match is found; ignored when a match exists\.

<a name='DiGi.Typology.Modify.TryUpdateByName(thisDiGi.Typology.Classes.Typology,System.Collections.Generic.IEnumerable_int_,string,string,DiGi.Typology.Classes.Typology).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name matched against the direct children of [in](DiGi.Typology.md#DiGi.Typology.Modify.TryUpdateByName(thisDiGi.Typology.Classes.Typology,System.Collections.Generic.IEnumerable_int_,string,string,DiGi.Typology.Classes.Typology).in 'DiGi\.Typology\.Modify\.TryUpdateByName\(this DiGi\.Typology\.Classes\.Typology, System\.Collections\.Generic\.IEnumerable\<int\>, string, string, DiGi\.Typology\.Classes\.Typology\)\.in'); also the name assigned to a new child\.

<a name='DiGi.Typology.Modify.TryUpdateByName(thisDiGi.Typology.Classes.Typology,System.Collections.Generic.IEnumerable_int_,string,string,DiGi.Typology.Classes.Typology).description'></a>

`description` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The description applied to the matched child, or assigned to a new child\.

<a name='DiGi.Typology.Modify.TryUpdateByName(thisDiGi.Typology.Classes.Typology,System.Collections.Generic.IEnumerable_int_,string,string,DiGi.Typology.Classes.Typology).out'></a>

`out` [Typology](DiGi.Typology.Classes.md#DiGi.Typology.Classes.Typology 'DiGi\.Typology\.Classes\.Typology')

When this method returns, contains the updated or newly created child typology if successful; otherwise, null\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if a direct child was updated or created; otherwise, false\.

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