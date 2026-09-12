# Issue #20 — Implementation Plan (corrected after compile-probe review)

> Follow-up to #19, which shipped `DiGi.Typology.Visual` (`2ba48b1` on `0.9.0`). Investigated against `0.9.0`.
> Aligned with the AI Guidelines (`Coding - General`, `Coding - Automatic Tests`, `Coding - Editor Config`).
>
> **This revision corrects §3 after verifying every C# overload/compile claim with a throwaway probe project, per `Coding - General` §1.17 — *"Verify overload-binding and compile-error claims with a probe project, not by reasoning."* The original §3.1 enabler (public item constructor so `new TTypology(item)` compiles in generic code) **does not compile in C#**. See §0 for the probe record and the corrected design.**

## 0. Probe verification — the original design is falsified

The original plan asserted load-bearing C# behaviours without a probe. Probing them (net10.0 console apps mirroring the real `Typology<T,TI>` / `Typology` / `VisualTypology` / `TypologyItem` / `VisualTypologyItem` shape, with the concrete-vs-generic sibling overloads), plus follow-up source checks against the real repo, gave: (F1–F6 probe-verified; F7–F8 source-verified:)

| # | Original claim | Probe result |
|---|---|---|
| **F1** | Make the base `Typology(TTypologyItem?)` constructor `public` so `new TTypology(item)` compiles in generic code (§3.1) | **Doesn't compile.** `new T(args)` with a non-empty argument list is illegal on a type parameter: **CS0304** "…does not have the new() constraint" (no `new()`), and **CS0417** "cannot provide arguments when creating an instance of a variable type" (with a `new()` constraint). Same for `new TTypologyItem(values, name)` → CS0417. |
| **F2** | (implicit) instantiate `TTypology` from an item in generic code | **A `public` virtual/abstract factory on the base works.** `plain.Update` → `Typology`; `vis.Update` → `VisualTypology` (appearance preserved). But it **must be `public`**, not the `protected` the issue suggests — a `protected` factory is **CS0122** from a generic extension (an extension is not a subclass). |
| **F3** | "No explicit type arguments required by existing consumers" (§3.3) | **True only for the plain-`Typology` sites** (the concrete overload wins the tie — verified). **False for a `VisualTypology` receiver on the string-based shapes:** `TTypologyItem` appears in no parameter → **CS0411** unless the caller writes `<VisualTypology, VisualTypologyItem>`. |
| **F4** | A generic `Create.Typology<T,TI>(this TTypologyItem?, …)` (§3.3) | **Infeasible.** The receiver is an item, so there is no node to dispatch a factory on. `Create.Typology` must stay concrete (one overload per assembly). |
| **F5** | Adding a generic `Update` next to the concrete one breaks the 104 `DiGi.GIS.UI` sites | **Doesn't break.** Non-generic wins the tie; `plain.Update(item)` still binds the concrete overload (verified, no CS0121). |
| **F6** | (implicit) re-path an item in generic code the way the concrete `Update` does (`new TypologyItem(fullPath, item)`) | **Also a wall.** The concrete `Update` re-paths every node it creates, and `new TTypologyItem(path, …)` hits the same CS0417. The factory must therefore take the **desired full path** and let the concrete override build the derived item (its own `(path, derived)` ctor preserves the extra field). Verified: `vis.Update` → `VisualTypology` holding a `VisualTypologyItem` with appearance intact. |
| **F7** | (implicit) adding one abstract member to the base only affects the two known concrete types | **A third concrete type exists** — the `DiGi.Test` test double `TypologyTest : Typology<TypologyTest, TypologyItemTest>` — and it must override the new abstract member or the test project won't compile. |
| **F8** | (implicit) the test double is ready to override the new member | **Source check: `TypologyItemTest` has no `(TypologyPath?, TypologyItemTest)` constructor** (the base `TypologyItem` and `VisualTypologyItem` both do). The §3.1 test-double override `new TypologyTest(new TypologyItemTest(path, source))` **does not compile as written** — the test double must also gain a `(path, derived)` constructor, mirroring the `VisualTypologyItem` pattern. |

**Consequence:** the original §3.1–§3.3 mechanism (public item ctor + `new TTypology(item)` + fully-generic `Create`) **cannot be implemented as written.** The feasible design is below (§3).

## 1. Verdict: Part B shipped; Part A still valid, but the mechanism must change

