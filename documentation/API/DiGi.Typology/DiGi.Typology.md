#### [DiGi\.Typology](DiGi.Typology.Overview.md 'DiGi\.Typology\.Overview')

## DiGi\.Typology Namespace
### Classes

<a name='DiGi.Typology.Create'></a>

## Create Class

```csharp
public static class Create
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Create
### Methods

<a name='DiGi.Typology.Create.Typology(thisDiGi.Typology.Classes.TypologyItem,System.Collections.Generic.IEnumerable_DiGi.Typology.Classes.Typology_)'></a>

## Create\.Typology\(this TypologyItem, IEnumerable\<Typology\>\) Method

Creates a typology carrying the given item and the given sub\-typologies\.

The sub-typologies are filed by [AddSubTypologies&lt;TTypology,TTypologyItem&gt;\(this Typology&lt;TTypology,TTypologyItem&gt;, IEnumerable&lt;TTypology&gt;\)](DiGi.Typology.md#DiGi.Typology.Modify.AddSubTypologies_TTypology,TTypologyItem_(thisDiGi.Typology.Classes.Typology_TTypology,TTypologyItem_,System.Collections.Generic.IEnumerable_TTypology_) 'DiGi\.Typology\.Modify\.AddSubTypologies\<TTypology,TTypologyItem\>\(this DiGi\.Typology\.Classes\.Typology\<TTypology,TTypologyItem\>, System\.Collections\.Generic\.IEnumerable\<TTypology\>\)'):
            each is cloned and filed under the last index of its own path, or under the next free index
            when it carries no path or its index is already taken. Resolving those indexes is why this is
            a factory rather than a constructor.

```csharp
public static DiGi.Typology.Classes.Typology? Typology(this DiGi.Typology.Classes.TypologyItem? typologyItem, System.Collections.Generic.IEnumerable<DiGi.Typology.Classes.Typology>? subTypologies);
```
#### Parameters

<a name='DiGi.Typology.Create.Typology(thisDiGi.Typology.Classes.TypologyItem,System.Collections.Generic.IEnumerable_DiGi.Typology.Classes.Typology_).typologyItem'></a>

`typologyItem` [TypologyItem](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyItem 'DiGi\.Typology\.Classes\.TypologyItem')

The typology item to assign\.

<a name='DiGi.Typology.Create.Typology(thisDiGi.Typology.Classes.TypologyItem,System.Collections.Generic.IEnumerable_DiGi.Typology.Classes.Typology_).subTypologies'></a>

`subTypologies` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Typology](DiGi.Typology.Classes.md#DiGi.Typology.Classes.Typology 'DiGi\.Typology\.Classes\.Typology')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

A collection of sub\-typologies to associate with the new instance\.

#### Returns
[Typology](DiGi.Typology.Classes.md#DiGi.Typology.Classes.Typology 'DiGi\.Typology\.Classes\.Typology')  
The created typology, or null when both arguments are null\.

<a name='DiGi.Typology.Modify'></a>

## Modify Class

```csharp
public static class Modify
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Modify
### Methods

<a name='DiGi.Typology.Modify.AddSubTypologies_TTypology,TTypologyItem_(thisDiGi.Typology.Classes.Typology_TTypology,TTypologyItem_,System.Collections.Generic.IEnumerable_TTypology_)'></a>

## Modify\.AddSubTypologies\<TTypology,TTypologyItem\>\(this Typology\<TTypology,TTypologyItem\>, IEnumerable\<TTypology\>\) Method

Files the given sub\-typologies under the given typology\.

Each sub-typology is cloned and then filed under the last index of its own path. One
            carrying no path, or one whose index is already taken, is filed under the next free index
            rather than being discarded, so the assigned key may differ from the path the sub-typology
            reports. Sub-typologies already filed are kept; the next free index is resolved against them.

```csharp
public static int AddSubTypologies<TTypology,TTypologyItem>(this DiGi.Typology.Classes.Typology<TTypology,TTypologyItem>? typology, System.Collections.Generic.IEnumerable<TTypology?>? subTypologies)
    where TTypology : DiGi.Typology.Classes.Typology<TTypology, TTypologyItem>
    where TTypologyItem : DiGi.Typology.Classes.TypologyItem, new();
```
#### Type parameters

<a name='DiGi.Typology.Modify.AddSubTypologies_TTypology,TTypologyItem_(thisDiGi.Typology.Classes.Typology_TTypology,TTypologyItem_,System.Collections.Generic.IEnumerable_TTypology_).TTypology'></a>

`TTypology`

The concrete typology type\.

<a name='DiGi.Typology.Modify.AddSubTypologies_TTypology,TTypologyItem_(thisDiGi.Typology.Classes.Typology_TTypology,TTypologyItem_,System.Collections.Generic.IEnumerable_TTypology_).TTypologyItem'></a>

`TTypologyItem`

The typology item type\.
#### Parameters

<a name='DiGi.Typology.Modify.AddSubTypologies_TTypology,TTypologyItem_(thisDiGi.Typology.Classes.Typology_TTypology,TTypologyItem_,System.Collections.Generic.IEnumerable_TTypology_).typology'></a>

