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
open Oxpecker.Solid.DaisyUI.Actions
open Oxpecker.Solid.DaisyUI.DataDisplay
open Oxpecker.Solid.DaisyUI.Feedback

[<SolidComponent>]
let App() =
    div(class' = "container mx-auto p-4") {
        // DaisyUI Card with Button
        Card <| Fragment() {
            CardBody <| Fragment() {
                CardTitle <| Fragment() { "Welcome to DaisyUI!" }
                p() { "This is a card component built with Oxpecker.Solid.DaisyUI" }
                
                // Using the type-based Button component
                let btn = DaisyButton()
                btn.color <- Some Primary
                btn.render <| Fragment() {
                    "Click Me!"
                }
            }
        }
        
        // Alert component
        Alert <| Fragment() {
            span() { "✓ Your application is ready!" }
        }
    }
```

## Component Categories

### Actions
Components for user interactions:
- **DaisyButton** - Buttons with various styles and colors
- **DaisyDropdown** - Dropdown menus
- **DaisyModal** - Modal dialogs
- **DaisySwap** - Swap/toggle animations
- **ThemeController** - Theme switching control

### Data Display
Components for showing data:
- **Badge** - Small status indicators
- **Card** - Content containers
- **Avatar** - User profile images
- **Stat** / **Stats** - Statistics display
- **Table** - Data tables
- **Timeline** - Event timelines

### Data Input
Form input components:
- **Checkbox** - Checkbox inputs
- **Radio** - Radio button inputs
- **TextInput** - Text input fields
- **Textarea** - Multi-line text areas
- **Select** - Dropdown selects
- **Range** - Range sliders
- **Toggle** - Toggle switches
- **FileInput** - File upload inputs
- **Rating** - Star ratings

### Layout
Page layout components:
- **Artboard** - Mobile mockup frames
- **Divider** - Content dividers
- **Drawer** - Side drawers
- **Footer** - Page footers
- **Hero** - Hero sections
- **Indicator** - Badge indicators
- **Join** - Grouped items
- **Stack** - Stacked items
- **Toast** - Toast notifications

### Navigation
Navigation components:
- **Breadcrumbs** - Breadcrumb navigation
- **BottomNav** - Bottom navigation bars
- **Link** - Styled links
- **Menu** - Menu lists
- **Navbar** - Navigation bars
- **Pagination** - Page navigation
- **Steps** - Step indicators
- **Tabs** - Tab navigation

### Feedback
User feedback components:
- **Alert** - Alert messages
- **Loading** - Loading spinners
- **Progress** - Progress bars
- **RadialProgress** - Circular progress
- **Skeleton** - Loading placeholders
- **Tooltip** - Hover tooltips

## Component Usage Examples

### Button with Custom Styling

```fsharp
open Oxpecker.Solid.DaisyUI.Actions

[<SolidComponent>]
let MyButton() =
    let btn = DaisyButton()
    btn.color <- Some Primary
    btn.size <- Some Large
    btn.wide <- true
    
    btn.render <| Fragment() {
        "Large Primary Button"
    }
```

### Modal Dialog

```fsharp
open Oxpecker.Solid
open Oxpecker.Solid.DaisyUI.Actions

[<SolidComponent>]
let MyModal() =
    let isOpen, setIsOpen = createSignal false
    
    Fragment() {
        // Trigger button
        let btn = DaisyButton()
        btn.color <- Some Primary
        btn.render <| button(onClick = fun _ -> setIsOpen(not (isOpen()))) {
            "Open Modal"
        }
        
        // Modal
        let modal = DaisyModal()
        modal.isOpen <- isOpen()
        modal.render <| Fragment() {
            ModalBox <| Fragment() {
                h3(class' = "font-bold text-lg") { "Hello!" }
                p(class' = "py-4") { "This is a modal dialog" }
                ModalAction <| Fragment() {
                    let closeBtn = DaisyButton()
                    closeBtn.render <| button(onClick = fun _ -> setIsOpen(false)) {
                        "Close"
                    }
                }
            }
        }
    }
```

### Card with Stats

```fsharp
open Oxpecker.Solid.DaisyUI.DataDisplay

[<SolidComponent>]
let StatsCard() =
    Card <| Fragment() {
        CardBody <| Fragment() {
            CardTitle <| Fragment() { "Statistics" }
            
            Stats <| Fragment() {
                Stat <| Fragment() {
                    div(class' = "stat-title") { "Total Users" }
                    div(class' = "stat-value") { "25.6K" }
                    div(class' = "stat-desc") { "↗︎ 400 (22%)" }
                }
                Stat <| Fragment() {
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
open Oxpecker.Solid.DaisyUI.DataInput

[<SolidComponent>]
let MyForm() =
    let name, setName = createSignal ""
    let agreed, setAgreed = createSignal false
    
    form(class' = "space-y-4") {
        div(class' = "form-control") {
            label(class' = "label") {
                span(class' = "label-text") { "Your Name" }
            }
            TextInput "Enter your name"
        }
        
        div(class' = "form-control") {
            label(class' = "label cursor-pointer") {
                span(class' = "label-text") { "I agree to terms" }
                Checkbox <| Fragment() { }
            }
        }
        
        div(class' = "form-control") {
            label(class' = "label") {
                span(class' = "label-text") { "Select option" }
            }
            Select <| Fragment() {
                option() { "Option 1" }
                option() { "Option 2" }
                option() { "Option 3" }
            }
        }
        
        let submitBtn = DaisyButton()
        submitBtn.color <- Some Primary
        submitBtn.block <- true
        submitBtn.render <| Fragment() {
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
        Show(when' = loading()) {
            Loading()
        }
        
        Progress (progress()) 100
        
        let btn = DaisyButton()
        btn.render <| button(onClick = fun _ ->
            setLoading(not (loading()))
            setProgress(progress() + 10)
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