#20 asked for two things. **Part B is done; Part A is not.**

| Part | #20 scope | Status | Where |
|------|-----------|--------|-------|
| **B. Visual solver** | A Visual solver that solves a table into a `VisualTypology` with per-bucket appearance | **Shipped** | #21 → `DiGi.Typology.Visual/Create/VisualTypology.cs` |
| **B. Rule-anchored appearance** | appearance reachable from the rule data at solve time | **Shipped (redesigned)** | appearance moved onto the rules (`TypologyAppearanceCollection`, `IVisualTypologyFilterRuleData.Appearance`) |
| **A. Generic tree building** | `Create.Typology` / `Modify.Update` / `Modify.TryUpdateByName` on a derived tree | **Not done** | still concrete on `Typology` / `TypologyItem` |

### The design changed under the issue
#20's acceptance reads *"…from the rule data with the level fallback"* and its premises name `VisualColumnTypologyFilter.Appearance` as the fallback. That member was **deliberately removed**; `VisualColumnTypologyFilter` now only exposes constructors and appearance is rule-anchored. So acceptance criterion 2's "level fallback" wording is **obsolete** — re-state it as rule-anchored appearance (see §7).

## 2. Verified premises (source)

- **Still concrete.** `DiGi.Typology/Create/Typology.cs` (`Typology(this TypologyItem?, IEnumerable<Typology>?)`), `DiGi.Typology/Modify/Update.cs` (5 overloads), `DiGi.Typology/Modify/TryUpdateByName.cs` all `new Classes.Typology(...)` / `new TypologyItem(path, item)`. Applied to a `VisualTypology` tree they would file a **plain** `Typology` node and drop the `VisualTypologyItem`'s appearance.
- **The generic pattern already exists** in this assembly: `Modify.AddSubTypologies`, `Modify.RemoveReferences`, `Query.TryGetLastIndex`, `Query.TryGetTypologies` (×3), `Query.TypologyPaths` are all `<TTypology, TTypologyItem>` with `where TTypology : Classes.Typology<TTypology, TTypologyItem> where TTypologyItem : Classes.TypologyItem, new()`. The three members in this issue are the only non-generic ones left in `Create`/`Modify`. **None of them needs to construct a `TTypology` from scratch** — they clone existing nodes — which is why they compile; `Create`/`Update`/`TryUpdateByName` are the ones that would.
- **`VisualTypology` and `Typology` are siblings, not parent/child.** Both derive from `Typology<TTypology, TTypologyItem>`; a `VisualTypology` is **not** a `Typology`. This is what keeps the concrete/generic coexistence safe (F5) and why the concrete overloads are inapplicable to a `VisualTypology` receiver (F3).
- **The #18 / #20 follow-up gap is exactly this.** Both defer the generic forms to "the first real derived typology," naming the same missing piece: *"a way to instantiate `TTypology` from an item."* #20 offers two candidates — an abstract/virtual factory hook **or** "a `new()`-style constraint … may be enough." **The probe shows only the factory hook is viable (F1/F2); the constraint hope is false.**
- **`VisualTypologyItem` has no 2/3-arg path constructor.** Its path constructors are 4-arg `(values|path, name, description, appearance)`. So a bare `new TTypologyItem(values, name)` is a **latent runtime `MissingMethodException`** for the derived type (CS0417 at the probe) — this is a second reason the generic methods must build nodes through the derived type's own factory, not a fixed-arity item constructor.
- **Call sites to preserve.** `DiGi.GIS.UI/Create/Typology.cs` has ~100 `Typology.Modify.TryUpdateByName(result, null, name, "Location", out Typology.Classes.Typology? …)`-shaped calls on plain `Typology` receivers. All bind to the concrete overload (F5).

## 3. Design (corrected)

### 3.1 Enabler — a `public` two-argument factory on the base (not a public constructor)
Add to `DiGi.Typology/Classes/Typology.cs`:

```csharp
/// <summary>Creates a <typeparamref name="TTypology"/> node for the specified full path, taking its name, description and any derived fields from the source item; the derived type supplies its own construction.</summary>
public abstract TTypology CreateNode(TTypologyItem? source, TypologyPath? path);
```

