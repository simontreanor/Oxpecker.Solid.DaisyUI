# API Migration Guide

## Overview

Oxpecker.Solid.DaisyUI has been refactored to provide a much cleaner, more idiomatic F# API using **type extensions with optional parameters**. This eliminates verbose property assignments and fragment wrappers.

## Key Improvements

### 1. No More Property Assignments with `<-`

**Before:**
```fsharp
let btn = DaisyButton()
btn.color <- Some Primary
btn.size <- Some Large
btn.wide <- true
btn.render <| Fragment() { "Click Me" }
```

**After:**
```fsharp
button().btn(color = Primary, size = Large, wide = true) {
    "Click Me"
}
```

### 2. No More `<| Fragment()` Wrapper

**Before:**
```fsharp
Card <| Fragment() {
    CardBody <| Fragment() {
        CardTitle <| Fragment() { "Title" }
        p() { "Content" }
    }
}
```

**After:**
```fsharp
div().card(bordered = true) {
    div().class'("card-body") {
        h2().cardTitle() { "Title" }
        p() { "Content" }
    }
}
```

### 3. Direct HTML Element Extensions

All components are now implemented as **F# type extensions** on native HTML elements:

```fsharp
// Extensions on button element
type button with
    [<Erase>]
    member this.btn(?color: ColorVariant, ?size: Size, ...) = ...

// Extensions on input element
type input with
    [<Erase>]
    member this.checkbox(?color: ColorVariant, ?size: Size) = ...
    member this.radio(?name: string, ?color: ColorVariant) = ...
    member this.toggle(?color: ColorVariant, ?size: Size) = ...
```

## Component Migration Examples

### Actions Module

#### Button
```fsharp
// Old
let btn = DaisyButton()
btn.color <- Some Primary
btn.outline <- true
btn.render <| Fragment() { "Save" }

// New
button().btn(color = Primary, outline = true) { "Save" }
```

#### Modal
```fsharp
// Old
let modal = DaisyModal()
modal.isOpen <- isOpen()
modal.middle <- true
modal.render <| Fragment() { /* content */ }

// New
dialog().modal(isOpen = isOpen(), position = ModalMiddle) { /* content */ }
```

### Data Display Module

#### Badge
```fsharp
// Old
Badge <| Fragment() { "NEW" }

// New
span().badge(color = Accent) { "NEW" }
```

#### Card
```fsharp
// Old
Card <| Fragment() {
    CardBody <| Fragment() {
        CardTitle <| Fragment() { "Title" }
        p() { "Content" }
    }
}

// New
div().card(bordered = true, color = Primary) {
    div().class'("card-body") {
        h2().cardTitle() { "Title" }
        p() { "Content" }
    }
}
```

#### Stats
```fsharp
// Old
Stats <| Fragment() {
    Stat <| Fragment() {
        div(class' = "stat-value") { "25.6K" }
    }
}

// New
div().stats() {
    div().stat() {
        div().class'("stat-value") { "25.6K" }
    }
}
```

### Data Input Module

#### Text Input
```fsharp
// Old
TextInput "Enter name"

// New
input().textInput(placeholder = "Enter name", bordered = true, color = Primary)
```

#### Checkbox
```fsharp
// Old
Checkbox <| Fragment() { }

// New
input().checkbox(color = Primary, size = Small)
```

#### Textarea
```fsharp
// Old
Textarea "Your message"

// New
textarea().textarea(placeholder = "Your message", bordered = true, rows = 4)
```

#### Toggle
```fsharp
// Old
Toggle <| Fragment() { }

// New
input().toggle(color = Primary)
```

### Layout Module

#### Hero
```fsharp
// Old
Hero <| Fragment() {
    div(class' = "hero-content") { /* content */ }
}

// New
div().hero() {
    div().class'("hero-content") { /* content */ }
}
```

#### Footer
```fsharp
// Old
Footer <| Fragment() {
    p() { "Copyright 2024" }
}

// New
footer().footer(center = true) {
    p() { "Copyright 2024" }
}
```

