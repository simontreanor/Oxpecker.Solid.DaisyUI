# Oxpecker.Solid.DaisyUI - Quick Start Guide

## Overview

Oxpecker.Solid.DaisyUI provides clean, type-safe F# bindings for DaisyUI components in SolidJS applications. The library uses a unique approach with F# types and static `Invoke` members to achieve a clean, function-like syntax with optional parameters.

## Installation

```bash
dotnet add package Oxpecker.Solid.DaisyUI
```

## Basic Usage

### Import the library

```fsharp
open Oxpecker.Solid
open Oxpecker.Solid.DaisyUI
```

### Clean Component Syntax

All DaisyUI components are available as standalone functions with optional parameters:

```fsharp
// Buttons - clean syntax with optional parameters
Button(color = Primary, size = Large) { "Click me" }
Button(outline = true) { "Outlined button" }

// Cards
Card(bordered = true) {
    CardBody() {
        CardTitle() { "Card Title" }
        p() { "Card content goes here" }
    }
}

// Badges
Badge(color = Success) { "New" }
Badge(outline = true, size = Large) { "Badge" }

// Form inputs
TextInput(placeholder = "Enter name", bordered = true)
Checkbox(color = Primary)
Textarea(rows = 4, placeholder = "Message...")
```

## Component Categories

### Actions
- `Button` - Buttons with various styles
- `dropdown` - Dropdown menus
- `modal` - Modal dialogs
- `swap` - Swap animations

### Data Display
- `Badge` - Status badges
- `Card`, `cardBody`, `cardTitle` - Card components
- `avatar` - Avatar images
- `stats`, `stat` - Statistics display
- `daisy_table` - Tables
- `timeline` - Timeline views

### Data Input
- `checkbox` - Checkboxes
- `radio` - Radio buttons
- `textInput` - Text inputs
- `textarea_input` - Text areas
- `select` - Select dropdowns
- `range` - Range sliders
- `toggle` - Toggle switches
- `fileInput` - File uploads
- `rating` - Star ratings

### Layout
- `hero` - Hero sections
- `divider` - Dividers
- `drawer` - Drawer sidebars
- `footer_layout` - Footers
- `indicator` - Indicators
- `join` - Joined elements
- `stack` - Stacked elements
- `toast` - Toast notifications

### Navigation
- `breadcrumbs` - Breadcrumb navigation
- `btmNav` - Bottom navigation
- `link` - Links
- `menu` - Menus
- `navbar` - Navigation bars
- `steps`, `step` - Step indicators
- `tabs`, `tab` - Tab navigation

### Feedback
- `alert` - Alert messages
- `loading` - Loading spinners
- `progress_bar` - Progress bars
- `radialProgress` - Radial progress
- `skeleton` - Skeleton loaders
- `tooltip` - Tooltips

## Common Parameters

### Color Variants
```fsharp
type ColorVariant =
    | Primary | Secondary | Accent | Neutral
    | Info | Success | Warning | Error | Ghost
```

### Sizes
```fsharp
type Size =
    | ExtraSmall | Small | Medium | Large | ExtraLarge
```

### Example Usage
```fsharp
Button(color = Primary, size = Large) { "Large Primary Button" }
Badge(color = Success, size = Small) { "Success" }
```

## Complete Example

```fsharp
[<SolidComponent>]
let MyApp() =
    div().class'("min-h-screen bg-base-200") {
        Navbar() {
            div().class'("flex-1") {
                a().class'("btn btn-ghost text-xl") { "My App" }
            }
        }
        
        Hero() {
            div().class'("hero-content text-center") {
                div().class'("max-w-md") {
                    h1().class'("text-5xl font-bold") { "Welcome!" }
                    p().class'("py-6") { "Get started with DaisyUI" }
                    Button(color = Primary, size = Large) { "Get Started" }
                }
            }
        }
        
        div().class'("container mx-auto p-4") {
            Card(bordered = true) {
                CardBody() {
                    CardTitle() { "Example Card" }
                    p() { "This demonstrates the clean API syntax" }
                    div().class'("card-actions justify-end") {
                        Button(color = Primary) { "Action" }
                    }
                }
            }
        }
    }
```

## Key Differences from Standard Oxpecker.Solid

Instead of chaining methods on HTML elements:
```fsharp
// ❌ Old verbose style
div().Card(bordered = true) { }
button().Button(color = Primary) { }
input().Checkbox() { }
```

Use the clean component syntax:
```fsharp
// ✅ New clean style
Card(bordered = true) { }
Button(color = Primary) { }
Checkbox() { }
```

## Why This Syntax?

F# only allows optional parameters (`?param`) on type members, not on let-bound functions. To achieve clean syntax like `Button(color = Primary)`, we use F# types with static `Invoke` members:

```fsharp
type btn =
    [<SolidComponent>]
    static member Invoke(?color: ColorVariant, ?size: Size, ...) =
        // Implementation
```

This gives you the best of both worlds:
- Clean, intuitive syntax: `Button(color = Primary)`
- Full IntelliSense support with optional parameters
- Type safety with compile-time checking

## License

MIT