- `DiGi.Typology/Classes/Typology.cs` (concrete `Typology`): `public override Typology CreateNode(TypologyItem? source, TypologyPath? path) => new Typology(new TypologyItem(path, source));`
- `DiGi.Typology.Visual/Classes/VisualTypology.cs`: `public override VisualTypology CreateNode(VisualTypologyItem? source, TypologyPath? path) => new VisualTypology(new VisualTypologyItem(path, source));`
- `DiGi.Test/DiGi.Typology.xUnit/Classes/TypologyTest.cs`: `public override TypologyTest CreateNode(TypologyItemTest? source, TypologyPath? path) => new TypologyTest(new TypologyItemTest(path, source));` — this requires a **new** `(TypologyPath?, TypologyItemTest)` constructor on `TypologyItemTest` (F8: it exists on the base `TypologyItem` and on `VisualTypologyItem`, but not on the test double; mirror the `VisualTypologyItem` pattern, copying name, description and `Weight`).

Why two arguments, not one: the concrete `Update` **re-paths** every node it files, and re-pathing a `TTypologyItem` in generic code is the same CS0417 wall as F1 (`new TTypologyItem(path, …)` is illegal). So the factory takes the **desired full path** and the source item, and each concrete override builds the derived item through its **own** `(path, derived)` constructor — which is what preserves `VisualTypologyItem.Appearance` (verified, F6). No `TTypologyItem` is ever constructed in generic code and there is **no cast**.

Why a method, not the `new()`/public-ctor the original plan used: **`new T(args)` is CS0417 on a type parameter (F1)**. Why `public`, not the `protected` the issue suggested: a generic extension method is not a subclass, so a `protected` member is **CS0122** (F2). This is the single "base-class hook" that #18 and #20 both defer to. *Note (guideline tension):* this is a new instance member on a `/Classes` type; it is a construction delegate, not business logic, and it is the only C#-feasible way to build a re-pathed `TTypology` node in generic code. If the team wants zero new base API, fall back to §3.6 (concrete per-assembly only).

### 3.2 Generic `Modify.Update` / `Modify.TryUpdateByName` (feasible, one caveat)
Add, beside the existing concrete members (same files, `Modify` partial class), building **every** node the method creates through `CreateNode(source, path)` (§3.1) — there is no separate re-path step (see §3.4):

- `Modify.Update<TTypology, TTypologyItem>(this TTypology?, TTypologyItem?)` — **the item shape. `TTypologyItem` is inferable from the item, so no explicit args are ever needed** at any call site.
- `Modify.Update<TTypology, TTypologyItem>(this TTypology?, IEnumerable<int>?, string?, string?)` (+ the three other name/description shapes) and `Modify.TryUpdateByName<TTypology, TTypologyItem>(this TTypology?, IEnumerable<int>?, string?, string?, out TTypology?)`.

**Caveat (F3):** the **string-based** shapes have no `TTypologyItem` parameter, so at a `VisualTypology` call site the caller **must** supply the explicit type arguments (`Update<VisualTypology, VisualTypologyItem>(…)`); at a plain-`Typology` site the concrete overload wins and no arguments are needed (verified, F5). To keep the derived call sites clean, **also add non-generic convenience overloads in `DiGi.Typology.Visual`** (`Modify.Update(this VisualTypology?, IEnumerable<int>?, string?, string?)`, `Modify.TryUpdateByName(this VisualTypology?, …)`, each delegating to the concrete `new VisualTypologyItem(…)` / `new VisualTypology(…)`). This makes the common `VisualTypology` path argument-free while leaving the generic forms available for a future derived type.

### 3.3 `Create.Typology` — stays concrete (one overload per assembly)
F4: `Create.Typology` takes a `TTypologyItem` receiver and has no node to dispatch a factory on, so it cannot be generic.

- `DiGi.Typology/Create/Typology.cs` — keep the existing `Create.Typology(this TypologyItem?, IEnumerable<Typology>?)` for plain `Typology` (unchanged).
- **New** `DiGi.Typology.Visual/Create/Typology.cs` — `Create.Typology(this VisualTypologyItem?, IEnumerable<VisualTypology>?)` → `new VisualTypology(item)` + `Modify.AddSubTypologies`. Concrete sibling of the existing one; same shape as the already-concrete solver `Create.VisualTypology`.

