#### [DiGi\.Typology](index.md 'index')

## DiGi\.Typology\.Interfaces Namespace
### Interfaces

<a name='DiGi.Typology.Interfaces.ITypologyFilter'></a>

## ITypologyFilter Interface

Defines the contract for a typology filter that can be serialized and is a typology object\.

```csharp
public interface ITypologyFilter : DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Typology.Interfaces.ITypologyObject
```

Derived  
↳ [TypologyFilter&lt;TTypologyFilter,TValue&gt;](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyFilter_TTypologyFilter,TValue_ 'DiGi\.Typology\.Classes\.TypologyFilter\<TTypologyFilter,TValue\>')  
↳ [TypologyFilter&lt;TTypologyFilter&gt;](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyFilter_TTypologyFilter_ 'DiGi\.Typology\.Classes\.TypologyFilter\<TTypologyFilter\>')  
↳ [ITypologyFilter&lt;TTypologyFilter,TValue&gt;](DiGi.Typology.Interfaces.md#DiGi.Typology.Interfaces.ITypologyFilter_TTypologyFilter,TValue_ 'DiGi\.Typology\.Interfaces\.ITypologyFilter\<TTypologyFilter,TValue\>')  
↳ [ITypologyFilter&lt;TTypologyFilter&gt;](DiGi.Typology.Interfaces.md#DiGi.Typology.Interfaces.ITypologyFilter_TTypologyFilter_ 'DiGi\.Typology\.Interfaces\.ITypologyFilter\<TTypologyFilter\>')

Implements [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Typology\.Interfaces\.ITypologyObject](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.interfaces.itypologyobject 'DiGi\.Typology\.Interfaces\.ITypologyObject')
### Properties

<a name='DiGi.Typology.Interfaces.ITypologyFilter.Rule'></a>

## ITypologyFilter\.Rule Property

Gets or sets the rule associated with this typology filter\.

```csharp
DiGi.Typology.Interfaces.ITypologyFilterRule? Rule { get; set; }
```

#### Property Value
[ITypologyFilterRule](DiGi.Typology.Interfaces.md#DiGi.Typology.Interfaces.ITypologyFilterRule 'DiGi\.Typology\.Interfaces\.ITypologyFilterRule')

<a name='DiGi.Typology.Interfaces.ITypologyFilter_TTypologyFilter,TValue_'></a>

## ITypologyFilter\<TTypologyFilter,TValue\> Interface

Defines the generic contract for a typology filter that holds a specific value\.

```csharp
public interface ITypologyFilter<TTypologyFilter,TValue> : DiGi.Typology.Interfaces.ITypologyFilter<TTypologyFilter>, DiGi.Typology.Interfaces.ITypologyFilter, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Typology.Interfaces.ITypologyObject
    where TTypologyFilter : DiGi.Typology.Interfaces.ITypologyFilter<TTypologyFilter>
```
#### Type parameters

<a name='DiGi.Typology.Interfaces.ITypologyFilter_TTypologyFilter,TValue_.TTypologyFilter'></a>

`TTypologyFilter`

The specific type of the nested filter\.

<a name='DiGi.Typology.Interfaces.ITypologyFilter_TTypologyFilter,TValue_.TValue'></a>

`TValue`

The type of value associated with this filter\.

Derived  
↳ [TypologyFilter&lt;TTypologyFilter,TValue&gt;](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyFilter_TTypologyFilter,TValue_ 'DiGi\.Typology\.Classes\.TypologyFilter\<TTypologyFilter,TValue\>')

Implements [DiGi\.Typology\.Interfaces\.ITypologyFilter&lt;](DiGi.Typology.Interfaces.md#DiGi.Typology.Interfaces.ITypologyFilter_TTypologyFilter_ 'DiGi\.Typology\.Interfaces\.ITypologyFilter\<TTypologyFilter\>')[TTypologyFilter](DiGi.Typology.Interfaces.md#DiGi.Typology.Interfaces.ITypologyFilter_TTypologyFilter,TValue_.TTypologyFilter 'DiGi\.Typology\.Interfaces\.ITypologyFilter\<TTypologyFilter,TValue\>\.TTypologyFilter')[&gt;](DiGi.Typology.Interfaces.md#DiGi.Typology.Interfaces.ITypologyFilter_TTypologyFilter_ 'DiGi\.Typology\.Interfaces\.ITypologyFilter\<TTypologyFilter\>'), [ITypologyFilter](DiGi.Typology.Interfaces.md#DiGi.Typology.Interfaces.ITypologyFilter 'DiGi\.Typology\.Interfaces\.ITypologyFilter'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Typology\.Interfaces\.ITypologyObject](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.interfaces.itypologyobject 'DiGi\.Typology\.Interfaces\.ITypologyObject')
### Properties

<a name='DiGi.Typology.Interfaces.ITypologyFilter_TTypologyFilter,TValue_.Value'></a>

## ITypologyFilter\<TTypologyFilter,TValue\>\.Value Property

Gets or sets the value associated with this typology filter\.

```csharp
TValue? Value { get; set; }
```

#### Property Value
[TValue](DiGi.Typology.Interfaces.md#DiGi.Typology.Interfaces.ITypologyFilter_TTypologyFilter,TValue_.TValue 'DiGi\.Typology\.Interfaces\.ITypologyFilter\<TTypologyFilter,TValue\>\.TValue')

<a name='DiGi.Typology.Interfaces.ITypologyFilter_TTypologyFilter_'></a>

## ITypologyFilter\<TTypologyFilter\> Interface

Defines the generic contract for a nested typology filter\.

```csharp
public interface ITypologyFilter<TTypologyFilter> : DiGi.Typology.Interfaces.ITypologyFilter, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Typology.Interfaces.ITypologyObject
    where TTypologyFilter : DiGi.Typology.Interfaces.ITypologyFilter<TTypologyFilter>
```
#### Type parameters

<a name='DiGi.Typology.Interfaces.ITypologyFilter_TTypologyFilter_.TTypologyFilter'></a>

`TTypologyFilter`

The specific type of the nested filter\.

Derived  
↳ [TypologyFilter&lt;TTypologyFilter,TValue&gt;](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyFilter_TTypologyFilter,TValue_ 'DiGi\.Typology\.Classes\.TypologyFilter\<TTypologyFilter,TValue\>')  
↳ [TypologyFilter&lt;TTypologyFilter&gt;](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyFilter_TTypologyFilter_ 'DiGi\.Typology\.Classes\.TypologyFilter\<TTypologyFilter\>')  
↳ [ITypologyFilter&lt;TTypologyFilter,TValue&gt;](DiGi.Typology.Interfaces.md#DiGi.Typology.Interfaces.ITypologyFilter_TTypologyFilter,TValue_ 'DiGi\.Typology\.Interfaces\.ITypologyFilter\<TTypologyFilter,TValue\>')

Implements [ITypologyFilter](DiGi.Typology.Interfaces.md#DiGi.Typology.Interfaces.ITypologyFilter 'DiGi\.Typology\.Interfaces\.ITypologyFilter'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Typology\.Interfaces\.ITypologyObject](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.interfaces.itypologyobject 'DiGi\.Typology\.Interfaces\.ITypologyObject')
### Properties

<a name='DiGi.Typology.Interfaces.ITypologyFilter_TTypologyFilter_.Filter'></a>

## ITypologyFilter\<TTypologyFilter\>\.Filter Property

Gets or sets the nested filter to be applied sequentially\.

```csharp
TTypologyFilter? Filter { get; set; }
```

#### Property Value
[TTypologyFilter](DiGi.Typology.Interfaces.md#DiGi.Typology.Interfaces.ITypologyFilter_TTypologyFilter_.TTypologyFilter 'DiGi\.Typology\.Interfaces\.ITypologyFilter\<TTypologyFilter\>\.TTypologyFilter')

<a name='DiGi.Typology.Interfaces.ITypologyFilterRule'></a>

## ITypologyFilterRule Interface

Defines the base contract for a typology filter rule\.

```csharp
public interface ITypologyFilterRule : DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Typology.Interfaces.ITypologyObject
```

Derived  
↳ [GroupValueFilterRule](DiGi.Typology.Classes.md#DiGi.Typology.Classes.GroupValueFilterRule 'DiGi\.Typology\.Classes\.GroupValueFilterRule')  
↳ [RangeValueFilterRule&lt;TValueType&gt;](DiGi.Typology.Classes.md#DiGi.Typology.Classes.RangeValueFilterRule_TValueType_ 'DiGi\.Typology\.Classes\.RangeValueFilterRule\<TValueType\>')  
↳ [TypologyFilterRule](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyFilterRule 'DiGi\.Typology\.Classes\.TypologyFilterRule')  
↳ [UniqueValueFilterRule](DiGi.Typology.Classes.md#DiGi.Typology.Classes.UniqueValueFilterRule 'DiGi\.Typology\.Classes\.UniqueValueFilterRule')  
↳ [ITypologyFilterRule&lt;TTypologyFilterRuleData&gt;](DiGi.Typology.Interfaces.md#DiGi.Typology.Interfaces.ITypologyFilterRule_TTypologyFilterRuleData_ 'DiGi\.Typology\.Interfaces\.ITypologyFilterRule\<TTypologyFilterRuleData\>')

Implements [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Typology\.Interfaces\.ITypologyObject](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.interfaces.itypologyobject 'DiGi\.Typology\.Interfaces\.ITypologyObject')

<a name='DiGi.Typology.Interfaces.ITypologyFilterRule_TTypologyFilterRuleData_'></a>

## ITypologyFilterRule\<TTypologyFilterRuleData\> Interface

Defines the generic contract for a typology filter rule that yields a specific filter rule data type\.

```csharp
public interface ITypologyFilterRule<TTypologyFilterRuleData> : DiGi.Typology.Interfaces.ITypologyFilterRule, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Typology.Interfaces.ITypologyObject
    where TTypologyFilterRuleData : DiGi.Typology.Interfaces.ITypologyFilterRuleData
```
#### Type parameters

<a name='DiGi.Typology.Interfaces.ITypologyFilterRule_TTypologyFilterRuleData_.TTypologyFilterRuleData'></a>

`TTypologyFilterRuleData`

The type of the filter rule data returned by this rule\.

Derived  
↳ [RangeValueFilterRule&lt;TValueType&gt;](DiGi.Typology.Classes.md#DiGi.Typology.Classes.RangeValueFilterRule_TValueType_ 'DiGi\.Typology\.Classes\.RangeValueFilterRule\<TValueType\>')  
↳ [UniqueValueFilterRule](DiGi.Typology.Classes.md#DiGi.Typology.Classes.UniqueValueFilterRule 'DiGi\.Typology\.Classes\.UniqueValueFilterRule')

Implements [ITypologyFilterRule](DiGi.Typology.Interfaces.md#DiGi.Typology.Interfaces.ITypologyFilterRule 'DiGi\.Typology\.Interfaces\.ITypologyFilterRule'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Typology\.Interfaces\.ITypologyObject](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.interfaces.itypologyobject 'DiGi\.Typology\.Interfaces\.ITypologyObject')
### Methods

<a name='DiGi.Typology.Interfaces.ITypologyFilterRule_TTypologyFilterRuleData_.RuleData(object)'></a>

## ITypologyFilterRule\<TTypologyFilterRuleData\>\.RuleData\(object\) Method

Retrieves the typology filter rule data based on the provided object value\.

```csharp
TTypologyFilterRuleData? RuleData(object? value);
```
#### Parameters

<a name='DiGi.Typology.Interfaces.ITypologyFilterRule_TTypologyFilterRuleData_.RuleData(object).value'></a>

`value` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The object value to evaluate against the rule\.

#### Returns
[TTypologyFilterRuleData](DiGi.Typology.Interfaces.md#DiGi.Typology.Interfaces.ITypologyFilterRule_TTypologyFilterRuleData_.TTypologyFilterRuleData 'DiGi\.Typology\.Interfaces\.ITypologyFilterRule\<TTypologyFilterRuleData\>\.TTypologyFilterRuleData')  
The matching typology filter rule data instance, or null if no match is found\.

<a name='DiGi.Typology.Interfaces.ITypologyFilterRuleData'></a>

## ITypologyFilterRuleData Interface

Defines the base contract for typology filter rule data\.

```csharp
public interface ITypologyFilterRuleData : DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Typology.Interfaces.ITypologyObject
```

Derived  
↳ [TypologyFilterRuleData&lt;TTypologyFilterRuleData&gt;](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyFilterRuleData_TTypologyFilterRuleData_ 'DiGi\.Typology\.Classes\.TypologyFilterRuleData\<TTypologyFilterRuleData\>')  
↳ [ITypologyFilterRuleData&lt;TTypologyFilterRuleData&gt;](DiGi.Typology.Interfaces.md#DiGi.Typology.Interfaces.ITypologyFilterRuleData_TTypologyFilterRuleData_ 'DiGi\.Typology\.Interfaces\.ITypologyFilterRuleData\<TTypologyFilterRuleData\>')

Implements [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Typology\.Interfaces\.ITypologyObject](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.interfaces.itypologyobject 'DiGi\.Typology\.Interfaces\.ITypologyObject')

<a name='DiGi.Typology.Interfaces.ITypologyFilterRuleData_TTypologyFilterRuleData_'></a>

## ITypologyFilterRuleData\<TTypologyFilterRuleData\> Interface

Defines the generic contract for typology filter rule data with equatable functionality\.

```csharp
public interface ITypologyFilterRuleData<TTypologyFilterRuleData> : DiGi.Typology.Interfaces.ITypologyFilterRuleData, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Typology.Interfaces.ITypologyObject, System.IEquatable<TTypologyFilterRuleData>
    where TTypologyFilterRuleData : DiGi.Typology.Interfaces.ITypologyFilterRuleData<TTypologyFilterRuleData>
```
#### Type parameters

<a name='DiGi.Typology.Interfaces.ITypologyFilterRuleData_TTypologyFilterRuleData_.TTypologyFilterRuleData'></a>

`TTypologyFilterRuleData`

The specific type of the typology filter rule data for comparison\.

Derived  
↳ [TypologyFilterRuleData&lt;TTypologyFilterRuleData&gt;](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyFilterRuleData_TTypologyFilterRuleData_ 'DiGi\.Typology\.Classes\.TypologyFilterRuleData\<TTypologyFilterRuleData\>')

Implements [ITypologyFilterRuleData](DiGi.Typology.Interfaces.md#DiGi.Typology.Interfaces.ITypologyFilterRuleData 'DiGi\.Typology\.Interfaces\.ITypologyFilterRuleData'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Typology\.Interfaces\.ITypologyObject](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.interfaces.itypologyobject 'DiGi\.Typology\.Interfaces\.ITypologyObject'), [System\.IEquatable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.iequatable-1 'System\.IEquatable\`1')[TTypologyFilterRuleData](DiGi.Typology.Interfaces.md#DiGi.Typology.Interfaces.ITypologyFilterRuleData_TTypologyFilterRuleData_.TTypologyFilterRuleData 'DiGi\.Typology\.Interfaces\.ITypologyFilterRuleData\<TTypologyFilterRuleData\>\.TTypologyFilterRuleData')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.iequatable-1 'System\.IEquatable\`1')