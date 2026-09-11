#### [DiGi\.Typology\.Visual](DiGi.Typology.Visual.Overview.md 'DiGi\.Typology\.Visual\.Overview')

## DiGi\.Typology\.Visual\.Interfaces Namespace
### Interfaces

<a name='DiGi.Typology.Visual.Interfaces.ITypologyVisualObject'></a>

## ITypologyVisualObject Interface

Defines the base contract for typology visual objects\.

```csharp
public interface ITypologyVisualObject : DiGi.Typology.Interfaces.ITypologyObject, DiGi.Core.Interfaces.IObject
```

Derived  
↳ [TypologyAppearance](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.TypologyAppearance 'DiGi\.Typology\.Visual\.Classes\.TypologyAppearance')  
↳ [TypologyAppearanceCollection](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.TypologyAppearanceCollection 'DiGi\.Typology\.Visual\.Classes\.TypologyAppearanceCollection')  
↳ [VisualColumnTypologyFilter&lt;UColumn&gt;](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualColumnTypologyFilter_UColumn_ 'DiGi\.Typology\.Visual\.Classes\.VisualColumnTypologyFilter\<UColumn\>')  
↳ [VisualRangeValueFilterRule&lt;TValueType&gt;](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualRangeValueFilterRule_TValueType_ 'DiGi\.Typology\.Visual\.Classes\.VisualRangeValueFilterRule\<TValueType\>')  
↳ [VisualRangeValueRuleData&lt;TValueType&gt;](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualRangeValueRuleData_TValueType_ 'DiGi\.Typology\.Visual\.Classes\.VisualRangeValueRuleData\<TValueType\>')  
↳ [VisualTypology](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualTypology 'DiGi\.Typology\.Visual\.Classes\.VisualTypology')  
↳ [VisualTypologyItem](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualTypologyItem 'DiGi\.Typology\.Visual\.Classes\.VisualTypologyItem')  
↳ [VisualUniqueValueFilterRule](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualUniqueValueFilterRule 'DiGi\.Typology\.Visual\.Classes\.VisualUniqueValueFilterRule')  
↳ [VisualUniqueValueRuleData](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualUniqueValueRuleData 'DiGi\.Typology\.Visual\.Classes\.VisualUniqueValueRuleData')  
↳ [ITypologyVisualSerializableObject](DiGi.Typology.Visual.Interfaces.md#DiGi.Typology.Visual.Interfaces.ITypologyVisualSerializableObject 'DiGi\.Typology\.Visual\.Interfaces\.ITypologyVisualSerializableObject')  
↳ [IVisualTypologyFilterRule](DiGi.Typology.Visual.Interfaces.md#DiGi.Typology.Visual.Interfaces.IVisualTypologyFilterRule 'DiGi\.Typology\.Visual\.Interfaces\.IVisualTypologyFilterRule')  
↳ [IVisualTypologyFilterRuleData](DiGi.Typology.Visual.Interfaces.md#DiGi.Typology.Visual.Interfaces.IVisualTypologyFilterRuleData 'DiGi\.Typology\.Visual\.Interfaces\.IVisualTypologyFilterRuleData')

Implements [DiGi\.Typology\.Interfaces\.ITypologyObject](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.interfaces.itypologyobject 'DiGi\.Typology\.Interfaces\.ITypologyObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')

<a name='DiGi.Typology.Visual.Interfaces.ITypologyVisualSerializableObject'></a>

## ITypologyVisualSerializableObject Interface

Defines the contract for a typology visual object that can be serialized\.

```csharp
public interface ITypologyVisualSerializableObject : DiGi.Typology.Visual.Interfaces.ITypologyVisualObject, DiGi.Typology.Interfaces.ITypologyObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject
```

Derived  
↳ [TypologyAppearance](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.TypologyAppearance 'DiGi\.Typology\.Visual\.Classes\.TypologyAppearance')  
↳ [TypologyAppearanceCollection](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.TypologyAppearanceCollection 'DiGi\.Typology\.Visual\.Classes\.TypologyAppearanceCollection')  
↳ [VisualColumnTypologyFilter&lt;UColumn&gt;](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualColumnTypologyFilter_UColumn_ 'DiGi\.Typology\.Visual\.Classes\.VisualColumnTypologyFilter\<UColumn\>')  
↳ [VisualRangeValueFilterRule&lt;TValueType&gt;](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualRangeValueFilterRule_TValueType_ 'DiGi\.Typology\.Visual\.Classes\.VisualRangeValueFilterRule\<TValueType\>')  
↳ [VisualRangeValueRuleData&lt;TValueType&gt;](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualRangeValueRuleData_TValueType_ 'DiGi\.Typology\.Visual\.Classes\.VisualRangeValueRuleData\<TValueType\>')  
↳ [VisualTypology](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualTypology 'DiGi\.Typology\.Visual\.Classes\.VisualTypology')  
↳ [VisualTypologyItem](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualTypologyItem 'DiGi\.Typology\.Visual\.Classes\.VisualTypologyItem')  
↳ [VisualUniqueValueFilterRule](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualUniqueValueFilterRule 'DiGi\.Typology\.Visual\.Classes\.VisualUniqueValueFilterRule')  
↳ [VisualUniqueValueRuleData](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualUniqueValueRuleData 'DiGi\.Typology\.Visual\.Classes\.VisualUniqueValueRuleData')  
↳ [IVisualTypologyFilterRule](DiGi.Typology.Visual.Interfaces.md#DiGi.Typology.Visual.Interfaces.IVisualTypologyFilterRule 'DiGi\.Typology\.Visual\.Interfaces\.IVisualTypologyFilterRule')  
↳ [IVisualTypologyFilterRuleData](DiGi.Typology.Visual.Interfaces.md#DiGi.Typology.Visual.Interfaces.IVisualTypologyFilterRuleData 'DiGi\.Typology\.Visual\.Interfaces\.IVisualTypologyFilterRuleData')

Implements [ITypologyVisualObject](DiGi.Typology.Visual.Interfaces.md#DiGi.Typology.Visual.Interfaces.ITypologyVisualObject 'DiGi\.Typology\.Visual\.Interfaces\.ITypologyVisualObject'), [DiGi\.Typology\.Interfaces\.ITypologyObject](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.interfaces.itypologyobject 'DiGi\.Typology\.Interfaces\.ITypologyObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject')

<a name='DiGi.Typology.Visual.Interfaces.IVisualTypologyFilterRule'></a>

## IVisualTypologyFilterRule Interface

Defines the contract for a typology filter rule that carries the appearance of each of its buckets\.

Where a plain [DiGi\.Typology\.Interfaces\.ITypologyFilterRule](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.interfaces.itypologyfilterrule 'DiGi\.Typology\.Interfaces\.ITypologyFilterRule') resolves a value to a rule-data bucket, a visual one also
            exposes the bucket appearances, in a [TypologyAppearanceCollection](DiGi.Typology.Visual.Interfaces.md#DiGi.Typology.Visual.Interfaces.IVisualTypologyFilterRule.TypologyAppearanceCollection 'DiGi\.Typology\.Visual\.Interfaces\.IVisualTypologyFilterRule\.TypologyAppearanceCollection') keyed as
            [Key\(this object\)](DiGi.Typology.Visual.md#DiGi.Typology.Visual.Query.Key(thisobject) 'DiGi\.Typology\.Visual\.Query\.Key\(this object\)') renders the bucket, so a client can render a resolved value.

```csharp
public interface IVisualTypologyFilterRule : DiGi.Typology.Visual.Interfaces.ITypologyVisualSerializableObject, DiGi.Typology.Visual.Interfaces.ITypologyVisualObject, DiGi.Typology.Interfaces.ITypologyObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Typology.Interfaces.ITypologyFilterRule, DiGi.Typology.Interfaces.ITypologySerializableObject
```

Derived  
↳ [VisualRangeValueFilterRule&lt;TValueType&gt;](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualRangeValueFilterRule_TValueType_ 'DiGi\.Typology\.Visual\.Classes\.VisualRangeValueFilterRule\<TValueType\>')  
↳ [VisualUniqueValueFilterRule](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualUniqueValueFilterRule 'DiGi\.Typology\.Visual\.Classes\.VisualUniqueValueFilterRule')

Implements [ITypologyVisualSerializableObject](DiGi.Typology.Visual.Interfaces.md#DiGi.Typology.Visual.Interfaces.ITypologyVisualSerializableObject 'DiGi\.Typology\.Visual\.Interfaces\.ITypologyVisualSerializableObject'), [ITypologyVisualObject](DiGi.Typology.Visual.Interfaces.md#DiGi.Typology.Visual.Interfaces.ITypologyVisualObject 'DiGi\.Typology\.Visual\.Interfaces\.ITypologyVisualObject'), [DiGi\.Typology\.Interfaces\.ITypologyObject](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.interfaces.itypologyobject 'DiGi\.Typology\.Interfaces\.ITypologyObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Typology\.Interfaces\.ITypologyFilterRule](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.interfaces.itypologyfilterrule 'DiGi\.Typology\.Interfaces\.ITypologyFilterRule'), [DiGi\.Typology\.Interfaces\.ITypologySerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.interfaces.itypologyserializableobject 'DiGi\.Typology\.Interfaces\.ITypologySerializableObject')
### Properties

<a name='DiGi.Typology.Visual.Interfaces.IVisualTypologyFilterRule.TypologyAppearanceCollection'></a>

## IVisualTypologyFilterRule\.TypologyAppearanceCollection Property

Gets the appearances of the buckets of this rule, keyed by bucket\. Never null\.

```csharp
DiGi.Typology.Visual.Classes.TypologyAppearanceCollection TypologyAppearanceCollection { get; }
```

#### Property Value
[TypologyAppearanceCollection](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.TypologyAppearanceCollection 'DiGi\.Typology\.Visual\.Classes\.TypologyAppearanceCollection')

<a name='DiGi.Typology.Visual.Interfaces.IVisualTypologyFilterRuleData'></a>

## IVisualTypologyFilterRuleData Interface

Defines the contract for the rule data of a bucket that carries the bucket's appearance\.

A consumer holding an [DiGi\.Typology\.Interfaces\.ITypologyFilterRuleData](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.interfaces.itypologyfilterruledata 'DiGi\.Typology\.Interfaces\.ITypologyFilterRuleData') - a solver's `GetTypologyItem` hook, for
            one - reads the appearance through this interface without knowing which rule kind, or which closed generic
            type, produced it.

```csharp
public interface IVisualTypologyFilterRuleData : DiGi.Typology.Visual.Interfaces.ITypologyVisualSerializableObject, DiGi.Typology.Visual.Interfaces.ITypologyVisualObject, DiGi.Typology.Interfaces.ITypologyObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Typology.Interfaces.ITypologyFilterRuleData, DiGi.Typology.Interfaces.ITypologySerializableObject
```

Derived  
↳ [VisualRangeValueRuleData&lt;TValueType&gt;](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualRangeValueRuleData_TValueType_ 'DiGi\.Typology\.Visual\.Classes\.VisualRangeValueRuleData\<TValueType\>')  
↳ [VisualUniqueValueRuleData](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualUniqueValueRuleData 'DiGi\.Typology\.Visual\.Classes\.VisualUniqueValueRuleData')

Implements [ITypologyVisualSerializableObject](DiGi.Typology.Visual.Interfaces.md#DiGi.Typology.Visual.Interfaces.ITypologyVisualSerializableObject 'DiGi\.Typology\.Visual\.Interfaces\.ITypologyVisualSerializableObject'), [ITypologyVisualObject](DiGi.Typology.Visual.Interfaces.md#DiGi.Typology.Visual.Interfaces.ITypologyVisualObject 'DiGi\.Typology\.Visual\.Interfaces\.ITypologyVisualObject'), [DiGi\.Typology\.Interfaces\.ITypologyObject](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.interfaces.itypologyobject 'DiGi\.Typology\.Interfaces\.ITypologyObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Typology\.Interfaces\.ITypologyFilterRuleData](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.interfaces.itypologyfilterruledata 'DiGi\.Typology\.Interfaces\.ITypologyFilterRuleData'), [DiGi\.Typology\.Interfaces\.ITypologySerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.interfaces.itypologyserializableobject 'DiGi\.Typology\.Interfaces\.ITypologySerializableObject')
### Properties

<a name='DiGi.Typology.Visual.Interfaces.IVisualTypologyFilterRuleData.Appearance'></a>

## IVisualTypologyFilterRuleData\.Appearance Property

Gets or sets the appearance of the bucket this rule data describes, or null when it has none\.

```csharp
DiGi.Typology.Visual.Classes.TypologyAppearance? Appearance { get; set; }
```

#### Property Value
[TypologyAppearance](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.TypologyAppearance 'DiGi\.Typology\.Visual\.Classes\.TypologyAppearance')