### 3.4 Appearance preservation (fixes the flatten bug) — handled by §3.1
The flatten bug is the line `new TypologyItem(path, item)` — the base `(path, source)` constructor copies **only** name/description (verified: it drops the derived item's extra field; the derived `(path, derived)` constructor keeps it). The §3.1 two-argument `CreateNode(source, path)` fixes this directly: each concrete override builds the node through its **own** derived `(path, derived)` constructor, so `VisualTypologyItem.Appearance` is preserved and there is no `TTypologyItem` cast. 

The original plan's item-level `RePath` virtual is therefore **not needed** and is dropped. (If it were kept, a future derived item that forgot to override `RePath` would **silently flatten** — the same "fails open" class the issue is fixing; the contract would be only test-enforced. Routing node creation through `CreateNode` avoids that footgun entirely.)

### 3.5 In-place `Update` semantics (decide and document)
The in-place branch sets only `.Name` / `.Description`; a `VisualTypology`'s existing-node appearance is left untouched (**keep-as-is**). Recommendation: **keep-as-is** — appearance is owned by the solver (`Create.VisualTypology`) and by `CreateNode` on creation, not by `Update`. State this in the `<summary>`.

### 3.6 Minimal alternative if the team wants zero new base API
Skip the generic forms entirely and add **only** the concrete `DiGi.Typology.Visual` overloads (`Create.Typology`, `Modify.Update`, `Modify.TryUpdateByName` on `VisualTypology` / `VisualTypologyItem`). This touches **no** `DiGi.Typology` base class, hits none of F1–F4, and is the lowest-risk path — at the cost of not being "generic" (a hypothetical second derived typology would need its own overloads). There is exactly one derived typology in the ecosystem (`VisualTypology`) today.

## 4. Concrete change list

| File | Change |
|------|--------|
| `DiGi.Typology/Classes/Typology.cs` | add `public abstract TTypology CreateNode(TTypologyItem?, TypologyPath?)`; override on concrete `Typology` → `new Typology(new TypologyItem(path, source))` |
| `DiGi.Typology/Modify/Update.cs` | add generic `Update<TTypology, TTypologyItem>` (item shape + 4 name/description shapes) beside the concrete ones; build every node via `CreateNode(source, fullPath)` |
| `DiGi.Typology/Modify/TryUpdateByName.cs` | add generic `TryUpdateByName<TTypology, TTypologyItem>`, delegating to the generic `Update` |
| `DiGi.Typology.Visual/Classes/VisualTypology.cs` | override `CreateNode` → `new VisualTypology(new VisualTypologyItem(path, source))` |
| `DiGi.Test/DiGi.Typology.xUnit/Classes/TypologyItemTest.cs` | add a `(TypologyPath?, TypologyItemTest)` constructor copying name, description and `Weight` (mirrors `VisualTypologyItem`; F8) |
| `DiGi.Test/DiGi.Typology.xUnit/Classes/TypologyTest.cs` | override `CreateNode` → `new TypologyTest(new TypologyItemTest(path, source))` (F7: a third concrete type must implement the new abstract member; needs the F8 constructor) |
| `DiGi.Typology.Visual/Modify/Update.cs` *(new)* | non-generic `Update(this VisualTypology?, …)` convenience overloads (argument-free derived path, F3) |
| `DiGi.Typology.Visual/Modify/TryUpdateByName.cs` *(new)* | non-generic `TryUpdateByName(this VisualTypology?, …)` convenience overload |
| `DiGi.Typology.Visual/Create/Typology.cs` *(new)* | `Create.Typology(this VisualTypologyItem?, IEnumerable<VisualTypology>?)` (F4: `Create` stays concrete) |


Guidelines: one logical member per file (generic overloads join their concrete siblings); explicit typing, block namespaces, target-typed `new()`, collection expressions; XML `<summary>` + `<typeparam>` on every new public member (CS1591); zero warnings.

## 5. Tests (`DiGi.Typology.xUnit`, `DiGi.Typology.Visual.xUnit`)

- **`DiGi.Typology.xUnit/Facts/Typology_Update_Generic.cs`** — on the existing test-derived `Typology`/`TypologyItem` (from `Typology_Generic_Derived`): every `Update` shape creates intermediate + leaf nodes of the derived type; the derived item's extra field survives; `TryUpdateByName` matches and updates in place (`Assert.Same`) and creates when absent; `SerializationCheck` green.
- **`DiGi.Typology.Visual.xUnit/Facts/VisualTypology_Update.cs`** — `Update` / `TryUpdateByName` / `Create.Typology` on a `VisualTypology`: a `VisualTypologyItem` keeps its `Appearance` through every overload; intermediate nodes are `VisualTypology`; `TryUpdateByName` updates in place; `Modify.RemoveReferences` keeps every appearance (the #14 "round-trips through solve, persist and re-load" acceptance).
- **Binding guard (F5)** — a fact that calls the concrete `Update` / `TryUpdateByName` on a plain `Typology` with a plain `TypologyItem` and asserts a `Typology` (not `VisualTypology`) is produced, locking the non-generic-wins routing.
- **CS0411 guard (F3)** — a fact exercising the `VisualTypology` string-based path through the **convenience overload** (no explicit type args) so the argument-free derived path is locked in; the generic string-based form is only called with explicit `<VisualTypology, VisualTypologyItem>` args.
- **Build-then-test** (`Coding - Automatic Tests` §4): build `DiGi.Typology` first, then `DiGi.Typology.Visual`, then the xUnit project (HintPath opacity).

## 6. Guideline alignment
- **Probe discipline** (`Coding - General` §1.17): this is the exact rule the original plan violated — it asserted compile/overload behaviour by reasoning. §0 records the probes that falsify it. Any future edit touching §3.1–§3.3 must re-probe.
- **Architecture** (`Coding - General` §2): anemic model + static `Query`/`Modify`/`Create` extensions — the new members sit in `Modify`/`Create` exactly like the already-generic siblings. The one deviation (a `public` instance factory on the base) is forced by C# (F1/F2) and is a construction delegate, not business logic.
- **No `new T(args)` / no reflection dispatch** (§1.17–§1.18): node creation goes through the derived type's own `CreateNode`, never a fixed-arity item constructor on a type parameter (F1) and never `GetMethod` name-dispatch (the `Query.RuleData` by-name contract is untouched).
- **Tests** (`Coding - Automatic Tests`): Facts structure, `SerializationCheck` on new serializable behaviour, build-then-test.
- **Style** (`Coding - Editor Config`): explicit types, block namespaces, `[]`, `new()`, CRLF, zero warnings.

## 7. Acceptance (updated for the #21 redesign + probe findings)
- [ ] `Update` / `TryUpdateByName` / `Create.Typology` work on a `VisualTypology`; a `VisualTypologyItem` keeps its `Appearance` through every overload (node creation via `CreateNode`).
- [ ] `DiGi.GIS.UI` builds **unchanged** — the ~100 plain-`Typology` call sites still bind to the concrete overloads (F5).
- [ ] A solved `VisualTypology` carries per-node appearance from the rule data (rule-anchored collections; the retired level fallback is out of scope). *(already true via #21 — re-assert in a fact.)*
- [ ] Derived string-based call sites are argument-free via the `DiGi.Typology.Visual` convenience overloads (F3); the generic string-based form is documented to need explicit type args.
- [ ] `DiGi.GIS`, `DiGi.GIS.PostgreSQL`, `DiGi.GIS.UI`, `DiGi.GIS.WebAPI` build against the new `DiGi.Typology` bin.

## 8. Out of scope / risks
- **Out of scope:** persisting `VisualTypology` through `TypologyModelPostgreSQLConverter`; UI Import/Export (ZiolkowskiJakub/DiGi.GIS.WebAPI.UI#17).
- **F1 (fatal if missed):** `new T(item)` / `new TTypologyItem(args)` do **not** compile on a type parameter (CS0304/CS0417) — do not attempt the public-ctor enabler; use `CreateNode`.
- **F2:** the factory hook must be **`public`**, not `protected` (CS0122 from a generic extension).
- **F3:** string-based generic overloads need explicit type args at a derived call site — ship the convenience overloads so the common path stays clean.
- **F4:** `Create.Typology` cannot be generic (no node receiver) — concrete per-assembly.
- **Footgun avoided (§3.4):** the original plan's item-level `RePath` virtual was **dropped** — it would have been only test-protected against silent flattening. Node creation goes through the node-level `CreateNode`; there is no `RePath` in the final design.
- **In-place semantics (§3.5):** appearance is keep-as-is on `Update`; document it.
- **Open decision:** §3.1 (generic forms + base factory hook) vs §3.6 (concrete per-assembly only, zero base API). Default: **§3.1** — it satisfies #20's "generic … for a derived typology" wording and gives #18's deferred hook; **§3.6** is the lower-risk fallback if the team does not actually need genericity beyond the one derived type.