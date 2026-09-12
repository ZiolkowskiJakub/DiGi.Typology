#### [DiGi\.Typology\.Visual](DiGi.Typology.Visual.Overview.md 'DiGi\.Typology\.Visual\.Overview')

## DiGi\.Typology\.Visual Namespace
### Classes

<a name='DiGi.Typology.Visual.Create'></a>

## Create Class

```csharp
public static class Create
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Create
### Methods

<a name='DiGi.Typology.Visual.Create.VisualTypology(thisDiGi.Core.IO.Table.Classes.Table,DiGi.Typology.Visual.Classes.VisualColumnTypologyFilter_DiGi.Core.IO.Table.Classes.Column_,DiGi.Core.IO.Table.Classes.Column,DiGi.Typology.Visual.Classes.VisualTypologyItem,bool)'></a>

## Create\.VisualTypology\(this Table, VisualColumnTypologyFilter\<Column\>, Column, VisualTypologyItem, bool\) Method

Classifies the rows of a table into a Visual typology tree, grouping them by the chained columns of a Visual
column typology filter, so that each node also carries the appearance of the bucket it came from\.

Each level of the chain resolves its column against the table by unique id, so a chain may be declared
            from columns that carry no table index: an index belongs to the table a column was added to rather than to
            the column itself. The caller's chain is never modified - a new chain is built over the table's own column
            instances, reusing the rule of each level rather than copying it, so a Visual rule's appearance collection is
            the one read at solve time.

A node is named and described exactly as the base solver names it: the level's column name and the rule
            data's text, and the column's description when the column carries one. Its appearance is the one the rule data
            carries - see [IVisualTypologyFilterRuleData](DiGi.Typology.Visual.Interfaces.md#DiGi.Typology.Visual.Interfaces.IVisualTypologyFilterRuleData 'DiGi\.Typology\.Visual\.Interfaces\.IVisualTypologyFilterRuleData') - or null when the rule maps none for that
            bucket, or when the level carries a base rule: no member of the level itself carries a fallback.

A row whose value resolves to no bucket at a level is excluded from that level's subtree, and from every
            level below it. A range rule resolves nothing for a null value, a value it cannot convert, and a value outside
            every declared range, so rows with no value in a range column are absent below that point. A unique value rule
            buckets nulls instead, under the name "null". There is no catch-all bucket.

With [includeReferences](DiGi.Typology.Visual.md#DiGi.Typology.Visual.Create.VisualTypology(thisDiGi.Core.IO.Table.Classes.Table,DiGi.Typology.Visual.Classes.VisualColumnTypologyFilter_DiGi.Core.IO.Table.Classes.Column_,DiGi.Core.IO.Table.Classes.Column,DiGi.Typology.Visual.Classes.VisualTypologyItem,bool).includeReferences 'DiGi\.Typology\.Visual\.Create\.VisualTypology\(this DiGi\.Core\.IO\.Table\.Classes\.Table, DiGi\.Typology\.Visual\.Classes\.VisualColumnTypologyFilter\<DiGi\.Core\.IO\.Table\.Classes\.Column\>, DiGi\.Core\.IO\.Table\.Classes\.Column, DiGi\.Typology\.Visual\.Classes\.VisualTypologyItem, bool\)\.includeReferences') set, every node from the matched one up to the root stores the
            reference - the reference column's cell value, read from the resolved column - so an ancestor's references are
            those of its whole subtree. Clear it to solve structure, node metadata and appearance only, for a tree whose
            node to object association is held elsewhere.

A chain this cannot honour in full is refused rather than solved in part: a level naming a column the
            table does not hold, a level carrying no rule, and a chain linking back on itself all return null, because
            each would otherwise answer with a tree ending above the level that was asked for. An empty table returns null
            for the same reason - there is nothing to answer with.

```csharp
public static DiGi.Typology.Visual.Classes.VisualTypology? VisualTypology(this DiGi.Core.IO.Table.Classes.Table? table, DiGi.Typology.Visual.Classes.VisualColumnTypologyFilter<DiGi.Core.IO.Table.Classes.Column>? columnTypologyFilter, DiGi.Core.IO.Table.Classes.Column? column_Reference, DiGi.Typology.Visual.Classes.VisualTypologyItem? typologyItem_Root=null, bool includeReferences=true);
```
#### Parameters

<a name='DiGi.Typology.Visual.Create.VisualTypology(thisDiGi.Core.IO.Table.Classes.Table,DiGi.Typology.Visual.Classes.VisualColumnTypologyFilter_DiGi.Core.IO.Table.Classes.Column_,DiGi.Core.IO.Table.Classes.Column,DiGi.Typology.Visual.Classes.VisualTypologyItem,bool).table'></a>

`table` [DiGi\.Core\.IO\.Table\.Classes\.Table](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.table.classes.table 'DiGi\.Core\.IO\.Table\.Classes\.Table')

The table whose rows are classified\.

<a name='DiGi.Typology.Visual.Create.VisualTypology(thisDiGi.Core.IO.Table.Classes.Table,DiGi.Typology.Visual.Classes.VisualColumnTypologyFilter_DiGi.Core.IO.Table.Classes.Column_,DiGi.Core.IO.Table.Classes.Column,DiGi.Typology.Visual.Classes.VisualTypologyItem,bool).columnTypologyFilter'></a>

`columnTypologyFilter` [DiGi\.Typology\.Visual\.Classes\.VisualColumnTypologyFilter&lt;](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualColumnTypologyFilter_UColumn_ 'DiGi\.Typology\.Visual\.Classes\.VisualColumnTypologyFilter\<UColumn\>')[DiGi\.Core\.IO\.Table\.Classes\.Column](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.table.classes.column 'DiGi\.Core\.IO\.Table\.Classes\.Column')[&gt;](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualColumnTypologyFilter_UColumn_ 'DiGi\.Typology\.Visual\.Classes\.VisualColumnTypologyFilter\<UColumn\>')

The root of the Visual filter chain describing the grouping levels\.

<a name='DiGi.Typology.Visual.Create.VisualTypology(thisDiGi.Core.IO.Table.Classes.Table,DiGi.Typology.Visual.Classes.VisualColumnTypologyFilter_DiGi.Core.IO.Table.Classes.Column_,DiGi.Core.IO.Table.Classes.Column,DiGi.Typology.Visual.Classes.VisualTypologyItem,bool).column_Reference'></a>

`column_Reference` [DiGi\.Core\.IO\.Table\.Classes\.Column](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.table.classes.column 'DiGi\.Core\.IO\.Table\.Classes\.Column')

The column identifying a row\. Resolved against the table by unique id, and required unless [includeReferences](DiGi.Typology.Visual.md#DiGi.Typology.Visual.Create.VisualTypology(thisDiGi.Core.IO.Table.Classes.Table,DiGi.Typology.Visual.Classes.VisualColumnTypologyFilter_DiGi.Core.IO.Table.Classes.Column_,DiGi.Core.IO.Table.Classes.Column,DiGi.Typology.Visual.Classes.VisualTypologyItem,bool).includeReferences 'DiGi\.Typology\.Visual\.Create\.VisualTypology\(this DiGi\.Core\.IO\.Table\.Classes\.Table, DiGi\.Typology\.Visual\.Classes\.VisualColumnTypologyFilter\<DiGi\.Core\.IO\.Table\.Classes\.Column\>, DiGi\.Core\.IO\.Table\.Classes\.Column, DiGi\.Typology\.Visual\.Classes\.VisualTypologyItem, bool\)\.includeReferences') is cleared\.

<a name='DiGi.Typology.Visual.Create.VisualTypology(thisDiGi.Core.IO.Table.Classes.Table,DiGi.Typology.Visual.Classes.VisualColumnTypologyFilter_DiGi.Core.IO.Table.Classes.Column_,DiGi.Core.IO.Table.Classes.Column,DiGi.Typology.Visual.Classes.VisualTypologyItem,bool).typologyItem_Root'></a>

`typologyItem_Root` [VisualTypologyItem](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualTypologyItem 'DiGi\.Typology\.Visual\.Classes\.VisualTypologyItem')

The item naming the root node\. When null the root is left unnamed\.

<a name='DiGi.Typology.Visual.Create.VisualTypology(thisDiGi.Core.IO.Table.Classes.Table,DiGi.Typology.Visual.Classes.VisualColumnTypologyFilter_DiGi.Core.IO.Table.Classes.Column_,DiGi.Core.IO.Table.Classes.Column,DiGi.Typology.Visual.Classes.VisualTypologyItem,bool).includeReferences'></a>

`includeReferences` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A value indicating whether the identified references are stored on the nodes\.

#### Returns
[VisualTypology](DiGi.Typology.Visual.Classes.md#DiGi.Typology.Visual.Classes.VisualTypology 'DiGi\.Typology\.Visual\.Classes\.VisualTypology')  
The solved Visual typology, or null when the table or the chain is null, when the table holds no rows, when a column named by the chain is absent from the table, when a level of the chain carries no rule, when the chain links back on itself, or when a required reference column is absent or unresolvable\.

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