#### [DiGi\.Typology](DiGi.Typology.Overview.md 'DiGi\.Typology\.Overview')

## DiGi\.Typology\.Classes Namespace
### Classes

<a name='DiGi.Typology.Classes.ColumnTypologyFilter'></a>

## ColumnTypologyFilter Class

Represents a concrete column\-based typology filter using the standard [DiGi\.Core\.IO\.Table\.Classes\.Column](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.table.classes.column 'DiGi\.Core\.IO\.Table\.Classes\.Column') type\.

```csharp
public class ColumnTypologyFilter : DiGi.Typology.Classes.ColumnTypologyFilter<DiGi.Core.IO.Table.Classes.Column>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Typology\.Classes\.TypologyFilter&lt;](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyFilter_TTypologyFilter_ 'DiGi\.Typology\.Classes\.TypologyFilter\<TTypologyFilter\>')[DiGi\.Typology\.Classes\.ColumnTypologyFilter&lt;](DiGi.Typology.Classes.md#DiGi.Typology.Classes.ColumnTypologyFilter_UColumn_ 'DiGi\.Typology\.Classes\.ColumnTypologyFilter\<UColumn\>')[DiGi\.Core\.IO\.Table\.Classes\.Column](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.table.classes.column 'DiGi\.Core\.IO\.Table\.Classes\.Column')[&gt;](DiGi.Typology.Classes.md#DiGi.Typology.Classes.ColumnTypologyFilter_UColumn_ 'DiGi\.Typology\.Classes\.ColumnTypologyFilter\<UColumn\>')[&gt;](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyFilter_TTypologyFilter_ 'DiGi\.Typology\.Classes\.TypologyFilter\<TTypologyFilter\>') → [DiGi\.Typology\.Classes\.TypologyFilter&lt;](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyFilter_TTypologyFilter,TValue_ 'DiGi\.Typology\.Classes\.TypologyFilter\<TTypologyFilter,TValue\>')[DiGi\.Typology\.Classes\.ColumnTypologyFilter&lt;](DiGi.Typology.Classes.md#DiGi.Typology.Classes.ColumnTypologyFilter_UColumn_ 'DiGi\.Typology\.Classes\.ColumnTypologyFilter\<UColumn\>')[DiGi\.Core\.IO\.Table\.Classes\.Column](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.table.classes.column 'DiGi\.Core\.IO\.Table\.Classes\.Column')[&gt;](DiGi.Typology.Classes.md#DiGi.Typology.Classes.ColumnTypologyFilter_UColumn_ 'DiGi\.Typology\.Classes\.ColumnTypologyFilter\<UColumn\>')[,](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyFilter_TTypologyFilter,TValue_ 'DiGi\.Typology\.Classes\.TypologyFilter\<TTypologyFilter,TValue\>')[DiGi\.Core\.IO\.Table\.Classes\.Column](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.table.classes.column 'DiGi\.Core\.IO\.Table\.Classes\.Column')[&gt;](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyFilter_TTypologyFilter,TValue_ 'DiGi\.Typology\.Classes\.TypologyFilter\<TTypologyFilter,TValue\>') → [DiGi\.Typology\.Classes\.ColumnTypologyFilter&lt;](DiGi.Typology.Classes.md#DiGi.Typology.Classes.ColumnTypologyFilter_UColumn_ 'DiGi\.Typology\.Classes\.ColumnTypologyFilter\<UColumn\>')[DiGi\.Core\.IO\.Table\.Classes\.Column](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.table.classes.column 'DiGi\.Core\.IO\.Table\.Classes\.Column')[&gt;](DiGi.Typology.Classes.md#DiGi.Typology.Classes.ColumnTypologyFilter_UColumn_ 'DiGi\.Typology\.Classes\.ColumnTypologyFilter\<UColumn\>') → ColumnTypologyFilter
### Constructors

<a name='DiGi.Typology.Classes.ColumnTypologyFilter.ColumnTypologyFilter()'></a>

## ColumnTypologyFilter\(\) Constructor

Initializes a new instance of the [ColumnTypologyFilter](DiGi.Typology.Classes.md#DiGi.Typology.Classes.ColumnTypologyFilter 'DiGi\.Typology\.Classes\.ColumnTypologyFilter') class\.

```csharp
public ColumnTypologyFilter();
```

<a name='DiGi.Typology.Classes.ColumnTypologyFilter.ColumnTypologyFilter(DiGi.Typology.Classes.ColumnTypologyFilter)'></a>

## ColumnTypologyFilter\(ColumnTypologyFilter\) Constructor

Initializes a new instance of the [ColumnTypologyFilter](DiGi.Typology.Classes.md#DiGi.Typology.Classes.ColumnTypologyFilter 'DiGi\.Typology\.Classes\.ColumnTypologyFilter') class by copying another instance\.

```csharp
public ColumnTypologyFilter(DiGi.Typology.Classes.ColumnTypologyFilter? columnTypologyFilter);
```
#### Parameters

<a name='DiGi.Typology.Classes.ColumnTypologyFilter.ColumnTypologyFilter(DiGi.Typology.Classes.ColumnTypologyFilter).columnTypologyFilter'></a>

`columnTypologyFilter` [ColumnTypologyFilter](DiGi.Typology.Classes.md#DiGi.Typology.Classes.ColumnTypologyFilter 'DiGi\.Typology\.Classes\.ColumnTypologyFilter')

The column typology filter to copy\.

<a name='DiGi.Typology.Classes.ColumnTypologyFilter.ColumnTypologyFilter(System.Text.Json.Nodes.JsonObject)'></a>

## ColumnTypologyFilter\(JsonObject\) Constructor

Initializes a new instance of the [ColumnTypologyFilter](DiGi.Typology.Classes.md#DiGi.Typology.Classes.ColumnTypologyFilter 'DiGi\.Typology\.Classes\.ColumnTypologyFilter') class from a JSON object\.

```csharp
public ColumnTypologyFilter(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Typology.Classes.ColumnTypologyFilter.ColumnTypologyFilter(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the filter data\.

<a name='DiGi.Typology.Classes.ColumnTypologyFilter_UColumn_'></a>

## ColumnTypologyFilter\<UColumn\> Class

Represents a typology filter based on columns of type [DiGi\.Core\.IO\.Table\.Interfaces\.IColumn](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.table.interfaces.icolumn 'DiGi\.Core\.IO\.Table\.Interfaces\.IColumn')\.

```csharp
public class ColumnTypologyFilter<UColumn> : DiGi.Typology.Classes.TypologyFilter<DiGi.Typology.Classes.ColumnTypologyFilter<UColumn>, UColumn>
    where UColumn : DiGi.Core.IO.Table.Interfaces.IColumn
```
#### Type parameters

<a name='DiGi.Typology.Classes.ColumnTypologyFilter_UColumn_.UColumn'></a>

`UColumn`

The column type implementing [DiGi\.Core\.IO\.Table\.Interfaces\.IColumn](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.table.interfaces.icolumn 'DiGi\.Core\.IO\.Table\.Interfaces\.IColumn')\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Typology\.Classes\.TypologyFilter&lt;](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyFilter_TTypologyFilter_ 'DiGi\.Typology\.Classes\.TypologyFilter\<TTypologyFilter\>')[DiGi\.Typology\.Classes\.ColumnTypologyFilter&lt;](DiGi.Typology.Classes.md#DiGi.Typology.Classes.ColumnTypologyFilter_UColumn_ 'DiGi\.Typology\.Classes\.ColumnTypologyFilter\<UColumn\>')[UColumn](DiGi.Typology.Classes.md#DiGi.Typology.Classes.ColumnTypologyFilter_UColumn_.UColumn 'DiGi\.Typology\.Classes\.ColumnTypologyFilter\<UColumn\>\.UColumn')[&gt;](DiGi.Typology.Classes.md#DiGi.Typology.Classes.ColumnTypologyFilter_UColumn_ 'DiGi\.Typology\.Classes\.ColumnTypologyFilter\<UColumn\>')[&gt;](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyFilter_TTypologyFilter_ 'DiGi\.Typology\.Classes\.TypologyFilter\<TTypologyFilter\>') → [DiGi\.Typology\.Classes\.TypologyFilter&lt;](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyFilter_TTypologyFilter,TValue_ 'DiGi\.Typology\.Classes\.TypologyFilter\<TTypologyFilter,TValue\>')[DiGi\.Typology\.Classes\.ColumnTypologyFilter&lt;](DiGi.Typology.Classes.md#DiGi.Typology.Classes.ColumnTypologyFilter_UColumn_ 'DiGi\.Typology\.Classes\.ColumnTypologyFilter\<UColumn\>')[UColumn](DiGi.Typology.Classes.md#DiGi.Typology.Classes.ColumnTypologyFilter_UColumn_.UColumn 'DiGi\.Typology\.Classes\.ColumnTypologyFilter\<UColumn\>\.UColumn')[&gt;](DiGi.Typology.Classes.md#DiGi.Typology.Classes.ColumnTypologyFilter_UColumn_ 'DiGi\.Typology\.Classes\.ColumnTypologyFilter\<UColumn\>')[,](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyFilter_TTypologyFilter,TValue_ 'DiGi\.Typology\.Classes\.TypologyFilter\<TTypologyFilter,TValue\>')[UColumn](DiGi.Typology.Classes.md#DiGi.Typology.Classes.ColumnTypologyFilter_UColumn_.UColumn 'DiGi\.Typology\.Classes\.ColumnTypologyFilter\<UColumn\>\.UColumn')[&gt;](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyFilter_TTypologyFilter,TValue_ 'DiGi\.Typology\.Classes\.TypologyFilter\<TTypologyFilter,TValue\>') → ColumnTypologyFilter\<UColumn\>

Derived  
↳ [ColumnTypologyFilter](DiGi.Typology.Classes.md#DiGi.Typology.Classes.ColumnTypologyFilter 'DiGi\.Typology\.Classes\.ColumnTypologyFilter')
### Constructors

<a name='DiGi.Typology.Classes.ColumnTypologyFilter_UColumn_.ColumnTypologyFilter()'></a>

## ColumnTypologyFilter\(\) Constructor

Initializes a new instance of the [ColumnTypologyFilter&lt;UColumn&gt;](DiGi.Typology.Classes.md#DiGi.Typology.Classes.ColumnTypologyFilter_UColumn_ 'DiGi\.Typology\.Classes\.ColumnTypologyFilter\<UColumn\>') class\.

```csharp
public ColumnTypologyFilter();
```

<a name='DiGi.Typology.Classes.ColumnTypologyFilter_UColumn_.ColumnTypologyFilter(DiGi.Typology.Classes.ColumnTypologyFilter_UColumn_)'></a>

## ColumnTypologyFilter\(ColumnTypologyFilter\<UColumn\>\) Constructor

Initializes a new instance of the [ColumnTypologyFilter&lt;UColumn&gt;](DiGi.Typology.Classes.md#DiGi.Typology.Classes.ColumnTypologyFilter_UColumn_ 'DiGi\.Typology\.Classes\.ColumnTypologyFilter\<UColumn\>') class by copying another instance\.

```csharp
public ColumnTypologyFilter(DiGi.Typology.Classes.ColumnTypologyFilter<UColumn>? columnTypologyFilter);
```
#### Parameters

<a name='DiGi.Typology.Classes.ColumnTypologyFilter_UColumn_.ColumnTypologyFilter(DiGi.Typology.Classes.ColumnTypologyFilter_UColumn_).columnTypologyFilter'></a>

`columnTypologyFilter` [DiGi\.Typology\.Classes\.ColumnTypologyFilter&lt;](DiGi.Typology.Classes.md#DiGi.Typology.Classes.ColumnTypologyFilter_UColumn_ 'DiGi\.Typology\.Classes\.ColumnTypologyFilter\<UColumn\>')[UColumn](DiGi.Typology.Classes.md#DiGi.Typology.Classes.ColumnTypologyFilter_UColumn_.UColumn 'DiGi\.Typology\.Classes\.ColumnTypologyFilter\<UColumn\>\.UColumn')[&gt;](DiGi.Typology.Classes.md#DiGi.Typology.Classes.ColumnTypologyFilter_UColumn_ 'DiGi\.Typology\.Classes\.ColumnTypologyFilter\<UColumn\>')

The column typology filter to copy\.

<a name='DiGi.Typology.Classes.ColumnTypologyFilter_UColumn_.ColumnTypologyFilter(System.Text.Json.Nodes.JsonObject)'></a>

## ColumnTypologyFilter\(JsonObject\) Constructor

Initializes a new instance of the [ColumnTypologyFilter&lt;UColumn&gt;](DiGi.Typology.Classes.md#DiGi.Typology.Classes.ColumnTypologyFilter_UColumn_ 'DiGi\.Typology\.Classes\.ColumnTypologyFilter\<UColumn\>') class from a JSON object\.

```csharp
public ColumnTypologyFilter(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Typology.Classes.ColumnTypologyFilter_UColumn_.ColumnTypologyFilter(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the filter data\.

<a name='DiGi.Typology.Classes.ColumnTypologyFilterSolver_TColumn,TRow_'></a>

## ColumnTypologyFilterSolver\<TColumn,TRow\> Class

Solver that applies a [ColumnTypologyFilter&lt;UColumn&gt;](DiGi.Typology.Classes.md#DiGi.Typology.Classes.ColumnTypologyFilter_UColumn_ 'DiGi\.Typology\.Classes\.ColumnTypologyFilter\<UColumn\>') to a collection of rows to resolve typologies\.

```csharp
public class ColumnTypologyFilterSolver<TColumn,TRow> : DiGi.Typology.Classes.TypologyFilterSolver<DiGi.Typology.Classes.ColumnTypologyFilter<TColumn>, TRow>
    where TColumn : DiGi.Core.IO.Table.Interfaces.IColumn
    where TRow : DiGi.Core.IO.Table.Interfaces.IRow<TRow>
```
#### Type parameters

<a name='DiGi.Typology.Classes.ColumnTypologyFilterSolver_TColumn,TRow_.TColumn'></a>

`TColumn`

The column type implementing [DiGi\.Core\.IO\.Table\.Interfaces\.IColumn](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.table.interfaces.icolumn 'DiGi\.Core\.IO\.Table\.Interfaces\.IColumn')\.

<a name='DiGi.Typology.Classes.ColumnTypologyFilterSolver_TColumn,TRow_.TRow'></a>

`TRow`

The row type implementing [DiGi\.Core\.IO\.Table\.Interfaces\.IRow&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.table.interfaces.irow-1 'DiGi\.Core\.IO\.Table\.Interfaces\.IRow\`1')\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Typology\.Classes\.TypologyFilterSolver&lt;](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyFilterSolver_TTypologyFilter,TObject_ 'DiGi\.Typology\.Classes\.TypologyFilterSolver\<TTypologyFilter,TObject\>')[DiGi\.Typology\.Classes\.ColumnTypologyFilter&lt;](DiGi.Typology.Classes.md#DiGi.Typology.Classes.ColumnTypologyFilter_UColumn_ 'DiGi\.Typology\.Classes\.ColumnTypologyFilter\<UColumn\>')[TColumn](DiGi.Typology.Classes.md#DiGi.Typology.Classes.ColumnTypologyFilterSolver_TColumn,TRow_.TColumn 'DiGi\.Typology\.Classes\.ColumnTypologyFilterSolver\<TColumn,TRow\>\.TColumn')[&gt;](DiGi.Typology.Classes.md#DiGi.Typology.Classes.ColumnTypologyFilter_UColumn_ 'DiGi\.Typology\.Classes\.ColumnTypologyFilter\<UColumn\>')[,](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyFilterSolver_TTypologyFilter,TObject_ 'DiGi\.Typology\.Classes\.TypologyFilterSolver\<TTypologyFilter,TObject\>')[TRow](DiGi.Typology.Classes.md#DiGi.Typology.Classes.ColumnTypologyFilterSolver_TColumn,TRow_.TRow 'DiGi\.Typology\.Classes\.ColumnTypologyFilterSolver\<TColumn,TRow\>\.TRow')[&gt;](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyFilterSolver_TTypologyFilter,TObject_ 'DiGi\.Typology\.Classes\.TypologyFilterSolver\<TTypologyFilter,TObject\>') → ColumnTypologyFilterSolver\<TColumn,TRow\>
### Constructors

<a name='DiGi.Typology.Classes.ColumnTypologyFilterSolver_TColumn,TRow_.ColumnTypologyFilterSolver()'></a>

## ColumnTypologyFilterSolver\(\) Constructor

Initializes a new instance of the [ColumnTypologyFilterSolver&lt;TColumn,TRow&gt;](DiGi.Typology.Classes.md#DiGi.Typology.Classes.ColumnTypologyFilterSolver_TColumn,TRow_ 'DiGi\.Typology\.Classes\.ColumnTypologyFilterSolver\<TColumn,TRow\>') class\.

```csharp
public ColumnTypologyFilterSolver();
```

<a name='DiGi.Typology.Classes.ColumnTypologyFilterSolver_TColumn,TRow_.ColumnTypologyFilterSolver(DiGi.Typology.Classes.ColumnTypologyFilter_TColumn_,DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_)'></a>

## ColumnTypologyFilterSolver\(ColumnTypologyFilter\<TColumn\>, Table\<TColumn,TRow\>\) Constructor

Initializes a new instance of the [ColumnTypologyFilterSolver&lt;TColumn,TRow&gt;](DiGi.Typology.Classes.md#DiGi.Typology.Classes.ColumnTypologyFilterSolver_TColumn,TRow_ 'DiGi\.Typology\.Classes\.ColumnTypologyFilterSolver\<TColumn,TRow\>') class using a specified column filter and data table\.

```csharp
public ColumnTypologyFilterSolver(DiGi.Typology.Classes.ColumnTypologyFilter<TColumn> columnTypologyFilter, DiGi.Core.IO.Table.Classes.Table<TColumn,TRow> table);
```
#### Parameters

<a name='DiGi.Typology.Classes.ColumnTypologyFilterSolver_TColumn,TRow_.ColumnTypologyFilterSolver(DiGi.Typology.Classes.ColumnTypologyFilter_TColumn_,DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_).columnTypologyFilter'></a>

`columnTypologyFilter` [DiGi\.Typology\.Classes\.ColumnTypologyFilter&lt;](DiGi.Typology.Classes.md#DiGi.Typology.Classes.ColumnTypologyFilter_UColumn_ 'DiGi\.Typology\.Classes\.ColumnTypologyFilter\<UColumn\>')[TColumn](DiGi.Typology.Classes.md#DiGi.Typology.Classes.ColumnTypologyFilterSolver_TColumn,TRow_.TColumn 'DiGi\.Typology\.Classes\.ColumnTypologyFilterSolver\<TColumn,TRow\>\.TColumn')[&gt;](DiGi.Typology.Classes.md#DiGi.Typology.Classes.ColumnTypologyFilter_UColumn_ 'DiGi\.Typology\.Classes\.ColumnTypologyFilter\<UColumn\>')

The column typology filter to apply\.

<a name='DiGi.Typology.Classes.ColumnTypologyFilterSolver_TColumn,TRow_.ColumnTypologyFilterSolver(DiGi.Typology.Classes.ColumnTypologyFilter_TColumn_,DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_).table'></a>

`table` [DiGi\.Core\.IO\.Table\.Classes\.Table&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.table.classes.table-2 'DiGi\.Core\.IO\.Table\.Classes\.Table\`2')[TColumn](DiGi.Typology.Classes.md#DiGi.Typology.Classes.ColumnTypologyFilterSolver_TColumn,TRow_.TColumn 'DiGi\.Typology\.Classes\.ColumnTypologyFilterSolver\<TColumn,TRow\>\.TColumn')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.table.classes.table-2 'DiGi\.Core\.IO\.Table\.Classes\.Table\`2')[TRow](DiGi.Typology.Classes.md#DiGi.Typology.Classes.ColumnTypologyFilterSolver_TColumn,TRow_.TRow 'DiGi\.Typology\.Classes\.ColumnTypologyFilterSolver\<TColumn,TRow\>\.TRow')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.table.classes.table-2 'DiGi\.Core\.IO\.Table\.Classes\.Table\`2')

The data table containing rows to evaluate\.

<a name='DiGi.Typology.Classes.ColumnTypologyFilterSolver_TColumn,TRow_.ColumnTypologyFilterSolver(DiGi.Typology.Classes.ColumnTypologyFilter_TColumn_,System.Collections.Generic.IEnumerable_TRow_)'></a>

## ColumnTypologyFilterSolver\(ColumnTypologyFilter\<TColumn\>, IEnumerable\<TRow\>\) Constructor

Initializes a new instance of the [ColumnTypologyFilterSolver&lt;TColumn,TRow&gt;](DiGi.Typology.Classes.md#DiGi.Typology.Classes.ColumnTypologyFilterSolver_TColumn,TRow_ 'DiGi\.Typology\.Classes\.ColumnTypologyFilterSolver\<TColumn,TRow\>') class using a specified column filter and a collection of rows\.

```csharp
public ColumnTypologyFilterSolver(DiGi.Typology.Classes.ColumnTypologyFilter<TColumn> columnTypologyFilter, System.Collections.Generic.IEnumerable<TRow> rows);
```
#### Parameters

<a name='DiGi.Typology.Classes.ColumnTypologyFilterSolver_TColumn,TRow_.ColumnTypologyFilterSolver(DiGi.Typology.Classes.ColumnTypologyFilter_TColumn_,System.Collections.Generic.IEnumerable_TRow_).columnTypologyFilter'></a>

`columnTypologyFilter` [DiGi\.Typology\.Classes\.ColumnTypologyFilter&lt;](DiGi.Typology.Classes.md#DiGi.Typology.Classes.ColumnTypologyFilter_UColumn_ 'DiGi\.Typology\.Classes\.ColumnTypologyFilter\<UColumn\>')[TColumn](DiGi.Typology.Classes.md#DiGi.Typology.Classes.ColumnTypologyFilterSolver_TColumn,TRow_.TColumn 'DiGi\.Typology\.Classes\.ColumnTypologyFilterSolver\<TColumn,TRow\>\.TColumn')[&gt;](DiGi.Typology.Classes.md#DiGi.Typology.Classes.ColumnTypologyFilter_UColumn_ 'DiGi\.Typology\.Classes\.ColumnTypologyFilter\<UColumn\>')

The column typology filter to apply\.

<a name='DiGi.Typology.Classes.ColumnTypologyFilterSolver_TColumn,TRow_.ColumnTypologyFilterSolver(DiGi.Typology.Classes.ColumnTypologyFilter_TColumn_,System.Collections.Generic.IEnumerable_TRow_).rows'></a>

`rows` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[TRow](DiGi.Typology.Classes.md#DiGi.Typology.Classes.ColumnTypologyFilterSolver_TColumn,TRow_.TRow 'DiGi\.Typology\.Classes\.ColumnTypologyFilterSolver\<TColumn,TRow\>\.TRow')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of rows to evaluate\.

<a name='DiGi.Typology.Classes.DoubleRangeFilterRule'></a>

## DoubleRangeFilterRule Class

Represents a typology filter rule for double range values\.

```csharp
public class DoubleRangeFilterRule : DiGi.Typology.Classes.RangeValueFilterRule<double>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [TypologyFilterRule](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyFilterRule 'DiGi\.Typology\.Classes\.TypologyFilterRule') → [DiGi\.Typology\.Classes\.RangeValueFilterRule&lt;](DiGi.Typology.Classes.md#DiGi.Typology.Classes.RangeValueFilterRule_TValueType_ 'DiGi\.Typology\.Classes\.RangeValueFilterRule\<TValueType\>')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](DiGi.Typology.Classes.md#DiGi.Typology.Classes.RangeValueFilterRule_TValueType_ 'DiGi\.Typology\.Classes\.RangeValueFilterRule\<TValueType\>') → DoubleRangeFilterRule
### Constructors

<a name='DiGi.Typology.Classes.DoubleRangeFilterRule.DoubleRangeFilterRule()'></a>

## DoubleRangeFilterRule\(\) Constructor

Initializes a new instance of the [DoubleRangeFilterRule](DiGi.Typology.Classes.md#DiGi.Typology.Classes.DoubleRangeFilterRule 'DiGi\.Typology\.Classes\.DoubleRangeFilterRule') class\.

```csharp
public DoubleRangeFilterRule();
```

<a name='DiGi.Typology.Classes.DoubleRangeFilterRule.DoubleRangeFilterRule(DiGi.Typology.Classes.DoubleRangeFilterRule)'></a>

## DoubleRangeFilterRule\(DoubleRangeFilterRule\) Constructor

Initializes a new instance of the [DoubleRangeFilterRule](DiGi.Typology.Classes.md#DiGi.Typology.Classes.DoubleRangeFilterRule 'DiGi\.Typology\.Classes\.DoubleRangeFilterRule') class by copying another instance\.

```csharp
public DoubleRangeFilterRule(DiGi.Typology.Classes.DoubleRangeFilterRule doubleRangeFilterRule);
```
#### Parameters

<a name='DiGi.Typology.Classes.DoubleRangeFilterRule.DoubleRangeFilterRule(DiGi.Typology.Classes.DoubleRangeFilterRule).doubleRangeFilterRule'></a>

`doubleRangeFilterRule` [DoubleRangeFilterRule](DiGi.Typology.Classes.md#DiGi.Typology.Classes.DoubleRangeFilterRule 'DiGi\.Typology\.Classes\.DoubleRangeFilterRule')

The source filter rule to copy\.

<a name='DiGi.Typology.Classes.DoubleRangeFilterRule.DoubleRangeFilterRule(System.Collections.Generic.IEnumerable_DiGi.Core.Classes.Range_double__)'></a>

## DoubleRangeFilterRule\(IEnumerable\<Range\<double\>\>\) Constructor

Initializes a new instance of the [DoubleRangeFilterRule](DiGi.Typology.Classes.md#DiGi.Typology.Classes.DoubleRangeFilterRule 'DiGi\.Typology\.Classes\.DoubleRangeFilterRule') class with a collection of ranges\.

```csharp
public DoubleRangeFilterRule(System.Collections.Generic.IEnumerable<DiGi.Core.Classes.Range<double>>? ranges);
```
#### Parameters

<a name='DiGi.Typology.Classes.DoubleRangeFilterRule.DoubleRangeFilterRule(System.Collections.Generic.IEnumerable_DiGi.Core.Classes.Range_double__).ranges'></a>

`ranges` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.Core\.Classes\.Range&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of double ranges to assign\.

<a name='DiGi.Typology.Classes.DoubleRangeFilterRule.DoubleRangeFilterRule(System.Text.Json.Nodes.JsonObject)'></a>

## DoubleRangeFilterRule\(JsonObject\) Constructor

Initializes a new instance of the [DoubleRangeFilterRule](DiGi.Typology.Classes.md#DiGi.Typology.Classes.DoubleRangeFilterRule 'DiGi\.Typology\.Classes\.DoubleRangeFilterRule') class with a JSON object\.

```csharp
public DoubleRangeFilterRule(System.Text.Json.Nodes.JsonObject jsonObject);
```
#### Parameters

<a name='DiGi.Typology.Classes.DoubleRangeFilterRule.DoubleRangeFilterRule(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the double range filter rule data\.

<a name='DiGi.Typology.Classes.GroupValueFilterRule'></a>

## GroupValueFilterRule Class

Represents a group value filter rule\.

```csharp
public abstract class GroupValueFilterRule : DiGi.Typology.Classes.TypologyFilterRule, DiGi.Typology.Interfaces.ITypologyFilterRule, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Typology.Interfaces.ITypologyObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [TypologyFilterRule](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyFilterRule 'DiGi\.Typology\.Classes\.TypologyFilterRule') → GroupValueFilterRule

Implements [ITypologyFilterRule](DiGi.Typology.Interfaces.md#DiGi.Typology.Interfaces.ITypologyFilterRule 'DiGi\.Typology\.Interfaces\.ITypologyFilterRule'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Typology\.Interfaces\.ITypologyObject](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.interfaces.itypologyobject 'DiGi\.Typology\.Interfaces\.ITypologyObject')
### Constructors

<a name='DiGi.Typology.Classes.GroupValueFilterRule.GroupValueFilterRule()'></a>

## GroupValueFilterRule\(\) Constructor

Initializes a new instance of the [GroupValueFilterRule](DiGi.Typology.Classes.md#DiGi.Typology.Classes.GroupValueFilterRule 'DiGi\.Typology\.Classes\.GroupValueFilterRule') class\.

```csharp
public GroupValueFilterRule();
```

<a name='DiGi.Typology.Classes.GroupValueFilterRule.GroupValueFilterRule(DiGi.Typology.Classes.GroupValueFilterRule)'></a>

## GroupValueFilterRule\(GroupValueFilterRule\) Constructor

Initializes a new instance of the [GroupValueFilterRule](DiGi.Typology.Classes.md#DiGi.Typology.Classes.GroupValueFilterRule 'DiGi\.Typology\.Classes\.GroupValueFilterRule') class by copying another instance\.

```csharp
public GroupValueFilterRule(DiGi.Typology.Classes.GroupValueFilterRule groupValueFilterRule);
```
#### Parameters

<a name='DiGi.Typology.Classes.GroupValueFilterRule.GroupValueFilterRule(DiGi.Typology.Classes.GroupValueFilterRule).groupValueFilterRule'></a>

`groupValueFilterRule` [GroupValueFilterRule](DiGi.Typology.Classes.md#DiGi.Typology.Classes.GroupValueFilterRule 'DiGi\.Typology\.Classes\.GroupValueFilterRule')

The source filter rule to copy\.

<a name='DiGi.Typology.Classes.GroupValueFilterRule.GroupValueFilterRule(System.Text.Json.Nodes.JsonObject)'></a>

## GroupValueFilterRule\(JsonObject\) Constructor

Initializes a new instance of the [GroupValueFilterRule](DiGi.Typology.Classes.md#DiGi.Typology.Classes.GroupValueFilterRule 'DiGi\.Typology\.Classes\.GroupValueFilterRule') class with a JSON object\.

```csharp
public GroupValueFilterRule(System.Text.Json.Nodes.JsonObject jsonObject);
```
#### Parameters

<a name='DiGi.Typology.Classes.GroupValueFilterRule.GroupValueFilterRule(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the filter rule data\.

<a name='DiGi.Typology.Classes.IntegerRangeFilterRule'></a>

## IntegerRangeFilterRule Class

Represents a typology filter rule for int range values\.

```csharp
public class IntegerRangeFilterRule : DiGi.Typology.Classes.RangeValueFilterRule<int>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [TypologyFilterRule](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyFilterRule 'DiGi\.Typology\.Classes\.TypologyFilterRule') → [DiGi\.Typology\.Classes\.RangeValueFilterRule&lt;](DiGi.Typology.Classes.md#DiGi.Typology.Classes.RangeValueFilterRule_TValueType_ 'DiGi\.Typology\.Classes\.RangeValueFilterRule\<TValueType\>')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](DiGi.Typology.Classes.md#DiGi.Typology.Classes.RangeValueFilterRule_TValueType_ 'DiGi\.Typology\.Classes\.RangeValueFilterRule\<TValueType\>') → IntegerRangeFilterRule
### Constructors

<a name='DiGi.Typology.Classes.IntegerRangeFilterRule.IntegerRangeFilterRule()'></a>

## IntegerRangeFilterRule\(\) Constructor

Initializes a new instance of the [IntegerRangeFilterRule](DiGi.Typology.Classes.md#DiGi.Typology.Classes.IntegerRangeFilterRule 'DiGi\.Typology\.Classes\.IntegerRangeFilterRule') class\.

```csharp
public IntegerRangeFilterRule();
```

<a name='DiGi.Typology.Classes.IntegerRangeFilterRule.IntegerRangeFilterRule(DiGi.Typology.Classes.IntegerRangeFilterRule)'></a>

## IntegerRangeFilterRule\(IntegerRangeFilterRule\) Constructor

Initializes a new instance of the [IntegerRangeFilterRule](DiGi.Typology.Classes.md#DiGi.Typology.Classes.IntegerRangeFilterRule 'DiGi\.Typology\.Classes\.IntegerRangeFilterRule') class by copying another instance\.

```csharp
public IntegerRangeFilterRule(DiGi.Typology.Classes.IntegerRangeFilterRule integerRangeFilterRule);
```
#### Parameters

<a name='DiGi.Typology.Classes.IntegerRangeFilterRule.IntegerRangeFilterRule(DiGi.Typology.Classes.IntegerRangeFilterRule).integerRangeFilterRule'></a>

`integerRangeFilterRule` [IntegerRangeFilterRule](DiGi.Typology.Classes.md#DiGi.Typology.Classes.IntegerRangeFilterRule 'DiGi\.Typology\.Classes\.IntegerRangeFilterRule')

The source filter rule to copy\.

<a name='DiGi.Typology.Classes.IntegerRangeFilterRule.IntegerRangeFilterRule(System.Collections.Generic.IEnumerable_DiGi.Core.Classes.Range_int__)'></a>

## IntegerRangeFilterRule\(IEnumerable\<Range\<int\>\>\) Constructor

Initializes a new instance of the [IntegerRangeFilterRule](DiGi.Typology.Classes.md#DiGi.Typology.Classes.IntegerRangeFilterRule 'DiGi\.Typology\.Classes\.IntegerRangeFilterRule') class with a collection of ranges\.

```csharp
public IntegerRangeFilterRule(System.Collections.Generic.IEnumerable<DiGi.Core.Classes.Range<int>>? ranges);
```
#### Parameters

<a name='DiGi.Typology.Classes.IntegerRangeFilterRule.IntegerRangeFilterRule(System.Collections.Generic.IEnumerable_DiGi.Core.Classes.Range_int__).ranges'></a>

`ranges` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.Core\.Classes\.Range&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of double ranges to assign\.

<a name='DiGi.Typology.Classes.IntegerRangeFilterRule.IntegerRangeFilterRule(System.Text.Json.Nodes.JsonObject)'></a>

## IntegerRangeFilterRule\(JsonObject\) Constructor

Initializes a new instance of the [IntegerRangeFilterRule](DiGi.Typology.Classes.md#DiGi.Typology.Classes.IntegerRangeFilterRule 'DiGi\.Typology\.Classes\.IntegerRangeFilterRule') class with a JSON object\.

```csharp
public IntegerRangeFilterRule(System.Text.Json.Nodes.JsonObject jsonObject);
```
#### Parameters

<a name='DiGi.Typology.Classes.IntegerRangeFilterRule.IntegerRangeFilterRule(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the double range filter rule data\.

<a name='DiGi.Typology.Classes.RangeValueFilterRule_TValueType_'></a>

## RangeValueFilterRule\<TValueType\> Class

Represents a generic base class for range value filter rules\.

```csharp
public abstract class RangeValueFilterRule<TValueType> : DiGi.Typology.Classes.TypologyFilterRule, DiGi.Typology.Interfaces.ITypologyFilterRule<DiGi.Typology.Classes.RangeValueRuleData<TValueType>>, DiGi.Typology.Interfaces.ITypologyFilterRule, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Typology.Interfaces.ITypologyObject
    where TValueType : System.IComparable<TValueType>
```
#### Type parameters

<a name='DiGi.Typology.Classes.RangeValueFilterRule_TValueType_.TValueType'></a>

`TValueType`

The type of the range values, which must implement [System\.IComparable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.icomparable-1 'System\.IComparable\`1')\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [TypologyFilterRule](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyFilterRule 'DiGi\.Typology\.Classes\.TypologyFilterRule') → RangeValueFilterRule\<TValueType\>

Derived  
↳ [DoubleRangeFilterRule](DiGi.Typology.Classes.md#DiGi.Typology.Classes.DoubleRangeFilterRule 'DiGi\.Typology\.Classes\.DoubleRangeFilterRule')  
↳ [IntegerRangeFilterRule](DiGi.Typology.Classes.md#DiGi.Typology.Classes.IntegerRangeFilterRule 'DiGi\.Typology\.Classes\.IntegerRangeFilterRule')

Implements [DiGi\.Typology\.Interfaces\.ITypologyFilterRule&lt;](DiGi.Typology.Interfaces.md#DiGi.Typology.Interfaces.ITypologyFilterRule_TTypologyFilterRuleData_ 'DiGi\.Typology\.Interfaces\.ITypologyFilterRule\<TTypologyFilterRuleData\>')[DiGi\.Typology\.Classes\.RangeValueRuleData&lt;](DiGi.Typology.Classes.md#DiGi.Typology.Classes.RangeValueRuleData_TValueType_ 'DiGi\.Typology\.Classes\.RangeValueRuleData\<TValueType\>')[TValueType](DiGi.Typology.Classes.md#DiGi.Typology.Classes.RangeValueFilterRule_TValueType_.TValueType 'DiGi\.Typology\.Classes\.RangeValueFilterRule\<TValueType\>\.TValueType')[&gt;](DiGi.Typology.Classes.md#DiGi.Typology.Classes.RangeValueRuleData_TValueType_ 'DiGi\.Typology\.Classes\.RangeValueRuleData\<TValueType\>')[&gt;](DiGi.Typology.Interfaces.md#DiGi.Typology.Interfaces.ITypologyFilterRule_TTypologyFilterRuleData_ 'DiGi\.Typology\.Interfaces\.ITypologyFilterRule\<TTypologyFilterRuleData\>'), [ITypologyFilterRule](DiGi.Typology.Interfaces.md#DiGi.Typology.Interfaces.ITypologyFilterRule 'DiGi\.Typology\.Interfaces\.ITypologyFilterRule'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Typology\.Interfaces\.ITypologyObject](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.interfaces.itypologyobject 'DiGi\.Typology\.Interfaces\.ITypologyObject')
### Constructors

<a name='DiGi.Typology.Classes.RangeValueFilterRule_TValueType_.RangeValueFilterRule()'></a>

## RangeValueFilterRule\(\) Constructor

Initializes a new instance of the [RangeValueFilterRule&lt;TValueType&gt;](DiGi.Typology.Classes.md#DiGi.Typology.Classes.RangeValueFilterRule_TValueType_ 'DiGi\.Typology\.Classes\.RangeValueFilterRule\<TValueType\>') class\.

```csharp
public RangeValueFilterRule();
```

<a name='DiGi.Typology.Classes.RangeValueFilterRule_TValueType_.RangeValueFilterRule(DiGi.Typology.Classes.RangeValueFilterRule_TValueType_)'></a>

## RangeValueFilterRule\(RangeValueFilterRule\<TValueType\>\) Constructor

Initializes a new instance of the [RangeValueFilterRule&lt;TValueType&gt;](DiGi.Typology.Classes.md#DiGi.Typology.Classes.RangeValueFilterRule_TValueType_ 'DiGi\.Typology\.Classes\.RangeValueFilterRule\<TValueType\>') class by copying another instance\.

```csharp
public RangeValueFilterRule(DiGi.Typology.Classes.RangeValueFilterRule<TValueType> rangeValueFilterRule);
```
#### Parameters

<a name='DiGi.Typology.Classes.RangeValueFilterRule_TValueType_.RangeValueFilterRule(DiGi.Typology.Classes.RangeValueFilterRule_TValueType_).rangeValueFilterRule'></a>

`rangeValueFilterRule` [DiGi\.Typology\.Classes\.RangeValueFilterRule&lt;](DiGi.Typology.Classes.md#DiGi.Typology.Classes.RangeValueFilterRule_TValueType_ 'DiGi\.Typology\.Classes\.RangeValueFilterRule\<TValueType\>')[TValueType](DiGi.Typology.Classes.md#DiGi.Typology.Classes.RangeValueFilterRule_TValueType_.TValueType 'DiGi\.Typology\.Classes\.RangeValueFilterRule\<TValueType\>\.TValueType')[&gt;](DiGi.Typology.Classes.md#DiGi.Typology.Classes.RangeValueFilterRule_TValueType_ 'DiGi\.Typology\.Classes\.RangeValueFilterRule\<TValueType\>')

The source range filter rule to copy\.

<a name='DiGi.Typology.Classes.RangeValueFilterRule_TValueType_.RangeValueFilterRule(System.Collections.Generic.IEnumerable_DiGi.Core.Classes.Range_TValueType__)'></a>

## RangeValueFilterRule\(IEnumerable\<Range\<TValueType\>\>\) Constructor

Initializes a new instance of the [RangeValueFilterRule&lt;TValueType&gt;](DiGi.Typology.Classes.md#DiGi.Typology.Classes.RangeValueFilterRule_TValueType_ 'DiGi\.Typology\.Classes\.RangeValueFilterRule\<TValueType\>') class with a collection of ranges\.

```csharp
public RangeValueFilterRule(System.Collections.Generic.IEnumerable<DiGi.Core.Classes.Range<TValueType>>? ranges);
```
#### Parameters

<a name='DiGi.Typology.Classes.RangeValueFilterRule_TValueType_.RangeValueFilterRule(System.Collections.Generic.IEnumerable_DiGi.Core.Classes.Range_TValueType__).ranges'></a>

`ranges` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.Core\.Classes\.Range&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[TValueType](DiGi.Typology.Classes.md#DiGi.Typology.Classes.RangeValueFilterRule_TValueType_.TValueType 'DiGi\.Typology\.Classes\.RangeValueFilterRule\<TValueType\>\.TValueType')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of ranges to assign\.

<a name='DiGi.Typology.Classes.RangeValueFilterRule_TValueType_.RangeValueFilterRule(System.Text.Json.Nodes.JsonObject)'></a>

## RangeValueFilterRule\(JsonObject\) Constructor

Initializes a new instance of the [RangeValueFilterRule&lt;TValueType&gt;](DiGi.Typology.Classes.md#DiGi.Typology.Classes.RangeValueFilterRule_TValueType_ 'DiGi\.Typology\.Classes\.RangeValueFilterRule\<TValueType\>') class with a JSON object\.

```csharp
public RangeValueFilterRule(System.Text.Json.Nodes.JsonObject jsonObject);
```
#### Parameters

<a name='DiGi.Typology.Classes.RangeValueFilterRule_TValueType_.RangeValueFilterRule(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the range filter rule data\.
### Properties

<a name='DiGi.Typology.Classes.RangeValueFilterRule_TValueType_.Ranges'></a>

## RangeValueFilterRule\<TValueType\>\.Ranges Property

Gets or sets the collection of ranges managed by this rule\.

```csharp
public System.Collections.Generic.IEnumerable<DiGi.Core.Classes.Range<TValueType>> Ranges { get; set; }
```

#### Property Value
[System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.Core\.Classes\.Range&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[TValueType](DiGi.Typology.Classes.md#DiGi.Typology.Classes.RangeValueFilterRule_TValueType_.TValueType 'DiGi\.Typology\.Classes\.RangeValueFilterRule\<TValueType\>\.TValueType')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')
### Methods

<a name='DiGi.Typology.Classes.RangeValueFilterRule_TValueType_.Add(DiGi.Core.Classes.Range_TValueType_)'></a>

## RangeValueFilterRule\<TValueType\>\.Add\(Range\<TValueType\>\) Method

Adds a range to the filter rule\.

```csharp
public bool Add(DiGi.Core.Classes.Range<TValueType>? range);
```
#### Parameters

<a name='DiGi.Typology.Classes.RangeValueFilterRule_TValueType_.Add(DiGi.Core.Classes.Range_TValueType_).range'></a>

`range` [DiGi\.Core\.Classes\.Range&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[TValueType](DiGi.Typology.Classes.md#DiGi.Typology.Classes.RangeValueFilterRule_TValueType_.TValueType 'DiGi\.Typology\.Classes\.RangeValueFilterRule\<TValueType\>\.TValueType')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')

The range to add\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the range was successfully added; otherwise, false\.

<a name='DiGi.Typology.Classes.RangeValueFilterRule_TValueType_.RuleData(object)'></a>

## RangeValueFilterRule\<TValueType\>\.RuleData\(object\) Method

Resolves the filter rule data for the specified value\.

```csharp
public DiGi.Typology.Classes.RangeValueRuleData<TValueType>? RuleData(object? object_Value);
```
#### Parameters

<a name='DiGi.Typology.Classes.RangeValueFilterRule_TValueType_.RuleData(object).object_Value'></a>

`object_Value` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The value to test against the ranges\.

Implements [RuleData\(object\)](DiGi.Typology.Interfaces.md#DiGi.Typology.Interfaces.ITypologyFilterRule_TTypologyFilterRuleData_.RuleData(object) 'DiGi\.Typology\.Interfaces\.ITypologyFilterRule\<TTypologyFilterRuleData\>\.RuleData\(object\)')

#### Returns
[DiGi\.Typology\.Classes\.RangeValueRuleData&lt;](DiGi.Typology.Classes.md#DiGi.Typology.Classes.RangeValueRuleData_TValueType_ 'DiGi\.Typology\.Classes\.RangeValueRuleData\<TValueType\>')[TValueType](DiGi.Typology.Classes.md#DiGi.Typology.Classes.RangeValueFilterRule_TValueType_.TValueType 'DiGi\.Typology\.Classes\.RangeValueFilterRule\<TValueType\>\.TValueType')[&gt;](DiGi.Typology.Classes.md#DiGi.Typology.Classes.RangeValueRuleData_TValueType_ 'DiGi\.Typology\.Classes\.RangeValueRuleData\<TValueType\>')  
The matching range rule data, or null if no range matches\.

<a name='DiGi.Typology.Classes.RangeValueRuleData_TValueType_'></a>

## RangeValueRuleData\<TValueType\> Class

Represents the resulting data for a range value rule\.

```csharp
public class RangeValueRuleData<TValueType> : DiGi.Typology.Classes.TypologyFilterRuleData<DiGi.Typology.Classes.RangeValueRuleData<TValueType>>
```
#### Type parameters

<a name='DiGi.Typology.Classes.RangeValueRuleData_TValueType_.TValueType'></a>

`TValueType`

The underlying type of the range values\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Typology\.Classes\.TypologyFilterRuleData&lt;](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyFilterRuleData_TTypologyFilterRuleData_ 'DiGi\.Typology\.Classes\.TypologyFilterRuleData\<TTypologyFilterRuleData\>')[DiGi\.Typology\.Classes\.RangeValueRuleData&lt;](DiGi.Typology.Classes.md#DiGi.Typology.Classes.RangeValueRuleData_TValueType_ 'DiGi\.Typology\.Classes\.RangeValueRuleData\<TValueType\>')[TValueType](DiGi.Typology.Classes.md#DiGi.Typology.Classes.RangeValueRuleData_TValueType_.TValueType 'DiGi\.Typology\.Classes\.RangeValueRuleData\<TValueType\>\.TValueType')[&gt;](DiGi.Typology.Classes.md#DiGi.Typology.Classes.RangeValueRuleData_TValueType_ 'DiGi\.Typology\.Classes\.RangeValueRuleData\<TValueType\>')[&gt;](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyFilterRuleData_TTypologyFilterRuleData_ 'DiGi\.Typology\.Classes\.TypologyFilterRuleData\<TTypologyFilterRuleData\>') → RangeValueRuleData\<TValueType\>
### Constructors

<a name='DiGi.Typology.Classes.RangeValueRuleData_TValueType_.RangeValueRuleData()'></a>

## RangeValueRuleData\(\) Constructor

Initializes a new instance of the [RangeValueRuleData&lt;TValueType&gt;](DiGi.Typology.Classes.md#DiGi.Typology.Classes.RangeValueRuleData_TValueType_ 'DiGi\.Typology\.Classes\.RangeValueRuleData\<TValueType\>') class\.

```csharp
public RangeValueRuleData();
```

<a name='DiGi.Typology.Classes.RangeValueRuleData_TValueType_.RangeValueRuleData(DiGi.Core.Classes.Range_TValueType_)'></a>

## RangeValueRuleData\(Range\<TValueType\>\) Constructor

Initializes a new instance of the [RangeValueRuleData&lt;TValueType&gt;](DiGi.Typology.Classes.md#DiGi.Typology.Classes.RangeValueRuleData_TValueType_ 'DiGi\.Typology\.Classes\.RangeValueRuleData\<TValueType\>') class with a specific range\.

```csharp
public RangeValueRuleData(DiGi.Core.Classes.Range<TValueType>? range);
```
#### Parameters

<a name='DiGi.Typology.Classes.RangeValueRuleData_TValueType_.RangeValueRuleData(DiGi.Core.Classes.Range_TValueType_).range'></a>

`range` [DiGi\.Core\.Classes\.Range&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[TValueType](DiGi.Typology.Classes.md#DiGi.Typology.Classes.RangeValueRuleData_TValueType_.TValueType 'DiGi\.Typology\.Classes\.RangeValueRuleData\<TValueType\>\.TValueType')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')

The range values\.

<a name='DiGi.Typology.Classes.RangeValueRuleData_TValueType_.RangeValueRuleData(DiGi.Typology.Classes.RangeValueRuleData_TValueType_)'></a>

## RangeValueRuleData\(RangeValueRuleData\<TValueType\>\) Constructor

Initializes a new instance of the [RangeValueRuleData&lt;TValueType&gt;](DiGi.Typology.Classes.md#DiGi.Typology.Classes.RangeValueRuleData_TValueType_ 'DiGi\.Typology\.Classes\.RangeValueRuleData\<TValueType\>') class by copying another instance\.

```csharp
public RangeValueRuleData(DiGi.Typology.Classes.RangeValueRuleData<TValueType> rangeValueRuleData);
```
#### Parameters

<a name='DiGi.Typology.Classes.RangeValueRuleData_TValueType_.RangeValueRuleData(DiGi.Typology.Classes.RangeValueRuleData_TValueType_).rangeValueRuleData'></a>

`rangeValueRuleData` [DiGi\.Typology\.Classes\.RangeValueRuleData&lt;](DiGi.Typology.Classes.md#DiGi.Typology.Classes.RangeValueRuleData_TValueType_ 'DiGi\.Typology\.Classes\.RangeValueRuleData\<TValueType\>')[TValueType](DiGi.Typology.Classes.md#DiGi.Typology.Classes.RangeValueRuleData_TValueType_.TValueType 'DiGi\.Typology\.Classes\.RangeValueRuleData\<TValueType\>\.TValueType')[&gt;](DiGi.Typology.Classes.md#DiGi.Typology.Classes.RangeValueRuleData_TValueType_ 'DiGi\.Typology\.Classes\.RangeValueRuleData\<TValueType\>')

The source range rule data to copy\.

<a name='DiGi.Typology.Classes.RangeValueRuleData_TValueType_.RangeValueRuleData(System.Text.Json.Nodes.JsonObject)'></a>

## RangeValueRuleData\(JsonObject\) Constructor

Initializes a new instance of the [RangeValueRuleData&lt;TValueType&gt;](DiGi.Typology.Classes.md#DiGi.Typology.Classes.RangeValueRuleData_TValueType_ 'DiGi\.Typology\.Classes\.RangeValueRuleData\<TValueType\>') class with a JSON object\.

```csharp
public RangeValueRuleData(System.Text.Json.Nodes.JsonObject jsonObject);
```
#### Parameters

<a name='DiGi.Typology.Classes.RangeValueRuleData_TValueType_.RangeValueRuleData(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing range rule data\.
### Methods

<a name='DiGi.Typology.Classes.RangeValueRuleData_TValueType_.Equals(DiGi.Typology.Classes.RangeValueRuleData_TValueType_)'></a>

## RangeValueRuleData\<TValueType\>\.Equals\(RangeValueRuleData\<TValueType\>\) Method

Determines whether this instance and another specified range rule data have the same value\.

```csharp
public override bool Equals(DiGi.Typology.Classes.RangeValueRuleData<TValueType> rangeValueRuleData);
```
#### Parameters

<a name='DiGi.Typology.Classes.RangeValueRuleData_TValueType_.Equals(DiGi.Typology.Classes.RangeValueRuleData_TValueType_).rangeValueRuleData'></a>

`rangeValueRuleData` [DiGi\.Typology\.Classes\.RangeValueRuleData&lt;](DiGi.Typology.Classes.md#DiGi.Typology.Classes.RangeValueRuleData_TValueType_ 'DiGi\.Typology\.Classes\.RangeValueRuleData\<TValueType\>')[TValueType](DiGi.Typology.Classes.md#DiGi.Typology.Classes.RangeValueRuleData_TValueType_.TValueType 'DiGi\.Typology\.Classes\.RangeValueRuleData\<TValueType\>\.TValueType')[&gt;](DiGi.Typology.Classes.md#DiGi.Typology.Classes.RangeValueRuleData_TValueType_ 'DiGi\.Typology\.Classes\.RangeValueRuleData\<TValueType\>')

The range rule data to compare with this instance\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the values are equal; otherwise, false\.

<a name='DiGi.Typology.Classes.RangeValueRuleData_TValueType_.Equals(object)'></a>

## RangeValueRuleData\<TValueType\>\.Equals\(object\) Method

Determines whether this instance and a specified object have the same value\.

```csharp
public override bool Equals(object? @object);
```
#### Parameters

<a name='DiGi.Typology.Classes.RangeValueRuleData_TValueType_.Equals(object).object'></a>

`object` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The object to compare with this instance\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the object is equal to this instance; otherwise, false\.

<a name='DiGi.Typology.Classes.RangeValueRuleData_TValueType_.GetHashCode()'></a>

## RangeValueRuleData\<TValueType\>\.GetHashCode\(\) Method

Returns the hash code for this instance\.

```csharp
public override int GetHashCode();
```

#### Returns
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')  
A 32\-bit signed integer hash code\.

<a name='DiGi.Typology.Classes.RangeValueRuleData_TValueType_.ToString()'></a>

## RangeValueRuleData\<TValueType\>\.ToString\(\) Method

Returns a string representation of the range rule data\.

```csharp
public override string ToString();
```

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
A string representation of the range\.

<a name='DiGi.Typology.Classes.Typology'></a>

## Typology Class

Represents a typology object that can be serialized and compared\.

```csharp
public class Typology : DiGi.Core.Classes.SerializableObject, DiGi.Typology.Interfaces.ITypologyObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.INamedObject, DiGi.Core.Interfaces.IDescribableObject, System.IComparable<DiGi.Typology.Classes.Typology>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → Typology

Implements [DiGi\.Typology\.Interfaces\.ITypologyObject](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.interfaces.itypologyobject 'DiGi\.Typology\.Interfaces\.ITypologyObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.INamedObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.inamedobject 'DiGi\.Core\.Interfaces\.INamedObject'), [DiGi\.Core\.Interfaces\.IDescribableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.idescribableobject 'DiGi\.Core\.Interfaces\.IDescribableObject'), [System\.IComparable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.icomparable-1 'System\.IComparable\`1')[Typology](DiGi.Typology.Classes.md#DiGi.Typology.Classes.Typology 'DiGi\.Typology\.Classes\.Typology')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.icomparable-1 'System\.IComparable\`1')
### Constructors

<a name='DiGi.Typology.Classes.Typology.Typology(DiGi.Typology.Classes.Typology)'></a>

## Typology\(Typology\) Constructor

Initializes a new instance of the [Typology](DiGi.Typology.Classes.md#DiGi.Typology.Classes.Typology 'DiGi\.Typology\.Classes\.Typology') class by cloning an existing typology\.

```csharp
public Typology(DiGi.Typology.Classes.Typology? typology);
```
#### Parameters

<a name='DiGi.Typology.Classes.Typology.Typology(DiGi.Typology.Classes.Typology).typology'></a>

`typology` [Typology](DiGi.Typology.Classes.md#DiGi.Typology.Classes.Typology 'DiGi\.Typology\.Classes\.Typology')

The source typology object to clone\.

<a name='DiGi.Typology.Classes.Typology.Typology(DiGi.Typology.Classes.TypologyItem)'></a>

## Typology\(TypologyItem\) Constructor

Initializes a new instance of the [Typology](DiGi.Typology.Classes.md#DiGi.Typology.Classes.Typology 'DiGi\.Typology\.Classes\.Typology') class with a specified typology item\.

```csharp
public Typology(DiGi.Typology.Classes.TypologyItem? typologyItem);
```
#### Parameters

<a name='DiGi.Typology.Classes.Typology.Typology(DiGi.Typology.Classes.TypologyItem).typologyItem'></a>

`typologyItem` [TypologyItem](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyItem 'DiGi\.Typology\.Classes\.TypologyItem')

The typology item to assign\.

<a name='DiGi.Typology.Classes.Typology.Typology(DiGi.Typology.Classes.TypologyItem,System.Collections.Generic.IEnumerable_DiGi.Typology.Classes.Typology_)'></a>

## Typology\(TypologyItem, IEnumerable\<Typology\>\) Constructor

Initializes a new instance of the [Typology](DiGi.Typology.Classes.md#DiGi.Typology.Classes.Typology 'DiGi\.Typology\.Classes\.Typology') class with a specified typology item and sub\-typologies\.

```csharp
public Typology(DiGi.Typology.Classes.TypologyItem? typologyItem, System.Collections.Generic.IEnumerable<DiGi.Typology.Classes.Typology>? subTypologies);
```
#### Parameters

<a name='DiGi.Typology.Classes.Typology.Typology(DiGi.Typology.Classes.TypologyItem,System.Collections.Generic.IEnumerable_DiGi.Typology.Classes.Typology_).typologyItem'></a>

`typologyItem` [TypologyItem](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyItem 'DiGi\.Typology\.Classes\.TypologyItem')

The typology item to assign\.

<a name='DiGi.Typology.Classes.Typology.Typology(DiGi.Typology.Classes.TypologyItem,System.Collections.Generic.IEnumerable_DiGi.Typology.Classes.Typology_).subTypologies'></a>

`subTypologies` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Typology](DiGi.Typology.Classes.md#DiGi.Typology.Classes.Typology 'DiGi\.Typology\.Classes\.Typology')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

A collection of sub\-typologies to associate with this instance\.

<a name='DiGi.Typology.Classes.Typology.Typology(string,string)'></a>

## Typology\(string, string\) Constructor

Initializes a new instance of the [Typology](DiGi.Typology.Classes.md#DiGi.Typology.Classes.Typology 'DiGi\.Typology\.Classes\.Typology') class with a specified name and description\.

```csharp
public Typology(string? name, string? description);
```
#### Parameters

<a name='DiGi.Typology.Classes.Typology.Typology(string,string).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the typology\.

<a name='DiGi.Typology.Classes.Typology.Typology(string,string).description'></a>

`description` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The description of the typology\.

<a name='DiGi.Typology.Classes.Typology.Typology(System.Text.Json.Nodes.JsonObject)'></a>

## Typology\(JsonObject\) Constructor

Initializes a new instance of the [Typology](DiGi.Typology.Classes.md#DiGi.Typology.Classes.Typology 'DiGi\.Typology\.Classes\.Typology') class from a JSON object\.

```csharp
public Typology(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Typology.Classes.Typology.Typology(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing typology data\.
### Properties

<a name='DiGi.Typology.Classes.Typology.Description'></a>

## Typology\.Description Property

Gets or sets the description of the typology\.

```csharp
public string? Description { get; set; }
```

Implements [Description](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.idescribableobject.description 'DiGi\.Core\.Interfaces\.IDescribableObject\.Description')

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Typology.Classes.Typology.Name'></a>

## Typology\.Name Property

Gets or sets the name of the typology\.

```csharp
public string? Name { get; set; }
```

Implements [Name](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.inamedobject.name 'DiGi\.Core\.Interfaces\.INamedObject\.Name')

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Typology.Classes.Typology.References'></a>

## Typology\.References Property

Gets the list of references associated with this typology\.

```csharp
public System.Collections.Generic.List<string> References { get; }
```

#### Property Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

<a name='DiGi.Typology.Classes.Typology.SubTypologies'></a>

## Typology\.SubTypologies Property

Gets or sets the list of sub\-typologies associated with this typology\.

```csharp
public System.Collections.Generic.List<DiGi.Typology.Classes.Typology>? SubTypologies { get; private set; }
```

#### Property Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Typology](DiGi.Typology.Classes.md#DiGi.Typology.Classes.Typology 'DiGi\.Typology\.Classes\.Typology')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

<a name='DiGi.Typology.Classes.Typology.TypologyPath'></a>

## Typology\.TypologyPath Property

Gets the path information for this typology\.

```csharp
public DiGi.Typology.Classes.TypologyPath? TypologyPath { get; }
```

#### Property Value
[TypologyPath](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyPath 'DiGi\.Typology\.Classes\.TypologyPath')
### Methods

<a name='DiGi.Typology.Classes.Typology.AddReference(string)'></a>

## Typology\.AddReference\(string\) Method

Adds a reference to the typology\.

```csharp
public bool AddReference(string? reference);
```
#### Parameters

<a name='DiGi.Typology.Classes.Typology.AddReference(string).reference'></a>

`reference` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The reference string to add\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the reference was added successfully; otherwise, false\.

<a name='DiGi.Typology.Classes.Typology.CompareTo(DiGi.Typology.Classes.Typology)'></a>

## Typology\.CompareTo\(Typology\) Method

Compares the current typology instance with another typology instance\.

```csharp
public int CompareTo(DiGi.Typology.Classes.Typology typology);
```
#### Parameters

<a name='DiGi.Typology.Classes.Typology.CompareTo(DiGi.Typology.Classes.Typology).typology'></a>

`typology` [Typology](DiGi.Typology.Classes.md#DiGi.Typology.Classes.Typology 'DiGi\.Typology\.Classes\.Typology')

The typology instance to compare against\.

#### Returns
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')  
A signed integer that indicates the relative order of the objects being compared\.

<a name='DiGi.Typology.Classes.Typology.Contains(string,bool)'></a>

## Typology\.Contains\(string, bool\) Method

Determines whether the typology contains a specific reference, optionally including references from nested typologies\.

```csharp
public bool Contains(string reference, bool includeNested=false);
```
#### Parameters

<a name='DiGi.Typology.Classes.Typology.Contains(string,bool).reference'></a>

`reference` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The reference string to search for\.

<a name='DiGi.Typology.Classes.Typology.Contains(string,bool).includeNested'></a>

`includeNested` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A value indicating whether to include nested typologies in the search\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the reference is found; otherwise, false\.

<a name='DiGi.Typology.Classes.Typology.GetReferences(bool)'></a>

## Typology\.GetReferences\(bool\) Method

Retrieves a set of all references associated with this typology, optionally including those from nested typologies\.

```csharp
public System.Collections.Generic.HashSet<string> GetReferences(bool includeNested);
```
#### Parameters

<a name='DiGi.Typology.Classes.Typology.GetReferences(bool).includeNested'></a>

`includeNested` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A value indicating whether to include references from nested typologies\.

#### Returns
[System\.Collections\.Generic\.HashSet&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1 'System\.Collections\.Generic\.HashSet\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1 'System\.Collections\.Generic\.HashSet\`1')  
A [System\.Collections\.Generic\.HashSet&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1 'System\.Collections\.Generic\.HashSet\`1') containing the references\.

<a name='DiGi.Typology.Classes.Typology.GetTypology(DiGi.Typology.Classes.TypologyPath)'></a>

## Typology\.GetTypology\(TypologyPath\) Method

Retrieves a typology instance based on the provided typology path\.

```csharp
public DiGi.Typology.Classes.Typology? GetTypology(DiGi.Typology.Classes.TypologyPath? typologyPath);
```
#### Parameters

<a name='DiGi.Typology.Classes.Typology.GetTypology(DiGi.Typology.Classes.TypologyPath).typologyPath'></a>

`typologyPath` [TypologyPath](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyPath 'DiGi\.Typology\.Classes\.TypologyPath')

The path used to locate the typology\.

#### Returns
[Typology](DiGi.Typology.Classes.md#DiGi.Typology.Classes.Typology 'DiGi\.Typology\.Classes\.Typology')  
The [Typology](DiGi.Typology.Classes.md#DiGi.Typology.Classes.Typology 'DiGi\.Typology\.Classes\.Typology') instance if found; otherwise, null\.

<a name='DiGi.Typology.Classes.Typology.GetTypology(System.Collections.Generic.IEnumerable_int_)'></a>

## Typology\.GetTypology\(IEnumerable\<int\>\) Method

Retrieves a typology instance based on a sequence of integer identifiers representing the path\.

```csharp
public DiGi.Typology.Classes.Typology? GetTypology(System.Collections.Generic.IEnumerable<int>? values);
```
#### Parameters

<a name='DiGi.Typology.Classes.Typology.GetTypology(System.Collections.Generic.IEnumerable_int_).values'></a>

`values` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

An enumerable collection of integers representing the typology path\.

#### Returns
[Typology](DiGi.Typology.Classes.md#DiGi.Typology.Classes.Typology 'DiGi\.Typology\.Classes\.Typology')  
The [Typology](DiGi.Typology.Classes.md#DiGi.Typology.Classes.Typology 'DiGi\.Typology\.Classes\.Typology') instance if found; otherwise, null\.

<a name='DiGi.Typology.Classes.Typology.GetTypologyPaths(bool)'></a>

## Typology\.GetTypologyPaths\(bool\) Method

Retrieves a list of typology paths for all sub\-typologies, optionally including nested ones\.

```csharp
public System.Collections.Generic.List<DiGi.Typology.Classes.TypologyPath>? GetTypologyPaths(bool includeNested=false);
```
#### Parameters

<a name='DiGi.Typology.Classes.Typology.GetTypologyPaths(bool).includeNested'></a>

`includeNested` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A value indicating whether to recursively retrieve paths from nested typologies\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[TypologyPath](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyPath 'DiGi\.Typology\.Classes\.TypologyPath')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1') of [TypologyPath](DiGi.Typology.Classes.md#DiGi.Typology.Classes.Typology.TypologyPath 'DiGi\.Typology\.Classes\.Typology\.TypologyPath') objects, or null if no sub\-typologies exist\.

<a name='DiGi.Typology.Classes.Typology.ToString()'></a>

## Typology\.ToString\(\) Method

Returns a string representation of the current typology\.

```csharp
public override string ToString();
```

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
A string representing the typology item or the base object string\.

<a name='DiGi.Typology.Classes.Typology.TryGetLastIndex(int)'></a>

## Typology\.TryGetLastIndex\(int\) Method

Attempts to retrieve the last index from the sub\-typologies collection\.

```csharp
public bool TryGetLastIndex(out int index);
```
#### Parameters

<a name='DiGi.Typology.Classes.Typology.TryGetLastIndex(int).index'></a>

`index` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

When this method returns, contains the maximum index if successful; otherwise, \-1\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the last index was successfully retrieved; otherwise, false\.

<a name='DiGi.Typology.Classes.Typology.TryGetTypologies(DiGi.Typology.Classes.TypologyPath,string,System.Collections.Generic.List_DiGi.Typology.Classes.Typology_)'></a>

## Typology\.TryGetTypologies\(TypologyPath, string, List\<Typology\>\) Method

Attempts to retrieve a list of typologies that match the specified path and name\.

```csharp
public bool TryGetTypologies(DiGi.Typology.Classes.TypologyPath? typologyPath, string name, out System.Collections.Generic.List<DiGi.Typology.Classes.Typology>? typologies);
```
#### Parameters

<a name='DiGi.Typology.Classes.Typology.TryGetTypologies(DiGi.Typology.Classes.TypologyPath,string,System.Collections.Generic.List_DiGi.Typology.Classes.Typology_).typologyPath'></a>

`typologyPath` [TypologyPath](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyPath 'DiGi\.Typology\.Classes\.TypologyPath')

The path to search within\.

<a name='DiGi.Typology.Classes.Typology.TryGetTypologies(DiGi.Typology.Classes.TypologyPath,string,System.Collections.Generic.List_DiGi.Typology.Classes.Typology_).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the typologies to find\.

<a name='DiGi.Typology.Classes.Typology.TryGetTypologies(DiGi.Typology.Classes.TypologyPath,string,System.Collections.Generic.List_DiGi.Typology.Classes.Typology_).typologies'></a>

`typologies` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Typology](DiGi.Typology.Classes.md#DiGi.Typology.Classes.Typology 'DiGi\.Typology\.Classes\.Typology')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

When this method returns, contains a list of matching typologies if successful; otherwise, null\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if one or more matching typologies were found; otherwise, false\.

<a name='DiGi.Typology.Classes.Typology.TryGetTypologies(string,System.Collections.Generic.List_DiGi.Typology.Classes.Typology_)'></a>

## Typology\.TryGetTypologies\(string, List\<Typology\>\) Method

Attempts to retrieve a list of typologies that match the specified name at the root level\.

```csharp
public bool TryGetTypologies(string name, out System.Collections.Generic.List<DiGi.Typology.Classes.Typology>? typologies);
```
#### Parameters

<a name='DiGi.Typology.Classes.Typology.TryGetTypologies(string,System.Collections.Generic.List_DiGi.Typology.Classes.Typology_).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the typologies to find\.

<a name='DiGi.Typology.Classes.Typology.TryGetTypologies(string,System.Collections.Generic.List_DiGi.Typology.Classes.Typology_).typologies'></a>

`typologies` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Typology](DiGi.Typology.Classes.md#DiGi.Typology.Classes.Typology 'DiGi\.Typology\.Classes\.Typology')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

When this method returns, contains a list of matching typologies if successful; otherwise, null\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if one or more matching typologies were found; otherwise, false\.

<a name='DiGi.Typology.Classes.Typology.TryGetTypologies(System.Collections.Generic.IEnumerable_int_,string,System.Collections.Generic.List_DiGi.Typology.Classes.Typology_)'></a>

## Typology\.TryGetTypologies\(IEnumerable\<int\>, string, List\<Typology\>\) Method

Attempts to retrieve a list of typologies that match the specified index values and name\.

```csharp
public bool TryGetTypologies(System.Collections.Generic.IEnumerable<int> values, string name, out System.Collections.Generic.List<DiGi.Typology.Classes.Typology>? typologies);
```
#### Parameters

<a name='DiGi.Typology.Classes.Typology.TryGetTypologies(System.Collections.Generic.IEnumerable_int_,string,System.Collections.Generic.List_DiGi.Typology.Classes.Typology_).values'></a>

`values` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The sequence of indices representing the typology path\.

<a name='DiGi.Typology.Classes.Typology.TryGetTypologies(System.Collections.Generic.IEnumerable_int_,string,System.Collections.Generic.List_DiGi.Typology.Classes.Typology_).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the typologies to find\.

<a name='DiGi.Typology.Classes.Typology.TryGetTypologies(System.Collections.Generic.IEnumerable_int_,string,System.Collections.Generic.List_DiGi.Typology.Classes.Typology_).typologies'></a>

`typologies` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Typology](DiGi.Typology.Classes.md#DiGi.Typology.Classes.Typology 'DiGi\.Typology\.Classes\.Typology')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

When this method returns, contains a list of matching typologies if successful; otherwise, null\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if one or more matching typologies were found; otherwise, false\.

<a name='DiGi.Typology.Classes.Typology.Update(DiGi.Typology.Classes.TypologyItem)'></a>

## Typology\.Update\(TypologyItem\) Method

Updates the typology based on the provided typology item\.

```csharp
public DiGi.Typology.Classes.Typology? Update(DiGi.Typology.Classes.TypologyItem? typologyItem);
```
#### Parameters

<a name='DiGi.Typology.Classes.Typology.Update(DiGi.Typology.Classes.TypologyItem).typologyItem'></a>

`typologyItem` [TypologyItem](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyItem 'DiGi\.Typology\.Classes\.TypologyItem')

The typology item containing updated information\.

#### Returns
[Typology](DiGi.Typology.Classes.md#DiGi.Typology.Classes.Typology 'DiGi\.Typology\.Classes\.Typology')  
The updated Typology instance, or null if the input was null\.

<a name='DiGi.Typology.Classes.Typology.Update(string)'></a>

## Typology\.Update\(string\) Method

Updates or creates a typology using specified name at the current level\.

```csharp
public DiGi.Typology.Classes.Typology? Update(string? name);
```
#### Parameters

<a name='DiGi.Typology.Classes.Typology.Update(string).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the typology\.

#### Returns
[Typology](DiGi.Typology.Classes.md#DiGi.Typology.Classes.Typology 'DiGi\.Typology\.Classes\.Typology')  
The updated or created Typology instance, or null if update failed\.

<a name='DiGi.Typology.Classes.Typology.Update(string,string)'></a>

## Typology\.Update\(string, string\) Method

Updates or creates a typology using specified name and description at the current level\.

```csharp
public DiGi.Typology.Classes.Typology? Update(string? name, string? description);
```
#### Parameters

<a name='DiGi.Typology.Classes.Typology.Update(string,string).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the typology\.

<a name='DiGi.Typology.Classes.Typology.Update(string,string).description'></a>

`description` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The description of the typology\.

#### Returns
[Typology](DiGi.Typology.Classes.md#DiGi.Typology.Classes.Typology 'DiGi\.Typology\.Classes\.Typology')  
The updated or created Typology instance, or null if update failed\.

<a name='DiGi.Typology.Classes.Typology.Update(System.Collections.Generic.IEnumerable_int_,string)'></a>

## Typology\.Update\(IEnumerable\<int\>, string\) Method

Updates or creates a typology using specified path values and name\.

```csharp
public DiGi.Typology.Classes.Typology? Update(System.Collections.Generic.IEnumerable<int>? values, string? name);
```
#### Parameters

<a name='DiGi.Typology.Classes.Typology.Update(System.Collections.Generic.IEnumerable_int_,string).values'></a>

`values` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The sequence of indices representing the typology path\.

<a name='DiGi.Typology.Classes.Typology.Update(System.Collections.Generic.IEnumerable_int_,string).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the typology\.

#### Returns
[Typology](DiGi.Typology.Classes.md#DiGi.Typology.Classes.Typology 'DiGi\.Typology\.Classes\.Typology')  
The updated or created Typology instance, or null if update failed\.

<a name='DiGi.Typology.Classes.Typology.Update(System.Collections.Generic.IEnumerable_int_,string,string)'></a>

## Typology\.Update\(IEnumerable\<int\>, string, string\) Method

Updates or creates a typology using specified path values, name, and description\.

```csharp
public DiGi.Typology.Classes.Typology? Update(System.Collections.Generic.IEnumerable<int>? values, string? name, string? description);
```
#### Parameters

<a name='DiGi.Typology.Classes.Typology.Update(System.Collections.Generic.IEnumerable_int_,string,string).values'></a>

`values` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The sequence of indices representing the typology path\.

<a name='DiGi.Typology.Classes.Typology.Update(System.Collections.Generic.IEnumerable_int_,string,string).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the typology\.

<a name='DiGi.Typology.Classes.Typology.Update(System.Collections.Generic.IEnumerable_int_,string,string).description'></a>

`description` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The description of the typology\.

#### Returns
[Typology](DiGi.Typology.Classes.md#DiGi.Typology.Classes.Typology 'DiGi\.Typology\.Classes\.Typology')  
The updated or created Typology instance, or null if update failed\.

<a name='DiGi.Typology.Classes.TypologyFile'></a>

## TypologyFile Class

Represents a typology file containing typology data\.

```csharp
public class TypologyFile : DiGi.Core.IO.File.Classes.ValueFile<DiGi.Typology.Classes.Typology>, DiGi.Typology.Interfaces.ITypologyObject, DiGi.Core.Interfaces.IObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.IO\.File\.Classes\.File](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.file.classes.file 'DiGi\.Core\.IO\.File\.Classes\.File') → [DiGi\.Core\.IO\.File\.Classes\.ValueFile&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.file.classes.valuefile-1 'DiGi\.Core\.IO\.File\.Classes\.ValueFile\`1')[Typology](DiGi.Typology.Classes.md#DiGi.Typology.Classes.Typology 'DiGi\.Typology\.Classes\.Typology')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.file.classes.valuefile-1 'DiGi\.Core\.IO\.File\.Classes\.ValueFile\`1') → TypologyFile

Implements [DiGi\.Typology\.Interfaces\.ITypologyObject](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.interfaces.itypologyobject 'DiGi\.Typology\.Interfaces\.ITypologyObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')
### Constructors

<a name='DiGi.Typology.Classes.TypologyFile.TypologyFile(DiGi.Typology.Classes.TypologyFile)'></a>

## TypologyFile\(TypologyFile\) Constructor

Initializes a new instance of the [TypologyFile](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyFile 'DiGi\.Typology\.Classes\.TypologyFile') class based on an existing [TypologyFile](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyFile 'DiGi\.Typology\.Classes\.TypologyFile') instance\.

```csharp
public TypologyFile(DiGi.Typology.Classes.TypologyFile? typologyFile);
```
#### Parameters

<a name='DiGi.Typology.Classes.TypologyFile.TypologyFile(DiGi.Typology.Classes.TypologyFile).typologyFile'></a>

`typologyFile` [TypologyFile](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyFile 'DiGi\.Typology\.Classes\.TypologyFile')

The source typology file to copy from\.

<a name='DiGi.Typology.Classes.TypologyFile.TypologyFile(string)'></a>

## TypologyFile\(string\) Constructor

Initializes a new instance of the [TypologyFile](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyFile 'DiGi\.Typology\.Classes\.TypologyFile') class from the specified file path\.

```csharp
public TypologyFile(string path);
```
#### Parameters

<a name='DiGi.Typology.Classes.TypologyFile.TypologyFile(string).path'></a>

`path` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The path to the typology file\.

<a name='DiGi.Typology.Classes.TypologyFile.TypologyFile(System.Text.Json.Nodes.JsonObject)'></a>

## TypologyFile\(JsonObject\) Constructor

Initializes a new instance of the [TypologyFile](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyFile 'DiGi\.Typology\.Classes\.TypologyFile') class using a JSON object\.

```csharp
public TypologyFile(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Typology.Classes.TypologyFile.TypologyFile(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing typology data\.

<a name='DiGi.Typology.Classes.TypologyFilter_TTypologyFilter,TValue_'></a>

## TypologyFilter\<TTypologyFilter,TValue\> Class

Represents a generic abstract base class for typology filters that hold a specific value\.

```csharp
public abstract class TypologyFilter<TTypologyFilter,TValue> : DiGi.Typology.Classes.TypologyFilter<TTypologyFilter>, DiGi.Typology.Interfaces.ITypologyFilter<TTypologyFilter, TValue>, DiGi.Typology.Interfaces.ITypologyFilter<TTypologyFilter>, DiGi.Typology.Interfaces.ITypologyFilter, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Typology.Interfaces.ITypologyObject
    where TTypologyFilter : DiGi.Typology.Classes.TypologyFilter<TTypologyFilter>
```
#### Type parameters

<a name='DiGi.Typology.Classes.TypologyFilter_TTypologyFilter,TValue_.TTypologyFilter'></a>

`TTypologyFilter`

The specific subclass type of the typology filter\.

<a name='DiGi.Typology.Classes.TypologyFilter_TTypologyFilter,TValue_.TValue'></a>

`TValue`

The type of the filter value\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Typology\.Classes\.TypologyFilter&lt;](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyFilter_TTypologyFilter_ 'DiGi\.Typology\.Classes\.TypologyFilter\<TTypologyFilter\>')[TTypologyFilter](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyFilter_TTypologyFilter,TValue_.TTypologyFilter 'DiGi\.Typology\.Classes\.TypologyFilter\<TTypologyFilter,TValue\>\.TTypologyFilter')[&gt;](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyFilter_TTypologyFilter_ 'DiGi\.Typology\.Classes\.TypologyFilter\<TTypologyFilter\>') → TypologyFilter\<TTypologyFilter,TValue\>

Derived  
↳ [ColumnTypologyFilter&lt;UColumn&gt;](DiGi.Typology.Classes.md#DiGi.Typology.Classes.ColumnTypologyFilter_UColumn_ 'DiGi\.Typology\.Classes\.ColumnTypologyFilter\<UColumn\>')

Implements [DiGi\.Typology\.Interfaces\.ITypologyFilter&lt;](DiGi.Typology.Interfaces.md#DiGi.Typology.Interfaces.ITypologyFilter_TTypologyFilter,TValue_ 'DiGi\.Typology\.Interfaces\.ITypologyFilter\<TTypologyFilter,TValue\>')[TTypologyFilter](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyFilter_TTypologyFilter,TValue_.TTypologyFilter 'DiGi\.Typology\.Classes\.TypologyFilter\<TTypologyFilter,TValue\>\.TTypologyFilter')[,](DiGi.Typology.Interfaces.md#DiGi.Typology.Interfaces.ITypologyFilter_TTypologyFilter,TValue_ 'DiGi\.Typology\.Interfaces\.ITypologyFilter\<TTypologyFilter,TValue\>')[TValue](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyFilter_TTypologyFilter,TValue_.TValue 'DiGi\.Typology\.Classes\.TypologyFilter\<TTypologyFilter,TValue\>\.TValue')[&gt;](DiGi.Typology.Interfaces.md#DiGi.Typology.Interfaces.ITypologyFilter_TTypologyFilter,TValue_ 'DiGi\.Typology\.Interfaces\.ITypologyFilter\<TTypologyFilter,TValue\>'), [DiGi\.Typology\.Interfaces\.ITypologyFilter&lt;](DiGi.Typology.Interfaces.md#DiGi.Typology.Interfaces.ITypologyFilter_TTypologyFilter_ 'DiGi\.Typology\.Interfaces\.ITypologyFilter\<TTypologyFilter\>')[TTypologyFilter](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyFilter_TTypologyFilter,TValue_.TTypologyFilter 'DiGi\.Typology\.Classes\.TypologyFilter\<TTypologyFilter,TValue\>\.TTypologyFilter')[&gt;](DiGi.Typology.Interfaces.md#DiGi.Typology.Interfaces.ITypologyFilter_TTypologyFilter_ 'DiGi\.Typology\.Interfaces\.ITypologyFilter\<TTypologyFilter\>'), [ITypologyFilter](DiGi.Typology.Interfaces.md#DiGi.Typology.Interfaces.ITypologyFilter 'DiGi\.Typology\.Interfaces\.ITypologyFilter'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Typology\.Interfaces\.ITypologyObject](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.interfaces.itypologyobject 'DiGi\.Typology\.Interfaces\.ITypologyObject')
### Constructors

<a name='DiGi.Typology.Classes.TypologyFilter_TTypologyFilter,TValue_.TypologyFilter()'></a>

## TypologyFilter\(\) Constructor

Initializes a new instance of the [TypologyFilter&lt;TTypologyFilter,TValue&gt;](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyFilter_TTypologyFilter,TValue_ 'DiGi\.Typology\.Classes\.TypologyFilter\<TTypologyFilter,TValue\>') class\.

```csharp
protected TypologyFilter();
```

<a name='DiGi.Typology.Classes.TypologyFilter_TTypologyFilter,TValue_.TypologyFilter(DiGi.Typology.Classes.TypologyFilter_TTypologyFilter,TValue_)'></a>

## TypologyFilter\(TypologyFilter\<TTypologyFilter,TValue\>\) Constructor

Initializes a new instance of the [TypologyFilter&lt;TTypologyFilter,TValue&gt;](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyFilter_TTypologyFilter,TValue_ 'DiGi\.Typology\.Classes\.TypologyFilter\<TTypologyFilter,TValue\>') class by copying another instance\.

```csharp
protected TypologyFilter(DiGi.Typology.Classes.TypologyFilter<TTypologyFilter,TValue>? typologyFilter);
```
#### Parameters

<a name='DiGi.Typology.Classes.TypologyFilter_TTypologyFilter,TValue_.TypologyFilter(DiGi.Typology.Classes.TypologyFilter_TTypologyFilter,TValue_).typologyFilter'></a>

`typologyFilter` [DiGi\.Typology\.Classes\.TypologyFilter&lt;](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyFilter_TTypologyFilter,TValue_ 'DiGi\.Typology\.Classes\.TypologyFilter\<TTypologyFilter,TValue\>')[TTypologyFilter](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyFilter_TTypologyFilter,TValue_.TTypologyFilter 'DiGi\.Typology\.Classes\.TypologyFilter\<TTypologyFilter,TValue\>\.TTypologyFilter')[,](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyFilter_TTypologyFilter,TValue_ 'DiGi\.Typology\.Classes\.TypologyFilter\<TTypologyFilter,TValue\>')[TValue](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyFilter_TTypologyFilter,TValue_.TValue 'DiGi\.Typology\.Classes\.TypologyFilter\<TTypologyFilter,TValue\>\.TValue')[&gt;](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyFilter_TTypologyFilter,TValue_ 'DiGi\.Typology\.Classes\.TypologyFilter\<TTypologyFilter,TValue\>')

The source filter instance to copy from\.

<a name='DiGi.Typology.Classes.TypologyFilter_TTypologyFilter,TValue_.TypologyFilter(System.Text.Json.Nodes.JsonObject)'></a>

## TypologyFilter\(JsonObject\) Constructor

Initializes a new instance of the [TypologyFilter&lt;TTypologyFilter,TValue&gt;](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyFilter_TTypologyFilter,TValue_ 'DiGi\.Typology\.Classes\.TypologyFilter\<TTypologyFilter,TValue\>') class with a JSON object\.

```csharp
protected TypologyFilter(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Typology.Classes.TypologyFilter_TTypologyFilter,TValue_.TypologyFilter(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing filter data\.
### Properties

<a name='DiGi.Typology.Classes.TypologyFilter_TTypologyFilter,TValue_.Value'></a>

## TypologyFilter\<TTypologyFilter,TValue\>\.Value Property

Gets or sets the value associated with this typology filter\.

```csharp
public TValue? Value { get; set; }
```

Implements [Value](DiGi.Typology.Interfaces.md#DiGi.Typology.Interfaces.ITypologyFilter_TTypologyFilter,TValue_.Value 'DiGi\.Typology\.Interfaces\.ITypologyFilter\<TTypologyFilter,TValue\>\.Value')

#### Property Value
[TValue](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyFilter_TTypologyFilter,TValue_.TValue 'DiGi\.Typology\.Classes\.TypologyFilter\<TTypologyFilter,TValue\>\.TValue')

<a name='DiGi.Typology.Classes.TypologyFilter_TTypologyFilter_'></a>

## TypologyFilter\<TTypologyFilter\> Class

Represents a generic abstract base class for typology filters\.

```csharp
public abstract class TypologyFilter<TTypologyFilter> : DiGi.Core.Classes.SerializableObject, DiGi.Typology.Interfaces.ITypologyFilter<TTypologyFilter>, DiGi.Typology.Interfaces.ITypologyFilter, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Typology.Interfaces.ITypologyObject
    where TTypologyFilter : DiGi.Typology.Classes.TypologyFilter<TTypologyFilter>
```
#### Type parameters

<a name='DiGi.Typology.Classes.TypologyFilter_TTypologyFilter_.TTypologyFilter'></a>

`TTypologyFilter`

The specific subclass type of the typology filter\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → TypologyFilter\<TTypologyFilter\>

Derived  
↳ [TypologyFilter&lt;TTypologyFilter,TValue&gt;](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyFilter_TTypologyFilter,TValue_ 'DiGi\.Typology\.Classes\.TypologyFilter\<TTypologyFilter,TValue\>')

Implements [DiGi\.Typology\.Interfaces\.ITypologyFilter&lt;](DiGi.Typology.Interfaces.md#DiGi.Typology.Interfaces.ITypologyFilter_TTypologyFilter_ 'DiGi\.Typology\.Interfaces\.ITypologyFilter\<TTypologyFilter\>')[TTypologyFilter](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyFilter_TTypologyFilter_.TTypologyFilter 'DiGi\.Typology\.Classes\.TypologyFilter\<TTypologyFilter\>\.TTypologyFilter')[&gt;](DiGi.Typology.Interfaces.md#DiGi.Typology.Interfaces.ITypologyFilter_TTypologyFilter_ 'DiGi\.Typology\.Interfaces\.ITypologyFilter\<TTypologyFilter\>'), [ITypologyFilter](DiGi.Typology.Interfaces.md#DiGi.Typology.Interfaces.ITypologyFilter 'DiGi\.Typology\.Interfaces\.ITypologyFilter'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Typology\.Interfaces\.ITypologyObject](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.interfaces.itypologyobject 'DiGi\.Typology\.Interfaces\.ITypologyObject')
### Constructors

<a name='DiGi.Typology.Classes.TypologyFilter_TTypologyFilter_.TypologyFilter()'></a>

## TypologyFilter\(\) Constructor

Initializes a new instance of the [TypologyFilter&lt;TTypologyFilter&gt;](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyFilter_TTypologyFilter_ 'DiGi\.Typology\.Classes\.TypologyFilter\<TTypologyFilter\>') class\.

```csharp
protected TypologyFilter();
```

<a name='DiGi.Typology.Classes.TypologyFilter_TTypologyFilter_.TypologyFilter(DiGi.Typology.Classes.TypologyFilter_TTypologyFilter_)'></a>

## TypologyFilter\(TypologyFilter\<TTypologyFilter\>\) Constructor

Initializes a new instance of the [TypologyFilter&lt;TTypologyFilter&gt;](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyFilter_TTypologyFilter_ 'DiGi\.Typology\.Classes\.TypologyFilter\<TTypologyFilter\>') class by copying another instance\.

```csharp
protected TypologyFilter(DiGi.Typology.Classes.TypologyFilter<TTypologyFilter>? typologyFilter_Other);
```
#### Parameters

<a name='DiGi.Typology.Classes.TypologyFilter_TTypologyFilter_.TypologyFilter(DiGi.Typology.Classes.TypologyFilter_TTypologyFilter_).typologyFilter_Other'></a>

`typologyFilter_Other` [DiGi\.Typology\.Classes\.TypologyFilter&lt;](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyFilter_TTypologyFilter_ 'DiGi\.Typology\.Classes\.TypologyFilter\<TTypologyFilter\>')[TTypologyFilter](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyFilter_TTypologyFilter_.TTypologyFilter 'DiGi\.Typology\.Classes\.TypologyFilter\<TTypologyFilter\>\.TTypologyFilter')[&gt;](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyFilter_TTypologyFilter_ 'DiGi\.Typology\.Classes\.TypologyFilter\<TTypologyFilter\>')

The source filter instance to copy from\.

<a name='DiGi.Typology.Classes.TypologyFilter_TTypologyFilter_.TypologyFilter(System.Text.Json.Nodes.JsonObject)'></a>

## TypologyFilter\(JsonObject\) Constructor

Initializes a new instance of the [TypologyFilter&lt;TTypologyFilter&gt;](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyFilter_TTypologyFilter_ 'DiGi\.Typology\.Classes\.TypologyFilter\<TTypologyFilter\>') class with a JSON object\.

```csharp
protected TypologyFilter(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Typology.Classes.TypologyFilter_TTypologyFilter_.TypologyFilter(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing filter data\.
### Properties

<a name='DiGi.Typology.Classes.TypologyFilter_TTypologyFilter_.Filter'></a>

## TypologyFilter\<TTypologyFilter\>\.Filter Property

Gets or sets the nested typology filter to apply sequentially\.

```csharp
public TTypologyFilter? Filter { get; set; }
```

Implements [Filter](DiGi.Typology.Interfaces.md#DiGi.Typology.Interfaces.ITypologyFilter_TTypologyFilter_.Filter 'DiGi\.Typology\.Interfaces\.ITypologyFilter\<TTypologyFilter\>\.Filter')

#### Property Value
[TTypologyFilter](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyFilter_TTypologyFilter_.TTypologyFilter 'DiGi\.Typology\.Classes\.TypologyFilter\<TTypologyFilter\>\.TTypologyFilter')

<a name='DiGi.Typology.Classes.TypologyFilter_TTypologyFilter_.Rule'></a>

## TypologyFilter\<TTypologyFilter\>\.Rule Property

Gets or sets the rule associated with this typology filter\.

```csharp
public DiGi.Typology.Interfaces.ITypologyFilterRule? Rule { get; set; }
```

Implements [Rule](DiGi.Typology.Interfaces.md#DiGi.Typology.Interfaces.ITypologyFilter.Rule 'DiGi\.Typology\.Interfaces\.ITypologyFilter\.Rule')

#### Property Value
[ITypologyFilterRule](DiGi.Typology.Interfaces.md#DiGi.Typology.Interfaces.ITypologyFilterRule 'DiGi\.Typology\.Interfaces\.ITypologyFilterRule')

<a name='DiGi.Typology.Classes.TypologyFilterRule'></a>

## TypologyFilterRule Class

Represents a base abstract class for typology filter rules\.

```csharp
public abstract class TypologyFilterRule : DiGi.Core.Classes.SerializableObject, DiGi.Typology.Interfaces.ITypologyFilterRule, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Typology.Interfaces.ITypologyObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → TypologyFilterRule

Derived  
↳ [GroupValueFilterRule](DiGi.Typology.Classes.md#DiGi.Typology.Classes.GroupValueFilterRule 'DiGi\.Typology\.Classes\.GroupValueFilterRule')  
↳ [RangeValueFilterRule&lt;TValueType&gt;](DiGi.Typology.Classes.md#DiGi.Typology.Classes.RangeValueFilterRule_TValueType_ 'DiGi\.Typology\.Classes\.RangeValueFilterRule\<TValueType\>')  
↳ [UniqueValueFilterRule](DiGi.Typology.Classes.md#DiGi.Typology.Classes.UniqueValueFilterRule 'DiGi\.Typology\.Classes\.UniqueValueFilterRule')

Implements [ITypologyFilterRule](DiGi.Typology.Interfaces.md#DiGi.Typology.Interfaces.ITypologyFilterRule 'DiGi\.Typology\.Interfaces\.ITypologyFilterRule'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Typology\.Interfaces\.ITypologyObject](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.interfaces.itypologyobject 'DiGi\.Typology\.Interfaces\.ITypologyObject')
### Constructors

<a name='DiGi.Typology.Classes.TypologyFilterRule.TypologyFilterRule()'></a>

## TypologyFilterRule\(\) Constructor

Initializes a new instance of the [TypologyFilterRule](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyFilterRule 'DiGi\.Typology\.Classes\.TypologyFilterRule') class\.

```csharp
public TypologyFilterRule();
```

<a name='DiGi.Typology.Classes.TypologyFilterRule.TypologyFilterRule(DiGi.Typology.Classes.TypologyFilterRule)'></a>

## TypologyFilterRule\(TypologyFilterRule\) Constructor

Initializes a new instance of the [TypologyFilterRule](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyFilterRule 'DiGi\.Typology\.Classes\.TypologyFilterRule') class by copying another instance\.

```csharp
public TypologyFilterRule(DiGi.Typology.Classes.TypologyFilterRule typologyFilterRule);
```
#### Parameters

<a name='DiGi.Typology.Classes.TypologyFilterRule.TypologyFilterRule(DiGi.Typology.Classes.TypologyFilterRule).typologyFilterRule'></a>

`typologyFilterRule` [TypologyFilterRule](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyFilterRule 'DiGi\.Typology\.Classes\.TypologyFilterRule')

The source filter rule to copy from\.

<a name='DiGi.Typology.Classes.TypologyFilterRule.TypologyFilterRule(System.Text.Json.Nodes.JsonObject)'></a>

## TypologyFilterRule\(JsonObject\) Constructor

Initializes a new instance of the [TypologyFilterRule](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyFilterRule 'DiGi\.Typology\.Classes\.TypologyFilterRule') class with a JSON object\.

```csharp
public TypologyFilterRule(System.Text.Json.Nodes.JsonObject jsonObject);
```
#### Parameters

<a name='DiGi.Typology.Classes.TypologyFilterRule.TypologyFilterRule(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing filter rule data\.

<a name='DiGi.Typology.Classes.TypologyFilterRuleData_TTypologyFilterRuleData_'></a>

## TypologyFilterRuleData\<TTypologyFilterRuleData\> Class

Represents a base abstract class for typology filter rule data\.

```csharp
public abstract class TypologyFilterRuleData<TTypologyFilterRuleData> : DiGi.Core.Classes.SerializableObject, DiGi.Typology.Interfaces.ITypologyFilterRuleData<TTypologyFilterRuleData>, DiGi.Typology.Interfaces.ITypologyFilterRuleData, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Typology.Interfaces.ITypologyObject, System.IEquatable<TTypologyFilterRuleData>
    where TTypologyFilterRuleData : DiGi.Typology.Classes.TypologyFilterRuleData<TTypologyFilterRuleData>
```
#### Type parameters

<a name='DiGi.Typology.Classes.TypologyFilterRuleData_TTypologyFilterRuleData_.TTypologyFilterRuleData'></a>

`TTypologyFilterRuleData`

The specific type of the typology filter rule data\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → TypologyFilterRuleData\<TTypologyFilterRuleData\>

Derived  
↳ [RangeValueRuleData&lt;TValueType&gt;](DiGi.Typology.Classes.md#DiGi.Typology.Classes.RangeValueRuleData_TValueType_ 'DiGi\.Typology\.Classes\.RangeValueRuleData\<TValueType\>')  
↳ [UniqueValueRuleData](DiGi.Typology.Classes.md#DiGi.Typology.Classes.UniqueValueRuleData 'DiGi\.Typology\.Classes\.UniqueValueRuleData')

Implements [DiGi\.Typology\.Interfaces\.ITypologyFilterRuleData&lt;](DiGi.Typology.Interfaces.md#DiGi.Typology.Interfaces.ITypologyFilterRuleData_TTypologyFilterRuleData_ 'DiGi\.Typology\.Interfaces\.ITypologyFilterRuleData\<TTypologyFilterRuleData\>')[TTypologyFilterRuleData](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyFilterRuleData_TTypologyFilterRuleData_.TTypologyFilterRuleData 'DiGi\.Typology\.Classes\.TypologyFilterRuleData\<TTypologyFilterRuleData\>\.TTypologyFilterRuleData')[&gt;](DiGi.Typology.Interfaces.md#DiGi.Typology.Interfaces.ITypologyFilterRuleData_TTypologyFilterRuleData_ 'DiGi\.Typology\.Interfaces\.ITypologyFilterRuleData\<TTypologyFilterRuleData\>'), [ITypologyFilterRuleData](DiGi.Typology.Interfaces.md#DiGi.Typology.Interfaces.ITypologyFilterRuleData 'DiGi\.Typology\.Interfaces\.ITypologyFilterRuleData'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Typology\.Interfaces\.ITypologyObject](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.interfaces.itypologyobject 'DiGi\.Typology\.Interfaces\.ITypologyObject'), [System\.IEquatable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.iequatable-1 'System\.IEquatable\`1')[TTypologyFilterRuleData](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyFilterRuleData_TTypologyFilterRuleData_.TTypologyFilterRuleData 'DiGi\.Typology\.Classes\.TypologyFilterRuleData\<TTypologyFilterRuleData\>\.TTypologyFilterRuleData')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.iequatable-1 'System\.IEquatable\`1')
### Constructors

<a name='DiGi.Typology.Classes.TypologyFilterRuleData_TTypologyFilterRuleData_.TypologyFilterRuleData()'></a>

## TypologyFilterRuleData\(\) Constructor

Initializes a new instance of the [TypologyFilterRuleData&lt;TTypologyFilterRuleData&gt;](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyFilterRuleData_TTypologyFilterRuleData_ 'DiGi\.Typology\.Classes\.TypologyFilterRuleData\<TTypologyFilterRuleData\>') class\.

```csharp
public TypologyFilterRuleData();
```

<a name='DiGi.Typology.Classes.TypologyFilterRuleData_TTypologyFilterRuleData_.TypologyFilterRuleData(DiGi.Typology.Classes.TypologyFilterRuleData_TTypologyFilterRuleData_)'></a>

## TypologyFilterRuleData\(TypologyFilterRuleData\<TTypologyFilterRuleData\>\) Constructor

Initializes a new instance of the [TypologyFilterRuleData&lt;TTypologyFilterRuleData&gt;](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyFilterRuleData_TTypologyFilterRuleData_ 'DiGi\.Typology\.Classes\.TypologyFilterRuleData\<TTypologyFilterRuleData\>') class by copying another instance\.

```csharp
public TypologyFilterRuleData(DiGi.Typology.Classes.TypologyFilterRuleData<TTypologyFilterRuleData> typologyFilterRuleData);
```
#### Parameters

<a name='DiGi.Typology.Classes.TypologyFilterRuleData_TTypologyFilterRuleData_.TypologyFilterRuleData(DiGi.Typology.Classes.TypologyFilterRuleData_TTypologyFilterRuleData_).typologyFilterRuleData'></a>

`typologyFilterRuleData` [DiGi\.Typology\.Classes\.TypologyFilterRuleData&lt;](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyFilterRuleData_TTypologyFilterRuleData_ 'DiGi\.Typology\.Classes\.TypologyFilterRuleData\<TTypologyFilterRuleData\>')[TTypologyFilterRuleData](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyFilterRuleData_TTypologyFilterRuleData_.TTypologyFilterRuleData 'DiGi\.Typology\.Classes\.TypologyFilterRuleData\<TTypologyFilterRuleData\>\.TTypologyFilterRuleData')[&gt;](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyFilterRuleData_TTypologyFilterRuleData_ 'DiGi\.Typology\.Classes\.TypologyFilterRuleData\<TTypologyFilterRuleData\>')

The source filter rule data to copy from\.

<a name='DiGi.Typology.Classes.TypologyFilterRuleData_TTypologyFilterRuleData_.TypologyFilterRuleData(System.Text.Json.Nodes.JsonObject)'></a>

## TypologyFilterRuleData\(JsonObject\) Constructor

Initializes a new instance of the [TypologyFilterRuleData&lt;TTypologyFilterRuleData&gt;](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyFilterRuleData_TTypologyFilterRuleData_ 'DiGi\.Typology\.Classes\.TypologyFilterRuleData\<TTypologyFilterRuleData\>') class with a JSON object\.

```csharp
public TypologyFilterRuleData(System.Text.Json.Nodes.JsonObject jsonObject);
```
#### Parameters

<a name='DiGi.Typology.Classes.TypologyFilterRuleData_TTypologyFilterRuleData_.TypologyFilterRuleData(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the filter rule data\.
### Methods

<a name='DiGi.Typology.Classes.TypologyFilterRuleData_TTypologyFilterRuleData_.Equals(TTypologyFilterRuleData)'></a>

## TypologyFilterRuleData\<TTypologyFilterRuleData\>\.Equals\(TTypologyFilterRuleData\) Method

Compares this filter rule data instance to another for equality\.

```csharp
public abstract bool Equals(TTypologyFilterRuleData typologyFilterRuleData);
```
#### Parameters

<a name='DiGi.Typology.Classes.TypologyFilterRuleData_TTypologyFilterRuleData_.Equals(TTypologyFilterRuleData).typologyFilterRuleData'></a>

`typologyFilterRuleData` [TTypologyFilterRuleData](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyFilterRuleData_TTypologyFilterRuleData_.TTypologyFilterRuleData 'DiGi\.Typology\.Classes\.TypologyFilterRuleData\<TTypologyFilterRuleData\>\.TTypologyFilterRuleData')

The filter rule data to compare\.

Implements [Equals\(T\)](https://learn.microsoft.com/en-us/dotnet/api/system.iequatable-1.equals#system-iequatable-1-equals(-0) 'System\.IEquatable\`1\.Equals\(\`0\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if they are equal; otherwise, false\.

<a name='DiGi.Typology.Classes.TypologyFilterSolver_TTypologyFilter,TObject_'></a>

## TypologyFilterSolver\<TTypologyFilter,TObject\> Class

Represents an abstract solver for applying typology filters to a collection of objects to resolve typologies\.

```csharp
public abstract class TypologyFilterSolver<TTypologyFilter,TObject> : DiGi.Core.Interfaces.IOneToOneSolver<TTypologyFilter, DiGi.Typology.Classes.Typology>, DiGi.Core.Interfaces.ISolver, DiGi.Core.Interfaces.IEvaluator
    where TTypologyFilter : DiGi.Typology.Interfaces.ITypologyFilter<TTypologyFilter>
```
#### Type parameters

<a name='DiGi.Typology.Classes.TypologyFilterSolver_TTypologyFilter,TObject_.TTypologyFilter'></a>

`TTypologyFilter`

The type of the typology filter\.

<a name='DiGi.Typology.Classes.TypologyFilterSolver_TTypologyFilter,TObject_.TObject'></a>

`TObject`

The type of objects being evaluated\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → TypologyFilterSolver\<TTypologyFilter,TObject\>

Derived  
↳ [ColumnTypologyFilterSolver&lt;TColumn,TRow&gt;](DiGi.Typology.Classes.md#DiGi.Typology.Classes.ColumnTypologyFilterSolver_TColumn,TRow_ 'DiGi\.Typology\.Classes\.ColumnTypologyFilterSolver\<TColumn,TRow\>')

Implements [DiGi\.Core\.Interfaces\.IOneToOneSolver&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.ionetoonesolver-2 'DiGi\.Core\.Interfaces\.IOneToOneSolver\`2')[TTypologyFilter](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyFilterSolver_TTypologyFilter,TObject_.TTypologyFilter 'DiGi\.Typology\.Classes\.TypologyFilterSolver\<TTypologyFilter,TObject\>\.TTypologyFilter')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.ionetoonesolver-2 'DiGi\.Core\.Interfaces\.IOneToOneSolver\`2')[Typology](DiGi.Typology.Classes.md#DiGi.Typology.Classes.Typology 'DiGi\.Typology\.Classes\.Typology')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.ionetoonesolver-2 'DiGi\.Core\.Interfaces\.IOneToOneSolver\`2'), [DiGi\.Core\.Interfaces\.ISolver](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.isolver 'DiGi\.Core\.Interfaces\.ISolver'), [DiGi\.Core\.Interfaces\.IEvaluator](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.ievaluator 'DiGi\.Core\.Interfaces\.IEvaluator')
### Constructors

<a name='DiGi.Typology.Classes.TypologyFilterSolver_TTypologyFilter,TObject_.TypologyFilterSolver()'></a>

## TypologyFilterSolver\(\) Constructor

Initializes a new instance of the [TypologyFilterSolver&lt;TTypologyFilter,TObject&gt;](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyFilterSolver_TTypologyFilter,TObject_ 'DiGi\.Typology\.Classes\.TypologyFilterSolver\<TTypologyFilter,TObject\>') class\.

```csharp
public TypologyFilterSolver();
```

<a name='DiGi.Typology.Classes.TypologyFilterSolver_TTypologyFilter,TObject_.TypologyFilterSolver(TTypologyFilter,System.Collections.Generic.IEnumerable_TObject_)'></a>

## TypologyFilterSolver\(TTypologyFilter, IEnumerable\<TObject\>\) Constructor

Initializes a new instance of the [TypologyFilterSolver&lt;TTypologyFilter,TObject&gt;](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyFilterSolver_TTypologyFilter,TObject_ 'DiGi\.Typology\.Classes\.TypologyFilterSolver\<TTypologyFilter,TObject\>') class with a specified typology filter and collection of objects\.

```csharp
public TypologyFilterSolver(TTypologyFilter? typologyFilter, System.Collections.Generic.IEnumerable<TObject>? objects);
```
#### Parameters

<a name='DiGi.Typology.Classes.TypologyFilterSolver_TTypologyFilter,TObject_.TypologyFilterSolver(TTypologyFilter,System.Collections.Generic.IEnumerable_TObject_).typologyFilter'></a>

`typologyFilter` [TTypologyFilter](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyFilterSolver_TTypologyFilter,TObject_.TTypologyFilter 'DiGi\.Typology\.Classes\.TypologyFilterSolver\<TTypologyFilter,TObject\>\.TTypologyFilter')

The input typology filter\.

<a name='DiGi.Typology.Classes.TypologyFilterSolver_TTypologyFilter,TObject_.TypologyFilterSolver(TTypologyFilter,System.Collections.Generic.IEnumerable_TObject_).objects'></a>

`objects` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[TObject](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyFilterSolver_TTypologyFilter,TObject_.TObject 'DiGi\.Typology\.Classes\.TypologyFilterSolver\<TTypologyFilter,TObject\>\.TObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of source objects to evaluate\.
### Properties

<a name='DiGi.Typology.Classes.TypologyFilterSolver_TTypologyFilter,TObject_.Input'></a>

## TypologyFilterSolver\<TTypologyFilter,TObject\>\.Input Property

Gets or sets the input typology filter used for solving\.

```csharp
public TTypologyFilter? Input { get; set; }
```

Implements [Input](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.ionetoonesolver-2.input 'DiGi\.Core\.Interfaces\.IOneToOneSolver\`2\.Input')

#### Property Value
[TTypologyFilter](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyFilterSolver_TTypologyFilter,TObject_.TTypologyFilter 'DiGi\.Typology\.Classes\.TypologyFilterSolver\<TTypologyFilter,TObject\>\.TTypologyFilter')

<a name='DiGi.Typology.Classes.TypologyFilterSolver_TTypologyFilter,TObject_.Objects'></a>

## TypologyFilterSolver\<TTypologyFilter,TObject\>\.Objects Property

Gets or sets the collection of source objects to evaluate\.

```csharp
public System.Collections.Generic.IEnumerable<TObject>? Objects { get; set; }
```

#### Property Value
[System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[TObject](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyFilterSolver_TTypologyFilter,TObject_.TObject 'DiGi\.Typology\.Classes\.TypologyFilterSolver\<TTypologyFilter,TObject\>\.TObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

<a name='DiGi.Typology.Classes.TypologyFilterSolver_TTypologyFilter,TObject_.Output'></a>

## TypologyFilterSolver\<TTypologyFilter,TObject\>\.Output Property

Gets the resulting typology output from the solving process\.

```csharp
public DiGi.Typology.Classes.Typology? Output { get; private set; }
```

Implements [Output](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.ionetoonesolver-2.output 'DiGi\.Core\.Interfaces\.IOneToOneSolver\`2\.Output')

#### Property Value
[Typology](DiGi.Typology.Classes.md#DiGi.Typology.Classes.Typology 'DiGi\.Typology\.Classes\.Typology')

<a name='DiGi.Typology.Classes.TypologyFilterSolver_TTypologyFilter,TObject_.TypologyItem'></a>

## TypologyFilterSolver\<TTypologyFilter,TObject\>\.TypologyItem Property

Default TypologyItem for Typology root

```csharp
public DiGi.Typology.Classes.TypologyItem? TypologyItem { get; set; }
```

#### Property Value
[TypologyItem](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyItem 'DiGi\.Typology\.Classes\.TypologyItem')
### Methods

<a name='DiGi.Typology.Classes.TypologyFilterSolver_TTypologyFilter,TObject_.GetReference(TObject)'></a>

## TypologyFilterSolver\<TTypologyFilter,TObject\>\.GetReference\(TObject\) Method

Gets a unique reference identifier string for the specified object\.

```csharp
protected virtual string? GetReference(TObject? @object);
```
#### Parameters

<a name='DiGi.Typology.Classes.TypologyFilterSolver_TTypologyFilter,TObject_.GetReference(TObject).object'></a>

`object` [TObject](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyFilterSolver_TTypologyFilter,TObject_.TObject 'DiGi\.Typology\.Classes\.TypologyFilterSolver\<TTypologyFilter,TObject\>\.TObject')

The object to identify\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
The unique identifier string, or null\.

<a name='DiGi.Typology.Classes.TypologyFilterSolver_TTypologyFilter,TObject_.GetTypologyItem(TTypologyFilter,DiGi.Typology.Interfaces.ITypologyFilterRuleData)'></a>

## TypologyFilterSolver\<TTypologyFilter,TObject\>\.GetTypologyItem\(TTypologyFilter, ITypologyFilterRuleData\) Method

Creates a new typology item based on the current filter context and evaluated rule data\.

```csharp
protected abstract DiGi.Typology.Classes.TypologyItem? GetTypologyItem(TTypologyFilter? typologyFilter, DiGi.Typology.Interfaces.ITypologyFilterRuleData? typologyFilterRuleData);
```
#### Parameters

<a name='DiGi.Typology.Classes.TypologyFilterSolver_TTypologyFilter,TObject_.GetTypologyItem(TTypologyFilter,DiGi.Typology.Interfaces.ITypologyFilterRuleData).typologyFilter'></a>

`typologyFilter` [TTypologyFilter](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyFilterSolver_TTypologyFilter,TObject_.TTypologyFilter 'DiGi\.Typology\.Classes\.TypologyFilterSolver\<TTypologyFilter,TObject\>\.TTypologyFilter')

The current typology filter context\.

<a name='DiGi.Typology.Classes.TypologyFilterSolver_TTypologyFilter,TObject_.GetTypologyItem(TTypologyFilter,DiGi.Typology.Interfaces.ITypologyFilterRuleData).typologyFilterRuleData'></a>

`typologyFilterRuleData` [ITypologyFilterRuleData](DiGi.Typology.Interfaces.md#DiGi.Typology.Interfaces.ITypologyFilterRuleData 'DiGi\.Typology\.Interfaces\.ITypologyFilterRuleData')

The evaluated rule data\.

#### Returns
[TypologyItem](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyItem 'DiGi\.Typology\.Classes\.TypologyItem')  
A new typology item, or null\.

<a name='DiGi.Typology.Classes.TypologyFilterSolver_TTypologyFilter,TObject_.GetValue(TTypologyFilter,TObject)'></a>

## TypologyFilterSolver\<TTypologyFilter,TObject\>\.GetValue\(TTypologyFilter, TObject\) Method

Extracts the target evaluation value from the specified object using the current filter context\.

```csharp
protected abstract object? GetValue(TTypologyFilter? typologyFilter, TObject? @object);
```
#### Parameters

<a name='DiGi.Typology.Classes.TypologyFilterSolver_TTypologyFilter,TObject_.GetValue(TTypologyFilter,TObject).typologyFilter'></a>

`typologyFilter` [TTypologyFilter](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyFilterSolver_TTypologyFilter,TObject_.TTypologyFilter 'DiGi\.Typology\.Classes\.TypologyFilterSolver\<TTypologyFilter,TObject\>\.TTypologyFilter')

The current typology filter context\.

<a name='DiGi.Typology.Classes.TypologyFilterSolver_TTypologyFilter,TObject_.GetValue(TTypologyFilter,TObject).object'></a>

`object` [TObject](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyFilterSolver_TTypologyFilter,TObject_.TObject 'DiGi\.Typology\.Classes\.TypologyFilterSolver\<TTypologyFilter,TObject\>\.TObject')

The object to extract the value from\.

#### Returns
[System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')  
The extracted value, or null\.

<a name='DiGi.Typology.Classes.TypologyFilterSolver_TTypologyFilter,TObject_.Solve()'></a>

## TypologyFilterSolver\<TTypologyFilter,TObject\>\.Solve\(\) Method

Solves and populates the typology output by evaluating the input filter against the objects\.

```csharp
public bool Solve();
```

Implements [Solve\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.isolver.solve 'DiGi\.Core\.Interfaces\.ISolver\.Solve')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if solving succeeded; otherwise, false\.

<a name='DiGi.Typology.Classes.TypologyItem'></a>

## TypologyItem Class

Represents an item within a typology system, providing identification via a path and descriptive metadata\.

```csharp
public class TypologyItem : DiGi.Core.Classes.SerializableObject, DiGi.Typology.Interfaces.ITypologyObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.INamedObject, DiGi.Core.Interfaces.IDescribableObject, System.IComparable<DiGi.Typology.Classes.TypologyItem>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → TypologyItem

Implements [DiGi\.Typology\.Interfaces\.ITypologyObject](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.interfaces.itypologyobject 'DiGi\.Typology\.Interfaces\.ITypologyObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.INamedObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.inamedobject 'DiGi\.Core\.Interfaces\.INamedObject'), [DiGi\.Core\.Interfaces\.IDescribableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.idescribableobject 'DiGi\.Core\.Interfaces\.IDescribableObject'), [System\.IComparable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.icomparable-1 'System\.IComparable\`1')[TypologyItem](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyItem 'DiGi\.Typology\.Classes\.TypologyItem')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.icomparable-1 'System\.IComparable\`1')
### Constructors

<a name='DiGi.Typology.Classes.TypologyItem.TypologyItem()'></a>

## TypologyItem\(\) Constructor

Initializes a new instance of the [TypologyItem](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyItem 'DiGi\.Typology\.Classes\.TypologyItem') class\.

```csharp
public TypologyItem();
```

<a name='DiGi.Typology.Classes.TypologyItem.TypologyItem(DiGi.Typology.Classes.TypologyItem)'></a>

## TypologyItem\(TypologyItem\) Constructor

Initializes a new instance of the [TypologyItem](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyItem 'DiGi\.Typology\.Classes\.TypologyItem') class by cloning an existing item\.

```csharp
public TypologyItem(DiGi.Typology.Classes.TypologyItem? typologyItem);
```
#### Parameters

<a name='DiGi.Typology.Classes.TypologyItem.TypologyItem(DiGi.Typology.Classes.TypologyItem).typologyItem'></a>

`typologyItem` [TypologyItem](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyItem 'DiGi\.Typology\.Classes\.TypologyItem')

The source item to clone\.

<a name='DiGi.Typology.Classes.TypologyItem.TypologyItem(DiGi.Typology.Classes.TypologyPath,DiGi.Typology.Classes.TypologyItem)'></a>

## TypologyItem\(TypologyPath, TypologyItem\) Constructor

Initializes a new instance of the [TypologyItem](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyItem 'DiGi\.Typology\.Classes\.TypologyItem') class using a specific typology path and metadata from another item\.

```csharp
public TypologyItem(DiGi.Typology.Classes.TypologyPath? typologyPath, DiGi.Typology.Classes.TypologyItem typologyItem);
```
#### Parameters

<a name='DiGi.Typology.Classes.TypologyItem.TypologyItem(DiGi.Typology.Classes.TypologyPath,DiGi.Typology.Classes.TypologyItem).typologyPath'></a>

`typologyPath` [TypologyPath](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyPath 'DiGi\.Typology\.Classes\.TypologyPath')

The path to assign to this item\.

<a name='DiGi.Typology.Classes.TypologyItem.TypologyItem(DiGi.Typology.Classes.TypologyPath,DiGi.Typology.Classes.TypologyItem).typologyItem'></a>

`typologyItem` [TypologyItem](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyItem 'DiGi\.Typology\.Classes\.TypologyItem')

The source item to copy the name and description from\.

<a name='DiGi.Typology.Classes.TypologyItem.TypologyItem(DiGi.Typology.Classes.TypologyPath,string)'></a>

## TypologyItem\(TypologyPath, string\) Constructor

Initializes a new instance of the [TypologyItem](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyItem 'DiGi\.Typology\.Classes\.TypologyItem') class using a typology path and a name\.

```csharp
public TypologyItem(DiGi.Typology.Classes.TypologyPath? typologyPath, string? name);
```
#### Parameters

<a name='DiGi.Typology.Classes.TypologyItem.TypologyItem(DiGi.Typology.Classes.TypologyPath,string).typologyPath'></a>

`typologyPath` [TypologyPath](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyPath 'DiGi\.Typology\.Classes\.TypologyPath')

The path associated with this item\.

<a name='DiGi.Typology.Classes.TypologyItem.TypologyItem(DiGi.Typology.Classes.TypologyPath,string).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the item\.

<a name='DiGi.Typology.Classes.TypologyItem.TypologyItem(DiGi.Typology.Classes.TypologyPath,string,string)'></a>

## TypologyItem\(TypologyPath, string, string\) Constructor

Initializes a new instance of the [TypologyItem](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyItem 'DiGi\.Typology\.Classes\.TypologyItem') class using a typology path, a name, and a description\.

```csharp
public TypologyItem(DiGi.Typology.Classes.TypologyPath? typologyPath, string? name, string? description);
```
#### Parameters

<a name='DiGi.Typology.Classes.TypologyItem.TypologyItem(DiGi.Typology.Classes.TypologyPath,string,string).typologyPath'></a>

`typologyPath` [TypologyPath](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyPath 'DiGi\.Typology\.Classes\.TypologyPath')

The path associated with this item\.

<a name='DiGi.Typology.Classes.TypologyItem.TypologyItem(DiGi.Typology.Classes.TypologyPath,string,string).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the item\.

<a name='DiGi.Typology.Classes.TypologyItem.TypologyItem(DiGi.Typology.Classes.TypologyPath,string,string).description'></a>

`description` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The description of the item\.

<a name='DiGi.Typology.Classes.TypologyItem.TypologyItem(System.Collections.Generic.IEnumerable_int_,string)'></a>

## TypologyItem\(IEnumerable\<int\>, string\) Constructor

Initializes a new instance of the [TypologyItem](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyItem 'DiGi\.Typology\.Classes\.TypologyItem') class using a collection of path values and a name\.

```csharp
public TypologyItem(System.Collections.Generic.IEnumerable<int>? values, string? name);
```
#### Parameters

<a name='DiGi.Typology.Classes.TypologyItem.TypologyItem(System.Collections.Generic.IEnumerable_int_,string).values'></a>

`values` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The sequence of integers defining the typology path\.

<a name='DiGi.Typology.Classes.TypologyItem.TypologyItem(System.Collections.Generic.IEnumerable_int_,string).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the item\.

<a name='DiGi.Typology.Classes.TypologyItem.TypologyItem(System.Collections.Generic.IEnumerable_int_,string,string)'></a>

## TypologyItem\(IEnumerable\<int\>, string, string\) Constructor

Initializes a new instance of the [TypologyItem](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyItem 'DiGi\.Typology\.Classes\.TypologyItem') class using a collection of path values, a name, and a description\.

```csharp
public TypologyItem(System.Collections.Generic.IEnumerable<int>? values, string? name, string? description);
```
#### Parameters

<a name='DiGi.Typology.Classes.TypologyItem.TypologyItem(System.Collections.Generic.IEnumerable_int_,string,string).values'></a>

`values` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The sequence of integers defining the typology path\.

<a name='DiGi.Typology.Classes.TypologyItem.TypologyItem(System.Collections.Generic.IEnumerable_int_,string,string).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the item\.

<a name='DiGi.Typology.Classes.TypologyItem.TypologyItem(System.Collections.Generic.IEnumerable_int_,string,string).description'></a>

`description` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The description of the item\.

<a name='DiGi.Typology.Classes.TypologyItem.TypologyItem(System.Text.Json.Nodes.JsonObject)'></a>

## TypologyItem\(JsonObject\) Constructor

Initializes a new instance of the [TypologyItem](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyItem 'DiGi\.Typology\.Classes\.TypologyItem') class from a JSON object\.

```csharp
public TypologyItem(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Typology.Classes.TypologyItem.TypologyItem(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing item data\.
### Properties

<a name='DiGi.Typology.Classes.TypologyItem.Description'></a>

## TypologyItem\.Description Property

Gets or sets the description of the typology item\.

```csharp
public string? Description { get; set; }
```

Implements [Description](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.idescribableobject.description 'DiGi\.Core\.Interfaces\.IDescribableObject\.Description')

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Typology.Classes.TypologyItem.Name'></a>

## TypologyItem\.Name Property

Gets or sets the name of the typology item\.

```csharp
public string? Name { get; set; }
```

Implements [Name](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.inamedobject.name 'DiGi\.Core\.Interfaces\.INamedObject\.Name')

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Typology.Classes.TypologyItem.TypologyPath'></a>

## TypologyItem\.TypologyPath Property

Gets the typology path associated with this item\.

```csharp
public DiGi.Typology.Classes.TypologyPath? TypologyPath { get; }
```

#### Property Value
[TypologyPath](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyPath 'DiGi\.Typology\.Classes\.TypologyPath')
### Methods

<a name='DiGi.Typology.Classes.TypologyItem.CompareTo(DiGi.Typology.Classes.TypologyItem)'></a>

## TypologyItem\.CompareTo\(TypologyItem\) Method

Compares the current instance with another [TypologyItem](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyItem 'DiGi\.Typology\.Classes\.TypologyItem') based on their paths\.

```csharp
public int CompareTo(DiGi.Typology.Classes.TypologyItem typologyItem);
```
#### Parameters

<a name='DiGi.Typology.Classes.TypologyItem.CompareTo(DiGi.Typology.Classes.TypologyItem).typologyItem'></a>

`typologyItem` [TypologyItem](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyItem 'DiGi\.Typology\.Classes\.TypologyItem')

The item to compare with this instance\.

#### Returns
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')  
A value indicating the relative order of the objects being compared\.

<a name='DiGi.Typology.Classes.TypologyItem.ToString()'></a>

## TypologyItem\.ToString\(\) Method

Returns a string representation of the current item, typically in the format "\[path\] name"\.

```csharp
public override string ToString();
```

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
A string representing the typology item\.

<a name='DiGi.Typology.Classes.TypologyModel'></a>

## TypologyModel Class

Represents a model for typology data, inheriting from GuidModel and implementing ITypologyObject and INamedObject\.

```csharp
public class TypologyModel : DiGi.Core.Classes.GuidModel, DiGi.Typology.Interfaces.ITypologyObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.INamedObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Classes\.UniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniqueobject 'DiGi\.Core\.Classes\.UniqueObject') → [DiGi\.Core\.Classes\.GuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidobject 'DiGi\.Core\.Classes\.GuidObject') → [DiGi\.Core\.Classes\.GuidModel](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidmodel 'DiGi\.Core\.Classes\.GuidModel') → TypologyModel

Implements [DiGi\.Typology\.Interfaces\.ITypologyObject](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.interfaces.itypologyobject 'DiGi\.Typology\.Interfaces\.ITypologyObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.INamedObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.inamedobject 'DiGi\.Core\.Interfaces\.INamedObject')
### Constructors

<a name='DiGi.Typology.Classes.TypologyModel.TypologyModel()'></a>

## TypologyModel\(\) Constructor

Initializes a new instance of the [TypologyModel](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyModel 'DiGi\.Typology\.Classes\.TypologyModel') class\.

```csharp
public TypologyModel();
```

<a name='DiGi.Typology.Classes.TypologyModel.TypologyModel(DiGi.Typology.Classes.TypologyModel)'></a>

## TypologyModel\(TypologyModel\) Constructor

Initializes a new instance of the [TypologyModel](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyModel 'DiGi\.Typology\.Classes\.TypologyModel') class by cloning an existing typology model\.

```csharp
public TypologyModel(DiGi.Typology.Classes.TypologyModel? typologyModel);
```
#### Parameters

<a name='DiGi.Typology.Classes.TypologyModel.TypologyModel(DiGi.Typology.Classes.TypologyModel).typologyModel'></a>

`typologyModel` [TypologyModel](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyModel 'DiGi\.Typology\.Classes\.TypologyModel')

The source typology model to clone\.

<a name='DiGi.Typology.Classes.TypologyModel.TypologyModel(string,DiGi.Typology.Classes.Typology)'></a>

## TypologyModel\(string, Typology\) Constructor

Initializes a new instance of the [TypologyModel](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyModel 'DiGi\.Typology\.Classes\.TypologyModel') class with specified name and typology\.

```csharp
public TypologyModel(string? name, DiGi.Typology.Classes.Typology? typology);
```
#### Parameters

<a name='DiGi.Typology.Classes.TypologyModel.TypologyModel(string,DiGi.Typology.Classes.Typology).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the typology model\.

<a name='DiGi.Typology.Classes.TypologyModel.TypologyModel(string,DiGi.Typology.Classes.Typology).typology'></a>

`typology` [Typology](DiGi.Typology.Classes.md#DiGi.Typology.Classes.Typology 'DiGi\.Typology\.Classes\.Typology')

The typology associated with the model\.

<a name='DiGi.Typology.Classes.TypologyModel.TypologyModel(System.Guid,string,DiGi.Typology.Classes.Typology)'></a>

## TypologyModel\(Guid, string, Typology\) Constructor

Initializes a new instance of the [TypologyModel](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyModel 'DiGi\.Typology\.Classes\.TypologyModel') class with specified GUID, name, and typology\.

```csharp
public TypologyModel(System.Guid guid, string? name, DiGi.Typology.Classes.Typology? typology);
```
#### Parameters

<a name='DiGi.Typology.Classes.TypologyModel.TypologyModel(System.Guid,string,DiGi.Typology.Classes.Typology).guid'></a>

`guid` [System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

The unique identifier for the model\.

<a name='DiGi.Typology.Classes.TypologyModel.TypologyModel(System.Guid,string,DiGi.Typology.Classes.Typology).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the typology model\.

<a name='DiGi.Typology.Classes.TypologyModel.TypologyModel(System.Guid,string,DiGi.Typology.Classes.Typology).typology'></a>

`typology` [Typology](DiGi.Typology.Classes.md#DiGi.Typology.Classes.Typology 'DiGi\.Typology\.Classes\.Typology')

The typology associated with the model\.

<a name='DiGi.Typology.Classes.TypologyModel.TypologyModel(System.Text.Json.Nodes.JsonObject)'></a>

## TypologyModel\(JsonObject\) Constructor

Initializes a new instance of the [TypologyModel](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyModel 'DiGi\.Typology\.Classes\.TypologyModel') class from a JSON object\.

```csharp
public TypologyModel(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Typology.Classes.TypologyModel.TypologyModel(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the model data\.
### Properties

<a name='DiGi.Typology.Classes.TypologyModel.Name'></a>

## TypologyModel\.Name Property

Gets or sets the name of the typology model\.

```csharp
public string? Name { get; set; }
```

Implements [Name](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.inamedobject.name 'DiGi\.Core\.Interfaces\.INamedObject\.Name')

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Typology.Classes.TypologyModel.Typology'></a>

## TypologyModel\.Typology Property

Gets or sets the typology associated with the model\.

```csharp
public DiGi.Typology.Classes.Typology? Typology { get; set; }
```

#### Property Value
[Typology](DiGi.Typology.Classes.md#DiGi.Typology.Classes.Typology 'DiGi\.Typology\.Classes\.Typology')

<a name='DiGi.Typology.Classes.TypologyPath'></a>

## TypologyPath Class

Represents a path within a typology hierarchy as a sequence of integer values\.

```csharp
public class TypologyPath : DiGi.Core.Classes.SerializableObject, DiGi.Typology.Interfaces.ITypologyObject, DiGi.Core.Interfaces.IObject, System.Collections.Generic.IEnumerable<int>, System.Collections.IEnumerable, System.IComparable<DiGi.Typology.Classes.TypologyPath>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → TypologyPath

Implements [DiGi\.Typology\.Interfaces\.ITypologyObject](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.interfaces.itypologyobject 'DiGi\.Typology\.Interfaces\.ITypologyObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1'), [System\.Collections\.IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/system.collections.ienumerable 'System\.Collections\.IEnumerable'), [System\.IComparable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.icomparable-1 'System\.IComparable\`1')[TypologyPath](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyPath 'DiGi\.Typology\.Classes\.TypologyPath')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.icomparable-1 'System\.IComparable\`1')
### Constructors

<a name='DiGi.Typology.Classes.TypologyPath.TypologyPath(DiGi.Typology.Classes.TypologyPath)'></a>

## TypologyPath\(TypologyPath\) Constructor

Initializes a new instance of the [TypologyPath](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyPath 'DiGi\.Typology\.Classes\.TypologyPath') class by copying an existing path\.

```csharp
public TypologyPath(DiGi.Typology.Classes.TypologyPath? typologyPath);
```
#### Parameters

<a name='DiGi.Typology.Classes.TypologyPath.TypologyPath(DiGi.Typology.Classes.TypologyPath).typologyPath'></a>

`typologyPath` [TypologyPath](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyPath 'DiGi\.Typology\.Classes\.TypologyPath')

The source typology path to copy\.

<a name='DiGi.Typology.Classes.TypologyPath.TypologyPath(System.Collections.Generic.IEnumerable_int_)'></a>

## TypologyPath\(IEnumerable\<int\>\) Constructor

Initializes a new instance of the [TypologyPath](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyPath 'DiGi\.Typology\.Classes\.TypologyPath') class using a collection of integer values\.

```csharp
public TypologyPath(System.Collections.Generic.IEnumerable<int>? values);
```
#### Parameters

<a name='DiGi.Typology.Classes.TypologyPath.TypologyPath(System.Collections.Generic.IEnumerable_int_).values'></a>

`values` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The sequence of integers representing the path\.

<a name='DiGi.Typology.Classes.TypologyPath.TypologyPath(System.Text.Json.Nodes.JsonObject)'></a>

## TypologyPath\(JsonObject\) Constructor

Initializes a new instance of the [TypologyPath](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyPath 'DiGi\.Typology\.Classes\.TypologyPath') class from a JSON object\.

```csharp
public TypologyPath(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Typology.Classes.TypologyPath.TypologyPath(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing path data\.
### Properties

<a name='DiGi.Typology.Classes.TypologyPath.Count'></a>

## TypologyPath\.Count Property

Gets the total number of elements in the typology path\.

```csharp
public int Count { get; }
```

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

<a name='DiGi.Typology.Classes.TypologyPath.Index'></a>

## TypologyPath\.Index Property

Gets the value of the last element in the path, or \-1 if the path is empty\.

```csharp
public int Index { get; }
```

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

<a name='DiGi.Typology.Classes.TypologyPath.Parent'></a>

## TypologyPath\.Parent Property

Gets the immediate parent of the current typology path\.

```csharp
public DiGi.Typology.Classes.TypologyPath? Parent { get; }
```

#### Property Value
[TypologyPath](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyPath 'DiGi\.Typology\.Classes\.TypologyPath')

<a name='DiGi.Typology.Classes.TypologyPath.ParentCount'></a>

## TypologyPath\.ParentCount Property

Gets the number of ancestor levels above the current path\.

```csharp
public int ParentCount { get; }
```

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

<a name='DiGi.Typology.Classes.TypologyPath.this[int]'></a>

## TypologyPath\.this\[int\] Property

Gets the value at the specified index of the typology path\.

```csharp
public int this[int index] { get; }
```
#### Parameters

<a name='DiGi.Typology.Classes.TypologyPath.this[int].index'></a>

`index` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The zero\-based index of the element to get\.

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')
### Methods

<a name='DiGi.Typology.Classes.TypologyPath.CompareTo(DiGi.Typology.Classes.TypologyPath)'></a>

## TypologyPath\.CompareTo\(TypologyPath\) Method

Compares the current path with another typology path\.

```csharp
public int CompareTo(DiGi.Typology.Classes.TypologyPath typologyPath);
```
#### Parameters

<a name='DiGi.Typology.Classes.TypologyPath.CompareTo(DiGi.Typology.Classes.TypologyPath).typologyPath'></a>

`typologyPath` [TypologyPath](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyPath 'DiGi\.Typology\.Classes\.TypologyPath')

The path to compare against\.

#### Returns
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')  
A value indicating whether this instance precedes, follows, or is equal to the specified path\.

<a name='DiGi.Typology.Classes.TypologyPath.Equals(object)'></a>

## TypologyPath\.Equals\(object\) Method

Determines whether the specified object is equal to the current typology path based on sequence equality\.

```csharp
public override bool Equals(object obj);
```
#### Parameters

<a name='DiGi.Typology.Classes.TypologyPath.Equals(object).obj'></a>

`obj` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The object to compare with the current instance\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the objects are equal; otherwise, false\.

<a name='DiGi.Typology.Classes.TypologyPath.GetEnumerator()'></a>

## TypologyPath\.GetEnumerator\(\) Method

Returns an enumerator that iterates through the integer values of the path\.

```csharp
public System.Collections.Generic.IEnumerator<int> GetEnumerator();
```

Implements [GetEnumerator\(\)](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1.getenumerator 'System\.Collections\.Generic\.IEnumerable\`1\.GetEnumerator'), [GetEnumerator\(\)](https://learn.microsoft.com/en-us/dotnet/api/system.collections.ienumerable.getenumerator 'System\.Collections\.IEnumerable\.GetEnumerator')

#### Returns
[System\.Collections\.Generic\.IEnumerator&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerator-1 'System\.Collections\.Generic\.IEnumerator\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerator-1 'System\.Collections\.Generic\.IEnumerator\`1')  
An enumerator for the sequence of integers\.

<a name='DiGi.Typology.Classes.TypologyPath.GetHashCode()'></a>

## TypologyPath\.GetHashCode\(\) Method

Returns a hash code for the current typology path based on its sequence of values\.

```csharp
public override int GetHashCode();
```

#### Returns
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')  
A 32\-bit signed integer hash code\.

<a name='DiGi.Typology.Classes.TypologyPath.GetParent(int)'></a>

## TypologyPath\.GetParent\(int\) Method

Retrieves a path representing the hierarchy up to and including the specified index\.

```csharp
public DiGi.Typology.Classes.TypologyPath? GetParent(int index);
```
#### Parameters

<a name='DiGi.Typology.Classes.TypologyPath.GetParent(int).index'></a>

`index` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The end index of the parent path\.

#### Returns
[TypologyPath](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyPath 'DiGi\.Typology\.Classes\.TypologyPath')  
A new [TypologyPath](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyPath 'DiGi\.Typology\.Classes\.TypologyPath') instance, or null if the index is out of range\.

<a name='DiGi.Typology.Classes.TypologyPath.GetTypologyPath(int,int)'></a>

## TypologyPath\.GetTypologyPath\(int, int\) Method

Extracts a specific segment of the typology path\.

```csharp
public DiGi.Typology.Classes.TypologyPath? GetTypologyPath(int index, int count);
```
#### Parameters

<a name='DiGi.Typology.Classes.TypologyPath.GetTypologyPath(int,int).index'></a>

`index` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The starting zero\-based index of the segment\.

<a name='DiGi.Typology.Classes.TypologyPath.GetTypologyPath(int,int).count'></a>

`count` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The number of elements to include in the segment\.

#### Returns
[TypologyPath](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyPath 'DiGi\.Typology\.Classes\.TypologyPath')  
A new [TypologyPath](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyPath 'DiGi\.Typology\.Classes\.TypologyPath') containing the extracted range\.

<a name='DiGi.Typology.Classes.TypologyPath.GetTypologyPaths()'></a>

## TypologyPath\.GetTypologyPaths\(\) Method

Generates a list of all ancestor paths for the current typology path\.

```csharp
public System.Collections.Generic.List<DiGi.Typology.Classes.TypologyPath> GetTypologyPaths();
```

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[TypologyPath](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyPath 'DiGi\.Typology\.Classes\.TypologyPath')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list containing all parent [TypologyPath](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyPath 'DiGi\.Typology\.Classes\.TypologyPath') instances\.

<a name='DiGi.Typology.Classes.TypologyPath.ToString()'></a>

## TypologyPath\.ToString\(\) Method

Returns a string representation of the path, with values separated by dots\.

```csharp
public override string ToString();
```

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
A dot\-separated string of the typology path values\.
### Operators

<a name='DiGi.Typology.Classes.TypologyPath.op_Addition(DiGi.Typology.Classes.TypologyPath,DiGi.Typology.Classes.TypologyPath)'></a>

## TypologyPath\.operator \+\(TypologyPath, TypologyPath\) Operator

Concatenates two typology paths into a single path\.

```csharp
public static DiGi.Typology.Classes.TypologyPath? operator +(DiGi.Typology.Classes.TypologyPath? typologyPath_1, DiGi.Typology.Classes.TypologyPath? typologyPath_2);
```
#### Parameters

<a name='DiGi.Typology.Classes.TypologyPath.op_Addition(DiGi.Typology.Classes.TypologyPath,DiGi.Typology.Classes.TypologyPath).typologyPath_1'></a>

`typologyPath_1` [TypologyPath](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyPath 'DiGi\.Typology\.Classes\.TypologyPath')

The first path segment\.

<a name='DiGi.Typology.Classes.TypologyPath.op_Addition(DiGi.Typology.Classes.TypologyPath,DiGi.Typology.Classes.TypologyPath).typologyPath_2'></a>

`typologyPath_2` [TypologyPath](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyPath 'DiGi\.Typology\.Classes\.TypologyPath')

The second path segment to append\.

#### Returns
[TypologyPath](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyPath 'DiGi\.Typology\.Classes\.TypologyPath')  
A new [TypologyPath](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyPath 'DiGi\.Typology\.Classes\.TypologyPath') representing the combined sequence, or null if both inputs are null\.

<a name='DiGi.Typology.Classes.TypologyPath.op_ExplicitDiGi.Typology.Classes.TypologyPath(System.Collections.Generic.List_int_)'></a>

## TypologyPath\.explicit operator TypologyPath\(List\<int\>\) Operator

Explicitly converts a list of integers to a [TypologyPath](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyPath 'DiGi\.Typology\.Classes\.TypologyPath')\.

```csharp
public static DiGi.Typology.Classes.TypologyPath? explicit operator DiGi.Typology.Classes.TypologyPath?(System.Collections.Generic.List<int>? values);
```
#### Parameters

<a name='DiGi.Typology.Classes.TypologyPath.op_ExplicitDiGi.Typology.Classes.TypologyPath(System.Collections.Generic.List_int_).values'></a>

`values` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

The list of integers representing the path\.

#### Returns
[TypologyPath](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyPath 'DiGi\.Typology\.Classes\.TypologyPath')  
A new [TypologyPath](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyPath 'DiGi\.Typology\.Classes\.TypologyPath') instance, or null if the input is null\.

<a name='DiGi.Typology.Classes.TypologyPath.op_ExplicitSystem.Collections.Generic.List_int_(DiGi.Typology.Classes.TypologyPath)'></a>

## TypologyPath\.explicit operator List\<int\>\(TypologyPath\) Operator

Explicitly converts a [TypologyPath](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyPath 'DiGi\.Typology\.Classes\.TypologyPath') to a list of integers\.

```csharp
public static System.Collections.Generic.List<int>? explicit operator System.Collections.Generic.List<int>?(DiGi.Typology.Classes.TypologyPath? typologyPath);
```
#### Parameters

<a name='DiGi.Typology.Classes.TypologyPath.op_ExplicitSystem.Collections.Generic.List_int_(DiGi.Typology.Classes.TypologyPath).typologyPath'></a>

`typologyPath` [TypologyPath](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyPath 'DiGi\.Typology\.Classes\.TypologyPath')

The typology path to convert\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A new list containing the values of the path, or null if the input is null\.

<a name='DiGi.Typology.Classes.UniqueValueFilterRule'></a>

## UniqueValueFilterRule Class

Represents a typology filter rule that matches unique values\.

```csharp
public class UniqueValueFilterRule : DiGi.Typology.Classes.TypologyFilterRule, DiGi.Typology.Interfaces.ITypologyFilterRule<DiGi.Typology.Classes.UniqueValueRuleData>, DiGi.Typology.Interfaces.ITypologyFilterRule, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Typology.Interfaces.ITypologyObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [TypologyFilterRule](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyFilterRule 'DiGi\.Typology\.Classes\.TypologyFilterRule') → UniqueValueFilterRule

Implements [DiGi\.Typology\.Interfaces\.ITypologyFilterRule&lt;](DiGi.Typology.Interfaces.md#DiGi.Typology.Interfaces.ITypologyFilterRule_TTypologyFilterRuleData_ 'DiGi\.Typology\.Interfaces\.ITypologyFilterRule\<TTypologyFilterRuleData\>')[UniqueValueRuleData](DiGi.Typology.Classes.md#DiGi.Typology.Classes.UniqueValueRuleData 'DiGi\.Typology\.Classes\.UniqueValueRuleData')[&gt;](DiGi.Typology.Interfaces.md#DiGi.Typology.Interfaces.ITypologyFilterRule_TTypologyFilterRuleData_ 'DiGi\.Typology\.Interfaces\.ITypologyFilterRule\<TTypologyFilterRuleData\>'), [ITypologyFilterRule](DiGi.Typology.Interfaces.md#DiGi.Typology.Interfaces.ITypologyFilterRule 'DiGi\.Typology\.Interfaces\.ITypologyFilterRule'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Typology\.Interfaces\.ITypologyObject](https://learn.microsoft.com/en-us/dotnet/api/digi.typology.interfaces.itypologyobject 'DiGi\.Typology\.Interfaces\.ITypologyObject')
### Methods

<a name='DiGi.Typology.Classes.UniqueValueFilterRule.RuleData(object)'></a>

## UniqueValueFilterRule\.RuleData\(object\) Method

Resolves the filter rule data for the specified value\.

```csharp
public DiGi.Typology.Classes.UniqueValueRuleData? RuleData(object? @object);
```
#### Parameters

<a name='DiGi.Typology.Classes.UniqueValueFilterRule.RuleData(object).object'></a>

`object` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The value to wrap in unique value data\.

Implements [RuleData\(object\)](DiGi.Typology.Interfaces.md#DiGi.Typology.Interfaces.ITypologyFilterRule_TTypologyFilterRuleData_.RuleData(object) 'DiGi\.Typology\.Interfaces\.ITypologyFilterRule\<TTypologyFilterRuleData\>\.RuleData\(object\)')

#### Returns
[UniqueValueRuleData](DiGi.Typology.Classes.md#DiGi.Typology.Classes.UniqueValueRuleData 'DiGi\.Typology\.Classes\.UniqueValueRuleData')  
A new instance of unique value rule data wrapping the value\.

<a name='DiGi.Typology.Classes.UniqueValueRuleData'></a>

## UniqueValueRuleData Class

Represents the resulting data for a unique value filter rule\.

```csharp
public class UniqueValueRuleData : DiGi.Typology.Classes.TypologyFilterRuleData<DiGi.Typology.Classes.UniqueValueRuleData>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Typology\.Classes\.TypologyFilterRuleData&lt;](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyFilterRuleData_TTypologyFilterRuleData_ 'DiGi\.Typology\.Classes\.TypologyFilterRuleData\<TTypologyFilterRuleData\>')[UniqueValueRuleData](DiGi.Typology.Classes.md#DiGi.Typology.Classes.UniqueValueRuleData 'DiGi\.Typology\.Classes\.UniqueValueRuleData')[&gt;](DiGi.Typology.Classes.md#DiGi.Typology.Classes.TypologyFilterRuleData_TTypologyFilterRuleData_ 'DiGi\.Typology\.Classes\.TypologyFilterRuleData\<TTypologyFilterRuleData\>') → UniqueValueRuleData
### Constructors

<a name='DiGi.Typology.Classes.UniqueValueRuleData.UniqueValueRuleData()'></a>

## UniqueValueRuleData\(\) Constructor

Initializes a new instance of the [UniqueValueRuleData](DiGi.Typology.Classes.md#DiGi.Typology.Classes.UniqueValueRuleData 'DiGi\.Typology\.Classes\.UniqueValueRuleData') class\.

```csharp
public UniqueValueRuleData();
```

<a name='DiGi.Typology.Classes.UniqueValueRuleData.UniqueValueRuleData(DiGi.Typology.Classes.UniqueValueRuleData)'></a>

## UniqueValueRuleData\(UniqueValueRuleData\) Constructor

Initializes a new instance of the [UniqueValueRuleData](DiGi.Typology.Classes.md#DiGi.Typology.Classes.UniqueValueRuleData 'DiGi\.Typology\.Classes\.UniqueValueRuleData') class by copying another instance\.

```csharp
public UniqueValueRuleData(DiGi.Typology.Classes.UniqueValueRuleData uniqueValueRuleData);
```
#### Parameters

<a name='DiGi.Typology.Classes.UniqueValueRuleData.UniqueValueRuleData(DiGi.Typology.Classes.UniqueValueRuleData).uniqueValueRuleData'></a>

`uniqueValueRuleData` [UniqueValueRuleData](DiGi.Typology.Classes.md#DiGi.Typology.Classes.UniqueValueRuleData 'DiGi\.Typology\.Classes\.UniqueValueRuleData')

The source unique value rule data to copy\.

<a name='DiGi.Typology.Classes.UniqueValueRuleData.UniqueValueRuleData(object)'></a>

## UniqueValueRuleData\(object\) Constructor

Initializes a new instance of the [UniqueValueRuleData](DiGi.Typology.Classes.md#DiGi.Typology.Classes.UniqueValueRuleData 'DiGi\.Typology\.Classes\.UniqueValueRuleData') class with a specific value\.

```csharp
public UniqueValueRuleData(object? @object);
```
#### Parameters

<a name='DiGi.Typology.Classes.UniqueValueRuleData.UniqueValueRuleData(object).object'></a>

`object` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The value to wrap\.

<a name='DiGi.Typology.Classes.UniqueValueRuleData.UniqueValueRuleData(System.Text.Json.Nodes.JsonObject)'></a>

## UniqueValueRuleData\(JsonObject\) Constructor

Initializes a new instance of the [UniqueValueRuleData](DiGi.Typology.Classes.md#DiGi.Typology.Classes.UniqueValueRuleData 'DiGi\.Typology\.Classes\.UniqueValueRuleData') class with a JSON object\.

```csharp
public UniqueValueRuleData(System.Text.Json.Nodes.JsonObject jsonObject);
```
#### Parameters

<a name='DiGi.Typology.Classes.UniqueValueRuleData.UniqueValueRuleData(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing unique value rule data\.
### Methods

<a name='DiGi.Typology.Classes.UniqueValueRuleData.Equals(DiGi.Typology.Classes.UniqueValueRuleData)'></a>

## UniqueValueRuleData\.Equals\(UniqueValueRuleData\) Method

Determines whether this instance and another specified unique value rule data have the same value\.

```csharp
public override bool Equals(DiGi.Typology.Classes.UniqueValueRuleData uniqueValueRuleData);
```
#### Parameters

<a name='DiGi.Typology.Classes.UniqueValueRuleData.Equals(DiGi.Typology.Classes.UniqueValueRuleData).uniqueValueRuleData'></a>

`uniqueValueRuleData` [UniqueValueRuleData](DiGi.Typology.Classes.md#DiGi.Typology.Classes.UniqueValueRuleData 'DiGi\.Typology\.Classes\.UniqueValueRuleData')

The unique value rule data to compare with this instance\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if they are equal; otherwise, false\.

<a name='DiGi.Typology.Classes.UniqueValueRuleData.Equals(object)'></a>

## UniqueValueRuleData\.Equals\(object\) Method

Determines whether this instance and a specified object have the same value\.

```csharp
public override bool Equals(object? @object);
```
#### Parameters

<a name='DiGi.Typology.Classes.UniqueValueRuleData.Equals(object).object'></a>

`object` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The object to compare with this instance\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the object is equal to this instance; otherwise, false\.

<a name='DiGi.Typology.Classes.UniqueValueRuleData.GetHashCode()'></a>

## UniqueValueRuleData\.GetHashCode\(\) Method

Returns the hash code for this instance\.

```csharp
public override int GetHashCode();
```

#### Returns
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')  
A 32\-bit signed integer hash code\.

<a name='DiGi.Typology.Classes.UniqueValueRuleData.ToString()'></a>

## UniqueValueRuleData\.ToString\(\) Method

Returns a string representation of the unique value rule data\.

```csharp
public override string ToString();
```

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
A string representation of the value\.