#### Toast
```fsharp
// Old
Toast <| Fragment() {
    Alert <| Fragment() { "Message" }
}

// New
div().toast(position = TopEnd) {
    div().alert(color = Success) { "Message" }
}
```

### Navigation Module

#### Menu
```fsharp
// Old
Menu <| Fragment() {
    li() { a() { "Item 1" } }
    li() { a() { "Item 2" } }
}

// New
ul().menu(vertical = true) {
    li() { a() { "Item 1" } }
    li() { a() { "Item 2" } }
}
```

#### Tabs
```fsharp
// Old
Tabs <| Fragment() {
    a() { "Tab 1" }
    a() { "Tab 2" }
}

// New
div().tabs(boxed = true) {
    a().tab(active = true) { "Tab 1" }
    a().tab() { "Tab 2" }
}
```

#### Link
```fsharp
// Old
Link "#home" <| Fragment() { "Home" }

// New
a().link(hover = true, color = Primary).href("#home") { "Home" }
```

### Feedback Module

#### Alert
```fsharp
// Old
Alert <| Fragment() {
    span() { "Success!" }
}

// New
div().alert(color = Success) {
    span() { "Success!" }
}
```

#### Loading
```fsharp
// Old
Loading()

// New
span().loading(variant = "spinner", color = Primary, size = Large)
```

#### Progress
```fsharp
// Old
Progress 70 100

// New
progress().progress(color = Primary).attr("value", "70").attr("max", "100")
```

#### Radial Progress
```fsharp
// Old
RadialProgress 75

// New
div().radialProgress(value = 75, color = Primary, size = "12rem") { "75%" }
```

#### Tooltip
```fsharp
// Old
Tooltip "Helpful text" <| Fragment() {
    button() { "Hover me" }
}

// New
div().tooltip(position = Top, color = Primary).data("tip", "Helpful text") {
    button() { "Hover me" }
}
```

## Benefits of the New API

1. **Less Boilerplate**: No need for variable declarations, property assignments, or `.render` calls
2. **More Composable**: Components flow naturally with computation expressions
3. **Better Type Inference**: F# can infer types more easily with optional parameters
4. **Idiomatic F#**: Follows F# conventions for fluent APIs
5. **Compile-Time Safety**: `[<Erase>]` attribute ensures extensions don't affect runtime
6. **No Breaking Changes to HTML**: Uses standard Oxpecker.Solid HTML elements

## Technical Implementation

The new API uses **F# type extensions** with the `[<Erase>]` attribute:

```fsharp
type button with
    [<Erase>]
    member this.btn(?color: ColorVariant, ?size: Size, ?outline: bool, ...) =
        let classes = [
            "btn"
            // Build class list based on parameters
        ]
        this.class' <- CssClass.combine classes
        this  // Return this for method chaining
```

This pattern:
- Extends existing HTML element types from Oxpecker.Solid
- Accepts optional parameters using F#'s `?param` syntax
- Builds appropriate CSS classes based on parameters
- Returns `this` to enable fluent chaining
- Uses `[<Erase>]` to remove extensions at compile-time (no runtime overhead)

## Migration Checklist

When migrating existing code:

- [ ] Replace `DaisyButton()` instantiation with `button().btn()`
- [ ] Remove all `<-` property assignments
- [ ] Remove all `<| Fragment()` wrappers
- [ ] Convert properties to optional parameters: `btn.color <- Some Primary` → `btn(color = Primary)`
- [ ] Replace component functions with element extensions (e.g., `Card` → `div().card()`)
- [ ] Update helper components like `CardTitle`, `ModalBox` to use direct HTML with classes
- [ ] Test thoroughly to ensure styling is preserved

## Questions?

For more examples, see:
- `examples/ExampleApp.fs` - Comprehensive example application
- `README.md` - Quick start guide
- `COMPONENT_REFERENCE.md` - Detailed component documentation
