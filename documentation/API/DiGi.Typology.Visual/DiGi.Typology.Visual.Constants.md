#### [DiGi\.Typology\.Visual](DiGi.Typology.Visual.Overview.md 'DiGi\.Typology\.Visual\.Overview')

## DiGi\.Typology\.Visual\.Constants Namespace
### Classes

<a name='DiGi.Typology.Visual.Constants.Format'></a>

## Format Class

Provides the format strings the assembly renders values with\.

```csharp
public static class Format
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Format
### Fields

<a name='DiGi.Typology.Visual.Constants.Format.DateTime'></a>

## Format\.DateTime Field

The format a [System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime') is rendered with by [Key\(this object\)](DiGi.Typology.Visual.md#DiGi.Typology.Visual.Query.Key(thisobject) 'DiGi\.Typology\.Visual\.Query\.Key\(this object\)'): ISO 8601 to
the tick, with no offset or kind designator, so two instants equal to the tick share a key whatever their
kind\.

```csharp
public const string DateTime = "yyyy-MM-ddTHH:mm:ss.fffffff";
```

#### Field Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')