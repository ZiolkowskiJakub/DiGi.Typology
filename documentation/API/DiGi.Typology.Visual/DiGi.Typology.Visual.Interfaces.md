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
↳ [VisualColumnTypologyFilter](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualColumnTypologyFilter 'DiGi\.Typology\.Visual\.Classes\.VisualColumnTypologyFilter')  
↳ [VisualRange&lt;T&gt;](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualRange_T_ 'DiGi\.Typology\.Visual\.Classes\.VisualRange\<T\>')  
↳ [VisualTypology](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualTypology 'DiGi\.Typology\.Visual\.Classes\.VisualTypology')  
↳ [VisualTypologyItem](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualTypologyItem 'DiGi\.Typology\.Visual\.Classes\.VisualTypologyItem')  
↳ [VisualUniqueValueFilterRule](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualUniqueValueFilterRule 'DiGi\.Typology\.Visual\.Classes\.VisualUniqueValueFilterRule')  
↳ [ITypologyVisualSerializableObject](DiGi.Typology.Visual.Interfaces.md#DiGi.Typology.Visual.Interfaces.ITypologyVisualSerializableObject 'DiGi\.Typology\.Visual\.Interfaces\.ITypologyVisualSerializableObject')

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
↳ [VisualColumnTypologyFilter](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualColumnTypologyFilter 'DiGi\.Typology\.Visual\.Classes\.VisualColumnTypologyFilter')  
↳ [VisualRange&lt;T&gt;](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualRange_T_ 'DiGi\.Typology\.Visual\.Classes\.VisualRange\<T\>')  
↳ [VisualTypology](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualTypology 'DiGi\.Typology\.Visual\.Classes\.VisualTypology')  
↳ [VisualTypologyItem](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualTypologyItem 'DiGi\.Typology\.Visual\.Classes\.VisualTypologyItem')  
↳ [VisualUniqueValueFilterRule](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualUniqueValueFilterRule 'DiGi\.Typology\.Visual\.Classes\.VisualUniqueValueFilterRule')

Implements [ITypologyVisualObject](DiGi.Typology.Visual.Interfaces.md#DiGi.Typology.Visual.Interfaces.ITypologyVisualObject 'DiGi\.Typology\.Visual\.Interfaces\.ITypologyVisualObject'), [DiGi\.Typology\.Interfaces\.ITypologyObject](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.interfaces.itypologyobject 'DiGi\.Typology\.Interfaces\.ITypologyObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject')