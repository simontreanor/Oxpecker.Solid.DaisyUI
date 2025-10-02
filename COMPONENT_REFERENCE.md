# Oxpecker.Solid.DaisyUI - Component Reference

## Overview

This document provides a quick reference for all available components in the Oxpecker.Solid.DaisyUI library.

## Component Modules

### Common Types (`Oxpecker.Solid.DaisyUI`)

Core types used across components:

```fsharp
type ColorVariant = Primary | Secondary | Accent | Neutral | Info | Success | Warning | Error | Ghost
type Size = ExtraSmall | Small | Medium | Large | ExtraLarge  
type ButtonStyle = Outline | Link | Glass
type Position = Top | Bottom | Left | Right | TopStart | TopEnd | BottomStart | BottomEnd | LeftStart | LeftEnd | RightStart | RightEnd
type ResponsivePosition = Start | Center | End
```

Helper modules:
- `CssClass.combine` - Combines a list of CSS classes
- `CssClass.ofColorVariant` - Converts ColorVariant to CSS class
- `CssClass.ofSize` - Converts Size to CSS class
- etc.

---

## Actions (`Oxpecker.Solid.DaisyUI.Actions`)

### DaisyButton

Type-based button component with configurable properties.

**Properties:**
- `color: ColorVariant option` - Button color variant
- `size: Size option` - Button size
- `style: ButtonStyle option` - Button style (Outline, Link, Glass)
- `wide: bool` - Wide button
- `block: bool` - Full-width button
- `circle: bool` - Circular button
- `square: bool` - Square button
- `loading: bool` - Loading state
- `disabled: bool` - Disabled state
- `active: bool` - Active state
- `noAnimation: bool` - Disable animations

**Usage:**
```fsharp
let btn = DaisyButton()
btn.color <- Some Primary
btn.size <- Some Large
btn.wide <- true
btn.render <| Fragment() { "Click Me!" }
```

### DaisyDropdown

Dropdown menu component.

**Properties:**
- `position: Position option` - Dropdown position
- `hover: bool` - Open on hover
- `isOpen: bool` - Controlled open state

**Usage:**
```fsharp
let dropdown = DaisyDropdown()
dropdown.position <- Some Bottom
dropdown.render <| Fragment() {
    button() { "Open" }
    DropdownContent <| Fragment() {
        li() { a() { "Item 1" } }
        li() { a() { "Item 2" } }
    }
}
```

### DaisyModal

Modal dialog component.

**Properties:**
- `isOpen: bool` - Modal open state
- `bottom: bool` - Bottom position
- `middle: bool` - Middle position (default)

**Usage:**
```fsharp
let modal = DaisyModal()
modal.isOpen <- true
modal.render <| Fragment() {
    ModalBox <| Fragment() {
        h3() { "Title" }
        p() { "Content" }
        ModalAction <| Fragment() {
            button() { "Close" }
        }
    }
}
```

### Helper Functions

- `ModalBox` - Modal content container
- `ModalAction` - Modal actions container  
- `ModalBackdrop` - Modal backdrop

### DaisySwap

Swap/toggle animation component.

**Properties:**
- `active: bool` - Swap state
- `rotate: bool` - Use rotate animation
- `flip: bool` - Use flip animation

### Helper Functions

- `SwapOn` - Element shown when active
- `SwapOff` - Element shown when inactive

### ThemeController

Theme switching control.

**Usage:**
```fsharp
ThemeController "dark"
```

---

## Data Display (`Oxpecker.Solid.DaisyUI.DataDisplay`)

### Badge
```fsharp
Badge <| Fragment() { "New" }
```

### Card
```fsharp
Card <| Fragment() {
    CardBody <| Fragment() {
        CardTitle <| Fragment() { "Title" }
        p() { "Content" }
    }
}
```

### Avatar
```fsharp
Avatar <| Fragment() {
    div(class' = "w-24 rounded-full") {
        img(src = "avatar.jpg")
    }
}
```

### Stats
```fsharp
Stats <| Fragment() {
    Stat <| Fragment() {
        div(class' = "stat-title") { "Downloads" }
        div(class' = "stat-value") { "31K" }
        div(class' = "stat-desc") { "Jan 1st - Feb 1st" }
    }
}
```

### Table
```fsharp
Table <| Fragment() {
    thead() {
        tr() {
            th() { "Name" }
            th() { "Job" }
        }
    }
    tbody() {
        tr() {
            td() { "Cy" }
            td() { "Quality" }
        }
    }
}
```

### Timeline
```fsharp
Timeline <| Fragment() {
    li() {
        hr()
        div(class' = "timeline-start") { "1984" }
        div(class' = "timeline-middle") { }
        div(class' = "timeline-end timeline-box") { "First Event" }
        hr()
    }
}
```

---

## Data Input (`Oxpecker.Solid.DaisyUI.DataInput`)

### Checkbox
```fsharp
Checkbox <| Fragment() { }
```

### Radio
```fsharp
Radio "group-name"
```

### TextInput
```fsharp
TextInput "Enter your name"
```

### Textarea
```fsharp
Textarea "Enter your message"
```

### Select
```fsharp
Select <| Fragment() {
    option() { "Option 1" }
    option() { "Option 2" }
}
```

### Range
```fsharp
Range 0 100
```

### Toggle
```fsharp
Toggle()
```

### FileInput
```fsharp
FileInput()
```

### Rating
```fsharp
Rating <| Fragment() {
    input(type' = "radio", name = "rating", class' = "mask mask-star-2 bg-orange-400")
    input(type' = "radio", name = "rating", class' = "mask mask-star-2 bg-orange-400")
}
```

---

## Layout (`Oxpecker.Solid.DaisyUI.Layout`)

