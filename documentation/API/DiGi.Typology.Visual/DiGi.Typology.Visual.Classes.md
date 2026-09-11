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

A collection of [TypologyAppearance](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.TypologyAppearance 'DiGi\.Typology\.Visual\.Classes\.TypologyAppearance'), one per value, filed under the key [Key\(object\)](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.TypologyAppearanceCollection.Key(object) 'DiGi\.Typology\.Visual\.Classes\.TypologyAppearanceCollection\.Key\(object\)')
renders for the value\.

The indexer performs that normalisation, so `[2010]`, `["2010"]`, `[2010L]` and
            `[uniqueValueRuleData]` address the same entry. Keys are not kept as [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object'): a JSON round trip
            turns every key into a string, and a boxed number does not compare equal to its string form or to the same number
            of another width.

Two values get the same key exactly when they are [System\.Object\.Equals\(System\.Object\)](https://learn.microsoft.com/en-us/dotnet/api/system.object.equals#system-object-equals(system-object) 'System\.Object\.Equals\(System\.Object\)')-equal, which is how
            [DiGi\.Typology\.Classes\.UniqueValueRuleData](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.classes.uniquevalueruledata 'DiGi\.Typology\.Classes\.UniqueValueRuleData') buckets them; see [Key\(object\)](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.TypologyAppearanceCollection.Key(object) 'DiGi\.Typology\.Visual\.Classes\.TypologyAppearanceCollection\.Key\(object\)') for the forms. Two limitations are
            inherent: a text value that is literally `"null"` shares the key of the NULL bucket, and floating-point keys
            are not guaranteed across a .NET Framework host, whose `double.ToString` differs - use a range rule for
            floating-point columns.

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

Gets the appearances held, in key order\. A new list is built on every call\.

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

Gets the keys that carry an appearance\. A new list is built on every call\.

```csharp
public System.Collections.Generic.List<string> Keys { get; }
```

#### Property Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

<a name='DiGi.Typology.Visual.Classes.TypologyAppearanceCollection.this[object]'></a>

## TypologyAppearanceCollection\.this\[object\] Property

Gets or sets the appearance of the bucket the given value falls into\.

The value is normalised through [Key\(object\)](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.TypologyAppearanceCollection.Key(object) 'DiGi\.Typology\.Visual\.Classes\.TypologyAppearanceCollection\.Key\(object\)'), so any value type is accepted: `null`
            addresses the NULL bucket, a number its invariant text form whatever its width, and a
            [DiGi\.Typology\.Classes\.UniqueValueRuleData](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.classes.uniquevalueruledata 'DiGi\.Typology\.Classes\.UniqueValueRuleData') its own bucket. The getter returns null when no appearance is filed for the
            value; assigning null removes the entry.

```csharp
public DiGi.Typology.Visual.Classes.TypologyAppearance? this[object? @object] { get; set; }
```
#### Parameters

<a name='DiGi.Typology.Visual.Classes.TypologyAppearanceCollection.this[object].object'></a>

`object` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The value, its string form, or the rule data produced for it\.

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

The value, its string form, or the rule data produced for it\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if an appearance is filed for the value; otherwise, false\.

<a name='DiGi.Typology.Visual.Classes.TypologyAppearanceCollection.Key(object)'></a>

## TypologyAppearanceCollection\.Key\(object\) Method

Renders a value as the key its appearance is filed under\.

The form is culture-invariant and agrees with [System\.Object\.Equals\(System\.Object\)](https://learn.microsoft.com/en-us/dotnet/api/system.object.equals#system-object-equals(system-object) 'System\.Object\.Equals\(System\.Object\)'): two values get the
            same key exactly when a [DiGi\.Typology\.Classes\.UniqueValueRuleData](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.classes.uniquevalueruledata 'DiGi\.Typology\.Classes\.UniqueValueRuleData') would bucket them together. `null` renders as
            `"null"`; a [DiGi\.Typology\.Classes\.UniqueValueRuleData](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.classes.uniquevalueruledata 'DiGi\.Typology\.Classes\.UniqueValueRuleData') as the key of its value; a string as itself; a
            [System\.Decimal](https://learn.microsoft.com/en-us/dotnet/api/system.decimal 'System\.Decimal') with its scale stripped (`1.10m` and `1.1m` are equal); a [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') or
            [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single') as its shortest round-trip form with negative zero folded to zero; a [System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime') to
            the tick with its kind ignored, as its equality ignores it; a [System\.DateTimeOffset](https://learn.microsoft.com/en-us/dotnet/api/system.datetimeoffset 'System\.DateTimeOffset') as the UTC instant its
            equality compares; any other [System\.IFormattable](https://learn.microsoft.com/en-us/dotnet/api/system.iformattable 'System\.IFormattable') - integers of any width, [System\.TimeSpan](https://learn.microsoft.com/en-us/dotnet/api/system.timespan 'System\.TimeSpan'),
            [System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid'), enums - in the invariant culture; and anything else through [System\.Object\.ToString](https://learn.microsoft.com/en-us/dotnet/api/system.object.tostring 'System\.Object\.ToString').
            A [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean') renders as `True` or `False` whichever branch its runtime takes. For the
            categorical types a unique value rule is meant for, the key equals [DiGi\.Typology\.Classes\.UniqueValueRuleData\.ToString](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.classes.uniquevalueruledata.tostring 'DiGi\.Typology\.Classes\.UniqueValueRuleData\.ToString').

```csharp
public static string Key(object? @object);
```
#### Parameters

<a name='DiGi.Typology.Visual.Classes.TypologyAppearanceCollection.Key(object).object'></a>

`object` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The value, or the rule data produced for it\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
The key\.

<a name='DiGi.Typology.Visual.Classes.VisualColumnTypologyFilter'></a>

## VisualColumnTypologyFilter Class

A [DiGi\.Typology\.Classes\.ColumnTypologyFilter&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.classes.columntypologyfilter-1 'DiGi\.Typology\.Classes\.ColumnTypologyFilter\`1') level carrying a fallback appearance for the buckets its rule
produces\.

The appearance of a bucket is normally carried by the rule - a [VisualRange&lt;T&gt;](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualRange_T_ 'DiGi\.Typology\.Visual\.Classes\.VisualRange\<T\>') inside a range
            rule, an entry of a [VisualUniqueValueFilterRule](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualUniqueValueFilterRule 'DiGi\.Typology\.Visual\.Classes\.VisualUniqueValueFilterRule') - and this level appearance stands in where the rule
            carries none. It is definition metadata for the editing client only today: a solver rebuilding the chain keeps the
            [DiGi\.Typology\.Classes\.TypologyFilter&lt;&gt;\.Rule](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.classes.typologyfilter-1.rule 'DiGi\.Typology\.Classes\.TypologyFilter\`1\.Rule') instance and drops the node, so nothing in a solved tree reflects
            it. The nested [DiGi\.Typology\.Classes\.TypologyFilter&lt;&gt;\.Filter](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.classes.typologyfilter-1.filter 'DiGi\.Typology\.Classes\.TypologyFilter\`1\.Filter') stays typed as the base level; a nested Visual
            level is Visual by its `_type` discriminator only.

```csharp
public class VisualColumnTypologyFilter : DiGi.Typology.Classes.ColumnTypologyFilter<DiGi.Core.IO.Table.Classes.Column>, DiGi.Typology.Visual.Interfaces.ITypologyVisualSerializableObject, DiGi.Typology.Visual.Interfaces.ITypologyVisualObject, DiGi.Typology.Interfaces.ITypologyObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Typology\.Classes\.TypologyFilter&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.classes.typologyfilter-1 'DiGi\.Typology\.Classes\.TypologyFilter\`1')[DiGi\.Typology\.Classes\.ColumnTypologyFilter&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.classes.columntypologyfilter-1 'DiGi\.Typology\.Classes\.ColumnTypologyFilter\`1')[DiGi\.Core\.IO\.Table\.Classes\.Column](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.table.classes.column 'DiGi\.Core\.IO\.Table\.Classes\.Column')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.classes.columntypologyfilter-1 'DiGi\.Typology\.Classes\.ColumnTypologyFilter\`1')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.classes.typologyfilter-1 'DiGi\.Typology\.Classes\.TypologyFilter\`1') → [DiGi\.Typology\.Classes\.TypologyFilter&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.classes.typologyfilter-2 'DiGi\.Typology\.Classes\.TypologyFilter\`2')[DiGi\.Typology\.Classes\.ColumnTypologyFilter&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.classes.columntypologyfilter-1 'DiGi\.Typology\.Classes\.ColumnTypologyFilter\`1')[DiGi\.Core\.IO\.Table\.Classes\.Column](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.table.classes.column 'DiGi\.Core\.IO\.Table\.Classes\.Column')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.classes.columntypologyfilter-1 'DiGi\.Typology\.Classes\.ColumnTypologyFilter\`1')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.classes.typologyfilter-2 'DiGi\.Typology\.Classes\.TypologyFilter\`2')[DiGi\.Core\.IO\.Table\.Classes\.Column](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.table.classes.column 'DiGi\.Core\.IO\.Table\.Classes\.Column')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.classes.typologyfilter-2 'DiGi\.Typology\.Classes\.TypologyFilter\`2') → [DiGi\.Typology\.Classes\.ColumnTypologyFilter&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.classes.columntypologyfilter-1 'DiGi\.Typology\.Classes\.ColumnTypologyFilter\`1')[DiGi\.Core\.IO\.Table\.Classes\.Column](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.table.classes.column 'DiGi\.Core\.IO\.Table\.Classes\.Column')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.classes.columntypologyfilter-1 'DiGi\.Typology\.Classes\.ColumnTypologyFilter\`1') → VisualColumnTypologyFilter

Implements [ITypologyVisualSerializableObject](DiGi.Typology.Visual.Interfaces.md#DiGi.Typology.Visual.Interfaces.ITypologyVisualSerializableObject 'DiGi\.Typology\.Visual\.Interfaces\.ITypologyVisualSerializableObject'), [ITypologyVisualObject](DiGi.Typology.Visual.Interfaces.md#DiGi.Typology.Visual.Interfaces.ITypologyVisualObject 'DiGi\.Typology\.Visual\.Interfaces\.ITypologyVisualObject'), [DiGi\.Typology\.Interfaces\.ITypologyObject](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.interfaces.itypologyobject 'DiGi\.Typology\.Interfaces\.ITypologyObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject')
### Constructors

<a name='DiGi.Typology.Visual.Classes.VisualColumnTypologyFilter.VisualColumnTypologyFilter()'></a>

## VisualColumnTypologyFilter\(\) Constructor

Initializes a new instance of the [VisualColumnTypologyFilter](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualColumnTypologyFilter 'DiGi\.Typology\.Visual\.Classes\.VisualColumnTypologyFilter') class\.

```csharp
public VisualColumnTypologyFilter();
```

<a name='DiGi.Typology.Visual.Classes.VisualColumnTypologyFilter.VisualColumnTypologyFilter(DiGi.Typology.Visual.Classes.VisualColumnTypologyFilter)'></a>

## VisualColumnTypologyFilter\(VisualColumnTypologyFilter\) Constructor

Initializes a new instance of the [VisualColumnTypologyFilter](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualColumnTypologyFilter 'DiGi\.Typology\.Visual\.Classes\.VisualColumnTypologyFilter') class by copying another instance,
its appearance included\.

```csharp
public VisualColumnTypologyFilter(DiGi.Typology.Visual.Classes.VisualColumnTypologyFilter? visualColumnTypologyFilter);
```
#### Parameters

<a name='DiGi.Typology.Visual.Classes.VisualColumnTypologyFilter.VisualColumnTypologyFilter(DiGi.Typology.Visual.Classes.VisualColumnTypologyFilter).visualColumnTypologyFilter'></a>

`visualColumnTypologyFilter` [VisualColumnTypologyFilter](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualColumnTypologyFilter 'DiGi\.Typology\.Visual\.Classes\.VisualColumnTypologyFilter')

The filter to copy\.

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
### Properties

<a name='DiGi.Typology.Visual.Classes.VisualColumnTypologyFilter.Appearance'></a>

## VisualColumnTypologyFilter\.Appearance Property

Gets or sets the fallback appearance of the buckets this level produces, or null when it has none\.

```csharp
public DiGi.Typology.Visual.Classes.TypologyAppearance? Appearance { get; set; }
```

#### Property Value
[TypologyAppearance](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.TypologyAppearance 'DiGi\.Typology\.Visual\.Classes\.TypologyAppearance')

<a name='DiGi.Typology.Visual.Classes.VisualRange_T_'></a>

## VisualRange\<T\> Class

A [DiGi\.Core\.Classes\.Range&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1') carrying the appearance of the bucket it defines\.

Rides inside the existing [DiGi\.Typology\.Classes\.IntegerRangeFilterRule](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.classes.integerrangefilterrule 'DiGi\.Typology\.Classes\.IntegerRangeFilterRule') and [DiGi\.Typology\.Classes\.DoubleRangeFilterRule](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.classes.doublerangefilterrule 'DiGi\.Typology\.Classes\.DoubleRangeFilterRule')
            unchanged: the rule keys on [DiGi\.Core\.Classes\.Range&lt;&gt;\.Min](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1.min 'DiGi\.Core\.Classes\.Range\`1\.Min') and stores whatever [DiGi\.Core\.Classes\.Range&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1') subtype it is
            given, so there is no Visual rule class. [DiGi\.Typology\.Classes\.RangeValueFilterRule&lt;&gt;\.RuleData\(System\.Object\)](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.classes.rangevaluefilterrule-1.ruledata#digi-typology-classes-rangevaluefilterrule-1-ruledata(system-object) 'DiGi\.Typology\.Classes\.RangeValueFilterRule\`1\.RuleData\(System\.Object\)') wraps the
            matched instance itself, so a consumer reads the appearance back as `ruleData.Range as VisualRange<T>`.

The appearance is metadata and takes no part in equality or hashing: two ranges with the same bounds are
            equal whatever they look like, which keeps bucket identity a property of the range alone.

```csharp
public class VisualRange<T> : DiGi.Core.Classes.Range<T>, DiGi.Typology.Visual.Interfaces.ITypologyVisualSerializableObject, DiGi.Typology.Visual.Interfaces.ITypologyVisualObject, DiGi.Typology.Interfaces.ITypologyObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject
```
#### Type parameters

<a name='DiGi.Typology.Visual.Classes.VisualRange_T_.T'></a>

`T`

The type of the values in the range\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Classes\.Range&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[T](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualRange_T_.T 'DiGi\.Typology\.Visual\.Classes\.VisualRange\<T\>\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1') → VisualRange\<T\>

Implements [ITypologyVisualSerializableObject](DiGi.Typology.Visual.Interfaces.md#DiGi.Typology.Visual.Interfaces.ITypologyVisualSerializableObject 'DiGi\.Typology\.Visual\.Interfaces\.ITypologyVisualSerializableObject'), [ITypologyVisualObject](DiGi.Typology.Visual.Interfaces.md#DiGi.Typology.Visual.Interfaces.ITypologyVisualObject 'DiGi\.Typology\.Visual\.Interfaces\.ITypologyVisualObject'), [DiGi\.Typology\.Interfaces\.ITypologyObject](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.interfaces.itypologyobject 'DiGi\.Typology\.Interfaces\.ITypologyObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject')
### Constructors

<a name='DiGi.Typology.Visual.Classes.VisualRange_T_.VisualRange(DiGi.Core.Classes.Range_T_,DiGi.Typology.Visual.Classes.TypologyAppearance)'></a>

## VisualRange\(Range\<T\>, TypologyAppearance\) Constructor

Initializes a new instance of the [VisualRange&lt;T&gt;](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualRange_T_ 'DiGi\.Typology\.Visual\.Classes\.VisualRange\<T\>') class from a plain range and an appearance\.

```csharp
public VisualRange(DiGi.Core.Classes.Range<T>? range, DiGi.Typology.Visual.Classes.TypologyAppearance? appearance);
```
#### Parameters

<a name='DiGi.Typology.Visual.Classes.VisualRange_T_.VisualRange(DiGi.Core.Classes.Range_T_,DiGi.Typology.Visual.Classes.TypologyAppearance).range'></a>

`range` [DiGi\.Core\.Classes\.Range&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[T](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualRange_T_.T 'DiGi\.Typology\.Visual\.Classes\.VisualRange\<T\>\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')

The range whose bounds are copied\.

<a name='DiGi.Typology.Visual.Classes.VisualRange_T_.VisualRange(DiGi.Core.Classes.Range_T_,DiGi.Typology.Visual.Classes.TypologyAppearance).appearance'></a>

`appearance` [TypologyAppearance](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.TypologyAppearance 'DiGi\.Typology\.Visual\.Classes\.TypologyAppearance')

The appearance of the bucket; it is cloned\.

<a name='DiGi.Typology.Visual.Classes.VisualRange_T_.VisualRange(DiGi.Typology.Visual.Classes.VisualRange_T_)'></a>

## VisualRange\(VisualRange\<T\>\) Constructor

Initializes a new instance of the [VisualRange&lt;T&gt;](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualRange_T_ 'DiGi\.Typology\.Visual\.Classes\.VisualRange\<T\>') class by copying an existing visual range\.

```csharp
public VisualRange(DiGi.Typology.Visual.Classes.VisualRange<T>? visualRange);
```
#### Parameters

<a name='DiGi.Typology.Visual.Classes.VisualRange_T_.VisualRange(DiGi.Typology.Visual.Classes.VisualRange_T_).visualRange'></a>

`visualRange` [DiGi\.Typology\.Visual\.Classes\.VisualRange&lt;](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualRange_T_ 'DiGi\.Typology\.Visual\.Classes\.VisualRange\<T\>')[T](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualRange_T_.T 'DiGi\.Typology\.Visual\.Classes\.VisualRange\<T\>\.T')[&gt;](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualRange_T_ 'DiGi\.Typology\.Visual\.Classes\.VisualRange\<T\>')

The visual range to copy\.

<a name='DiGi.Typology.Visual.Classes.VisualRange_T_.VisualRange(System.Text.Json.Nodes.JsonObject)'></a>

## VisualRange\(JsonObject\) Constructor

Initializes a new instance of the [VisualRange&lt;T&gt;](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualRange_T_ 'DiGi\.Typology\.Visual\.Classes\.VisualRange\<T\>') class from a JSON object\.

```csharp
public VisualRange(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Typology.Visual.Classes.VisualRange_T_.VisualRange(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object to initialize the range from\.

<a name='DiGi.Typology.Visual.Classes.VisualRange_T_.VisualRange(T,T,DiGi.Typology.Visual.Classes.TypologyAppearance)'></a>

## VisualRange\(T, T, TypologyAppearance\) Constructor

Initializes a new instance of the [VisualRange&lt;T&gt;](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualRange_T_ 'DiGi\.Typology\.Visual\.Classes\.VisualRange\<T\>') class with specified boundary values and appearance\.

```csharp
public VisualRange(T? value_1, T? value_2, DiGi.Typology.Visual.Classes.TypologyAppearance? appearance);
```
#### Parameters

<a name='DiGi.Typology.Visual.Classes.VisualRange_T_.VisualRange(T,T,DiGi.Typology.Visual.Classes.TypologyAppearance).value_1'></a>

`value_1` [T](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualRange_T_.T 'DiGi\.Typology\.Visual\.Classes\.VisualRange\<T\>\.T')

The first boundary value\.

<a name='DiGi.Typology.Visual.Classes.VisualRange_T_.VisualRange(T,T,DiGi.Typology.Visual.Classes.TypologyAppearance).value_2'></a>

`value_2` [T](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualRange_T_.T 'DiGi\.Typology\.Visual\.Classes\.VisualRange\<T\>\.T')

The second boundary value\.

<a name='DiGi.Typology.Visual.Classes.VisualRange_T_.VisualRange(T,T,DiGi.Typology.Visual.Classes.TypologyAppearance).appearance'></a>

`appearance` [TypologyAppearance](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.TypologyAppearance 'DiGi\.Typology\.Visual\.Classes\.TypologyAppearance')

The appearance of the bucket; it is cloned\.
### Properties

<a name='DiGi.Typology.Visual.Classes.VisualRange_T_.Appearance'></a>

## VisualRange\<T\>\.Appearance Property

Gets or sets the appearance of the bucket this range defines, or null when it has none\.

```csharp
public DiGi.Typology.Visual.Classes.TypologyAppearance? Appearance { get; set; }
```

#### Property Value
[TypologyAppearance](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.TypologyAppearance 'DiGi\.Typology\.Visual\.Classes\.TypologyAppearance')

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

A [DiGi\.Typology\.Classes\.UniqueValueFilterRule](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.classes.uniquevaluefilterrule 'DiGi\.Typology\.Classes\.UniqueValueFilterRule') carrying an appearance per value\.

The rule itself is stateless and its rule data is created at solve time, so the appearances live here, in a
            [TypologyAppearanceCollection](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.TypologyAppearanceCollection 'DiGi\.Typology\.Visual\.Classes\.TypologyAppearanceCollection') keyed by the value - see
            [Key\(object\)](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.TypologyAppearanceCollection.Key(object) 'DiGi\.Typology\.Visual\.Classes\.TypologyAppearanceCollection\.Key\(object\)') for the key a value resolves to. A consumer holding a
            [DiGi\.Typology\.Classes\.UniqueValueRuleData](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.classes.uniquevalueruledata 'DiGi\.Typology\.Classes\.UniqueValueRuleData') reads `rule.TypologyAppearanceCollection[uniqueValueRuleData]`.

This type adds no `RuleData` member: [DiGi\.Typology\.Query\.RuleData\(DiGi\.Typology\.Interfaces\.ITypologyFilterRule,System\.Object\)](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.query.ruledata#digi-typology-query-ruledata(digi-typology-interfaces-itypologyfilterrule-system-object) 'DiGi\.Typology\.Query\.RuleData\(DiGi\.Typology\.Interfaces\.ITypologyFilterRule,System\.Object\)')
            resolves that method by name, and a hiding overload would make the lookup ambiguous.

```csharp
public class VisualUniqueValueFilterRule : DiGi.Typology.Classes.UniqueValueFilterRule, DiGi.Typology.Visual.Interfaces.ITypologyVisualSerializableObject, DiGi.Typology.Visual.Interfaces.ITypologyVisualObject, DiGi.Typology.Interfaces.ITypologyObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Typology\.Classes\.TypologyFilterRule](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.classes.typologyfilterrule 'DiGi\.Typology\.Classes\.TypologyFilterRule') → [DiGi\.Typology\.Classes\.UniqueValueFilterRule](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.classes.uniquevaluefilterrule 'DiGi\.Typology\.Classes\.UniqueValueFilterRule') → VisualUniqueValueFilterRule

Implements [ITypologyVisualSerializableObject](DiGi.Typology.Visual.Interfaces.md#DiGi.Typology.Visual.Interfaces.ITypologyVisualSerializableObject 'DiGi\.Typology\.Visual\.Interfaces\.ITypologyVisualSerializableObject'), [ITypologyVisualObject](DiGi.Typology.Visual.Interfaces.md#DiGi.Typology.Visual.Interfaces.ITypologyVisualObject 'DiGi\.Typology\.Visual\.Interfaces\.ITypologyVisualObject'), [DiGi\.Typology\.Interfaces\.ITypologyObject](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.interfaces.itypologyobject 'DiGi\.Typology\.Interfaces\.ITypologyObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject')
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

Gets the appearances of the buckets of this rule, keyed by value\. Never null; file entries through its indexer\.

```csharp
public DiGi.Typology.Visual.Classes.TypologyAppearanceCollection TypologyAppearanceCollection { get; }
```

#### Property Value
[TypologyAppearanceCollection](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.TypologyAppearanceCollection 'DiGi\.Typology\.Visual\.Classes\.TypologyAppearanceCollection')