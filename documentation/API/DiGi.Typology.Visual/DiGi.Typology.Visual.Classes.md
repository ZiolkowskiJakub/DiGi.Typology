#### [DiGi\.Typology\.Visual](DiGi.Typology.Visual.Overview.md 'DiGi\.Typology\.Visual\.Overview')

## DiGi\.Typology\.Visual\.Classes Namespace
### Classes

<a name='DiGi.Typology.Visual.Classes.TypologyAppearance'></a>

## TypologyAppearance Class

The appearance of one typology bucket or node: a set of shape appearances, one per kind, such as a
[DiGi\.Geometry\.Visual\.Core\.Classes\.FaceAppearance](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.visual.core.classes.faceappearance 'DiGi\.Geometry\.Visual\.Core\.Classes\.FaceAppearance') for faces and a
[DiGi\.Geometry\.Visual\.Core\.Classes\.CurveAppearance](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.visual.core.classes.curveappearance 'DiGi\.Geometry\.Visual\.Core\.Classes\.CurveAppearance') for curves\.

This is a container of [DiGi\.Geometry\.Visual\.Core\.Interfaces\.IAppearance](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.visual.core.interfaces.iappearance 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IAppearance') instances, not an appearance itself. Each is filed under
            its exact runtime type and matched exactly: with only a `CurveAppearance` filed, asking for a
            `PointAppearance` yields null even though the former derives from the latter, because an assignable-to
            lookup could answer with either of two filed kinds.

The serialized form lists the appearances in the ordinal order of their type names whatever order they
            were filed in, so two containers holding the same appearances serialize identically.

```csharp
public class TypologyAppearance : DiGi.Core.Classes.SerializableObject, DiGi.Typology.Visual.Interfaces.ITypologyVisualSerializableObject, DiGi.Typology.Visual.Interfaces.ITypologyVisualObject, DiGi.Typology.Interfaces.ITypologyObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → TypologyAppearance

Implements [ITypologyVisualSerializableObject](DiGi.Typology.Visual.Interfaces.md#DiGi.Typology.Visual.Interfaces.ITypologyVisualSerializableObject 'DiGi\.Typology\.Visual\.Interfaces\.ITypologyVisualSerializableObject'), [ITypologyVisualObject](DiGi.Typology.Visual.Interfaces.md#DiGi.Typology.Visual.Interfaces.ITypologyVisualObject 'DiGi\.Typology\.Visual\.Interfaces\.ITypologyVisualObject'), [DiGi\.Typology\.Interfaces\.ITypologyObject](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.interfaces.itypologyobject 'DiGi\.Typology\.Interfaces\.ITypologyObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject')
### Constructors

<a name='DiGi.Typology.Visual.Classes.TypologyAppearance.TypologyAppearance()'></a>

## TypologyAppearance\(\) Constructor

Initializes a new, empty instance of the [TypologyAppearance](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.TypologyAppearance 'DiGi\.Typology\.Visual\.Classes\.TypologyAppearance') class\.

```csharp
public TypologyAppearance();
```

<a name='DiGi.Typology.Visual.Classes.TypologyAppearance.TypologyAppearance(DiGi.Typology.Visual.Classes.TypologyAppearance)'></a>

## TypologyAppearance\(TypologyAppearance\) Constructor

Initializes a new instance of the [TypologyAppearance](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.TypologyAppearance 'DiGi\.Typology\.Visual\.Classes\.TypologyAppearance') class by copying another instance: every
appearance is cloned\.

```csharp
public TypologyAppearance(DiGi.Typology.Visual.Classes.TypologyAppearance? typologyAppearance);
```
#### Parameters

<a name='DiGi.Typology.Visual.Classes.TypologyAppearance.TypologyAppearance(DiGi.Typology.Visual.Classes.TypologyAppearance).typologyAppearance'></a>

`typologyAppearance` [TypologyAppearance](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.TypologyAppearance 'DiGi\.Typology\.Visual\.Classes\.TypologyAppearance')

The source appearance to copy\.

<a name='DiGi.Typology.Visual.Classes.TypologyAppearance.TypologyAppearance(System.Collections.Generic.IEnumerable_DiGi.Geometry.Visual.Core.Interfaces.IAppearance_)'></a>

## TypologyAppearance\(IEnumerable\<IAppearance\>\) Constructor

Initializes a new instance of the [TypologyAppearance](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.TypologyAppearance 'DiGi\.Typology\.Visual\.Classes\.TypologyAppearance') class filing the given appearances\.

The instances are filed as given, not cloned; where two share a runtime type the later one wins.

```csharp
public TypologyAppearance(System.Collections.Generic.IEnumerable<DiGi.Geometry.Visual.Core.Interfaces.IAppearance?>? appearances);
```
#### Parameters

<a name='DiGi.Typology.Visual.Classes.TypologyAppearance.TypologyAppearance(System.Collections.Generic.IEnumerable_DiGi.Geometry.Visual.Core.Interfaces.IAppearance_).appearances'></a>

`appearances` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.Geometry\.Visual\.Core\.Interfaces\.IAppearance](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.visual.core.interfaces.iappearance 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IAppearance')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The appearances to file; null entries are skipped\.

<a name='DiGi.Typology.Visual.Classes.TypologyAppearance.TypologyAppearance(System.Text.Json.Nodes.JsonObject)'></a>

## TypologyAppearance\(JsonObject\) Constructor

Initializes a new instance of the [TypologyAppearance](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.TypologyAppearance 'DiGi\.Typology\.Visual\.Classes\.TypologyAppearance') class from a JSON object\.

```csharp
public TypologyAppearance(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Typology.Visual.Classes.TypologyAppearance.TypologyAppearance(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the appearance data\.
### Properties

<a name='DiGi.Typology.Visual.Classes.TypologyAppearance.Count'></a>

## TypologyAppearance\.Count Property

Gets the number of appearances filed\.

```csharp
public int Count { get; }
```

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

<a name='DiGi.Typology.Visual.Classes.TypologyAppearance.this[System.Type]'></a>

## TypologyAppearance\.this\[Type\] Property

Gets the appearance filed under exactly the given runtime type, or null when there is none\.

```csharp
public DiGi.Geometry.Visual.Core.Interfaces.IAppearance? this[System.Type? type] { get; }
```
#### Parameters

<a name='DiGi.Typology.Visual.Classes.TypologyAppearance.this[System.Type].type'></a>

`type` [System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')

The runtime type of the appearance\.

#### Property Value
[DiGi\.Geometry\.Visual\.Core\.Interfaces\.IAppearance](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.visual.core.interfaces.iappearance 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IAppearance')

<a name='DiGi.Typology.Visual.Classes.TypologyAppearance.Types'></a>

## TypologyAppearance\.Types Property

Gets the runtime types of the appearances filed, in the ordinal order of their full names\. A new list is
built on every call\.

```csharp
public System.Collections.Generic.List<System.Type> Types { get; }
```

#### Property Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')
### Methods

<a name='DiGi.Typology.Visual.Classes.TypologyAppearance.Add(DiGi.Geometry.Visual.Core.Interfaces.IAppearance)'></a>

## TypologyAppearance\.Add\(IAppearance\) Method

Files an appearance under its runtime type, replacing the one already filed under that type\.

```csharp
public bool Add(DiGi.Geometry.Visual.Core.Interfaces.IAppearance? appearance);
```
#### Parameters

<a name='DiGi.Typology.Visual.Classes.TypologyAppearance.Add(DiGi.Geometry.Visual.Core.Interfaces.IAppearance).appearance'></a>

`appearance` [DiGi\.Geometry\.Visual\.Core\.Interfaces\.IAppearance](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.visual.core.interfaces.iappearance 'DiGi\.Geometry\.Visual\.Core\.Interfaces\.IAppearance')

The appearance to file\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the appearance was filed; otherwise, false \(null\)\.

<a name='DiGi.Typology.Visual.Classes.TypologyAppearance.Contains(System.Type)'></a>

## TypologyAppearance\.Contains\(Type\) Method

Determines whether an appearance is filed under exactly the given runtime type\.

```csharp
public bool Contains(System.Type? type);
```
#### Parameters

<a name='DiGi.Typology.Visual.Classes.TypologyAppearance.Contains(System.Type).type'></a>

`type` [System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')

The runtime type of the appearance\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if an appearance is filed under the type; otherwise, false \(absent or null\)\.

<a name='DiGi.Typology.Visual.Classes.TypologyAppearance.Remove(System.Type)'></a>

## TypologyAppearance\.Remove\(Type\) Method

Removes the appearance filed under exactly the given runtime type\.

```csharp
public bool Remove(System.Type? type);
```
#### Parameters

<a name='DiGi.Typology.Visual.Classes.TypologyAppearance.Remove(System.Type).type'></a>

`type` [System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')

The runtime type of the appearance\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if an appearance was removed; otherwise, false \(absent or null\)\.

<a name='DiGi.Typology.Visual.Classes.TypologyAppearanceCollection'></a>

## TypologyAppearanceCollection Class

A collection of [TypologyAppearance](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.TypologyAppearance 'DiGi\.Typology\.Visual\.Classes\.TypologyAppearance'), one per bucket, filed under the key [Key\(this object\)](DiGi.Typology.Visual.md#DiGi.Typology.Visual.Query.Key(thisobject) 'DiGi\.Typology\.Visual\.Query\.Key\(this object\)')
renders for the bucket's value or range\.

The indexer performs that normalisation, so `[2010]`, `["2010"]`, `[2010L]` and
            `[uniqueValueRuleData]` address the same entry. Keys are not kept as [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object'): a JSON round trip
            turns every key into a string, and a boxed number does not compare equal to its string form or to the same number
            of another width.

Two values get the same key exactly when they are [System\.Object\.Equals\(System\.Object\)](https://learn.microsoft.com/en-us/dotnet/api/system.object.equals#system-object-equals(system-object) 'System\.Object\.Equals\(System\.Object\)')-equal, which is how
            [DiGi\.Typology\.Classes\.UniqueValueRuleData](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.classes.uniquevalueruledata 'DiGi\.Typology\.Classes\.UniqueValueRuleData') buckets them; see [Key\(this object\)](DiGi.Typology.Visual.md#DiGi.Typology.Visual.Query.Key(thisobject) 'DiGi\.Typology\.Visual\.Query\.Key\(this object\)') for the forms, the range
            form included. Two limitations are inherent: a text value that is literally `"null"` shares the key of the
            NULL bucket, and floating-point keys are not guaranteed across a .NET Framework host, whose
            `double.ToString` differs - use a range rule for floating-point columns.

```csharp
public class TypologyAppearanceCollection : DiGi.Core.Classes.SerializableObject, DiGi.Typology.Visual.Interfaces.ITypologyVisualSerializableObject, DiGi.Typology.Visual.Interfaces.ITypologyVisualObject, DiGi.Typology.Interfaces.ITypologyObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → TypologyAppearanceCollection

Implements [ITypologyVisualSerializableObject](DiGi.Typology.Visual.Interfaces.md#DiGi.Typology.Visual.Interfaces.ITypologyVisualSerializableObject 'DiGi\.Typology\.Visual\.Interfaces\.ITypologyVisualSerializableObject'), [ITypologyVisualObject](DiGi.Typology.Visual.Interfaces.md#DiGi.Typology.Visual.Interfaces.ITypologyVisualObject 'DiGi\.Typology\.Visual\.Interfaces\.ITypologyVisualObject'), [DiGi\.Typology\.Interfaces\.ITypologyObject](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.interfaces.itypologyobject 'DiGi\.Typology\.Interfaces\.ITypologyObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject')
### Constructors

<a name='DiGi.Typology.Visual.Classes.TypologyAppearanceCollection.TypologyAppearanceCollection()'></a>

## TypologyAppearanceCollection\(\) Constructor

Initializes a new, empty instance of the [TypologyAppearanceCollection](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.TypologyAppearanceCollection 'DiGi\.Typology\.Visual\.Classes\.TypologyAppearanceCollection') class\. Entries are filed
through the indexer\.

```csharp
public TypologyAppearanceCollection();
```

<a name='DiGi.Typology.Visual.Classes.TypologyAppearanceCollection.TypologyAppearanceCollection(DiGi.Typology.Visual.Classes.TypologyAppearanceCollection)'></a>

## TypologyAppearanceCollection\(TypologyAppearanceCollection\) Constructor

Initializes a new instance of the [TypologyAppearanceCollection](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.TypologyAppearanceCollection 'DiGi\.Typology\.Visual\.Classes\.TypologyAppearanceCollection') class by copying another
instance: every appearance is cloned under its key\.

```csharp
public TypologyAppearanceCollection(DiGi.Typology.Visual.Classes.TypologyAppearanceCollection? typologyAppearanceCollection);
```
#### Parameters

<a name='DiGi.Typology.Visual.Classes.TypologyAppearanceCollection.TypologyAppearanceCollection(DiGi.Typology.Visual.Classes.TypologyAppearanceCollection).typologyAppearanceCollection'></a>

`typologyAppearanceCollection` [TypologyAppearanceCollection](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.TypologyAppearanceCollection 'DiGi\.Typology\.Visual\.Classes\.TypologyAppearanceCollection')

The source collection to copy\.

<a name='DiGi.Typology.Visual.Classes.TypologyAppearanceCollection.TypologyAppearanceCollection(System.Text.Json.Nodes.JsonObject)'></a>

## TypologyAppearanceCollection\(JsonObject\) Constructor

Initializes a new instance of the [TypologyAppearanceCollection](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.TypologyAppearanceCollection 'DiGi\.Typology\.Visual\.Classes\.TypologyAppearanceCollection') class from a JSON object\.

```csharp
public TypologyAppearanceCollection(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Typology.Visual.Classes.TypologyAppearanceCollection.TypologyAppearanceCollection(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the collection data\.
### Properties

<a name='DiGi.Typology.Visual.Classes.TypologyAppearanceCollection.Appearances'></a>

## TypologyAppearanceCollection\.Appearances Property

Gets the appearances held, in no guaranteed order\. A new list is built on every call\.

```csharp
public System.Collections.Generic.List<DiGi.Typology.Visual.Classes.TypologyAppearance> Appearances { get; }
```

#### Property Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[TypologyAppearance](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.TypologyAppearance 'DiGi\.Typology\.Visual\.Classes\.TypologyAppearance')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

<a name='DiGi.Typology.Visual.Classes.TypologyAppearanceCollection.Count'></a>

## TypologyAppearanceCollection\.Count Property

Gets the number of appearances held\.

```csharp
public int Count { get; }
```

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

<a name='DiGi.Typology.Visual.Classes.TypologyAppearanceCollection.Keys'></a>

## TypologyAppearanceCollection\.Keys Property

Gets the keys that carry an appearance, in no guaranteed order\. A new list is built on every call\.

```csharp
public System.Collections.Generic.List<string> Keys { get; }
```

#### Property Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

<a name='DiGi.Typology.Visual.Classes.TypologyAppearanceCollection.this[object]'></a>

## TypologyAppearanceCollection\.this\[object\] Property

Gets or sets the appearance of the bucket the given value falls into\.

The value is normalised through [Key\(this object\)](DiGi.Typology.Visual.md#DiGi.Typology.Visual.Query.Key(thisobject) 'DiGi\.Typology\.Visual\.Query\.Key\(this object\)'), so any value type is accepted: `null`
            addresses the NULL bucket, a number its invariant text form whatever its width, a range its bounds, and rule
            data the bucket it was produced for. The getter returns null when no appearance is filed for the
            value; assigning null removes the entry.

```csharp
public DiGi.Typology.Visual.Classes.TypologyAppearance? this[object? @object] { get; set; }
```
#### Parameters

<a name='DiGi.Typology.Visual.Classes.TypologyAppearanceCollection.this[object].object'></a>

`object` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The value or range, its string form, or the rule data produced for it\.

#### Property Value
[TypologyAppearance](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.TypologyAppearance 'DiGi\.Typology\.Visual\.Classes\.TypologyAppearance')
### Methods

<a name='DiGi.Typology.Visual.Classes.TypologyAppearanceCollection.Contains(object)'></a>

## TypologyAppearanceCollection\.Contains\(object\) Method

Determines whether an appearance is filed for the given value\.

```csharp
public bool Contains(object? @object);
```
#### Parameters

<a name='DiGi.Typology.Visual.Classes.TypologyAppearanceCollection.Contains(object).object'></a>

`object` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The value or range, its string form, or the rule data produced for it\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if an appearance is filed for the value; otherwise, false\.

<a name='DiGi.Typology.Visual.Classes.VisualColumnTypologyFilter'></a>

## VisualColumnTypologyFilter Class

A concrete column\-based Visual typology filter using the standard [DiGi\.Core\.IO\.Table\.Classes\.Column](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.table.classes.column 'DiGi\.Core\.IO\.Table\.Classes\.Column') type\.

```csharp
public class VisualColumnTypologyFilter : DiGi.Typology.Visual.Classes.VisualColumnTypologyFilter<DiGi.Core.IO.Table.Classes.Column>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Typology\.Classes\.TypologyFilter&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.classes.typologyfilter-1 'DiGi\.Typology\.Classes\.TypologyFilter\`1')[DiGi\.Typology\.Visual\.Classes\.VisualColumnTypologyFilter&lt;](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualColumnTypologyFilter_UColumn_ 'DiGi\.Typology\.Visual\.Classes\.VisualColumnTypologyFilter\<UColumn\>')[DiGi\.Core\.IO\.Table\.Classes\.Column](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.table.classes.column 'DiGi\.Core\.IO\.Table\.Classes\.Column')[&gt;](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualColumnTypologyFilter_UColumn_ 'DiGi\.Typology\.Visual\.Classes\.VisualColumnTypologyFilter\<UColumn\>')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.classes.typologyfilter-1 'DiGi\.Typology\.Classes\.TypologyFilter\`1') → [DiGi\.Typology\.Classes\.TypologyFilter&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.classes.typologyfilter-2 'DiGi\.Typology\.Classes\.TypologyFilter\`2')[DiGi\.Typology\.Visual\.Classes\.VisualColumnTypologyFilter&lt;](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualColumnTypologyFilter_UColumn_ 'DiGi\.Typology\.Visual\.Classes\.VisualColumnTypologyFilter\<UColumn\>')[DiGi\.Core\.IO\.Table\.Classes\.Column](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.table.classes.column 'DiGi\.Core\.IO\.Table\.Classes\.Column')[&gt;](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualColumnTypologyFilter_UColumn_ 'DiGi\.Typology\.Visual\.Classes\.VisualColumnTypologyFilter\<UColumn\>')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.classes.typologyfilter-2 'DiGi\.Typology\.Classes\.TypologyFilter\`2')[DiGi\.Core\.IO\.Table\.Classes\.Column](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.table.classes.column 'DiGi\.Core\.IO\.Table\.Classes\.Column')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.classes.typologyfilter-2 'DiGi\.Typology\.Classes\.TypologyFilter\`2') → [DiGi\.Typology\.Visual\.Classes\.VisualColumnTypologyFilter&lt;](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualColumnTypologyFilter_UColumn_ 'DiGi\.Typology\.Visual\.Classes\.VisualColumnTypologyFilter\<UColumn\>')[DiGi\.Core\.IO\.Table\.Classes\.Column](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.table.classes.column 'DiGi\.Core\.IO\.Table\.Classes\.Column')[&gt;](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualColumnTypologyFilter_UColumn_ 'DiGi\.Typology\.Visual\.Classes\.VisualColumnTypologyFilter\<UColumn\>') → VisualColumnTypologyFilter
### Constructors

<a name='DiGi.Typology.Visual.Classes.VisualColumnTypologyFilter.VisualColumnTypologyFilter()'></a>

## VisualColumnTypologyFilter\(\) Constructor

Initializes a new instance of the [VisualColumnTypologyFilter](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualColumnTypologyFilter 'DiGi\.Typology\.Visual\.Classes\.VisualColumnTypologyFilter') class\.

```csharp
public VisualColumnTypologyFilter();
```

<a name='DiGi.Typology.Visual.Classes.VisualColumnTypologyFilter.VisualColumnTypologyFilter(DiGi.Typology.Visual.Classes.VisualColumnTypologyFilter)'></a>

## VisualColumnTypologyFilter\(VisualColumnTypologyFilter\) Constructor

Initializes a new instance of the [VisualColumnTypologyFilter](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualColumnTypologyFilter 'DiGi\.Typology\.Visual\.Classes\.VisualColumnTypologyFilter') class by copying another instance\.

```csharp
public VisualColumnTypologyFilter(DiGi.Typology.Visual.Classes.VisualColumnTypologyFilter? visualColumnTypologyFilter);
```
#### Parameters

<a name='DiGi.Typology.Visual.Classes.VisualColumnTypologyFilter.VisualColumnTypologyFilter(DiGi.Typology.Visual.Classes.VisualColumnTypologyFilter).visualColumnTypologyFilter'></a>

`visualColumnTypologyFilter` [VisualColumnTypologyFilter](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualColumnTypologyFilter 'DiGi\.Typology\.Visual\.Classes\.VisualColumnTypologyFilter')

The column typology filter to copy\.

<a name='DiGi.Typology.Visual.Classes.VisualColumnTypologyFilter.VisualColumnTypologyFilter(System.Text.Json.Nodes.JsonObject)'></a>

## VisualColumnTypologyFilter\(JsonObject\) Constructor

Initializes a new instance of the [VisualColumnTypologyFilter](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualColumnTypologyFilter 'DiGi\.Typology\.Visual\.Classes\.VisualColumnTypologyFilter') class from a JSON object\.

```csharp
public VisualColumnTypologyFilter(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Typology.Visual.Classes.VisualColumnTypologyFilter.VisualColumnTypologyFilter(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the filter data\.

<a name='DiGi.Typology.Visual.Classes.VisualColumnTypologyFilter_UColumn_'></a>

## VisualColumnTypologyFilter\<UColumn\> Class

The Visual counterpart of [DiGi\.Typology\.Classes\.ColumnTypologyFilter&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.classes.columntypologyfilter-1 'DiGi\.Typology\.Classes\.ColumnTypologyFilter\`1'): a filter level over a single column, held
in a typology so a client can render it\.

All behaviour is inherited from its base; this type only exposes the constructors and pins the level to the
            Visual family, so it is recognised by its `_type` discriminator in a serialized tree.

```csharp
public class VisualColumnTypologyFilter<UColumn> : DiGi.Typology.Classes.TypologyFilter<DiGi.Typology.Visual.Classes.VisualColumnTypologyFilter<UColumn>, UColumn>, DiGi.Typology.Visual.Interfaces.ITypologyVisualSerializableObject, DiGi.Typology.Visual.Interfaces.ITypologyVisualObject, DiGi.Typology.Interfaces.ITypologyObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject
    where UColumn : DiGi.Core.IO.Table.Interfaces.IColumn
```
#### Type parameters

<a name='DiGi.Typology.Visual.Classes.VisualColumnTypologyFilter_UColumn_.UColumn'></a>

`UColumn`

The column type implementing [DiGi\.Core\.IO\.Table\.Interfaces\.IColumn](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.table.interfaces.icolumn 'DiGi\.Core\.IO\.Table\.Interfaces\.IColumn')\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Typology\.Classes\.TypologyFilter&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.classes.typologyfilter-1 'DiGi\.Typology\.Classes\.TypologyFilter\`1')[DiGi\.Typology\.Visual\.Classes\.VisualColumnTypologyFilter&lt;](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualColumnTypologyFilter_UColumn_ 'DiGi\.Typology\.Visual\.Classes\.VisualColumnTypologyFilter\<UColumn\>')[UColumn](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualColumnTypologyFilter_UColumn_.UColumn 'DiGi\.Typology\.Visual\.Classes\.VisualColumnTypologyFilter\<UColumn\>\.UColumn')[&gt;](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualColumnTypologyFilter_UColumn_ 'DiGi\.Typology\.Visual\.Classes\.VisualColumnTypologyFilter\<UColumn\>')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.classes.typologyfilter-1 'DiGi\.Typology\.Classes\.TypologyFilter\`1') → [DiGi\.Typology\.Classes\.TypologyFilter&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.classes.typologyfilter-2 'DiGi\.Typology\.Classes\.TypologyFilter\`2')[DiGi\.Typology\.Visual\.Classes\.VisualColumnTypologyFilter&lt;](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualColumnTypologyFilter_UColumn_ 'DiGi\.Typology\.Visual\.Classes\.VisualColumnTypologyFilter\<UColumn\>')[UColumn](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualColumnTypologyFilter_UColumn_.UColumn 'DiGi\.Typology\.Visual\.Classes\.VisualColumnTypologyFilter\<UColumn\>\.UColumn')[&gt;](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualColumnTypologyFilter_UColumn_ 'DiGi\.Typology\.Visual\.Classes\.VisualColumnTypologyFilter\<UColumn\>')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.classes.typologyfilter-2 'DiGi\.Typology\.Classes\.TypologyFilter\`2')[UColumn](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualColumnTypologyFilter_UColumn_.UColumn 'DiGi\.Typology\.Visual\.Classes\.VisualColumnTypologyFilter\<UColumn\>\.UColumn')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.classes.typologyfilter-2 'DiGi\.Typology\.Classes\.TypologyFilter\`2') → VisualColumnTypologyFilter\<UColumn\>

Derived  
↳ [VisualColumnTypologyFilter](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualColumnTypologyFilter 'DiGi\.Typology\.Visual\.Classes\.VisualColumnTypologyFilter')

Implements [ITypologyVisualSerializableObject](DiGi.Typology.Visual.Interfaces.md#DiGi.Typology.Visual.Interfaces.ITypologyVisualSerializableObject 'DiGi\.Typology\.Visual\.Interfaces\.ITypologyVisualSerializableObject'), [ITypologyVisualObject](DiGi.Typology.Visual.Interfaces.md#DiGi.Typology.Visual.Interfaces.ITypologyVisualObject 'DiGi\.Typology\.Visual\.Interfaces\.ITypologyVisualObject'), [DiGi\.Typology\.Interfaces\.ITypologyObject](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.interfaces.itypologyobject 'DiGi\.Typology\.Interfaces\.ITypologyObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject')
### Constructors

<a name='DiGi.Typology.Visual.Classes.VisualColumnTypologyFilter_UColumn_.VisualColumnTypologyFilter()'></a>

## VisualColumnTypologyFilter\(\) Constructor

Initializes a new instance of the [VisualColumnTypologyFilter&lt;UColumn&gt;](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualColumnTypologyFilter_UColumn_ 'DiGi\.Typology\.Visual\.Classes\.VisualColumnTypologyFilter\<UColumn\>') class\.

```csharp
public VisualColumnTypologyFilter();
```

<a name='DiGi.Typology.Visual.Classes.VisualColumnTypologyFilter_UColumn_.VisualColumnTypologyFilter(DiGi.Typology.Visual.Classes.VisualColumnTypologyFilter_UColumn_)'></a>

## VisualColumnTypologyFilter\(VisualColumnTypologyFilter\<UColumn\>\) Constructor

Initializes a new instance of the [VisualColumnTypologyFilter&lt;UColumn&gt;](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualColumnTypologyFilter_UColumn_ 'DiGi\.Typology\.Visual\.Classes\.VisualColumnTypologyFilter\<UColumn\>') class by copying another
instance\.

```csharp
public VisualColumnTypologyFilter(DiGi.Typology.Visual.Classes.VisualColumnTypologyFilter<UColumn>? visualColumnTypologyFilter);
```
#### Parameters

<a name='DiGi.Typology.Visual.Classes.VisualColumnTypologyFilter_UColumn_.VisualColumnTypologyFilter(DiGi.Typology.Visual.Classes.VisualColumnTypologyFilter_UColumn_).visualColumnTypologyFilter'></a>

`visualColumnTypologyFilter` [DiGi\.Typology\.Visual\.Classes\.VisualColumnTypologyFilter&lt;](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualColumnTypologyFilter_UColumn_ 'DiGi\.Typology\.Visual\.Classes\.VisualColumnTypologyFilter\<UColumn\>')[UColumn](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualColumnTypologyFilter_UColumn_.UColumn 'DiGi\.Typology\.Visual\.Classes\.VisualColumnTypologyFilter\<UColumn\>\.UColumn')[&gt;](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualColumnTypologyFilter_UColumn_ 'DiGi\.Typology\.Visual\.Classes\.VisualColumnTypologyFilter\<UColumn\>')

The column typology filter to copy\.

<a name='DiGi.Typology.Visual.Classes.VisualColumnTypologyFilter_UColumn_.VisualColumnTypologyFilter(System.Text.Json.Nodes.JsonObject)'></a>

## VisualColumnTypologyFilter\(JsonObject\) Constructor

Initializes a new instance of the [VisualColumnTypologyFilter&lt;UColumn&gt;](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualColumnTypologyFilter_UColumn_ 'DiGi\.Typology\.Visual\.Classes\.VisualColumnTypologyFilter\<UColumn\>') class from a JSON object\.

```csharp
public VisualColumnTypologyFilter(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Typology.Visual.Classes.VisualColumnTypologyFilter_UColumn_.VisualColumnTypologyFilter(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the filter data\.

<a name='DiGi.Typology.Visual.Classes.VisualDoubleRangeFilterRule'></a>

## VisualDoubleRangeFilterRule Class

A [VisualRangeValueFilterRule&lt;TValueType&gt;](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualRangeValueFilterRule_TValueType_ 'DiGi\.Typology\.Visual\.Classes\.VisualRangeValueFilterRule\<TValueType\>') for [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') ranges, carrying an appearance per
bucket\.

```csharp
public class VisualDoubleRangeFilterRule : DiGi.Typology.Visual.Classes.VisualRangeValueFilterRule<double>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Typology\.Classes\.TypologyFilterRule](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.classes.typologyfilterrule 'DiGi\.Typology\.Classes\.TypologyFilterRule') → [DiGi\.Typology\.Visual\.Classes\.VisualRangeValueFilterRule&lt;](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualRangeValueFilterRule_TValueType_ 'DiGi\.Typology\.Visual\.Classes\.VisualRangeValueFilterRule\<TValueType\>')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualRangeValueFilterRule_TValueType_ 'DiGi\.Typology\.Visual\.Classes\.VisualRangeValueFilterRule\<TValueType\>') → VisualDoubleRangeFilterRule
### Constructors

<a name='DiGi.Typology.Visual.Classes.VisualDoubleRangeFilterRule.VisualDoubleRangeFilterRule()'></a>

## VisualDoubleRangeFilterRule\(\) Constructor

Initializes a new, empty instance of the [VisualDoubleRangeFilterRule](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualDoubleRangeFilterRule 'DiGi\.Typology\.Visual\.Classes\.VisualDoubleRangeFilterRule') class; ranges and
appearances are filed afterwards\.

```csharp
public VisualDoubleRangeFilterRule();
```

<a name='DiGi.Typology.Visual.Classes.VisualDoubleRangeFilterRule.VisualDoubleRangeFilterRule(DiGi.Typology.Visual.Classes.VisualDoubleRangeFilterRule)'></a>

## VisualDoubleRangeFilterRule\(VisualDoubleRangeFilterRule\) Constructor

Initializes a new instance of the [VisualDoubleRangeFilterRule](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualDoubleRangeFilterRule 'DiGi\.Typology\.Visual\.Classes\.VisualDoubleRangeFilterRule') class by copying another instance,
its ranges included\.

```csharp
public VisualDoubleRangeFilterRule(DiGi.Typology.Visual.Classes.VisualDoubleRangeFilterRule visualDoubleRangeFilterRule);
```
#### Parameters

<a name='DiGi.Typology.Visual.Classes.VisualDoubleRangeFilterRule.VisualDoubleRangeFilterRule(DiGi.Typology.Visual.Classes.VisualDoubleRangeFilterRule).visualDoubleRangeFilterRule'></a>

`visualDoubleRangeFilterRule` [VisualDoubleRangeFilterRule](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualDoubleRangeFilterRule 'DiGi\.Typology\.Visual\.Classes\.VisualDoubleRangeFilterRule')

The source rule to copy\.

<a name='DiGi.Typology.Visual.Classes.VisualDoubleRangeFilterRule.VisualDoubleRangeFilterRule(System.Collections.Generic.IEnumerable_DiGi.Core.Classes.Range_double__)'></a>

## VisualDoubleRangeFilterRule\(IEnumerable\<Range\<double\>\>\) Constructor

Initializes a new instance of the [VisualDoubleRangeFilterRule](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualDoubleRangeFilterRule 'DiGi\.Typology\.Visual\.Classes\.VisualDoubleRangeFilterRule') class with a collection of ranges\.

```csharp
public VisualDoubleRangeFilterRule(System.Collections.Generic.IEnumerable<DiGi.Core.Classes.Range<double>>? ranges);
```
#### Parameters

<a name='DiGi.Typology.Visual.Classes.VisualDoubleRangeFilterRule.VisualDoubleRangeFilterRule(System.Collections.Generic.IEnumerable_DiGi.Core.Classes.Range_double__).ranges'></a>

`ranges` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.Core\.Classes\.Range&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of double ranges to assign\.

<a name='DiGi.Typology.Visual.Classes.VisualDoubleRangeFilterRule.VisualDoubleRangeFilterRule(System.Text.Json.Nodes.JsonObject)'></a>

## VisualDoubleRangeFilterRule\(JsonObject\) Constructor

Initializes a new instance of the [VisualDoubleRangeFilterRule](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualDoubleRangeFilterRule 'DiGi\.Typology\.Visual\.Classes\.VisualDoubleRangeFilterRule') class from a JSON object\.

```csharp
public VisualDoubleRangeFilterRule(System.Text.Json.Nodes.JsonObject jsonObject);
```
#### Parameters

<a name='DiGi.Typology.Visual.Classes.VisualDoubleRangeFilterRule.VisualDoubleRangeFilterRule(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the rule data\.

<a name='DiGi.Typology.Visual.Classes.VisualIntegerRangeFilterRule'></a>

## VisualIntegerRangeFilterRule Class

A [VisualRangeValueFilterRule&lt;TValueType&gt;](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualRangeValueFilterRule_TValueType_ 'DiGi\.Typology\.Visual\.Classes\.VisualRangeValueFilterRule\<TValueType\>') for [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32') ranges, carrying an appearance per
bucket\.

```csharp
public class VisualIntegerRangeFilterRule : DiGi.Typology.Visual.Classes.VisualRangeValueFilterRule<int>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Typology\.Classes\.TypologyFilterRule](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.classes.typologyfilterrule 'DiGi\.Typology\.Classes\.TypologyFilterRule') → [DiGi\.Typology\.Visual\.Classes\.VisualRangeValueFilterRule&lt;](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualRangeValueFilterRule_TValueType_ 'DiGi\.Typology\.Visual\.Classes\.VisualRangeValueFilterRule\<TValueType\>')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualRangeValueFilterRule_TValueType_ 'DiGi\.Typology\.Visual\.Classes\.VisualRangeValueFilterRule\<TValueType\>') → VisualIntegerRangeFilterRule
### Constructors

<a name='DiGi.Typology.Visual.Classes.VisualIntegerRangeFilterRule.VisualIntegerRangeFilterRule()'></a>

## VisualIntegerRangeFilterRule\(\) Constructor

Initializes a new, empty instance of the [VisualIntegerRangeFilterRule](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualIntegerRangeFilterRule 'DiGi\.Typology\.Visual\.Classes\.VisualIntegerRangeFilterRule') class; ranges and
appearances are filed afterwards\.

```csharp
public VisualIntegerRangeFilterRule();
```

<a name='DiGi.Typology.Visual.Classes.VisualIntegerRangeFilterRule.VisualIntegerRangeFilterRule(DiGi.Typology.Visual.Classes.VisualIntegerRangeFilterRule)'></a>

## VisualIntegerRangeFilterRule\(VisualIntegerRangeFilterRule\) Constructor

Initializes a new instance of the [VisualIntegerRangeFilterRule](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualIntegerRangeFilterRule 'DiGi\.Typology\.Visual\.Classes\.VisualIntegerRangeFilterRule') class by copying another instance,
its ranges included\.

```csharp
public VisualIntegerRangeFilterRule(DiGi.Typology.Visual.Classes.VisualIntegerRangeFilterRule visualIntegerRangeFilterRule);
```
#### Parameters

<a name='DiGi.Typology.Visual.Classes.VisualIntegerRangeFilterRule.VisualIntegerRangeFilterRule(DiGi.Typology.Visual.Classes.VisualIntegerRangeFilterRule).visualIntegerRangeFilterRule'></a>

`visualIntegerRangeFilterRule` [VisualIntegerRangeFilterRule](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualIntegerRangeFilterRule 'DiGi\.Typology\.Visual\.Classes\.VisualIntegerRangeFilterRule')

The source rule to copy\.

<a name='DiGi.Typology.Visual.Classes.VisualIntegerRangeFilterRule.VisualIntegerRangeFilterRule(System.Collections.Generic.IEnumerable_DiGi.Core.Classes.Range_int__)'></a>

## VisualIntegerRangeFilterRule\(IEnumerable\<Range\<int\>\>\) Constructor

Initializes a new instance of the [VisualIntegerRangeFilterRule](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualIntegerRangeFilterRule 'DiGi\.Typology\.Visual\.Classes\.VisualIntegerRangeFilterRule') class with a collection of ranges\.

```csharp
public VisualIntegerRangeFilterRule(System.Collections.Generic.IEnumerable<DiGi.Core.Classes.Range<int>>? ranges);
```
#### Parameters

<a name='DiGi.Typology.Visual.Classes.VisualIntegerRangeFilterRule.VisualIntegerRangeFilterRule(System.Collections.Generic.IEnumerable_DiGi.Core.Classes.Range_int__).ranges'></a>

`ranges` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.Core\.Classes\.Range&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of integer ranges to assign\.

<a name='DiGi.Typology.Visual.Classes.VisualIntegerRangeFilterRule.VisualIntegerRangeFilterRule(System.Text.Json.Nodes.JsonObject)'></a>

## VisualIntegerRangeFilterRule\(JsonObject\) Constructor

Initializes a new instance of the [VisualIntegerRangeFilterRule](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualIntegerRangeFilterRule 'DiGi\.Typology\.Visual\.Classes\.VisualIntegerRangeFilterRule') class from a JSON object\.

```csharp
public VisualIntegerRangeFilterRule(System.Text.Json.Nodes.JsonObject jsonObject);
```
#### Parameters

<a name='DiGi.Typology.Visual.Classes.VisualIntegerRangeFilterRule.VisualIntegerRangeFilterRule(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the rule data\.

<a name='DiGi.Typology.Visual.Classes.VisualRangeValueFilterRule_TValueType_'></a>

## VisualRangeValueFilterRule\<TValueType\> Class

A [DiGi\.Typology\.Classes\.RangeValueFilterRule&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.classes.rangevaluefilterrule-1 'DiGi\.Typology\.Classes\.RangeValueFilterRule\`1') that also carries the appearance of each of its buckets\.

Like its base it files its ranges keyed on [DiGi\.Core\.Classes\.Range&lt;&gt;\.Min](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1.min 'DiGi\.Core\.Classes\.Range\`1\.Min') and enumerates them in ascending
            `Min` order, so the order they were declared in does not affect which bucket a value resolves to; matching is
            a closed interval on both ends, so ranges that touch at a boundary both contain it and the lower one wins. The
            difference is the appearance: the base rule is stateless and a consumer reads it back off the matched range,
            whereas here each bucket's appearance is filed on the rule itself, in a [TypologyAppearanceCollection](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualRangeValueFilterRule_TValueType_.TypologyAppearanceCollection 'DiGi\.Typology\.Visual\.Classes\.VisualRangeValueFilterRule\<TValueType\>\.TypologyAppearanceCollection')
            keyed by the range (see [Key\(this object\)](DiGi.Typology.Visual.md#DiGi.Typology.Visual.Query.Key(thisobject) 'DiGi\.Typology\.Visual\.Query\.Key\(this object\)')), so it survives a round trip, and
            [RuleData\(object\)](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualRangeValueFilterRule_TValueType_.RuleData(object) 'DiGi\.Typology\.Visual\.Classes\.VisualRangeValueFilterRule\<TValueType\>\.RuleData\(object\)') hands it to the rule data it produces.

This rule does not derive from [DiGi\.Typology\.Classes\.RangeValueFilterRule&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.classes.rangevaluefilterrule-1 'DiGi\.Typology\.Classes\.RangeValueFilterRule\`1'):
            [DiGi\.Typology\.Query\.RuleData\(DiGi\.Typology\.Interfaces\.ITypologyFilterRule,System\.Object\)](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.query.ruledata#digi-typology-query-ruledata(digi-typology-interfaces-itypologyfilterrule-system-object) 'DiGi\.Typology\.Query\.RuleData\(DiGi\.Typology\.Interfaces\.ITypologyFilterRule,System\.Object\)') binds `RuleData` by name through
            reflection, so hiding the base method to change its return type is not an option.

```csharp
public abstract class VisualRangeValueFilterRule<TValueType> : DiGi.Typology.Classes.TypologyFilterRule, DiGi.Typology.Visual.Interfaces.IVisualTypologyFilterRule, DiGi.Typology.Visual.Interfaces.ITypologyVisualSerializableObject, DiGi.Typology.Visual.Interfaces.ITypologyVisualObject, DiGi.Typology.Interfaces.ITypologyObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Typology.Interfaces.ITypologyFilterRule, DiGi.Typology.Interfaces.ITypologySerializableObject, DiGi.Typology.Interfaces.ITypologyFilterRule<DiGi.Typology.Visual.Classes.VisualRangeValueRuleData<TValueType>>
    where TValueType : System.IComparable<TValueType>
```
#### Type parameters

<a name='DiGi.Typology.Visual.Classes.VisualRangeValueFilterRule_TValueType_.TValueType'></a>

`TValueType`

The type of the range values, which must implement [System\.IComparable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.icomparable-1 'System\.IComparable\`1')\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Typology\.Classes\.TypologyFilterRule](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.classes.typologyfilterrule 'DiGi\.Typology\.Classes\.TypologyFilterRule') → VisualRangeValueFilterRule\<TValueType\>

Derived  
↳ [VisualDoubleRangeFilterRule](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualDoubleRangeFilterRule 'DiGi\.Typology\.Visual\.Classes\.VisualDoubleRangeFilterRule')  
↳ [VisualIntegerRangeFilterRule](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualIntegerRangeFilterRule 'DiGi\.Typology\.Visual\.Classes\.VisualIntegerRangeFilterRule')

Implements [IVisualTypologyFilterRule](DiGi.Typology.Visual.Interfaces.md#DiGi.Typology.Visual.Interfaces.IVisualTypologyFilterRule 'DiGi\.Typology\.Visual\.Interfaces\.IVisualTypologyFilterRule'), [ITypologyVisualSerializableObject](DiGi.Typology.Visual.Interfaces.md#DiGi.Typology.Visual.Interfaces.ITypologyVisualSerializableObject 'DiGi\.Typology\.Visual\.Interfaces\.ITypologyVisualSerializableObject'), [ITypologyVisualObject](DiGi.Typology.Visual.Interfaces.md#DiGi.Typology.Visual.Interfaces.ITypologyVisualObject 'DiGi\.Typology\.Visual\.Interfaces\.ITypologyVisualObject'), [DiGi\.Typology\.Interfaces\.ITypologyObject](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.interfaces.itypologyobject 'DiGi\.Typology\.Interfaces\.ITypologyObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Typology\.Interfaces\.ITypologyFilterRule](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.interfaces.itypologyfilterrule 'DiGi\.Typology\.Interfaces\.ITypologyFilterRule'), [DiGi\.Typology\.Interfaces\.ITypologySerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.interfaces.itypologyserializableobject 'DiGi\.Typology\.Interfaces\.ITypologySerializableObject'), [DiGi\.Typology\.Interfaces\.ITypologyFilterRule&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.interfaces.itypologyfilterrule-1 'DiGi\.Typology\.Interfaces\.ITypologyFilterRule\`1')[DiGi\.Typology\.Visual\.Classes\.VisualRangeValueRuleData&lt;](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualRangeValueRuleData_TValueType_ 'DiGi\.Typology\.Visual\.Classes\.VisualRangeValueRuleData\<TValueType\>')[TValueType](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualRangeValueFilterRule_TValueType_.TValueType 'DiGi\.Typology\.Visual\.Classes\.VisualRangeValueFilterRule\<TValueType\>\.TValueType')[&gt;](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualRangeValueRuleData_TValueType_ 'DiGi\.Typology\.Visual\.Classes\.VisualRangeValueRuleData\<TValueType\>')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.interfaces.itypologyfilterrule-1 'DiGi\.Typology\.Interfaces\.ITypologyFilterRule\`1')
### Constructors

<a name='DiGi.Typology.Visual.Classes.VisualRangeValueFilterRule_TValueType_.VisualRangeValueFilterRule()'></a>

## VisualRangeValueFilterRule\(\) Constructor

Initializes a new, empty instance of the [VisualRangeValueFilterRule&lt;TValueType&gt;](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualRangeValueFilterRule_TValueType_ 'DiGi\.Typology\.Visual\.Classes\.VisualRangeValueFilterRule\<TValueType\>') class; ranges
and appearances are filed through [Ranges](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualRangeValueFilterRule_TValueType_.Ranges 'DiGi\.Typology\.Visual\.Classes\.VisualRangeValueFilterRule\<TValueType\>\.Ranges') and [TypologyAppearanceCollection](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualRangeValueFilterRule_TValueType_.TypologyAppearanceCollection 'DiGi\.Typology\.Visual\.Classes\.VisualRangeValueFilterRule\<TValueType\>\.TypologyAppearanceCollection')\.

```csharp
public VisualRangeValueFilterRule();
```

<a name='DiGi.Typology.Visual.Classes.VisualRangeValueFilterRule_TValueType_.VisualRangeValueFilterRule(DiGi.Typology.Visual.Classes.VisualRangeValueFilterRule_TValueType_)'></a>

## VisualRangeValueFilterRule\(VisualRangeValueFilterRule\<TValueType\>\) Constructor

Initializes a new instance of the [VisualRangeValueFilterRule&lt;TValueType&gt;](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualRangeValueFilterRule_TValueType_ 'DiGi\.Typology\.Visual\.Classes\.VisualRangeValueFilterRule\<TValueType\>') class by copying another
instance: every range is cloned under its minimum and the appearances are cloned under their keys\.

```csharp
public VisualRangeValueFilterRule(DiGi.Typology.Visual.Classes.VisualRangeValueFilterRule<TValueType> visualRangeValueFilterRule);
```
#### Parameters

<a name='DiGi.Typology.Visual.Classes.VisualRangeValueFilterRule_TValueType_.VisualRangeValueFilterRule(DiGi.Typology.Visual.Classes.VisualRangeValueFilterRule_TValueType_).visualRangeValueFilterRule'></a>

`visualRangeValueFilterRule` [DiGi\.Typology\.Visual\.Classes\.VisualRangeValueFilterRule&lt;](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualRangeValueFilterRule_TValueType_ 'DiGi\.Typology\.Visual\.Classes\.VisualRangeValueFilterRule\<TValueType\>')[TValueType](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualRangeValueFilterRule_TValueType_.TValueType 'DiGi\.Typology\.Visual\.Classes\.VisualRangeValueFilterRule\<TValueType\>\.TValueType')[&gt;](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualRangeValueFilterRule_TValueType_ 'DiGi\.Typology\.Visual\.Classes\.VisualRangeValueFilterRule\<TValueType\>')

The source rule to copy\.

<a name='DiGi.Typology.Visual.Classes.VisualRangeValueFilterRule_TValueType_.VisualRangeValueFilterRule(System.Collections.Generic.IEnumerable_DiGi.Core.Classes.Range_TValueType__)'></a>

## VisualRangeValueFilterRule\(IEnumerable\<Range\<TValueType\>\>\) Constructor

Initializes a new instance of the [VisualRangeValueFilterRule&lt;TValueType&gt;](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualRangeValueFilterRule_TValueType_ 'DiGi\.Typology\.Visual\.Classes\.VisualRangeValueFilterRule\<TValueType\>') class with a collection
of ranges\.

```csharp
public VisualRangeValueFilterRule(System.Collections.Generic.IEnumerable<DiGi.Core.Classes.Range<TValueType>>? ranges);
```
#### Parameters

<a name='DiGi.Typology.Visual.Classes.VisualRangeValueFilterRule_TValueType_.VisualRangeValueFilterRule(System.Collections.Generic.IEnumerable_DiGi.Core.Classes.Range_TValueType__).ranges'></a>

`ranges` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.Core\.Classes\.Range&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[TValueType](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualRangeValueFilterRule_TValueType_.TValueType 'DiGi\.Typology\.Visual\.Classes\.VisualRangeValueFilterRule\<TValueType\>\.TValueType')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The ranges to file; null entries are skipped\.

<a name='DiGi.Typology.Visual.Classes.VisualRangeValueFilterRule_TValueType_.VisualRangeValueFilterRule(System.Text.Json.Nodes.JsonObject)'></a>

## VisualRangeValueFilterRule\(JsonObject\) Constructor

Initializes a new instance of the [VisualRangeValueFilterRule&lt;TValueType&gt;](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualRangeValueFilterRule_TValueType_ 'DiGi\.Typology\.Visual\.Classes\.VisualRangeValueFilterRule\<TValueType\>') class from a JSON object\.

```csharp
public VisualRangeValueFilterRule(System.Text.Json.Nodes.JsonObject jsonObject);
```
#### Parameters

<a name='DiGi.Typology.Visual.Classes.VisualRangeValueFilterRule_TValueType_.VisualRangeValueFilterRule(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the rule data\.
### Properties

<a name='DiGi.Typology.Visual.Classes.VisualRangeValueFilterRule_TValueType_.Ranges'></a>

## VisualRangeValueFilterRule\<TValueType\>\.Ranges Property

Gets or sets the ranges of this rule, enumerated in ascending [DiGi\.Core\.Classes\.Range&lt;&gt;\.Min](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1.min 'DiGi\.Core\.Classes\.Range\`1\.Min') order\. Assigning a
sequence replaces the current ranges; null clears them\.

```csharp
public System.Collections.Generic.IEnumerable<DiGi.Core.Classes.Range<TValueType>> Ranges { get; set; }
```

#### Property Value
[System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.Core\.Classes\.Range&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[TValueType](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualRangeValueFilterRule_TValueType_.TValueType 'DiGi\.Typology\.Visual\.Classes\.VisualRangeValueFilterRule\<TValueType\>\.TValueType')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

<a name='DiGi.Typology.Visual.Classes.VisualRangeValueFilterRule_TValueType_.TypologyAppearanceCollection'></a>

## VisualRangeValueFilterRule\<TValueType\>\.TypologyAppearanceCollection Property

Gets the appearances of the buckets of this rule, keyed by range: file an entry as
`rule.TypologyAppearanceCollection[range] = appearance`\. Never null\.

```csharp
public DiGi.Typology.Visual.Classes.TypologyAppearanceCollection TypologyAppearanceCollection { get; }
```

Implements [TypologyAppearanceCollection](DiGi.Typology.Visual.Interfaces.md#DiGi.Typology.Visual.Interfaces.IVisualTypologyFilterRule.TypologyAppearanceCollection 'DiGi\.Typology\.Visual\.Interfaces\.IVisualTypologyFilterRule\.TypologyAppearanceCollection')

#### Property Value
[TypologyAppearanceCollection](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.TypologyAppearanceCollection 'DiGi\.Typology\.Visual\.Classes\.TypologyAppearanceCollection')
### Methods

<a name='DiGi.Typology.Visual.Classes.VisualRangeValueFilterRule_TValueType_.Add(DiGi.Core.Classes.Range_TValueType_)'></a>

## VisualRangeValueFilterRule\<TValueType\>\.Add\(Range\<TValueType\>\) Method

Files a range under its [DiGi\.Core\.Classes\.Range&lt;&gt;\.Min](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1.min 'DiGi\.Core\.Classes\.Range\`1\.Min'), replacing any range already filed under that minimum\.

```csharp
public bool Add(DiGi.Core.Classes.Range<TValueType>? range);
```
#### Parameters

<a name='DiGi.Typology.Visual.Classes.VisualRangeValueFilterRule_TValueType_.Add(DiGi.Core.Classes.Range_TValueType_).range'></a>

`range` [DiGi\.Core\.Classes\.Range&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[TValueType](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualRangeValueFilterRule_TValueType_.TValueType 'DiGi\.Typology\.Visual\.Classes\.VisualRangeValueFilterRule\<TValueType\>\.TValueType')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')

The range to file\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the range was filed; otherwise, false \(null\)\.

<a name='DiGi.Typology.Visual.Classes.VisualRangeValueFilterRule_TValueType_.RuleData(object)'></a>

## VisualRangeValueFilterRule\<TValueType\>\.RuleData\(object\) Method

Resolves the value to the bucket it falls into and returns the rule data for that bucket\.

The value is converted to [TValueType](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualRangeValueFilterRule_TValueType_.TValueType 'DiGi\.Typology\.Visual\.Classes\.VisualRangeValueFilterRule\<TValueType\>\.TValueType') and matched against the ranges in ascending
            [DiGi\.Core\.Classes\.Range&lt;&gt;\.Min](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1.min 'DiGi\.Core\.Classes\.Range\`1\.Min') order; the first range that contains it wins. The rule data carries the appearance
            filed for that range in [TypologyAppearanceCollection](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualRangeValueFilterRule_TValueType_.TypologyAppearanceCollection 'DiGi\.Typology\.Visual\.Classes\.VisualRangeValueFilterRule\<TValueType\>\.TypologyAppearanceCollection'), by reference, or null when none is filed.

```csharp
public DiGi.Typology.Visual.Classes.VisualRangeValueRuleData<TValueType>? RuleData(object? object_Value);
```
#### Parameters

<a name='DiGi.Typology.Visual.Classes.VisualRangeValueFilterRule_TValueType_.RuleData(object).object_Value'></a>

`object_Value` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The value to match against the ranges\.

Implements [RuleData\(object\)](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.interfaces.itypologyfilterrule-1.ruledata#digi-typology-interfaces-itypologyfilterrule-1-ruledata(system-object) 'DiGi\.Typology\.Interfaces\.ITypologyFilterRule\`1\.RuleData\(System\.Object\)')

#### Returns
[DiGi\.Typology\.Visual\.Classes\.VisualRangeValueRuleData&lt;](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualRangeValueRuleData_TValueType_ 'DiGi\.Typology\.Visual\.Classes\.VisualRangeValueRuleData\<TValueType\>')[TValueType](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualRangeValueFilterRule_TValueType_.TValueType 'DiGi\.Typology\.Visual\.Classes\.VisualRangeValueFilterRule\<TValueType\>\.TValueType')[&gt;](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualRangeValueRuleData_TValueType_ 'DiGi\.Typology\.Visual\.Classes\.VisualRangeValueRuleData\<TValueType\>')  
The rule data wrapping the matched range and its appearance, or null when the value is not convertible or no range contains it\.

<a name='DiGi.Typology.Visual.Classes.VisualRangeValueRuleData_TValueType_'></a>

## VisualRangeValueRuleData\<TValueType\> Class

The resulting data for a [VisualRangeValueFilterRule&lt;TValueType&gt;](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualRangeValueFilterRule_TValueType_ 'DiGi\.Typology\.Visual\.Classes\.VisualRangeValueFilterRule\<TValueType\>'): the [DiGi\.Core\.Classes\.Range&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1') a value
fell into, together with the appearance of that bucket\.

The appearance is metadata, not identity: equality, ordering and the hash consider the
            [DiGi\.Core\.Classes\.Range&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1') alone (as in the base [DiGi\.Typology\.Classes\.RangeValueRuleData&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.classes.rangevalueruledata-1 'DiGi\.Typology\.Classes\.RangeValueRuleData\`1')), so two rule data
            instances are equal when they wrap equal ranges whatever they look like.

```csharp
public class VisualRangeValueRuleData<TValueType> : DiGi.Typology.Classes.TypologyFilterRuleData<DiGi.Typology.Visual.Classes.VisualRangeValueRuleData<TValueType>>, DiGi.Typology.Visual.Interfaces.IVisualTypologyFilterRuleData, DiGi.Typology.Visual.Interfaces.ITypologyVisualSerializableObject, DiGi.Typology.Visual.Interfaces.ITypologyVisualObject, DiGi.Typology.Interfaces.ITypologyObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Typology.Interfaces.ITypologyFilterRuleData, DiGi.Typology.Interfaces.ITypologySerializableObject
```
#### Type parameters

<a name='DiGi.Typology.Visual.Classes.VisualRangeValueRuleData_TValueType_.TValueType'></a>

`TValueType`

The underlying type of the range values\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Typology\.Classes\.TypologyFilterRuleData&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.classes.typologyfilterruledata-1 'DiGi\.Typology\.Classes\.TypologyFilterRuleData\`1')[DiGi\.Typology\.Visual\.Classes\.VisualRangeValueRuleData&lt;](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualRangeValueRuleData_TValueType_ 'DiGi\.Typology\.Visual\.Classes\.VisualRangeValueRuleData\<TValueType\>')[TValueType](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualRangeValueRuleData_TValueType_.TValueType 'DiGi\.Typology\.Visual\.Classes\.VisualRangeValueRuleData\<TValueType\>\.TValueType')[&gt;](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualRangeValueRuleData_TValueType_ 'DiGi\.Typology\.Visual\.Classes\.VisualRangeValueRuleData\<TValueType\>')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.classes.typologyfilterruledata-1 'DiGi\.Typology\.Classes\.TypologyFilterRuleData\`1') → VisualRangeValueRuleData\<TValueType\>

Implements [IVisualTypologyFilterRuleData](DiGi.Typology.Visual.Interfaces.md#DiGi.Typology.Visual.Interfaces.IVisualTypologyFilterRuleData 'DiGi\.Typology\.Visual\.Interfaces\.IVisualTypologyFilterRuleData'), [ITypologyVisualSerializableObject](DiGi.Typology.Visual.Interfaces.md#DiGi.Typology.Visual.Interfaces.ITypologyVisualSerializableObject 'DiGi\.Typology\.Visual\.Interfaces\.ITypologyVisualSerializableObject'), [ITypologyVisualObject](DiGi.Typology.Visual.Interfaces.md#DiGi.Typology.Visual.Interfaces.ITypologyVisualObject 'DiGi\.Typology\.Visual\.Interfaces\.ITypologyVisualObject'), [DiGi\.Typology\.Interfaces\.ITypologyObject](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.interfaces.itypologyobject 'DiGi\.Typology\.Interfaces\.ITypologyObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Typology\.Interfaces\.ITypologyFilterRuleData](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.interfaces.itypologyfilterruledata 'DiGi\.Typology\.Interfaces\.ITypologyFilterRuleData'), [DiGi\.Typology\.Interfaces\.ITypologySerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.interfaces.itypologyserializableobject 'DiGi\.Typology\.Interfaces\.ITypologySerializableObject')
### Constructors

<a name='DiGi.Typology.Visual.Classes.VisualRangeValueRuleData_TValueType_.VisualRangeValueRuleData()'></a>

## VisualRangeValueRuleData\(\) Constructor

Initializes a new, empty instance of the [VisualRangeValueRuleData&lt;TValueType&gt;](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualRangeValueRuleData_TValueType_ 'DiGi\.Typology\.Visual\.Classes\.VisualRangeValueRuleData\<TValueType\>') class; the range
and the appearance are set afterwards\.

```csharp
public VisualRangeValueRuleData();
```

<a name='DiGi.Typology.Visual.Classes.VisualRangeValueRuleData_TValueType_.VisualRangeValueRuleData(DiGi.Core.Classes.Range_TValueType_,DiGi.Typology.Visual.Classes.TypologyAppearance)'></a>

## VisualRangeValueRuleData\(Range\<TValueType\>, TypologyAppearance\) Constructor

Initializes a new instance of the [VisualRangeValueRuleData&lt;TValueType&gt;](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualRangeValueRuleData_TValueType_ 'DiGi\.Typology\.Visual\.Classes\.VisualRangeValueRuleData\<TValueType\>') class wrapping a range and
an appearance\.

Both are stored as given, not cloned, so the caller retains ownership of the instances it passes.

```csharp
public VisualRangeValueRuleData(DiGi.Core.Classes.Range<TValueType>? range, DiGi.Typology.Visual.Classes.TypologyAppearance? appearance);
```
#### Parameters

<a name='DiGi.Typology.Visual.Classes.VisualRangeValueRuleData_TValueType_.VisualRangeValueRuleData(DiGi.Core.Classes.Range_TValueType_,DiGi.Typology.Visual.Classes.TypologyAppearance).range'></a>

`range` [DiGi\.Core\.Classes\.Range&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[TValueType](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualRangeValueRuleData_TValueType_.TValueType 'DiGi\.Typology\.Visual\.Classes\.VisualRangeValueRuleData\<TValueType\>\.TValueType')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')

The range the value fell into\.

<a name='DiGi.Typology.Visual.Classes.VisualRangeValueRuleData_TValueType_.VisualRangeValueRuleData(DiGi.Core.Classes.Range_TValueType_,DiGi.Typology.Visual.Classes.TypologyAppearance).appearance'></a>

`appearance` [TypologyAppearance](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.TypologyAppearance 'DiGi\.Typology\.Visual\.Classes\.TypologyAppearance')

The appearance of the bucket; may be null\.

<a name='DiGi.Typology.Visual.Classes.VisualRangeValueRuleData_TValueType_.VisualRangeValueRuleData(DiGi.Typology.Visual.Classes.VisualRangeValueRuleData_TValueType_)'></a>

## VisualRangeValueRuleData\(VisualRangeValueRuleData\<TValueType\>\) Constructor

Initializes a new instance of the [VisualRangeValueRuleData&lt;TValueType&gt;](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualRangeValueRuleData_TValueType_ 'DiGi\.Typology\.Visual\.Classes\.VisualRangeValueRuleData\<TValueType\>') class by copying another
instance: the range and the appearance are cloned\.

```csharp
public VisualRangeValueRuleData(DiGi.Typology.Visual.Classes.VisualRangeValueRuleData<TValueType> visualRangeValueRuleData);
```
#### Parameters

<a name='DiGi.Typology.Visual.Classes.VisualRangeValueRuleData_TValueType_.VisualRangeValueRuleData(DiGi.Typology.Visual.Classes.VisualRangeValueRuleData_TValueType_).visualRangeValueRuleData'></a>

`visualRangeValueRuleData` [DiGi\.Typology\.Visual\.Classes\.VisualRangeValueRuleData&lt;](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualRangeValueRuleData_TValueType_ 'DiGi\.Typology\.Visual\.Classes\.VisualRangeValueRuleData\<TValueType\>')[TValueType](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualRangeValueRuleData_TValueType_.TValueType 'DiGi\.Typology\.Visual\.Classes\.VisualRangeValueRuleData\<TValueType\>\.TValueType')[&gt;](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualRangeValueRuleData_TValueType_ 'DiGi\.Typology\.Visual\.Classes\.VisualRangeValueRuleData\<TValueType\>')

The source rule data to copy\.

<a name='DiGi.Typology.Visual.Classes.VisualRangeValueRuleData_TValueType_.VisualRangeValueRuleData(System.Text.Json.Nodes.JsonObject)'></a>

## VisualRangeValueRuleData\(JsonObject\) Constructor

Initializes a new instance of the [VisualRangeValueRuleData&lt;TValueType&gt;](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualRangeValueRuleData_TValueType_ 'DiGi\.Typology\.Visual\.Classes\.VisualRangeValueRuleData\<TValueType\>') class from a JSON object\.

```csharp
public VisualRangeValueRuleData(System.Text.Json.Nodes.JsonObject jsonObject);
```
#### Parameters

<a name='DiGi.Typology.Visual.Classes.VisualRangeValueRuleData_TValueType_.VisualRangeValueRuleData(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the rule data\.
### Properties

<a name='DiGi.Typology.Visual.Classes.VisualRangeValueRuleData_TValueType_.Appearance'></a>

## VisualRangeValueRuleData\<TValueType\>\.Appearance Property

Gets or sets the appearance of the bucket this rule data describes, or null when it has none\.

Rule data produced by a [VisualRangeValueFilterRule&lt;TValueType&gt;](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualRangeValueFilterRule_TValueType_ 'DiGi\.Typology\.Visual\.Classes\.VisualRangeValueFilterRule\<TValueType\>') shares the instance filed on
            the rule, so mutating it mutates the rule's entry.

```csharp
public DiGi.Typology.Visual.Classes.TypologyAppearance? Appearance { get; set; }
```

Implements [Appearance](DiGi.Typology.Visual.Interfaces.md#DiGi.Typology.Visual.Interfaces.IVisualTypologyFilterRuleData.Appearance 'DiGi\.Typology\.Visual\.Interfaces\.IVisualTypologyFilterRuleData\.Appearance')

#### Property Value
[TypologyAppearance](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.TypologyAppearance 'DiGi\.Typology\.Visual\.Classes\.TypologyAppearance')

<a name='DiGi.Typology.Visual.Classes.VisualRangeValueRuleData_TValueType_.Range'></a>

## VisualRangeValueRuleData\<TValueType\>\.Range Property

Gets the range the value fell into, or null when this instance wraps none\.

```csharp
public DiGi.Core.Classes.Range<TValueType>? Range { get; }
```

#### Property Value
[DiGi\.Core\.Classes\.Range&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[TValueType](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualRangeValueRuleData_TValueType_.TValueType 'DiGi\.Typology\.Visual\.Classes\.VisualRangeValueRuleData\<TValueType\>\.TValueType')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')
### Methods

<a name='DiGi.Typology.Visual.Classes.VisualRangeValueRuleData_TValueType_.Equals(DiGi.Typology.Visual.Classes.VisualRangeValueRuleData_TValueType_)'></a>

## VisualRangeValueRuleData\<TValueType\>\.Equals\(VisualRangeValueRuleData\<TValueType\>\) Method

Determines whether this instance and another range rule data wrap the same range; the appearance is not
considered\.

```csharp
public override bool Equals(DiGi.Typology.Visual.Classes.VisualRangeValueRuleData<TValueType> visualRangeValueRuleData);
```
#### Parameters

<a name='DiGi.Typology.Visual.Classes.VisualRangeValueRuleData_TValueType_.Equals(DiGi.Typology.Visual.Classes.VisualRangeValueRuleData_TValueType_).visualRangeValueRuleData'></a>

`visualRangeValueRuleData` [DiGi\.Typology\.Visual\.Classes\.VisualRangeValueRuleData&lt;](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualRangeValueRuleData_TValueType_ 'DiGi\.Typology\.Visual\.Classes\.VisualRangeValueRuleData\<TValueType\>')[TValueType](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualRangeValueRuleData_TValueType_.TValueType 'DiGi\.Typology\.Visual\.Classes\.VisualRangeValueRuleData\<TValueType\>\.TValueType')[&gt;](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualRangeValueRuleData_TValueType_ 'DiGi\.Typology\.Visual\.Classes\.VisualRangeValueRuleData\<TValueType\>')

The rule data to compare with this instance\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if both wrap equal ranges; otherwise, false\.

<a name='DiGi.Typology.Visual.Classes.VisualRangeValueRuleData_TValueType_.Equals(object)'></a>

## VisualRangeValueRuleData\<TValueType\>\.Equals\(object\) Method

Determines whether this instance and a specified object wrap the same range\.

```csharp
public override bool Equals(object? @object);
```
#### Parameters

<a name='DiGi.Typology.Visual.Classes.VisualRangeValueRuleData_TValueType_.Equals(object).object'></a>

`object` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The object to compare with this instance\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the object is a [VisualRangeValueRuleData&lt;TValueType&gt;](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualRangeValueRuleData_TValueType_ 'DiGi\.Typology\.Visual\.Classes\.VisualRangeValueRuleData\<TValueType\>') of equal range; otherwise, false\.

<a name='DiGi.Typology.Visual.Classes.VisualRangeValueRuleData_TValueType_.GetHashCode()'></a>

## VisualRangeValueRuleData\<TValueType\>\.GetHashCode\(\) Method

Returns the hash code for this instance, based on the range alone\.

```csharp
public override int GetHashCode();
```

#### Returns
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')  
A 32\-bit signed integer hash code\.

<a name='DiGi.Typology.Visual.Classes.VisualRangeValueRuleData_TValueType_.ToString()'></a>

## VisualRangeValueRuleData\<TValueType\>\.ToString\(\) Method

Returns a string representation of the range rule data\.

The range is rendered as a closed interval, `[min, max]`, matching the rule's closed-interval matching
            semantics on both ends.

```csharp
public override string ToString();
```

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
A string representation of the range\.

<a name='DiGi.Typology.Visual.Classes.VisualTypology'></a>

## VisualTypology Class

A typology tree whose nodes carry a [VisualTypologyItem](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualTypologyItem 'DiGi\.Typology\.Visual\.Classes\.VisualTypologyItem'), so each node has an appearance next to its
name and description\. All behaviour is inherited from [DiGi\.Typology\.Classes\.Typology&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.classes.typology-2 'DiGi\.Typology\.Classes\.Typology\`2'); this type
only exposes the constructors\.

```csharp
public class VisualTypology : DiGi.Typology.Classes.Typology<DiGi.Typology.Visual.Classes.VisualTypology, DiGi.Typology.Visual.Classes.VisualTypologyItem>, DiGi.Typology.Visual.Interfaces.ITypologyVisualSerializableObject, DiGi.Typology.Visual.Interfaces.ITypologyVisualObject, DiGi.Typology.Interfaces.ITypologyObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Typology\.Classes\.Typology&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.classes.typology-2 'DiGi\.Typology\.Classes\.Typology\`2')[VisualTypology](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualTypology 'DiGi\.Typology\.Visual\.Classes\.VisualTypology')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.classes.typology-2 'DiGi\.Typology\.Classes\.Typology\`2')[VisualTypologyItem](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualTypologyItem 'DiGi\.Typology\.Visual\.Classes\.VisualTypologyItem')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.classes.typology-2 'DiGi\.Typology\.Classes\.Typology\`2') → VisualTypology

Implements [ITypologyVisualSerializableObject](DiGi.Typology.Visual.Interfaces.md#DiGi.Typology.Visual.Interfaces.ITypologyVisualSerializableObject 'DiGi\.Typology\.Visual\.Interfaces\.ITypologyVisualSerializableObject'), [ITypologyVisualObject](DiGi.Typology.Visual.Interfaces.md#DiGi.Typology.Visual.Interfaces.ITypologyVisualObject 'DiGi\.Typology\.Visual\.Interfaces\.ITypologyVisualObject'), [DiGi\.Typology\.Interfaces\.ITypologyObject](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.interfaces.itypologyobject 'DiGi\.Typology\.Interfaces\.ITypologyObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject')
### Constructors

<a name='DiGi.Typology.Visual.Classes.VisualTypology.VisualTypology(DiGi.Typology.Visual.Classes.VisualTypology)'></a>

## VisualTypology\(VisualTypology\) Constructor

Initializes a new instance of the [VisualTypology](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualTypology 'DiGi\.Typology\.Visual\.Classes\.VisualTypology') class by cloning an existing typology\.

```csharp
public VisualTypology(DiGi.Typology.Visual.Classes.VisualTypology? visualTypology);
```
#### Parameters

<a name='DiGi.Typology.Visual.Classes.VisualTypology.VisualTypology(DiGi.Typology.Visual.Classes.VisualTypology).visualTypology'></a>

`visualTypology` [VisualTypology](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualTypology 'DiGi\.Typology\.Visual\.Classes\.VisualTypology')

The source typology to clone\.

<a name='DiGi.Typology.Visual.Classes.VisualTypology.VisualTypology(DiGi.Typology.Visual.Classes.VisualTypologyItem)'></a>

## VisualTypology\(VisualTypologyItem\) Constructor

Initializes a new instance of the [VisualTypology](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualTypology 'DiGi\.Typology\.Visual\.Classes\.VisualTypology') class with a specified typology item\.

Use [DiGi\.Typology\.Modify\.AddSubTypologies&lt;&gt;\.Typology\.Classes\.Typology\{&lt;&gt;\.Collections\.Generic\.IEnumerable\{&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.modify.addsubtypologies--2#digi-typology-modify-addsubtypologies--2(digi-typology-classes-typology{--0---1}-system-collections-generic-ienumerable{--0}) 'DiGi\.Typology\.Modify\.AddSubTypologies\`\`2\(DiGi\.Typology\.Classes\.Typology\{\`\`0,\`\`1\},System\.Collections\.Generic\.IEnumerable\{\`\`0\}\)')
            to file sub-typologies under it: filing each one resolves an index against the indexes already taken, which
            does not belong in a constructor.

```csharp
public VisualTypology(DiGi.Typology.Visual.Classes.VisualTypologyItem? visualTypologyItem);
```
#### Parameters

<a name='DiGi.Typology.Visual.Classes.VisualTypology.VisualTypology(DiGi.Typology.Visual.Classes.VisualTypologyItem).visualTypologyItem'></a>

`visualTypologyItem` [VisualTypologyItem](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualTypologyItem 'DiGi\.Typology\.Visual\.Classes\.VisualTypologyItem')

The typology item to assign; it is cloned\.

<a name='DiGi.Typology.Visual.Classes.VisualTypology.VisualTypology(string,string)'></a>

## VisualTypology\(string, string\) Constructor

Initializes a new instance of the [VisualTypology](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualTypology 'DiGi\.Typology\.Visual\.Classes\.VisualTypology') class with a specified name and description and
no appearance\.

```csharp
public VisualTypology(string? name, string? description);
```
#### Parameters

<a name='DiGi.Typology.Visual.Classes.VisualTypology.VisualTypology(string,string).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the typology\.

<a name='DiGi.Typology.Visual.Classes.VisualTypology.VisualTypology(string,string).description'></a>

`description` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The description of the typology\.

<a name='DiGi.Typology.Visual.Classes.VisualTypology.VisualTypology(System.Text.Json.Nodes.JsonObject)'></a>

## VisualTypology\(JsonObject\) Constructor

Initializes a new instance of the [VisualTypology](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualTypology 'DiGi\.Typology\.Visual\.Classes\.VisualTypology') class from a JSON object\.

```csharp
public VisualTypology(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Typology.Visual.Classes.VisualTypology.VisualTypology(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing typology data\.
### Methods

<a name='DiGi.Typology.Visual.Classes.VisualTypology.CreateNode(DiGi.Typology.Visual.Classes.VisualTypologyItem,DiGi.Typology.Classes.TypologyPath)'></a>

## VisualTypology\.CreateNode\(VisualTypologyItem, TypologyPath\) Method

Creates a [VisualTypology](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualTypology 'DiGi\.Typology\.Visual\.Classes\.VisualTypology') for the specified full path, taking the name, the description and the
appearance of the source item\.

```csharp
public override DiGi.Typology.Visual.Classes.VisualTypology CreateNode(DiGi.Typology.Visual.Classes.VisualTypologyItem? source, DiGi.Typology.Classes.TypologyPath? path);
```
#### Parameters

<a name='DiGi.Typology.Visual.Classes.VisualTypology.CreateNode(DiGi.Typology.Visual.Classes.VisualTypologyItem,DiGi.Typology.Classes.TypologyPath).source'></a>

`source` [VisualTypologyItem](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualTypologyItem 'DiGi\.Typology\.Visual\.Classes\.VisualTypologyItem')

The item to take the name, the description and the appearance from; null for an unnamed intermediate node\.

<a name='DiGi.Typology.Visual.Classes.VisualTypology.CreateNode(DiGi.Typology.Visual.Classes.VisualTypologyItem,DiGi.Typology.Classes.TypologyPath).path'></a>

`path` [DiGi\.Typology\.Classes\.TypologyPath](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.classes.typologypath 'DiGi\.Typology\.Classes\.TypologyPath')

The full path of the node to create\.

#### Returns
[VisualTypology](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualTypology 'DiGi\.Typology\.Visual\.Classes\.VisualTypology')  
The created typology\.

<a name='DiGi.Typology.Visual.Classes.VisualTypologyItem'></a>

## VisualTypologyItem Class

A [DiGi\.Typology\.Classes\.TypologyItem](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.classes.typologyitem 'DiGi\.Typology\.Classes\.TypologyItem') carrying the appearance of its node\.

The appearance is node metadata, not link data: like the name and the description it is settable, it
            survives [DiGi\.Typology\.Modify\.RemoveReferences&lt;&gt;\.Typology\.Classes\.Typology\{&lt;&gt;\.Boolean\)](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.modify.removereferences--2#digi-typology-modify-removereferences--2(digi-typology-classes-typology{--0---1}-system-boolean) 'DiGi\.Typology\.Modify\.RemoveReferences\`\`2\(DiGi\.Typology\.Classes\.Typology\{\`\`0,\`\`1\},System\.Boolean\)')
            and a re-sync of the references, and it takes part in equality, ordering and the hash. Appearances have no value
            equality of their own, so they are compared through their serialized form, which
            [TypologyAppearance](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.TypologyAppearance 'DiGi\.Typology\.Visual\.Classes\.TypologyAppearance') keeps canonical.

```csharp
public class VisualTypologyItem : DiGi.Typology.Classes.TypologyItem, DiGi.Typology.Visual.Interfaces.ITypologyVisualSerializableObject, DiGi.Typology.Visual.Interfaces.ITypologyVisualObject, DiGi.Typology.Interfaces.ITypologyObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Typology\.Classes\.TypologyItem](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.classes.typologyitem 'DiGi\.Typology\.Classes\.TypologyItem') → VisualTypologyItem

Implements [ITypologyVisualSerializableObject](DiGi.Typology.Visual.Interfaces.md#DiGi.Typology.Visual.Interfaces.ITypologyVisualSerializableObject 'DiGi\.Typology\.Visual\.Interfaces\.ITypologyVisualSerializableObject'), [ITypologyVisualObject](DiGi.Typology.Visual.Interfaces.md#DiGi.Typology.Visual.Interfaces.ITypologyVisualObject 'DiGi\.Typology\.Visual\.Interfaces\.ITypologyVisualObject'), [DiGi\.Typology\.Interfaces\.ITypologyObject](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.interfaces.itypologyobject 'DiGi\.Typology\.Interfaces\.ITypologyObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject')
### Constructors

<a name='DiGi.Typology.Visual.Classes.VisualTypologyItem.VisualTypologyItem()'></a>

## VisualTypologyItem\(\) Constructor

Initializes a new, empty instance of the [VisualTypologyItem](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualTypologyItem 'DiGi\.Typology\.Visual\.Classes\.VisualTypologyItem') class\.

```csharp
public VisualTypologyItem();
```

<a name='DiGi.Typology.Visual.Classes.VisualTypologyItem.VisualTypologyItem(DiGi.Typology.Classes.TypologyPath,DiGi.Typology.Visual.Classes.VisualTypologyItem)'></a>

## VisualTypologyItem\(TypologyPath, VisualTypologyItem\) Constructor

Initializes a new instance of the [VisualTypologyItem](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualTypologyItem 'DiGi\.Typology\.Visual\.Classes\.VisualTypologyItem') class using a specific typology path and
the name, description and appearance of another item\.

```csharp
public VisualTypologyItem(DiGi.Typology.Classes.TypologyPath? typologyPath, DiGi.Typology.Visual.Classes.VisualTypologyItem visualTypologyItem);
```
#### Parameters

<a name='DiGi.Typology.Visual.Classes.VisualTypologyItem.VisualTypologyItem(DiGi.Typology.Classes.TypologyPath,DiGi.Typology.Visual.Classes.VisualTypologyItem).typologyPath'></a>

`typologyPath` [DiGi\.Typology\.Classes\.TypologyPath](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.classes.typologypath 'DiGi\.Typology\.Classes\.TypologyPath')

The path to assign to this item\.

<a name='DiGi.Typology.Visual.Classes.VisualTypologyItem.VisualTypologyItem(DiGi.Typology.Classes.TypologyPath,DiGi.Typology.Visual.Classes.VisualTypologyItem).visualTypologyItem'></a>

`visualTypologyItem` [VisualTypologyItem](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualTypologyItem 'DiGi\.Typology\.Visual\.Classes\.VisualTypologyItem')

The source item to copy the name, the description and the appearance from\.

<a name='DiGi.Typology.Visual.Classes.VisualTypologyItem.VisualTypologyItem(DiGi.Typology.Classes.TypologyPath,string,string,DiGi.Typology.Visual.Classes.TypologyAppearance)'></a>

## VisualTypologyItem\(TypologyPath, string, string, TypologyAppearance\) Constructor

Initializes a new instance of the [VisualTypologyItem](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualTypologyItem 'DiGi\.Typology\.Visual\.Classes\.VisualTypologyItem') class using a typology path, a name, a
description and an appearance\.

```csharp
public VisualTypologyItem(DiGi.Typology.Classes.TypologyPath? typologyPath, string? name, string? description, DiGi.Typology.Visual.Classes.TypologyAppearance? appearance);
```
#### Parameters

<a name='DiGi.Typology.Visual.Classes.VisualTypologyItem.VisualTypologyItem(DiGi.Typology.Classes.TypologyPath,string,string,DiGi.Typology.Visual.Classes.TypologyAppearance).typologyPath'></a>

`typologyPath` [DiGi\.Typology\.Classes\.TypologyPath](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.classes.typologypath 'DiGi\.Typology\.Classes\.TypologyPath')

The path associated with this item\.

<a name='DiGi.Typology.Visual.Classes.VisualTypologyItem.VisualTypologyItem(DiGi.Typology.Classes.TypologyPath,string,string,DiGi.Typology.Visual.Classes.TypologyAppearance).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the item\.

<a name='DiGi.Typology.Visual.Classes.VisualTypologyItem.VisualTypologyItem(DiGi.Typology.Classes.TypologyPath,string,string,DiGi.Typology.Visual.Classes.TypologyAppearance).description'></a>

`description` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The description of the item\.

<a name='DiGi.Typology.Visual.Classes.VisualTypologyItem.VisualTypologyItem(DiGi.Typology.Classes.TypologyPath,string,string,DiGi.Typology.Visual.Classes.TypologyAppearance).appearance'></a>

`appearance` [TypologyAppearance](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.TypologyAppearance 'DiGi\.Typology\.Visual\.Classes\.TypologyAppearance')

The appearance of the node; it is cloned\.

<a name='DiGi.Typology.Visual.Classes.VisualTypologyItem.VisualTypologyItem(DiGi.Typology.Visual.Classes.VisualTypologyItem)'></a>

## VisualTypologyItem\(VisualTypologyItem\) Constructor

Initializes a new instance of the [VisualTypologyItem](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualTypologyItem 'DiGi\.Typology\.Visual\.Classes\.VisualTypologyItem') class by cloning an existing item\.

```csharp
public VisualTypologyItem(DiGi.Typology.Visual.Classes.VisualTypologyItem? visualTypologyItem);
```
#### Parameters

<a name='DiGi.Typology.Visual.Classes.VisualTypologyItem.VisualTypologyItem(DiGi.Typology.Visual.Classes.VisualTypologyItem).visualTypologyItem'></a>

`visualTypologyItem` [VisualTypologyItem](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualTypologyItem 'DiGi\.Typology\.Visual\.Classes\.VisualTypologyItem')

The source item to clone\.

<a name='DiGi.Typology.Visual.Classes.VisualTypologyItem.VisualTypologyItem(System.Collections.Generic.IEnumerable_int_,string,string,DiGi.Typology.Visual.Classes.TypologyAppearance)'></a>

## VisualTypologyItem\(IEnumerable\<int\>, string, string, TypologyAppearance\) Constructor

Initializes a new instance of the [VisualTypologyItem](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualTypologyItem 'DiGi\.Typology\.Visual\.Classes\.VisualTypologyItem') class using a collection of path values, a
name, a description and an appearance\.

```csharp
public VisualTypologyItem(System.Collections.Generic.IEnumerable<int>? values, string? name, string? description, DiGi.Typology.Visual.Classes.TypologyAppearance? appearance);
```
#### Parameters

<a name='DiGi.Typology.Visual.Classes.VisualTypologyItem.VisualTypologyItem(System.Collections.Generic.IEnumerable_int_,string,string,DiGi.Typology.Visual.Classes.TypologyAppearance).values'></a>

`values` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The sequence of integers defining the typology path\.

<a name='DiGi.Typology.Visual.Classes.VisualTypologyItem.VisualTypologyItem(System.Collections.Generic.IEnumerable_int_,string,string,DiGi.Typology.Visual.Classes.TypologyAppearance).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the item\.

<a name='DiGi.Typology.Visual.Classes.VisualTypologyItem.VisualTypologyItem(System.Collections.Generic.IEnumerable_int_,string,string,DiGi.Typology.Visual.Classes.TypologyAppearance).description'></a>

`description` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The description of the item\.

<a name='DiGi.Typology.Visual.Classes.VisualTypologyItem.VisualTypologyItem(System.Collections.Generic.IEnumerable_int_,string,string,DiGi.Typology.Visual.Classes.TypologyAppearance).appearance'></a>

`appearance` [TypologyAppearance](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.TypologyAppearance 'DiGi\.Typology\.Visual\.Classes\.TypologyAppearance')

The appearance of the node; it is cloned\.

<a name='DiGi.Typology.Visual.Classes.VisualTypologyItem.VisualTypologyItem(System.Text.Json.Nodes.JsonObject)'></a>

## VisualTypologyItem\(JsonObject\) Constructor

Initializes a new instance of the [VisualTypologyItem](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualTypologyItem 'DiGi\.Typology\.Visual\.Classes\.VisualTypologyItem') class from a JSON object\.

```csharp
public VisualTypologyItem(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Typology.Visual.Classes.VisualTypologyItem.VisualTypologyItem(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing item data\.
### Properties

<a name='DiGi.Typology.Visual.Classes.VisualTypologyItem.Appearance'></a>

## VisualTypologyItem\.Appearance Property

Gets or sets the appearance of the node, or null when it has none\.

```csharp
public DiGi.Typology.Visual.Classes.TypologyAppearance? Appearance { get; set; }
```

#### Property Value
[TypologyAppearance](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.TypologyAppearance 'DiGi\.Typology\.Visual\.Classes\.TypologyAppearance')
### Methods

<a name='DiGi.Typology.Visual.Classes.VisualTypologyItem.CompareTo(DiGi.Typology.Classes.TypologyItem)'></a>

## VisualTypologyItem\.CompareTo\(TypologyItem\) Method

Compares by the base item first, then by the serialized form of the appearance, ordinally, an absent
appearance first; a plain [DiGi\.Typology\.Classes\.TypologyItem](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.classes.typologyitem 'DiGi\.Typology\.Classes\.TypologyItem') orders before an equal\-valued visual item\.

```csharp
public override int CompareTo(DiGi.Typology.Classes.TypologyItem typologyItem);
```
#### Parameters

<a name='DiGi.Typology.Visual.Classes.VisualTypologyItem.CompareTo(DiGi.Typology.Classes.TypologyItem).typologyItem'></a>

`typologyItem` [DiGi\.Typology\.Classes\.TypologyItem](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.classes.typologyitem 'DiGi\.Typology\.Classes\.TypologyItem')

The item to compare with this instance\.

#### Returns
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')  
A value indicating the relative order of the objects being compared\.

<a name='DiGi.Typology.Visual.Classes.VisualTypologyItem.Equals(DiGi.Typology.Classes.TypologyItem)'></a>

## VisualTypologyItem\.Equals\(TypologyItem\) Method

Determines whether the specified item is value\-equal to the current item, the appearance included\.

```csharp
public override bool Equals(DiGi.Typology.Classes.TypologyItem? typologyItem);
```
#### Parameters

<a name='DiGi.Typology.Visual.Classes.VisualTypologyItem.Equals(DiGi.Typology.Classes.TypologyItem).typologyItem'></a>

`typologyItem` [DiGi\.Typology\.Classes\.TypologyItem](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.classes.typologyitem 'DiGi\.Typology\.Classes\.TypologyItem')

The item to compare with the current instance\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the item is a [VisualTypologyItem](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualTypologyItem 'DiGi\.Typology\.Visual\.Classes\.VisualTypologyItem') equal in base value and in appearance; otherwise, false\.

<a name='DiGi.Typology.Visual.Classes.VisualTypologyItem.GetHashCode()'></a>

## VisualTypologyItem\.GetHashCode\(\) Method

Returns a hash code combining the base item hash with the serialized form of the appearance\.

The appearance is mutable, so the hash follows it - an item must not be mutated while it is held as a
            key of a dictionary or a set.

```csharp
public override int GetHashCode();
```

#### Returns
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')  
A 32\-bit signed integer hash code\.

<a name='DiGi.Typology.Visual.Classes.VisualUniqueValueFilterRule'></a>

## VisualUniqueValueFilterRule Class

The Visual counterpart of [DiGi\.Typology\.Classes\.UniqueValueFilterRule](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.classes.uniquevaluefilterrule 'DiGi\.Typology\.Classes\.UniqueValueFilterRule'): buckets a value by equality and carries an
appearance per value\.

The rule data is created at solve time, so the appearances live here, in a
            [TypologyAppearanceCollection](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.TypologyAppearanceCollection 'DiGi\.Typology\.Visual\.Classes\.TypologyAppearanceCollection') keyed by the value - see [Key\(this object\)](DiGi.Typology.Visual.md#DiGi.Typology.Visual.Query.Key(thisobject) 'DiGi\.Typology\.Visual\.Query\.Key\(this object\)') for
            the key a value resolves to - and [RuleData\(object\)](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualUniqueValueFilterRule.RuleData(object) 'DiGi\.Typology\.Visual\.Classes\.VisualUniqueValueFilterRule\.RuleData\(object\)') hands the value's appearance to the
            [VisualUniqueValueRuleData](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualUniqueValueRuleData 'DiGi\.Typology\.Visual\.Classes\.VisualUniqueValueRuleData') it produces. A consumer holding rule data of either kind can also read
            `rule.TypologyAppearanceCollection[ruleData]`.

This rule does not derive from [DiGi\.Typology\.Classes\.UniqueValueFilterRule](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.classes.uniquevaluefilterrule 'DiGi\.Typology\.Classes\.UniqueValueFilterRule'):
            [DiGi\.Typology\.Query\.RuleData\(DiGi\.Typology\.Interfaces\.ITypologyFilterRule,System\.Object\)](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.query.ruledata#digi-typology-query-ruledata(digi-typology-interfaces-itypologyfilterrule-system-object) 'DiGi\.Typology\.Query\.RuleData\(DiGi\.Typology\.Interfaces\.ITypologyFilterRule,System\.Object\)') binds `RuleData` by name through
            reflection, so hiding the base method to change its return type is not an option.

```csharp
public class VisualUniqueValueFilterRule : DiGi.Typology.Classes.TypologyFilterRule, DiGi.Typology.Visual.Interfaces.IVisualTypologyFilterRule, DiGi.Typology.Visual.Interfaces.ITypologyVisualSerializableObject, DiGi.Typology.Visual.Interfaces.ITypologyVisualObject, DiGi.Typology.Interfaces.ITypologyObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Typology.Interfaces.ITypologyFilterRule, DiGi.Typology.Interfaces.ITypologySerializableObject, DiGi.Typology.Interfaces.ITypologyFilterRule<DiGi.Typology.Visual.Classes.VisualUniqueValueRuleData>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Typology\.Classes\.TypologyFilterRule](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.classes.typologyfilterrule 'DiGi\.Typology\.Classes\.TypologyFilterRule') → VisualUniqueValueFilterRule

Implements [IVisualTypologyFilterRule](DiGi.Typology.Visual.Interfaces.md#DiGi.Typology.Visual.Interfaces.IVisualTypologyFilterRule 'DiGi\.Typology\.Visual\.Interfaces\.IVisualTypologyFilterRule'), [ITypologyVisualSerializableObject](DiGi.Typology.Visual.Interfaces.md#DiGi.Typology.Visual.Interfaces.ITypologyVisualSerializableObject 'DiGi\.Typology\.Visual\.Interfaces\.ITypologyVisualSerializableObject'), [ITypologyVisualObject](DiGi.Typology.Visual.Interfaces.md#DiGi.Typology.Visual.Interfaces.ITypologyVisualObject 'DiGi\.Typology\.Visual\.Interfaces\.ITypologyVisualObject'), [DiGi\.Typology\.Interfaces\.ITypologyObject](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.interfaces.itypologyobject 'DiGi\.Typology\.Interfaces\.ITypologyObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Typology\.Interfaces\.ITypologyFilterRule](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.interfaces.itypologyfilterrule 'DiGi\.Typology\.Interfaces\.ITypologyFilterRule'), [DiGi\.Typology\.Interfaces\.ITypologySerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.interfaces.itypologyserializableobject 'DiGi\.Typology\.Interfaces\.ITypologySerializableObject'), [DiGi\.Typology\.Interfaces\.ITypologyFilterRule&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.interfaces.itypologyfilterrule-1 'DiGi\.Typology\.Interfaces\.ITypologyFilterRule\`1')[VisualUniqueValueRuleData](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualUniqueValueRuleData 'DiGi\.Typology\.Visual\.Classes\.VisualUniqueValueRuleData')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.interfaces.itypologyfilterrule-1 'DiGi\.Typology\.Interfaces\.ITypologyFilterRule\`1')
### Constructors

<a name='DiGi.Typology.Visual.Classes.VisualUniqueValueFilterRule.VisualUniqueValueFilterRule()'></a>

## VisualUniqueValueFilterRule\(\) Constructor

Initializes a new instance of the [VisualUniqueValueFilterRule](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualUniqueValueFilterRule 'DiGi\.Typology\.Visual\.Classes\.VisualUniqueValueFilterRule') class with no appearances\.

```csharp
public VisualUniqueValueFilterRule();
```

<a name='DiGi.Typology.Visual.Classes.VisualUniqueValueFilterRule.VisualUniqueValueFilterRule(DiGi.Typology.Visual.Classes.VisualUniqueValueFilterRule)'></a>

## VisualUniqueValueFilterRule\(VisualUniqueValueFilterRule\) Constructor

Initializes a new instance of the [VisualUniqueValueFilterRule](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualUniqueValueFilterRule 'DiGi\.Typology\.Visual\.Classes\.VisualUniqueValueFilterRule') class by copying another instance,
its appearances included\.

```csharp
public VisualUniqueValueFilterRule(DiGi.Typology.Visual.Classes.VisualUniqueValueFilterRule visualUniqueValueFilterRule);
```
#### Parameters

<a name='DiGi.Typology.Visual.Classes.VisualUniqueValueFilterRule.VisualUniqueValueFilterRule(DiGi.Typology.Visual.Classes.VisualUniqueValueFilterRule).visualUniqueValueFilterRule'></a>

`visualUniqueValueFilterRule` [VisualUniqueValueFilterRule](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualUniqueValueFilterRule 'DiGi\.Typology\.Visual\.Classes\.VisualUniqueValueFilterRule')

The source rule to copy\.

<a name='DiGi.Typology.Visual.Classes.VisualUniqueValueFilterRule.VisualUniqueValueFilterRule(System.Text.Json.Nodes.JsonObject)'></a>

## VisualUniqueValueFilterRule\(JsonObject\) Constructor

Initializes a new instance of the [VisualUniqueValueFilterRule](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualUniqueValueFilterRule 'DiGi\.Typology\.Visual\.Classes\.VisualUniqueValueFilterRule') class with a JSON object\.

```csharp
public VisualUniqueValueFilterRule(System.Text.Json.Nodes.JsonObject jsonObject);
```
#### Parameters

<a name='DiGi.Typology.Visual.Classes.VisualUniqueValueFilterRule.VisualUniqueValueFilterRule(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the rule data\.
### Properties

<a name='DiGi.Typology.Visual.Classes.VisualUniqueValueFilterRule.TypologyAppearanceCollection'></a>

## VisualUniqueValueFilterRule\.TypologyAppearanceCollection Property

Gets the appearances of the buckets of this rule, keyed by value: file an entry as
`rule.TypologyAppearanceCollection[value] = appearance`\. Never null\.

```csharp
public DiGi.Typology.Visual.Classes.TypologyAppearanceCollection TypologyAppearanceCollection { get; }
```

Implements [TypologyAppearanceCollection](DiGi.Typology.Visual.Interfaces.md#DiGi.Typology.Visual.Interfaces.IVisualTypologyFilterRule.TypologyAppearanceCollection 'DiGi\.Typology\.Visual\.Interfaces\.IVisualTypologyFilterRule\.TypologyAppearanceCollection')

#### Property Value
[TypologyAppearanceCollection](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.TypologyAppearanceCollection 'DiGi\.Typology\.Visual\.Classes\.TypologyAppearanceCollection')
### Methods

<a name='DiGi.Typology.Visual.Classes.VisualUniqueValueFilterRule.RuleData(object)'></a>

## VisualUniqueValueFilterRule\.RuleData\(object\) Method

Wraps the value in the rule data of its bucket, together with the appearance filed for the value in
[TypologyAppearanceCollection](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualUniqueValueFilterRule.TypologyAppearanceCollection 'DiGi\.Typology\.Visual\.Classes\.VisualUniqueValueFilterRule\.TypologyAppearanceCollection'), by reference, or null when none is filed\.

Every value gets a bucket, as in [DiGi\.Typology\.Classes\.UniqueValueFilterRule](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.classes.uniquevaluefilterrule 'DiGi\.Typology\.Classes\.UniqueValueFilterRule'); `null` is the NULL bucket.

```csharp
public DiGi.Typology.Visual.Classes.VisualUniqueValueRuleData? RuleData(object? @object);
```
#### Parameters

<a name='DiGi.Typology.Visual.Classes.VisualUniqueValueFilterRule.RuleData(object).object'></a>

`object` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The value to bucket\.

Implements [RuleData\(object\)](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.interfaces.itypologyfilterrule-1.ruledata#digi-typology-interfaces-itypologyfilterrule-1-ruledata(system-object) 'DiGi\.Typology\.Interfaces\.ITypologyFilterRule\`1\.RuleData\(System\.Object\)')

#### Returns
[VisualUniqueValueRuleData](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualUniqueValueRuleData 'DiGi\.Typology\.Visual\.Classes\.VisualUniqueValueRuleData')  
The rule data wrapping the value and its appearance\.

<a name='DiGi.Typology.Visual.Classes.VisualUniqueValueRuleData'></a>

## VisualUniqueValueRuleData Class

The resulting data for a [VisualUniqueValueFilterRule](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualUniqueValueFilterRule 'DiGi\.Typology\.Visual\.Classes\.VisualUniqueValueFilterRule'): the value a bucket was keyed by, together with
the appearance of that bucket\.

The appearance is metadata, not identity: equality and the hash consider the [Value](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualUniqueValueRuleData.Value 'DiGi\.Typology\.Visual\.Classes\.VisualUniqueValueRuleData\.Value') alone (as
            in the base [DiGi\.Typology\.Classes\.UniqueValueRuleData](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.classes.uniquevalueruledata 'DiGi\.Typology\.Classes\.UniqueValueRuleData')), so two rule data instances are equal when they wrap equal values
            whatever they look like.

```csharp
public class VisualUniqueValueRuleData : DiGi.Typology.Classes.TypologyFilterRuleData<DiGi.Typology.Visual.Classes.VisualUniqueValueRuleData>, DiGi.Typology.Visual.Interfaces.IVisualTypologyFilterRuleData, DiGi.Typology.Visual.Interfaces.ITypologyVisualSerializableObject, DiGi.Typology.Visual.Interfaces.ITypologyVisualObject, DiGi.Typology.Interfaces.ITypologyObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Typology.Interfaces.ITypologyFilterRuleData, DiGi.Typology.Interfaces.ITypologySerializableObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Typology\.Classes\.TypologyFilterRuleData&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.classes.typologyfilterruledata-1 'DiGi\.Typology\.Classes\.TypologyFilterRuleData\`1')[VisualUniqueValueRuleData](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualUniqueValueRuleData 'DiGi\.Typology\.Visual\.Classes\.VisualUniqueValueRuleData')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.classes.typologyfilterruledata-1 'DiGi\.Typology\.Classes\.TypologyFilterRuleData\`1') → VisualUniqueValueRuleData

Implements [IVisualTypologyFilterRuleData](DiGi.Typology.Visual.Interfaces.md#DiGi.Typology.Visual.Interfaces.IVisualTypologyFilterRuleData 'DiGi\.Typology\.Visual\.Interfaces\.IVisualTypologyFilterRuleData'), [ITypologyVisualSerializableObject](DiGi.Typology.Visual.Interfaces.md#DiGi.Typology.Visual.Interfaces.ITypologyVisualSerializableObject 'DiGi\.Typology\.Visual\.Interfaces\.ITypologyVisualSerializableObject'), [ITypologyVisualObject](DiGi.Typology.Visual.Interfaces.md#DiGi.Typology.Visual.Interfaces.ITypologyVisualObject 'DiGi\.Typology\.Visual\.Interfaces\.ITypologyVisualObject'), [DiGi\.Typology\.Interfaces\.ITypologyObject](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.interfaces.itypologyobject 'DiGi\.Typology\.Interfaces\.ITypologyObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Typology\.Interfaces\.ITypologyFilterRuleData](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.interfaces.itypologyfilterruledata 'DiGi\.Typology\.Interfaces\.ITypologyFilterRuleData'), [DiGi\.Typology\.Interfaces\.ITypologySerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.interfaces.itypologyserializableobject 'DiGi\.Typology\.Interfaces\.ITypologySerializableObject')
### Constructors

<a name='DiGi.Typology.Visual.Classes.VisualUniqueValueRuleData.VisualUniqueValueRuleData()'></a>

## VisualUniqueValueRuleData\(\) Constructor

Initializes a new, empty instance of the [VisualUniqueValueRuleData](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualUniqueValueRuleData 'DiGi\.Typology\.Visual\.Classes\.VisualUniqueValueRuleData') class; the value and the
appearance are set afterwards\.

```csharp
public VisualUniqueValueRuleData();
```

<a name='DiGi.Typology.Visual.Classes.VisualUniqueValueRuleData.VisualUniqueValueRuleData(DiGi.Typology.Visual.Classes.VisualUniqueValueRuleData)'></a>

## VisualUniqueValueRuleData\(VisualUniqueValueRuleData\) Constructor

Initializes a new instance of the [VisualUniqueValueRuleData](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualUniqueValueRuleData 'DiGi\.Typology\.Visual\.Classes\.VisualUniqueValueRuleData') class by copying another instance\.

The value is shared by reference, as unique values are expected to be immutable; the appearance is cloned.

```csharp
public VisualUniqueValueRuleData(DiGi.Typology.Visual.Classes.VisualUniqueValueRuleData visualUniqueValueRuleData);
```
#### Parameters

<a name='DiGi.Typology.Visual.Classes.VisualUniqueValueRuleData.VisualUniqueValueRuleData(DiGi.Typology.Visual.Classes.VisualUniqueValueRuleData).visualUniqueValueRuleData'></a>

`visualUniqueValueRuleData` [VisualUniqueValueRuleData](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualUniqueValueRuleData 'DiGi\.Typology\.Visual\.Classes\.VisualUniqueValueRuleData')

The source rule data to copy\.

<a name='DiGi.Typology.Visual.Classes.VisualUniqueValueRuleData.VisualUniqueValueRuleData(object)'></a>

## VisualUniqueValueRuleData\(object\) Constructor

Initializes a new instance of the [VisualUniqueValueRuleData](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualUniqueValueRuleData 'DiGi\.Typology\.Visual\.Classes\.VisualUniqueValueRuleData') class wrapping a value\.

The value is stored by reference, not cloned, so the caller retains ownership of the instance it passes.

```csharp
public VisualUniqueValueRuleData(object? @object);
```
#### Parameters

<a name='DiGi.Typology.Visual.Classes.VisualUniqueValueRuleData.VisualUniqueValueRuleData(object).object'></a>

`object` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The value to wrap\.

<a name='DiGi.Typology.Visual.Classes.VisualUniqueValueRuleData.VisualUniqueValueRuleData(object,DiGi.Typology.Visual.Classes.TypologyAppearance)'></a>

## VisualUniqueValueRuleData\(object, TypologyAppearance\) Constructor

Initializes a new instance of the [VisualUniqueValueRuleData](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualUniqueValueRuleData 'DiGi\.Typology\.Visual\.Classes\.VisualUniqueValueRuleData') class wrapping a value and an
appearance\.

Both are stored as given, not cloned, so the caller retains ownership of the instances it passes.

```csharp
public VisualUniqueValueRuleData(object? @object, DiGi.Typology.Visual.Classes.TypologyAppearance? appearance);
```
#### Parameters

<a name='DiGi.Typology.Visual.Classes.VisualUniqueValueRuleData.VisualUniqueValueRuleData(object,DiGi.Typology.Visual.Classes.TypologyAppearance).object'></a>

`object` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The value to wrap\.

<a name='DiGi.Typology.Visual.Classes.VisualUniqueValueRuleData.VisualUniqueValueRuleData(object,DiGi.Typology.Visual.Classes.TypologyAppearance).appearance'></a>

`appearance` [TypologyAppearance](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.TypologyAppearance 'DiGi\.Typology\.Visual\.Classes\.TypologyAppearance')

The appearance of the bucket; may be null\.

<a name='DiGi.Typology.Visual.Classes.VisualUniqueValueRuleData.VisualUniqueValueRuleData(System.Text.Json.Nodes.JsonObject)'></a>

## VisualUniqueValueRuleData\(JsonObject\) Constructor

Initializes a new instance of the [VisualUniqueValueRuleData](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualUniqueValueRuleData 'DiGi\.Typology\.Visual\.Classes\.VisualUniqueValueRuleData') class from a JSON object\.

```csharp
public VisualUniqueValueRuleData(System.Text.Json.Nodes.JsonObject jsonObject);
```
#### Parameters

<a name='DiGi.Typology.Visual.Classes.VisualUniqueValueRuleData.VisualUniqueValueRuleData(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the rule data\.
### Properties

<a name='DiGi.Typology.Visual.Classes.VisualUniqueValueRuleData.Appearance'></a>

## VisualUniqueValueRuleData\.Appearance Property

Gets or sets the appearance of the bucket this rule data describes, or null when it has none\.

Rule data produced by a [VisualUniqueValueFilterRule](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualUniqueValueFilterRule 'DiGi\.Typology\.Visual\.Classes\.VisualUniqueValueFilterRule') shares the instance filed on the rule,
            so mutating it mutates the rule's entry.

```csharp
public DiGi.Typology.Visual.Classes.TypologyAppearance? Appearance { get; set; }
```

Implements [Appearance](DiGi.Typology.Visual.Interfaces.md#DiGi.Typology.Visual.Interfaces.IVisualTypologyFilterRuleData.Appearance 'DiGi\.Typology\.Visual\.Interfaces\.IVisualTypologyFilterRuleData\.Appearance')

#### Property Value
[TypologyAppearance](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.TypologyAppearance 'DiGi\.Typology\.Visual\.Classes\.TypologyAppearance')

<a name='DiGi.Typology.Visual.Classes.VisualUniqueValueRuleData.Value'></a>

## VisualUniqueValueRuleData\.Value Property

Gets the value the bucket was keyed by, or null when this instance wraps none\.

```csharp
public object? Value { get; }
```

#### Property Value
[System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')
### Methods

<a name='DiGi.Typology.Visual.Classes.VisualUniqueValueRuleData.Equals(DiGi.Typology.Visual.Classes.VisualUniqueValueRuleData)'></a>

## VisualUniqueValueRuleData\.Equals\(VisualUniqueValueRuleData\) Method

Determines whether this instance and another unique value rule data wrap the same value; the appearance is not
considered\.

```csharp
public override bool Equals(DiGi.Typology.Visual.Classes.VisualUniqueValueRuleData visualUniqueValueRuleData);
```
#### Parameters

<a name='DiGi.Typology.Visual.Classes.VisualUniqueValueRuleData.Equals(DiGi.Typology.Visual.Classes.VisualUniqueValueRuleData).visualUniqueValueRuleData'></a>

`visualUniqueValueRuleData` [VisualUniqueValueRuleData](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualUniqueValueRuleData 'DiGi\.Typology\.Visual\.Classes\.VisualUniqueValueRuleData')

The rule data to compare with this instance\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if both wrap equal values; otherwise, false\.

<a name='DiGi.Typology.Visual.Classes.VisualUniqueValueRuleData.Equals(object)'></a>

## VisualUniqueValueRuleData\.Equals\(object\) Method

Determines whether this instance and a specified object wrap the same value\.

```csharp
public override bool Equals(object? @object);
```
#### Parameters

<a name='DiGi.Typology.Visual.Classes.VisualUniqueValueRuleData.Equals(object).object'></a>

`object` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The object to compare with this instance\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the object is a [VisualUniqueValueRuleData](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualUniqueValueRuleData 'DiGi\.Typology\.Visual\.Classes\.VisualUniqueValueRuleData') of equal value; otherwise, false\.

<a name='DiGi.Typology.Visual.Classes.VisualUniqueValueRuleData.GetHashCode()'></a>

## VisualUniqueValueRuleData\.GetHashCode\(\) Method

Returns the hash code for this instance, based on the value alone\.

```csharp
public override int GetHashCode();
```

#### Returns
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')  
A 32\-bit signed integer hash code\.

<a name='DiGi.Typology.Visual.Classes.VisualUniqueValueRuleData.ToString()'></a>

## VisualUniqueValueRuleData\.ToString\(\) Method

Returns a string representation of the unique value rule data\.

```csharp
public override string ToString();
```

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
A string representation of the value\.