### Artboard
```fsharp
Artboard <| Fragment() {
    // Mobile mockup content
}
```

### Divider
```fsharp
Divider "OR"
```

### Drawer
```fsharp
Drawer <| Fragment() {
    // Drawer content and trigger
}
```

### Footer
```fsharp
Footer <| Fragment() {
    p() { "Copyright © 2025" }
}
```

### Hero
```fsharp
Hero <| Fragment() {
    div(class' = "hero-content text-center") {
        h1(class' = "text-5xl font-bold") { "Hello there" }
    }
}
```

### Indicator
```fsharp
Indicator <| Fragment() {
    span(class' = "indicator-item badge badge-secondary") { "new" }
    div(class' = "grid w-32 h-32 bg-base-300 place-items-center") { "content" }
}
```

### Join
```fsharp
Join <| Fragment() {
    button(class' = "btn join-item") { "Button" }
    button(class' = "btn join-item") { "Button" }
}
```

### Stack
```fsharp
Stack <| Fragment() {
    div(class' = "card") { "Card 1" }
    div(class' = "card") { "Card 2" }
}
```

### Toast
```fsharp
Toast <| Fragment() {
    Alert <| Fragment() { "Message" }
}
```

---

## Navigation (`Oxpecker.Solid.DaisyUI.Navigation`)

### Breadcrumbs
```fsharp
Breadcrumbs <| Fragment() {
    ul() {
        li() { a() { "Home" } }
        li() { a() { "Documents" } }
        li() { "Current" }
    }
}
```

### BottomNav
```fsharp
BottomNav <| Fragment() {
    button() { span(class' = "btm-nav-label") { "Home" } }
    button() { span(class' = "btm-nav-label") { "Profile" } }
}
```

### Link
```fsharp
Link "#section" <| Fragment() { "Go to section" }
```

### Menu
```fsharp
Menu <| Fragment() {
    li() { a() { "Item 1" } }
    li() { a() { "Item 2" } }
}
```

### Navbar
```fsharp
Navbar <| Fragment() {
    div(class' = "flex-1") {
        a(class' = "btn btn-ghost text-xl") { "daisyUI" }
    }
    div(class' = "flex-none") {
        button(class' = "btn btn-square btn-ghost") { "☰" }
    }
}
```

### Pagination
```fsharp
Pagination <| Fragment() {
    button(class' = "join-item btn") { "1" }
    button(class' = "join-item btn") { "2" }
    button(class' = "join-item btn btn-active") { "3" }
}
```

### Steps
```fsharp
Steps <| Fragment() {
    li(class' = "step step-primary") { "Register" }
    li(class' = "step step-primary") { "Choose plan" }
    li(class' = "step") { "Purchase" }
}
```

### Tabs
```fsharp
Tabs <| Fragment() {
    a(class' = "tab") { "Tab 1" }
    a(class' = "tab tab-active") { "Tab 2" }
    a(class' = "tab") { "Tab 3" }
}
```

---

## Feedback (`Oxpecker.Solid.DaisyUI.Feedback`)

### Alert
```fsharp
Alert <| Fragment() {
    svg() { }
    span() { "We use cookies for no reason." }
}
```

### Loading
```fsharp
Loading()
```

### Progress
```fsharp
Progress 70 100
```

### RadialProgress
```fsharp
RadialProgress 70
```

### Skeleton
```fsharp
Skeleton()
```

### Tooltip
```fsharp
Tooltip "Hover me" <| Fragment() {
    button() { "Button" }
}
```

---

## CSS Classes Reference

### Common Modifiers

**Colors:**
- `*-primary`, `*-secondary`, `*-accent`, `*-neutral`
- `*-info`, `*-success`, `*-warning`, `*-error`
- `*-ghost`

**Sizes:**
- `*-xs`, `*-sm`, `*-md`, `*-lg`, `*-xl`

**Positions:**
- `*-top`, `*-bottom`, `*-left`, `*-right`
- `*-start`, `*-end`, `*-center`

Replace `*` with the component class (e.g., `btn-primary`, `badge-sm`, etc.)

---

## Best Practices

1. **Use Type-Based Components for Complex Cases**
   - For components with many options, use type-based components (DaisyButton, DaisyModal, etc.)
   - This provides better IDE support and compile-time safety

2. **Use Helper Functions for Simple Cases**
   - For simple components without many options, use helper functions (Badge, Alert, etc.)
   - These are more concise and easier to use

3. **Combine with Tailwind Classes**
   - DaisyUI components work seamlessly with Tailwind utility classes
   - Use `class'` attribute to add custom styling

4. **Leverage SolidJS Reactivity**
   - Use `createSignal`, `createMemo`, etc. for reactive state
   - Components automatically re-render when signals change

5. **Follow DaisyUI Documentation**
   - For detailed styling options, refer to [DaisyUI docs](https://daisyui.com/)
   - This library provides type-safe wrappers around DaisyUI classes

---

## Future Enhancements

Potential improvements for future versions:

- [ ] More granular type-based components for all categories
- [ ] Builder pattern for complex components
- [ ] Pre-composed component variants (e.g., PrimaryButton, SuccessAlert)
- [ ] Theme configuration helpers
- [ ] Accessibility attributes integration
- [ ] Animation utilities
- [ ] Form validation helpers

---

## Resources

- [DaisyUI Documentation](https://daisyui.com/)
- [Oxpecker.Solid Documentation](https://lanayx.github.io/Oxpecker/src/Oxpecker.Solid/)
- [SolidJS Documentation](https://www.solidjs.com/)
- [Tailwind CSS Documentation](https://tailwindcss.com/)

---

**Last Updated:** October 2, 2025
