# Oxpecker.Solid.DaisyUI

[![NuGet](https://img.shields.io/nuget/v/Oxpecker.Solid.DaisyUI.svg)](https://www.nuget.org/packages/Oxpecker.Solid.DaisyUI)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

**Oxpecker.Solid.DaisyUI** is a comprehensive F# library that provides type-safe bindings for all [DaisyUI](https://daisyui.com/) components, specifically designed for use with [Oxpecker.Solid](https://github.com/Lanayx/Oxpecker) and [SolidJS](https://www.solidjs.com/).

This library enables you to build beautiful, responsive user interfaces using DaisyUI's component library with the power and type safety of F#, all while leveraging SolidJS's reactive primitives.

## Features

✨ **Complete DaisyUI Coverage** - All major DaisyUI components available as type-safe F# functions  
🔒 **Type Safety** - Leverage F#'s type system to catch errors at compile time  
⚡ **Oxpecker.Solid Integration** - Seamlessly works with Oxpecker's SolidJS bindings  
🎨 **Tailwind CSS Powered** - Built on top of Tailwind CSS utility classes  
📦 **Easy to Use** - Simple, idiomatic F# API  

## Installation

### NuGet Package

```bash
dotnet add package Oxpecker.Solid.DaisyUI
```

### Prerequisites

You'll also need:
- **Oxpecker.Solid** - For SolidJS bindings
- **DaisyUI** - The CSS framework (install via npm/yarn)
- **Tailwind CSS** - DaisyUI's peer dependency

```bash
npm install -D daisyui@latest
npm install -D tailwindcss@latest
```

### Tailwind Configuration

Update your `tailwind.config.js`:

```javascript
module.exports = {
  content: [
    "./src/**/*.{fs,jsx,tsx}",
  ],
  plugins: [require("daisyui")],
  daisyui: {
    themes: ["light", "dark", "cupcake"],
  },
}
```

## Quick Start

Here's a simple example showing how to use Oxpecker.Solid.DaisyUI components:

```fsharp
module App

open Oxpecker.Solid
open Oxpecker.Solid.DaisyUI

[<SolidComponent>]
let App() =
    div(class' = "container mx-auto p-4") {
        // DaisyUI Card with Button - Clean syntax!
        Card(bordered = true) {
            CardBody() {
                CardTitle() { "Welcome to DaisyUI!" }
                p() { "This is a card component built with Oxpecker.Solid.DaisyUI" }
                
                // Clean button syntax with optional parameters
                Button(color = Primary, size = Large) {
                    "Click Me!"
                }
            }
        }
        
        // Alert component
        alert(color = Success) {
            span() { "✓ Your application is ready!" }
        }
    }
```

### Key Difference: Clean Component Syntax

Oxpecker.Solid.DaisyUI uses a unique approach for clean, intuitive syntax:

```fsharp
// ✅ Clean syntax - components as functions
Button(color = Primary) { "Click" }
Card(bordered = true) { ... }
Badge(color = Success) { "New" }

// ❌ Not the verbose chaining style
button().Button(color = Primary) { "Click" }
div().Card(bordered = true) { ... }
```

This is achieved using F# types with static `Invoke` members, giving you:
- Function-like syntax
- Full optional parameter support
- Complete IntelliSense
- Type safety

## Component Categories

### Actions
Interactive components with clean syntax:
- **Button** - Buttons with various styles and colors
- **dropdown** - Dropdown menus
- **modal** - Modal dialogs
- **swap** - Swap/toggle animations
- **themeController** - Theme switching control

### Data Display
Components for showing data:
- **Badge** - Small status indicators
- **Card** - Content containers
- **cardTitle** - Card titles
- **cardBody** - Card body sections
- **avatar** - User profile images
- **stat / stats** - Statistics display
- **daisy_table** - Data tables
- **timeline** - Event timelines

### Data Input
Form input components:
- **checkbox** - Checkbox inputs
- **radio** - Radio button inputs
- **textInput** - Text input fields
- **textarea_input** - Multi-line text areas
- **select** - Dropdown selects
- **range** - Range sliders
- **toggle** - Toggle switches
- **fileInput** - File upload inputs
- **rating** - Star ratings

### Layout
Page layout components:
- **artboard** - Mobile mockup frames
- **divider** - Content dividers
- **drawer** - Side drawers
- **footer_layout** - Page footers
- **hero** - Hero sections
- **indicator** - Badge indicators
- **join** - Grouped items
- **stack** - Stacked items
- **toast** - Toast notifications

### Navigation
Navigation components:
- **breadcrumbs** - Breadcrumb navigation
- **btmNav** - Bottom navigation bars
- **link** - Styled links
- **menu** - Menu lists
- **navbar** - Navigation bars
- **steps** - Step indicators
- **step** - Individual step items
- **tabs** - Tab navigation
- **tab** - Individual tab items

### Feedback
User feedback components:
- **alert** - Alert messages
- **loading** - Loading spinners
- **progress_bar** - Progress bars
- **radialProgress** - Circular progress
- **skeleton** - Loading placeholders
- **tooltip** - Hover tooltips

## Component Usage Examples

### Button with Custom Styling

```fsharp
open Oxpecker.Solid.DaisyUI

[<SolidComponent>]
let MyButton() =
    Button(color = Primary, size = Large, wide = true) {
        "Large Primary Button"
    }
```

### Modal Dialog

```fsharp
open Oxpecker.Solid
open Oxpecker.Solid.DaisyUI

[<SolidComponent>]
let MyModal() =
    let isOpen, setIsOpen = createSignal false
    
    Fragment() {
        // Trigger button
        Button(color = Primary).onClick(fun _ -> setIsOpen(not (isOpen()))) {
            "Open Modal"
        }
        
        // Modal
        Show(``when`` = isOpen) <| Fragment() {
            modal(isOpen = isOpen()).attr("open", "true") {
                div(class' = "modal-box") {
                    h3(class' = "font-bold text-lg") { "Hello!" }
                    p(class' = "py-4") { "This is a modal dialog" }
                    div(class' = "modal-action") {
                        Button().onClick(fun _ -> setIsOpen(false)) {
                            "Close"
                        }
                    }
                }
            }
        }
    }
```

### Card with Stats

```fsharp
open Oxpecker.Solid.DaisyUI

[<SolidComponent>]
let StatsCard() =
    Card(bordered = true) {
        CardBody() {
            CardTitle() { "Statistics" }
            
            Stats() {
                Stat() {
                    div(class' = "stat-title") { "Total Users" }
                    div(class' = "stat-value") { "25.6K" }
                    div(class' = "stat-desc") { "↗︎ 400 (22%)" }
                }
                Stat() {
                    div(class' = "stat-title") { "Page Views" }
                    div(class' = "stat-value") { "2.6M" }
                    div(class' = "stat-desc") { "↗︎ 90 (14%)" }
                }
            }
        }
    }
```

### Form with Inputs

```fsharp
open Oxpecker.Solid.DaisyUI

[<SolidComponent>]
let MyForm() =
    let name, setName = createSignal ""
    let agreed, setAgreed = createSignal false
    
    form(class' = "space-y-4") {
        div(class' = "form-control") {
            label(class' = "label") {
                span(class' = "label-text") { "Your Name" }
            }
            textInput(placeholder = "Enter your name", bordered = true)
        }
        
        div(class' = "form-control") {
            label(class' = "label cursor-pointer") {
                span(class' = "label-text") { "I agree to terms" }
                checkbox(color = Primary)
            }
        }
        
        div(class' = "form-control") {
            label(class' = "label") {
                span(class' = "label-text") { "Select option" }
            }
            select(bordered = true) {
                option() { "Option 1" }
                option() { "Option 2" }
                option() { "Option 3" }
            }
        }
        
        Button(color = Primary, block = true) {
            "Submit"
        }
    }
```

## Type-Safe Variants

The library provides type-safe discriminated unions for common DaisyUI modifiers:

### ColorVariant
```fsharp
type ColorVariant =
    | Primary
    | Secondary
    | Accent
    | Neutral
    | Info
    | Success
    | Warning
    | Error
    | Ghost
```

### Size
```fsharp
type Size =
    | ExtraSmall
    | Small
    | Medium
    | Large
    | ExtraLarge
```

### ButtonStyle
```fsharp
type ButtonStyle =
    | Outline
    | Link
    | Glass
```

### Position
```fsharp
type Position =
    | Top | Bottom | Left | Right
    | TopStart | TopEnd
    | BottomStart | BottomEnd
    | LeftStart | LeftEnd
    | RightStart | RightEnd
```

## Advanced Usage

### Combining with Oxpecker.Solid Reactivity

```fsharp
open Oxpecker.Solid
open Oxpecker.Solid.DaisyUI.Feedback

[<SolidComponent>]
let LoadingExample() =
    let loading, setLoading = createSignal true
    let progress, setProgress = createSignal 0
    
    div() {
        Show(when' = Loading()) {
            Loading()
        }
        
        Progress (Progress()) 100
        
        let btn = DaisyButton()
        btn.render <| button(onClick = fun _ ->
            setLoading(not (Loading()))
            setProgress(Progress() + 10)
        ) {
            "Toggle & Increment"
        }
    }
```

### Custom Themes

DaisyUI supports multiple themes. Switch between them using the ThemeController:

```fsharp
open Oxpecker.Solid.DaisyUI.Actions

[<SolidComponent>]
let ThemeSwitcher() =
    div(class' = "flex gap-2") {
        label() {
            span() { "Dark Mode" }
            ThemeController "dark"
        }
    }
```

## Contributing

Contributions are welcome! This library is part of the Oxpecker ecosystem. If you'd like to add more components, improve type safety, or enhance the API:

1. Fork the repository
2. Create a feature branch
3. Make your changes
4. Submit a pull request

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Acknowledgments

- **[DaisyUI](https://daisyui.com/)** - The amazing component library
- **[Oxpecker](https://github.com/Lanayx/Oxpecker)** - F# web framework and Solid.js bindings
- **[SolidJS](https://www.solidjs.com/)** - The reactive JavaScript library
- **[Tailwind CSS](https://tailwindcss.com/)** - The utility-first CSS framework

## Related Projects

- [Oxpecker](https://github.com/Lanayx/Oxpecker) - F# web framework
- [Oxpecker.Solid](https://github.com/Lanayx/Oxpecker) - SolidJS bindings for F#
- [DaisyUI](https://daisyui.com/) - Tailwind CSS component library

## Support

If you find this library helpful, please consider:
- ⭐ Starring the repository
- 📢 Sharing it with others
- 🐛 Reporting issues
- 💡 Suggesting improvements

---

**Happy coding with F#, SolidJS, and DaisyUI!** 🎉