`typology` [DiGi\.Typology\.Classes\.Typology&lt;](DiGi.Typology.Classes.md#DiGi.Typology.Classes.Typology_TTypology,TTypologyItem_ 'DiGi\.Typology\.Classes\.Typology\<TTypology,TTypologyItem\>')[TTypology](DiGi.Typology.md#DiGi.Typology.Modify.AddSubTypologies_TTypology,TTypologyItem_(thisDiGi.Typology.Classes.Typology_TTypology,TTypologyItem_,System.Collections.Generic.IEnumerable_TTypology_).TTypology 'DiGi\.Typology\.Modify\.AddSubTypologies\<TTypology,TTypologyItem\>\(this DiGi\.Typology\.Classes\.Typology\<TTypology,TTypologyItem\>, System\.Collections\.Generic\.IEnumerable\<TTypology\>\)\.TTypology')[,](DiGi.Typology.Classes.md#DiGi.Typology.Classes.Typology_TTypology,TTypologyItem_ 'DiGi\.Typology\.Classes\.Typology\<TTypology,TTypologyItem\>')[TTypologyItem](DiGi.Typology.md#DiGi.Typology.Modify.AddSubTypologies_TTypology,TTypologyItem_(thisDiGi.Typology.Classes.Typology_TTypology,TTypologyItem_,System.Collections.Generic.IEnumerable_TTypology_).TTypologyItem 'DiGi\.Typology\.Modify\.AddSubTypologies\<TTypology,TTypologyItem\>\(this DiGi\.Typology\.Classes\.Typology\<TTypology,TTypologyItem\>, System\.Collections\.Generic\.IEnumerable\<TTypology\>\)\.TTypologyItem')[&gt;](DiGi.Typology.Classes.md#DiGi.Typology.Classes.Typology_TTypology,TTypologyItem_ 'DiGi\.Typology\.Classes\.Typology\<TTypology,TTypologyItem\>')

The typology to file the sub\-typologies under\.

<a name='DiGi.Typology.Modify.AddSubTypologies_TTypology,TTypologyItem_(thisDiGi.Typology.Classes.Typology_TTypology,TTypologyItem_,System.Collections.Generic.IEnumerable_TTypology_).subTypologies'></a>

`subTypologies` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[TTypology](DiGi.Typology.md#DiGi.Typology.Modify.AddSubTypologies_TTypology,TTypologyItem_(thisDiGi.Typology.Classes.Typology_TTypology,TTypologyItem_,System.Collections.Generic.IEnumerable_TTypology_).TTypology 'DiGi\.Typology\.Modify\.AddSubTypologies\<TTypology,TTypologyItem\>\(this DiGi\.Typology\.Classes\.Typology\<TTypology,TTypologyItem\>, System\.Collections\.Generic\.IEnumerable\<TTypology\>\)\.TTypology')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The sub\-typologies to file; null entries are skipped\.

#### Returns
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')  
The number of sub\-typologies filed; 0 when either argument is null\.

<a name='DiGi.Typology.Modify.RemoveReferences_TTypology,TTypologyItem_(thisDiGi.Typology.Classes.Typology_TTypology,TTypologyItem_,bool)'></a>

## Modify\.RemoveReferences\<TTypology,TTypologyItem\>\(this Typology\<TTypology,TTypologyItem\>, bool\) Method

Removes every reference held by the given typology, optionally descending into its nested typologies\.

Structure and node metadata are left untouched, so what remains is the metadata-only form of the same tree. Use it to strip a solved tree whose node to object association is held elsewhere, rather than re-solving one.

Applied to a sub-typology this strips that branch alone, because Query.SubTypology returns the instance the tree holds rather than a clone of it.

```csharp
public static bool RemoveReferences<TTypology,TTypologyItem>(this DiGi.Typology.Classes.Typology<TTypology,TTypologyItem>? typology, bool includeNested=true)
    where TTypology : DiGi.Typology.Classes.Typology<TTypology, TTypologyItem>
    where TTypologyItem : DiGi.Typology.Classes.TypologyItem, new();
```
#### Type parameters

<a name='DiGi.Typology.Modify.RemoveReferences_TTypology,TTypologyItem_(thisDiGi.Typology.Classes.Typology_TTypology,TTypologyItem_,bool).TTypology'></a>

`TTypology`

The concrete typology type\.

<a name='DiGi.Typology.Modify.RemoveReferences_TTypology,TTypologyItem_(thisDiGi.Typology.Classes.Typology_TTypology,TTypologyItem_,bool).TTypologyItem'></a>

`TTypologyItem`

The typology item type\.
#### Parameters

<a name='DiGi.Typology.Modify.RemoveReferences_TTypology,TTypologyItem_(thisDiGi.Typology.Classes.Typology_TTypology,TTypologyItem_,bool).typology'></a>

`typology` [DiGi\.Typology\.Classes\.Typology&lt;](DiGi.Typology.Classes.md#DiGi.Typology.Classes.Typology_TTypology,TTypologyItem_ 'DiGi\.Typology\.Classes\.Typology\<TTypology,TTypologyItem\>')[TTypology](DiGi.Typology.md#DiGi.Typology.Modify.RemoveReferences_TTypology,TTypologyItem_(thisDiGi.Typology.Classes.Typology_TTypology,TTypologyItem_,bool).TTypology 'DiGi\.Typology\.Modify\.RemoveReferences\<TTypology,TTypologyItem\>\(this DiGi\.Typology\.Classes\.Typology\<TTypology,TTypologyItem\>, bool\)\.TTypology')[,](DiGi.Typology.Classes.md#DiGi.Typology.Classes.Typology_TTypology,TTypologyItem_ 'DiGi\.Typology\.Classes\.Typology\<TTypology,TTypologyItem\>')[TTypologyItem](DiGi.Typology.md#DiGi.Typology.Modify.RemoveReferences_TTypology,TTypologyItem_(thisDiGi.Typology.Classes.Typology_TTypology,TTypologyItem_,bool).TTypologyItem 'DiGi\.Typology\.Modify\.RemoveReferences\<TTypology,TTypologyItem\>\(this DiGi\.Typology\.Classes\.Typology\<TTypology,TTypologyItem\>, bool\)\.TTypologyItem')[&gt;](DiGi.Typology.Classes.md#DiGi.Typology.Classes.Typology_TTypology,TTypologyItem_ 'DiGi\.Typology\.Classes\.Typology\<TTypology,TTypologyItem\>')

The typology to strip\.

<a name='DiGi.Typology.Modify.RemoveReferences_TTypology,TTypologyItem_(thisDiGi.Typology.Classes.Typology_TTypology,TTypologyItem_,bool).includeNested'></a>

`includeNested` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A value indicating whether nested typologies are stripped as well\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True when at least one reference was removed; otherwise, false\.

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

<a name='DiGi.Typology.Modify.Update(thisDiGi.Typology.Classes.Typology,DiGi.Typology.Classes.TypologyItem)'></a>

## Modify\.Update\(this Typology, TypologyItem\) Method

Updates the given typology based on the provided typology item\.
            

The path carried by the item is relative to [typology](DiGi.Typology.md#DiGi.Typology.Modify.Update(thisDiGi.Typology.Classes.Typology,DiGi.Typology.Classes.TypologyItem).typology 'DiGi\.Typology\.Modify\.Update\(this DiGi\.Typology\.Classes\.Typology, DiGi\.Typology\.Classes\.TypologyItem\)\.typology'). Missing intermediate
            nodes are created; an existing node is updated in place, keeping its sub-typologies and
            its references. When the item carries no path, it is filed under a new index.

```csharp
public static DiGi.Typology.Classes.Typology? Update(this DiGi.Typology.Classes.Typology? typology, DiGi.Typology.Classes.TypologyItem? typologyItem);
```
#### Parameters

<a name='DiGi.Typology.Modify.Update(thisDiGi.Typology.Classes.Typology,DiGi.Typology.Classes.TypologyItem).typology'></a>

`typology` [Typology](DiGi.Typology.Classes.md#DiGi.Typology.Classes.Typology 'DiGi\.Typology\.Classes\.Typology')

The typology to update\.

<a name='DiGi.Typology.Modify.Update(thisDiGi.Typology.Classes.Typology,DiGi.Typology.Classes.TypologyItem).typologyItem'></a>

`typologyItem` [TypologyItem](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyItem 'DiGi\.Typology\.Classes\.TypologyItem')

The typology item containing updated information\.

#### Returns
[Typology](DiGi.Typology.Classes.md#DiGi.Typology.Classes.Typology 'DiGi\.Typology\.Classes\.Typology')  
The updated Typology instance, or null if either input was null\.

<a name='DiGi.Typology.Modify.Update(thisDiGi.Typology.Classes.Typology,string)'></a>

## Modify\.Update\(this Typology, string\) Method

Updates or creates a sub\-typology using specified name at the current level\.

```csharp
public static DiGi.Typology.Classes.Typology? Update(this DiGi.Typology.Classes.Typology? typology, string? name);
```
#### Parameters

<a name='DiGi.Typology.Modify.Update(thisDiGi.Typology.Classes.Typology,string).typology'></a>

`typology` [Typology](DiGi.Typology.Classes.md#DiGi.Typology.Classes.Typology 'DiGi\.Typology\.Classes\.Typology')

The typology to update\.

<a name='DiGi.Typology.Modify.Update(thisDiGi.Typology.Classes.Typology,string).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the typology\.

#### Returns
[Typology](DiGi.Typology.Classes.md#DiGi.Typology.Classes.Typology 'DiGi\.Typology\.Classes\.Typology')  
The updated or created Typology instance, or null if update failed\.

<a name='DiGi.Typology.Modify.Update(thisDiGi.Typology.Classes.Typology,string,string)'></a>

## Modify\.Update\(this Typology, string, string\) Method

Updates or creates a sub\-typology using specified name and description at the current level\.

```csharp
public static DiGi.Typology.Classes.Typology? Update(this DiGi.Typology.Classes.Typology? typology, string? name, string? description);
```
#### Parameters

<a name='DiGi.Typology.Modify.Update(thisDiGi.Typology.Classes.Typology,string,string).typology'></a>

`typology` [Typology](DiGi.Typology.Classes.md#DiGi.Typology.Classes.Typology 'DiGi\.Typology\.Classes\.Typology')

The typology to update\.

<a name='DiGi.Typology.Modify.Update(thisDiGi.Typology.Classes.Typology,string,string).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the typology\.

<a name='DiGi.Typology.Modify.Update(thisDiGi.Typology.Classes.Typology,string,string).description'></a>

`description` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The description of the typology\.

#### Returns
[Typology](DiGi.Typology.Classes.md#DiGi.Typology.Classes.Typology 'DiGi\.Typology\.Classes\.Typology')  
The updated or created Typology instance, or null if update failed\.

<a name='DiGi.Typology.Modify.Update(thisDiGi.Typology.Classes.Typology,System.Collections.Generic.IEnumerable_int_,string)'></a>

## Modify\.Update\(this Typology, IEnumerable\<int\>, string\) Method

Updates or creates a sub\-typology using specified path values and name\.

```csharp
public static DiGi.Typology.Classes.Typology? Update(this DiGi.Typology.Classes.Typology? typology, System.Collections.Generic.IEnumerable<int>? values, string? name);
```
#### Parameters

<a name='DiGi.Typology.Modify.Update(thisDiGi.Typology.Classes.Typology,System.Collections.Generic.IEnumerable_int_,string).typology'></a>

`typology` [Typology](DiGi.Typology.Classes.md#DiGi.Typology.Classes.Typology 'DiGi\.Typology\.Classes\.Typology')

The typology to update\.

<a name='DiGi.Typology.Modify.Update(thisDiGi.Typology.Classes.Typology,System.Collections.Generic.IEnumerable_int_,string).values'></a>

`values` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The sequence of indices representing the typology path\.

<a name='DiGi.Typology.Modify.Update(thisDiGi.Typology.Classes.Typology,System.Collections.Generic.IEnumerable_int_,string).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the typology\.

#### Returns
[Typology](DiGi.Typology.Classes.md#DiGi.Typology.Classes.Typology 'DiGi\.Typology\.Classes\.Typology')  
The updated or created Typology instance, or null if update failed\.

<a name='DiGi.Typology.Modify.Update(thisDiGi.Typology.Classes.Typology,System.Collections.Generic.IEnumerable_int_,string,string)'></a>

## Modify\.Update\(this Typology, IEnumerable\<int\>, string, string\) Method

Updates or creates a sub\-typology using specified path values, name, and description\.

```csharp
public static DiGi.Typology.Classes.Typology? Update(this DiGi.Typology.Classes.Typology? typology, System.Collections.Generic.IEnumerable<int>? values, string? name, string? description);
```
#### Parameters

<a name='DiGi.Typology.Modify.Update(thisDiGi.Typology.Classes.Typology,System.Collections.Generic.IEnumerable_int_,string,string).typology'></a>

`typology` [Typology](DiGi.Typology.Classes.md#DiGi.Typology.Classes.Typology 'DiGi\.Typology\.Classes\.Typology')

The typology to update\.

<a name='DiGi.Typology.Modify.Update(thisDiGi.Typology.Classes.Typology,System.Collections.Generic.IEnumerable_int_,string,string).values'></a>

`values` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The sequence of indices representing the typology path\.

<a name='DiGi.Typology.Modify.Update(thisDiGi.Typology.Classes.Typology,System.Collections.Generic.IEnumerable_int_,string,string).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the typology\.

<a name='DiGi.Typology.Modify.Update(thisDiGi.Typology.Classes.Typology,System.Collections.Generic.IEnumerable_int_,string,string).description'></a>

`description` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The description of the typology\.

#### Returns
[Typology](DiGi.Typology.Classes.md#DiGi.Typology.Classes.Typology 'DiGi\.Typology\.Classes\.Typology')  
The updated or created Typology instance, or null if update failed\.

<a name='DiGi.Typology.Query'></a>

## Query Class

Static partial class containing query extension methods for typology entities\.

```csharp
public static class Query
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Query
### Methods

<a name='DiGi.Typology.Query.Contains_TTypology,TTypologyItem_(thisDiGi.Typology.Classes.Typology_TTypology,TTypologyItem_,string,bool)'></a>

## Query\.Contains\<TTypology,TTypologyItem\>\(this Typology\<TTypology,TTypologyItem\>, string, bool\) Method

Determines whether the given typology carries a specific reference, optionally searching its
nested typologies as well\.

```csharp
public static bool Contains<TTypology,TTypologyItem>(this DiGi.Typology.Classes.Typology<TTypology,TTypologyItem>? typology, string? reference, bool includeNested=false)
    where TTypology : DiGi.Typology.Classes.Typology<TTypology, TTypologyItem>
    where TTypologyItem : DiGi.Typology.Classes.TypologyItem, new();
```
#### Type parameters

<a name='DiGi.Typology.Query.Contains_TTypology,TTypologyItem_(thisDiGi.Typology.Classes.Typology_TTypology,TTypologyItem_,string,bool).TTypology'></a>

`TTypology`

The concrete typology type\.

<a name='DiGi.Typology.Query.Contains_TTypology,TTypologyItem_(thisDiGi.Typology.Classes.Typology_TTypology,TTypologyItem_,string,bool).TTypologyItem'></a>

`TTypologyItem`

The typology item type\.
#### Parameters

<a name='DiGi.Typology.Query.Contains_TTypology,TTypologyItem_(thisDiGi.Typology.Classes.Typology_TTypology,TTypologyItem_,string,bool).typology'></a>

`typology` [DiGi\.Typology\.Classes\.Typology&lt;](DiGi.Typology.Classes.md#DiGi.Typology.Classes.Typology_TTypology,TTypologyItem_ 'DiGi\.Typology\.Classes\.Typology\<TTypology,TTypologyItem\>')[TTypology](DiGi.Typology.md#DiGi.Typology.Query.Contains_TTypology,TTypologyItem_(thisDiGi.Typology.Classes.Typology_TTypology,TTypologyItem_,string,bool).TTypology 'DiGi\.Typology\.Query\.Contains\<TTypology,TTypologyItem\>\(this DiGi\.Typology\.Classes\.Typology\<TTypology,TTypologyItem\>, string, bool\)\.TTypology')[,](DiGi.Typology.Classes.md#DiGi.Typology.Classes.Typology_TTypology,TTypologyItem_ 'DiGi\.Typology\.Classes\.Typology\<TTypology,TTypologyItem\>')[TTypologyItem](DiGi.Typology.md#DiGi.Typology.Query.Contains_TTypology,TTypologyItem_(thisDiGi.Typology.Classes.Typology_TTypology,TTypologyItem_,string,bool).TTypologyItem 'DiGi\.Typology\.Query\.Contains\<TTypology,TTypologyItem\>\(this DiGi\.Typology\.Classes\.Typology\<TTypology,TTypologyItem\>, string, bool\)\.TTypologyItem')[&gt;](DiGi.Typology.Classes.md#DiGi.Typology.Classes.Typology_TTypology,TTypologyItem_ 'DiGi\.Typology\.Classes\.Typology\<TTypology,TTypologyItem\>')

The typology to search\.

<a name='DiGi.Typology.Query.Contains_TTypology,TTypologyItem_(thisDiGi.Typology.Classes.Typology_TTypology,TTypologyItem_,string,bool).reference'></a>

`reference` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The reference string to search for\.

<a name='DiGi.Typology.Query.Contains_TTypology,TTypologyItem_(thisDiGi.Typology.Classes.Typology_TTypology,TTypologyItem_,string,bool).includeNested'></a>

`includeNested` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A value indicating whether to include nested typologies in the search\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the reference is found; otherwise, false\.

<a name='DiGi.Typology.Query.ReferenceSet_TTypology,TTypologyItem_(thisDiGi.Typology.Classes.Typology_TTypology,TTypologyItem_,bool)'></a>

## Query\.ReferenceSet\<TTypology,TTypologyItem\>\(this Typology\<TTypology,TTypologyItem\>, bool\) Method

Retrieves the set of references associated with the given typology, optionally including those
carried by its nested typologies\.

With [includeNested](DiGi.Typology.md#DiGi.Typology.Query.ReferenceSet_TTypology,TTypologyItem_(thisDiGi.Typology.Classes.Typology_TTypology,TTypologyItem_,bool).includeNested 'DiGi\.Typology\.Query\.ReferenceSet\<TTypology,TTypologyItem\>\(this DiGi\.Typology\.Classes\.Typology\<TTypology,TTypologyItem\>, bool\)\.includeNested') false this is the content of
            [References](DiGi.Typology.Classes.md#DiGi.Typology.Classes.Typology_TTypology,TTypologyItem_.References 'DiGi\.Typology\.Classes\.Typology\<TTypology,TTypologyItem\>\.References') as a set; the recursive form is what this method adds.
            It is named for the set it returns because the typology already exposes a References property.

```csharp
public static System.Collections.Generic.HashSet<string> ReferenceSet<TTypology,TTypologyItem>(this DiGi.Typology.Classes.Typology<TTypology,TTypologyItem>? typology, bool includeNested=false)
    where TTypology : DiGi.Typology.Classes.Typology<TTypology, TTypologyItem>
    where TTypologyItem : DiGi.Typology.Classes.TypologyItem, new();
```
#### Type parameters

<a name='DiGi.Typology.Query.ReferenceSet_TTypology,TTypologyItem_(thisDiGi.Typology.Classes.Typology_TTypology,TTypologyItem_,bool).TTypology'></a>

`TTypology`

The concrete typology type\.

<a name='DiGi.Typology.Query.ReferenceSet_TTypology,TTypologyItem_(thisDiGi.Typology.Classes.Typology_TTypology,TTypologyItem_,bool).TTypologyItem'></a>

`TTypologyItem`

The typology item type\.
#### Parameters

<a name='DiGi.Typology.Query.ReferenceSet_TTypology,TTypologyItem_(thisDiGi.Typology.Classes.Typology_TTypology,TTypologyItem_,bool).typology'></a>

`typology` [DiGi\.Typology\.Classes\.Typology&lt;](DiGi.Typology.Classes.md#DiGi.Typology.Classes.Typology_TTypology,TTypologyItem_ 'DiGi\.Typology\.Classes\.Typology\<TTypology,TTypologyItem\>')[TTypology](DiGi.Typology.md#DiGi.Typology.Query.ReferenceSet_TTypology,TTypologyItem_(thisDiGi.Typology.Classes.Typology_TTypology,TTypologyItem_,bool).TTypology 'DiGi\.Typology\.Query\.ReferenceSet\<TTypology,TTypologyItem\>\(this DiGi\.Typology\.Classes\.Typology\<TTypology,TTypologyItem\>, bool\)\.TTypology')[,](DiGi.Typology.Classes.md#DiGi.Typology.Classes.Typology_TTypology,TTypologyItem_ 'DiGi\.Typology\.Classes\.Typology\<TTypology,TTypologyItem\>')[TTypologyItem](DiGi.Typology.md#DiGi.Typology.Query.ReferenceSet_TTypology,TTypologyItem_(thisDiGi.Typology.Classes.Typology_TTypology,TTypologyItem_,bool).TTypologyItem 'DiGi\.Typology\.Query\.ReferenceSet\<TTypology,TTypologyItem\>\(this DiGi\.Typology\.Classes\.Typology\<TTypology,TTypologyItem\>, bool\)\.TTypologyItem')[&gt;](DiGi.Typology.Classes.md#DiGi.Typology.Classes.Typology_TTypology,TTypologyItem_ 'DiGi\.Typology\.Classes\.Typology\<TTypology,TTypologyItem\>')

The typology whose references are collected\.

<a name='DiGi.Typology.Query.ReferenceSet_TTypology,TTypologyItem_(thisDiGi.Typology.Classes.Typology_TTypology,TTypologyItem_,bool).includeNested'></a>

`includeNested` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A value indicating whether to include references from nested typologies\.

#### Returns
[System\.Collections\.Generic\.HashSet&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1 'System\.Collections\.Generic\.HashSet\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1 'System\.Collections\.Generic\.HashSet\`1')  
A [System\.Collections\.Generic\.HashSet&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1 'System\.Collections\.Generic\.HashSet\`1') containing the references, empty when the typology is null\.

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

<a name='DiGi.Typology.Query.SubTypology_TTypology,TTypologyItem_(thisDiGi.Typology.Classes.Typology_TTypology,TTypologyItem_,DiGi.Typology.Classes.TypologyPath)'></a>

## Query\.SubTypology\<TTypology,TTypologyItem\>\(this Typology\<TTypology,TTypologyItem\>, TypologyPath\) Method

Retrieves the sub\-typology found at the provided path, relative to the given typology\.

An empty path resolves to [typology](DiGi.Typology.md#DiGi.Typology.Query.SubTypology_TTypology,TTypologyItem_(thisDiGi.Typology.Classes.Typology_TTypology,TTypologyItem_,DiGi.Typology.Classes.TypologyPath).typology 'DiGi\.Typology\.Query\.SubTypology\<TTypology,TTypologyItem\>\(this DiGi\.Typology\.Classes\.Typology\<TTypology,TTypologyItem\>, DiGi\.Typology\.Classes\.TypologyPath\)\.typology') itself. Each step of the path is
            resolved against the filing keys of the typology reached so far, so a sub-typology filed under
            a key differing from the one its own path reports is still found.

```csharp
public static TTypology? SubTypology<TTypology,TTypologyItem>(this DiGi.Typology.Classes.Typology<TTypology,TTypologyItem>? typology, DiGi.Typology.Classes.TypologyPath? typologyPath)
    where TTypology : DiGi.Typology.Classes.Typology<TTypology, TTypologyItem>
    where TTypologyItem : DiGi.Typology.Classes.TypologyItem, new();
```
#### Type parameters

<a name='DiGi.Typology.Query.SubTypology_TTypology,TTypologyItem_(thisDiGi.Typology.Classes.Typology_TTypology,TTypologyItem_,DiGi.Typology.Classes.TypologyPath).TTypology'></a>

`TTypology`

The concrete typology type\.

<a name='DiGi.Typology.Query.SubTypology_TTypology,TTypologyItem_(thisDiGi.Typology.Classes.Typology_TTypology,TTypologyItem_,DiGi.Typology.Classes.TypologyPath).TTypologyItem'></a>

`TTypologyItem`

The typology item type\.
#### Parameters

<a name='DiGi.Typology.Query.SubTypology_TTypology,TTypologyItem_(thisDiGi.Typology.Classes.Typology_TTypology,TTypologyItem_,DiGi.Typology.Classes.TypologyPath).typology'></a>

`typology` [DiGi\.Typology\.Classes\.Typology&lt;](DiGi.Typology.Classes.md#DiGi.Typology.Classes.Typology_TTypology,TTypologyItem_ 'DiGi\.Typology\.Classes\.Typology\<TTypology,TTypologyItem\>')[TTypology](DiGi.Typology.md#DiGi.Typology.Query.SubTypology_TTypology,TTypologyItem_(thisDiGi.Typology.Classes.Typology_TTypology,TTypologyItem_,DiGi.Typology.Classes.TypologyPath).TTypology 'DiGi\.Typology\.Query\.SubTypology\<TTypology,TTypologyItem\>\(this DiGi\.Typology\.Classes\.Typology\<TTypology,TTypologyItem\>, DiGi\.Typology\.Classes\.TypologyPath\)\.TTypology')[,](DiGi.Typology.Classes.md#DiGi.Typology.Classes.Typology_TTypology,TTypologyItem_ 'DiGi\.Typology\.Classes\.Typology\<TTypology,TTypologyItem\>')[TTypologyItem](DiGi.Typology.md#DiGi.Typology.Query.SubTypology_TTypology,TTypologyItem_(thisDiGi.Typology.Classes.Typology_TTypology,TTypologyItem_,DiGi.Typology.Classes.TypologyPath).TTypologyItem 'DiGi\.Typology\.Query\.SubTypology\<TTypology,TTypologyItem\>\(this DiGi\.Typology\.Classes\.Typology\<TTypology,TTypologyItem\>, DiGi\.Typology\.Classes\.TypologyPath\)\.TTypologyItem')[&gt;](DiGi.Typology.Classes.md#DiGi.Typology.Classes.Typology_TTypology,TTypologyItem_ 'DiGi\.Typology\.Classes\.Typology\<TTypology,TTypologyItem\>')

The typology the path is resolved against\.

<a name='DiGi.Typology.Query.SubTypology_TTypology,TTypologyItem_(thisDiGi.Typology.Classes.Typology_TTypology,TTypologyItem_,DiGi.Typology.Classes.TypologyPath).typologyPath'></a>

`typologyPath` [TypologyPath](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyPath 'DiGi\.Typology\.Classes\.TypologyPath')

The path used to locate the sub\-typology\.

#### Returns
[TTypology](DiGi.Typology.md#DiGi.Typology.Query.SubTypology_TTypology,TTypologyItem_(thisDiGi.Typology.Classes.Typology_TTypology,TTypologyItem_,DiGi.Typology.Classes.TypologyPath).TTypology 'DiGi\.Typology\.Query\.SubTypology\<TTypology,TTypologyItem\>\(this DiGi\.Typology\.Classes\.Typology\<TTypology,TTypologyItem\>, DiGi\.Typology\.Classes\.TypologyPath\)\.TTypology')  
The [Typology](DiGi.Typology.Classes.md#DiGi.Typology.Classes.Typology 'DiGi\.Typology\.Classes\.Typology') instance if found; otherwise, null\.

<a name='DiGi.Typology.Query.SubTypology_TTypology,TTypologyItem_(thisDiGi.Typology.Classes.Typology_TTypology,TTypologyItem_,System.Collections.Generic.IEnumerable_int_)'></a>

## Query\.SubTypology\<TTypology,TTypologyItem\>\(this Typology\<TTypology,TTypologyItem\>, IEnumerable\<int\>\) Method

Retrieves the sub\-typology found at the path described by a sequence of integer indexes,
relative to the given typology\.

```csharp
public static TTypology? SubTypology<TTypology,TTypologyItem>(this DiGi.Typology.Classes.Typology<TTypology,TTypologyItem>? typology, System.Collections.Generic.IEnumerable<int>? values)
    where TTypology : DiGi.Typology.Classes.Typology<TTypology, TTypologyItem>
    where TTypologyItem : DiGi.Typology.Classes.TypologyItem, new();
```
#### Type parameters

<a name='DiGi.Typology.Query.SubTypology_TTypology,TTypologyItem_(thisDiGi.Typology.Classes.Typology_TTypology,TTypologyItem_,System.Collections.Generic.IEnumerable_int_).TTypology'></a>

`TTypology`

The concrete typology type\.

<a name='DiGi.Typology.Query.SubTypology_TTypology,TTypologyItem_(thisDiGi.Typology.Classes.Typology_TTypology,TTypologyItem_,System.Collections.Generic.IEnumerable_int_).TTypologyItem'></a>

`TTypologyItem`

The typology item type\.
#### Parameters

<a name='DiGi.Typology.Query.SubTypology_TTypology,TTypologyItem_(thisDiGi.Typology.Classes.Typology_TTypology,TTypologyItem_,System.Collections.Generic.IEnumerable_int_).typology'></a>

`typology` [DiGi\.Typology\.Classes\.Typology&lt;](DiGi.Typology.Classes.md#DiGi.Typology.Classes.Typology_TTypology,TTypologyItem_ 'DiGi\.Typology\.Classes\.Typology\<TTypology,TTypologyItem\>')[TTypology](DiGi.Typology.md#DiGi.Typology.Query.SubTypology_TTypology,TTypologyItem_(thisDiGi.Typology.Classes.Typology_TTypology,TTypologyItem_,System.Collections.Generic.IEnumerable_int_).TTypology 'DiGi\.Typology\.Query\.SubTypology\<TTypology,TTypologyItem\>\(this DiGi\.Typology\.Classes\.Typology\<TTypology,TTypologyItem\>, System\.Collections\.Generic\.IEnumerable\<int\>\)\.TTypology')[,](DiGi.Typology.Classes.md#DiGi.Typology.Classes.Typology_TTypology,TTypologyItem_ 'DiGi\.Typology\.Classes\.Typology\<TTypology,TTypologyItem\>')[TTypologyItem](DiGi.Typology.md#DiGi.Typology.Query.SubTypology_TTypology,TTypologyItem_(thisDiGi.Typology.Classes.Typology_TTypology,TTypologyItem_,System.Collections.Generic.IEnumerable_int_).TTypologyItem 'DiGi\.Typology\.Query\.SubTypology\<TTypology,TTypologyItem\>\(this DiGi\.Typology\.Classes\.Typology\<TTypology,TTypologyItem\>, System\.Collections\.Generic\.IEnumerable\<int\>\)\.TTypologyItem')[&gt;](DiGi.Typology.Classes.md#DiGi.Typology.Classes.Typology_TTypology,TTypologyItem_ 'DiGi\.Typology\.Classes\.Typology\<TTypology,TTypologyItem\>')

The typology the path is resolved against\.

<a name='DiGi.Typology.Query.SubTypology_TTypology,TTypologyItem_(thisDiGi.Typology.Classes.Typology_TTypology,TTypologyItem_,System.Collections.Generic.IEnumerable_int_).values'></a>

`values` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

An enumerable collection of integers representing the typology path\.

#### Returns
[TTypology](DiGi.Typology.md#DiGi.Typology.Query.SubTypology_TTypology,TTypologyItem_(thisDiGi.Typology.Classes.Typology_TTypology,TTypologyItem_,System.Collections.Generic.IEnumerable_int_).TTypology 'DiGi\.Typology\.Query\.SubTypology\<TTypology,TTypologyItem\>\(this DiGi\.Typology\.Classes\.Typology\<TTypology,TTypologyItem\>, System\.Collections\.Generic\.IEnumerable\<int\>\)\.TTypology')  
The [Typology](DiGi.Typology.Classes.md#DiGi.Typology.Classes.Typology 'DiGi\.Typology\.Classes\.Typology') instance if found; otherwise, null\.

<a name='DiGi.Typology.Query.TryGetLastIndex_TTypology,TTypologyItem_(thisDiGi.Typology.Classes.Typology_TTypology,TTypologyItem_,int)'></a>

## Query\.TryGetLastIndex\<TTypology,TTypologyItem\>\(this Typology\<TTypology,TTypologyItem\>, int\) Method

Attempts to retrieve the highest index a sub\-typology of the given typology is filed under\.

```csharp
public static bool TryGetLastIndex<TTypology,TTypologyItem>(this DiGi.Typology.Classes.Typology<TTypology,TTypologyItem>? typology, out int index)
    where TTypology : DiGi.Typology.Classes.Typology<TTypology, TTypologyItem>
    where TTypologyItem : DiGi.Typology.Classes.TypologyItem, new();
```
#### Type parameters

<a name='DiGi.Typology.Query.TryGetLastIndex_TTypology,TTypologyItem_(thisDiGi.Typology.Classes.Typology_TTypology,TTypologyItem_,int).TTypology'></a>

`TTypology`

The concrete typology type\.

<a name='DiGi.Typology.Query.TryGetLastIndex_TTypology,TTypologyItem_(thisDiGi.Typology.Classes.Typology_TTypology,TTypologyItem_,int).TTypologyItem'></a>

`TTypologyItem`

The typology item type\.
#### Parameters

<a name='DiGi.Typology.Query.TryGetLastIndex_TTypology,TTypologyItem_(thisDiGi.Typology.Classes.Typology_TTypology,TTypologyItem_,int).typology'></a>

`typology` [DiGi\.Typology\.Classes\.Typology&lt;](DiGi.Typology.Classes.md#DiGi.Typology.Classes.Typology_TTypology,TTypologyItem_ 'DiGi\.Typology\.Classes\.Typology\<TTypology,TTypologyItem\>')[TTypology](DiGi.Typology.md#DiGi.Typology.Query.TryGetLastIndex_TTypology,TTypologyItem_(thisDiGi.Typology.Classes.Typology_TTypology,TTypologyItem_,int).TTypology 'DiGi\.Typology\.Query\.TryGetLastIndex\<TTypology,TTypologyItem\>\(this DiGi\.Typology\.Classes\.Typology\<TTypology,TTypologyItem\>, int\)\.TTypology')[,](DiGi.Typology.Classes.md#DiGi.Typology.Classes.Typology_TTypology,TTypologyItem_ 'DiGi\.Typology\.Classes\.Typology\<TTypology,TTypologyItem\>')[TTypologyItem](DiGi.Typology.md#DiGi.Typology.Query.TryGetLastIndex_TTypology,TTypologyItem_(thisDiGi.Typology.Classes.Typology_TTypology,TTypologyItem_,int).TTypologyItem 'DiGi\.Typology\.Query\.TryGetLastIndex\<TTypology,TTypologyItem\>\(this DiGi\.Typology\.Classes\.Typology\<TTypology,TTypologyItem\>, int\)\.TTypologyItem')[&gt;](DiGi.Typology.Classes.md#DiGi.Typology.Classes.Typology_TTypology,TTypologyItem_ 'DiGi\.Typology\.Classes\.Typology\<TTypology,TTypologyItem\>')

The typology whose filing indexes are inspected\.

<a name='DiGi.Typology.Query.TryGetLastIndex_TTypology,TTypologyItem_(thisDiGi.Typology.Classes.Typology_TTypology,TTypologyItem_,int).index'></a>

`index` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

When this method returns, contains the highest index if successful; otherwise, \-1\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the typology carries at least one sub\-typology; otherwise, false\.

<a name='DiGi.Typology.Query.TryGetTypologies_TTypology,TTypologyItem_(thisDiGi.Typology.Classes.Typology_TTypology,TTypologyItem_,DiGi.Typology.Classes.TypologyPath,string,System.Collections.Generic.List_TTypology_)'></a>

## Query\.TryGetTypologies\<TTypology,TTypologyItem\>\(this Typology\<TTypology,TTypologyItem\>, TypologyPath, string, List\<TTypology\>\) Method

Attempts to retrieve the direct children, of the typology found at the specified path, that carry the specified name\.

```csharp
public static bool TryGetTypologies<TTypology,TTypologyItem>(this DiGi.Typology.Classes.Typology<TTypology,TTypologyItem>? typology, DiGi.Typology.Classes.TypologyPath? typologyPath, string name, out System.Collections.Generic.List<TTypology>? typologies)
    where TTypology : DiGi.Typology.Classes.Typology<TTypology, TTypologyItem>
    where TTypologyItem : DiGi.Typology.Classes.TypologyItem, new();
```
#### Type parameters

<a name='DiGi.Typology.Query.TryGetTypologies_TTypology,TTypologyItem_(thisDiGi.Typology.Classes.Typology_TTypology,TTypologyItem_,DiGi.Typology.Classes.TypologyPath,string,System.Collections.Generic.List_TTypology_).TTypology'></a>

`TTypology`

The concrete typology type\.

<a name='DiGi.Typology.Query.TryGetTypologies_TTypology,TTypologyItem_(thisDiGi.Typology.Classes.Typology_TTypology,TTypologyItem_,DiGi.Typology.Classes.TypologyPath,string,System.Collections.Generic.List_TTypology_).TTypologyItem'></a>

`TTypologyItem`

The typology item type\.
#### Parameters

<a name='DiGi.Typology.Query.TryGetTypologies_TTypology,TTypologyItem_(thisDiGi.Typology.Classes.Typology_TTypology,TTypologyItem_,DiGi.Typology.Classes.TypologyPath,string,System.Collections.Generic.List_TTypology_).typology'></a>

`typology` [DiGi\.Typology\.Classes\.Typology&lt;](DiGi.Typology.Classes.md#DiGi.Typology.Classes.Typology_TTypology,TTypologyItem_ 'DiGi\.Typology\.Classes\.Typology\<TTypology,TTypologyItem\>')[TTypology](DiGi.Typology.md#DiGi.Typology.Query.TryGetTypologies_TTypology,TTypologyItem_(thisDiGi.Typology.Classes.Typology_TTypology,TTypologyItem_,DiGi.Typology.Classes.TypologyPath,string,System.Collections.Generic.List_TTypology_).TTypology 'DiGi\.Typology\.Query\.TryGetTypologies\<TTypology,TTypologyItem\>\(this DiGi\.Typology\.Classes\.Typology\<TTypology,TTypologyItem\>, DiGi\.Typology\.Classes\.TypologyPath, string, System\.Collections\.Generic\.List\<TTypology\>\)\.TTypology')[,](DiGi.Typology.Classes.md#DiGi.Typology.Classes.Typology_TTypology,TTypologyItem_ 'DiGi\.Typology\.Classes\.Typology\<TTypology,TTypologyItem\>')[TTypologyItem](DiGi.Typology.md#DiGi.Typology.Query.TryGetTypologies_TTypology,TTypologyItem_(thisDiGi.Typology.Classes.Typology_TTypology,TTypologyItem_,DiGi.Typology.Classes.TypologyPath,string,System.Collections.Generic.List_TTypology_).TTypologyItem 'DiGi\.Typology\.Query\.TryGetTypologies\<TTypology,TTypologyItem\>\(this DiGi\.Typology\.Classes\.Typology\<TTypology,TTypologyItem\>, DiGi\.Typology\.Classes\.TypologyPath, string, System\.Collections\.Generic\.List\<TTypology\>\)\.TTypologyItem')[&gt;](DiGi.Typology.Classes.md#DiGi.Typology.Classes.Typology_TTypology,TTypologyItem_ 'DiGi\.Typology\.Classes\.Typology\<TTypology,TTypologyItem\>')

The typology the path is resolved against\.

<a name='DiGi.Typology.Query.TryGetTypologies_TTypology,TTypologyItem_(thisDiGi.Typology.Classes.Typology_TTypology,TTypologyItem_,DiGi.Typology.Classes.TypologyPath,string,System.Collections.Generic.List_TTypology_).typologyPath'></a>

`typologyPath` [TypologyPath](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyPath 'DiGi\.Typology\.Classes\.TypologyPath')

The path to search within\.

<a name='DiGi.Typology.Query.TryGetTypologies_TTypology,TTypologyItem_(thisDiGi.Typology.Classes.Typology_TTypology,TTypologyItem_,DiGi.Typology.Classes.TypologyPath,string,System.Collections.Generic.List_TTypology_).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the typologies to find\.

<a name='DiGi.Typology.Query.TryGetTypologies_TTypology,TTypologyItem_(thisDiGi.Typology.Classes.Typology_TTypology,TTypologyItem_,DiGi.Typology.Classes.TypologyPath,string,System.Collections.Generic.List_TTypology_).typologies'></a>

`typologies` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[TTypology](DiGi.Typology.md#DiGi.Typology.Query.TryGetTypologies_TTypology,TTypologyItem_(thisDiGi.Typology.Classes.Typology_TTypology,TTypologyItem_,DiGi.Typology.Classes.TypologyPath,string,System.Collections.Generic.List_TTypology_).TTypology 'DiGi\.Typology\.Query\.TryGetTypologies\<TTypology,TTypologyItem\>\(this DiGi\.Typology\.Classes\.Typology\<TTypology,TTypologyItem\>, DiGi\.Typology\.Classes\.TypologyPath, string, System\.Collections\.Generic\.List\<TTypology\>\)\.TTypology')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

When this method returns, contains a list of matching typologies if successful; otherwise, null\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if one or more matching typologies were found; otherwise, false\.

<a name='DiGi.Typology.Query.TryGetTypologies_TTypology,TTypologyItem_(thisDiGi.Typology.Classes.Typology_TTypology,TTypologyItem_,string,System.Collections.Generic.List_TTypology_)'></a>

## Query\.TryGetTypologies\<TTypology,TTypologyItem\>\(this Typology\<TTypology,TTypologyItem\>, string, List\<TTypology\>\) Method

Attempts to retrieve the direct children of the given typology that carry the specified name\.

```csharp
public static bool TryGetTypologies<TTypology,TTypologyItem>(this DiGi.Typology.Classes.Typology<TTypology,TTypologyItem>? typology, string name, out System.Collections.Generic.List<TTypology>? typologies)
    where TTypology : DiGi.Typology.Classes.Typology<TTypology, TTypologyItem>
    where TTypologyItem : DiGi.Typology.Classes.TypologyItem, new();
```
#### Type parameters

<a name='DiGi.Typology.Query.TryGetTypologies_TTypology,TTypologyItem_(thisDiGi.Typology.Classes.Typology_TTypology,TTypologyItem_,string,System.Collections.Generic.List_TTypology_).TTypology'></a>

`TTypology`

The concrete typology type\.

<a name='DiGi.Typology.Query.TryGetTypologies_TTypology,TTypologyItem_(thisDiGi.Typology.Classes.Typology_TTypology,TTypologyItem_,string,System.Collections.Generic.List_TTypology_).TTypologyItem'></a>

`TTypologyItem`

The typology item type\.
#### Parameters

<a name='DiGi.Typology.Query.TryGetTypologies_TTypology,TTypologyItem_(thisDiGi.Typology.Classes.Typology_TTypology,TTypologyItem_,string,System.Collections.Generic.List_TTypology_).typology'></a>

`typology` [DiGi\.Typology\.Classes\.Typology&lt;](DiGi.Typology.Classes.md#DiGi.Typology.Classes.Typology_TTypology,TTypologyItem_ 'DiGi\.Typology\.Classes\.Typology\<TTypology,TTypologyItem\>')[TTypology](DiGi.Typology.md#DiGi.Typology.Query.TryGetTypologies_TTypology,TTypologyItem_(thisDiGi.Typology.Classes.Typology_TTypology,TTypologyItem_,string,System.Collections.Generic.List_TTypology_).TTypology 'DiGi\.Typology\.Query\.TryGetTypologies\<TTypology,TTypologyItem\>\(this DiGi\.Typology\.Classes\.Typology\<TTypology,TTypologyItem\>, string, System\.Collections\.Generic\.List\<TTypology\>\)\.TTypology')[,](DiGi.Typology.Classes.md#DiGi.Typology.Classes.Typology_TTypology,TTypologyItem_ 'DiGi\.Typology\.Classes\.Typology\<TTypology,TTypologyItem\>')[TTypologyItem](DiGi.Typology.md#DiGi.Typology.Query.TryGetTypologies_TTypology,TTypologyItem_(thisDiGi.Typology.Classes.Typology_TTypology,TTypologyItem_,string,System.Collections.Generic.List_TTypology_).TTypologyItem 'DiGi\.Typology\.Query\.TryGetTypologies\<TTypology,TTypologyItem\>\(this DiGi\.Typology\.Classes\.Typology\<TTypology,TTypologyItem\>, string, System\.Collections\.Generic\.List\<TTypology\>\)\.TTypologyItem')[&gt;](DiGi.Typology.Classes.md#DiGi.Typology.Classes.Typology_TTypology,TTypologyItem_ 'DiGi\.Typology\.Classes\.Typology\<TTypology,TTypologyItem\>')

The typology whose direct children are searched\.

<a name='DiGi.Typology.Query.TryGetTypologies_TTypology,TTypologyItem_(thisDiGi.Typology.Classes.Typology_TTypology,TTypologyItem_,string,System.Collections.Generic.List_TTypology_).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the typologies to find\.

<a name='DiGi.Typology.Query.TryGetTypologies_TTypology,TTypologyItem_(thisDiGi.Typology.Classes.Typology_TTypology,TTypologyItem_,string,System.Collections.Generic.List_TTypology_).typologies'></a>

`typologies` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[TTypology](DiGi.Typology.md#DiGi.Typology.Query.TryGetTypologies_TTypology,TTypologyItem_(thisDiGi.Typology.Classes.Typology_TTypology,TTypologyItem_,string,System.Collections.Generic.List_TTypology_).TTypology 'DiGi\.Typology\.Query\.TryGetTypologies\<TTypology,TTypologyItem\>\(this DiGi\.Typology\.Classes\.Typology\<TTypology,TTypologyItem\>, string, System\.Collections\.Generic\.List\<TTypology\>\)\.TTypology')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

When this method returns, contains a list of matching typologies if successful; otherwise, null\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if one or more matching typologies were found; otherwise, false\.

<a name='DiGi.Typology.Query.TryGetTypologies_TTypology,TTypologyItem_(thisDiGi.Typology.Classes.Typology_TTypology,TTypologyItem_,System.Collections.Generic.IEnumerable_int_,string,System.Collections.Generic.List_TTypology_)'></a>

## Query\.TryGetTypologies\<TTypology,TTypologyItem\>\(this Typology\<TTypology,TTypologyItem\>, IEnumerable\<int\>, string, List\<TTypology\>\) Method

Attempts to retrieve the direct children, of the typology found at the specified index values, that carry the specified name\.

```csharp
public static bool TryGetTypologies<TTypology,TTypologyItem>(this DiGi.Typology.Classes.Typology<TTypology,TTypologyItem>? typology, System.Collections.Generic.IEnumerable<int> values, string name, out System.Collections.Generic.List<TTypology>? typologies)
    where TTypology : DiGi.Typology.Classes.Typology<TTypology, TTypologyItem>
    where TTypologyItem : DiGi.Typology.Classes.TypologyItem, new();
```
#### Type parameters

<a name='DiGi.Typology.Query.TryGetTypologies_TTypology,TTypologyItem_(thisDiGi.Typology.Classes.Typology_TTypology,TTypologyItem_,System.Collections.Generic.IEnumerable_int_,string,System.Collections.Generic.List_TTypology_).TTypology'></a>

`TTypology`

The concrete typology type\.

<a name='DiGi.Typology.Query.TryGetTypologies_TTypology,TTypologyItem_(thisDiGi.Typology.Classes.Typology_TTypology,TTypologyItem_,System.Collections.Generic.IEnumerable_int_,string,System.Collections.Generic.List_TTypology_).TTypologyItem'></a>

`TTypologyItem`

The typology item type\.
#### Parameters

<a name='DiGi.Typology.Query.TryGetTypologies_TTypology,TTypologyItem_(thisDiGi.Typology.Classes.Typology_TTypology,TTypologyItem_,System.Collections.Generic.IEnumerable_int_,string,System.Collections.Generic.List_TTypology_).typology'></a>

`typology` [DiGi\.Typology\.Classes\.Typology&lt;](DiGi.Typology.Classes.md#DiGi.Typology.Classes.Typology_TTypology,TTypologyItem_ 'DiGi\.Typology\.Classes\.Typology\<TTypology,TTypologyItem\>')[TTypology](DiGi.Typology.md#DiGi.Typology.Query.TryGetTypologies_TTypology,TTypologyItem_(thisDiGi.Typology.Classes.Typology_TTypology,TTypologyItem_,System.Collections.Generic.IEnumerable_int_,string,System.Collections.Generic.List_TTypology_).TTypology 'DiGi\.Typology\.Query\.TryGetTypologies\<TTypology,TTypologyItem\>\(this DiGi\.Typology\.Classes\.Typology\<TTypology,TTypologyItem\>, System\.Collections\.Generic\.IEnumerable\<int\>, string, System\.Collections\.Generic\.List\<TTypology\>\)\.TTypology')[,](DiGi.Typology.Classes.md#DiGi.Typology.Classes.Typology_TTypology,TTypologyItem_ 'DiGi\.Typology\.Classes\.Typology\<TTypology,TTypologyItem\>')[TTypologyItem](DiGi.Typology.md#DiGi.Typology.Query.TryGetTypologies_TTypology,TTypologyItem_(thisDiGi.Typology.Classes.Typology_TTypology,TTypologyItem_,System.Collections.Generic.IEnumerable_int_,string,System.Collections.Generic.List_TTypology_).TTypologyItem 'DiGi\.Typology\.Query\.TryGetTypologies\<TTypology,TTypologyItem\>\(this DiGi\.Typology\.Classes\.Typology\<TTypology,TTypologyItem\>, System\.Collections\.Generic\.IEnumerable\<int\>, string, System\.Collections\.Generic\.List\<TTypology\>\)\.TTypologyItem')[&gt;](DiGi.Typology.Classes.md#DiGi.Typology.Classes.Typology_TTypology,TTypologyItem_ 'DiGi\.Typology\.Classes\.Typology\<TTypology,TTypologyItem\>')

The typology the path is resolved against\.

<a name='DiGi.Typology.Query.TryGetTypologies_TTypology,TTypologyItem_(thisDiGi.Typology.Classes.Typology_TTypology,TTypologyItem_,System.Collections.Generic.IEnumerable_int_,string,System.Collections.Generic.List_TTypology_).values'></a>

`values` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The sequence of indices representing the typology path\.

<a name='DiGi.Typology.Query.TryGetTypologies_TTypology,TTypologyItem_(thisDiGi.Typology.Classes.Typology_TTypology,TTypologyItem_,System.Collections.Generic.IEnumerable_int_,string,System.Collections.Generic.List_TTypology_).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the typologies to find\.

<a name='DiGi.Typology.Query.TryGetTypologies_TTypology,TTypologyItem_(thisDiGi.Typology.Classes.Typology_TTypology,TTypologyItem_,System.Collections.Generic.IEnumerable_int_,string,System.Collections.Generic.List_TTypology_).typologies'></a>

`typologies` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[TTypology](DiGi.Typology.md#DiGi.Typology.Query.TryGetTypologies_TTypology,TTypologyItem_(thisDiGi.Typology.Classes.Typology_TTypology,TTypologyItem_,System.Collections.Generic.IEnumerable_int_,string,System.Collections.Generic.List_TTypology_).TTypology 'DiGi\.Typology\.Query\.TryGetTypologies\<TTypology,TTypologyItem\>\(this DiGi\.Typology\.Classes\.Typology\<TTypology,TTypologyItem\>, System\.Collections\.Generic\.IEnumerable\<int\>, string, System\.Collections\.Generic\.List\<TTypology\>\)\.TTypology')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

When this method returns, contains a list of matching typologies if successful; otherwise, null\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if one or more matching typologies were found; otherwise, false\.

<a name='DiGi.Typology.Query.TypologyPaths_TTypology,TTypologyItem_(thisDiGi.Typology.Classes.Typology_TTypology,TTypologyItem_,bool)'></a>

## Query\.TypologyPaths\<TTypology,TTypologyItem\>\(this Typology\<TTypology,TTypologyItem\>, bool\) Method

Retrieves the paths of the sub\-typologies of the given typology, optionally including nested ones\.

The paths are the ones the sub-typologies report themselves, which may differ from the keys
            they are filed under - see [SubTypologies](DiGi.Typology.Classes.md#DiGi.Typology.Classes.Typology_TTypology,TTypologyItem_.SubTypologies 'DiGi\.Typology\.Classes\.Typology\<TTypology,TTypologyItem\>\.SubTypologies'). A sub-typology carrying
            no path contributes nothing.

```csharp
public static System.Collections.Generic.List<DiGi.Typology.Classes.TypologyPath> TypologyPaths<TTypology,TTypologyItem>(this DiGi.Typology.Classes.Typology<TTypology,TTypologyItem>? typology, bool includeNested=false)
    where TTypology : DiGi.Typology.Classes.Typology<TTypology, TTypologyItem>
    where TTypologyItem : DiGi.Typology.Classes.TypologyItem, new();
```
#### Type parameters

<a name='DiGi.Typology.Query.TypologyPaths_TTypology,TTypologyItem_(thisDiGi.Typology.Classes.Typology_TTypology,TTypologyItem_,bool).TTypology'></a>

`TTypology`

The concrete typology type\.

<a name='DiGi.Typology.Query.TypologyPaths_TTypology,TTypologyItem_(thisDiGi.Typology.Classes.Typology_TTypology,TTypologyItem_,bool).TTypologyItem'></a>

`TTypologyItem`

The typology item type\.
#### Parameters

<a name='DiGi.Typology.Query.TypologyPaths_TTypology,TTypologyItem_(thisDiGi.Typology.Classes.Typology_TTypology,TTypologyItem_,bool).typology'></a>

`typology` [DiGi\.Typology\.Classes\.Typology&lt;](DiGi.Typology.Classes.md#DiGi.Typology.Classes.Typology_TTypology,TTypologyItem_ 'DiGi\.Typology\.Classes\.Typology\<TTypology,TTypologyItem\>')[TTypology](DiGi.Typology.md#DiGi.Typology.Query.TypologyPaths_TTypology,TTypologyItem_(thisDiGi.Typology.Classes.Typology_TTypology,TTypologyItem_,bool).TTypology 'DiGi\.Typology\.Query\.TypologyPaths\<TTypology,TTypologyItem\>\(this DiGi\.Typology\.Classes\.Typology\<TTypology,TTypologyItem\>, bool\)\.TTypology')[,](DiGi.Typology.Classes.md#DiGi.Typology.Classes.Typology_TTypology,TTypologyItem_ 'DiGi\.Typology\.Classes\.Typology\<TTypology,TTypologyItem\>')[TTypologyItem](DiGi.Typology.md#DiGi.Typology.Query.TypologyPaths_TTypology,TTypologyItem_(thisDiGi.Typology.Classes.Typology_TTypology,TTypologyItem_,bool).TTypologyItem 'DiGi\.Typology\.Query\.TypologyPaths\<TTypology,TTypologyItem\>\(this DiGi\.Typology\.Classes\.Typology\<TTypology,TTypologyItem\>, bool\)\.TTypologyItem')[&gt;](DiGi.Typology.Classes.md#DiGi.Typology.Classes.Typology_TTypology,TTypologyItem_ 'DiGi\.Typology\.Classes\.Typology\<TTypology,TTypologyItem\>')

The typology whose sub\-typology paths are collected\.

<a name='DiGi.Typology.Query.TypologyPaths_TTypology,TTypologyItem_(thisDiGi.Typology.Classes.Typology_TTypology,TTypologyItem_,bool).includeNested'></a>

`includeNested` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A value indicating whether to recursively retrieve paths from nested typologies\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[TypologyPath](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyPath 'DiGi\.Typology\.Classes\.TypologyPath')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1') of [TypologyPath](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyPath 'DiGi\.Typology\.Classes\.TypologyPath') objects, empty when no sub\-typologies exist\.