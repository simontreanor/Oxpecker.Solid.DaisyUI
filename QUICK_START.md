# Oxpecker.Solid.DaisyUI - Quick Start Guide

## Installation

```bash
dotnet add package Oxpecker.Solid.DaisyUI
npm install -D daisyui@latest tailwindcss@latest
```

## Setup

### 1. Configure Tailwind CSS

Create or update your CSS file (e.g., `src/index.css`):

```css
@import "tailwindcss";

@plugin "daisyui" {
  themes: light --default, dark --prefersdark;
  root: ":root";
}
```

### 2. Import the library

```fsharp
open Oxpecker.Solid
open Oxpecker.Solid.DaisyUI
```

## Basic Usage

All components use PascalCase naming and support optional parameters:

```fsharp
[<SolidComponent>]
let App() =
    div(class' = "container mx-auto p-4") {
        // Button with variants
        Button(color = Primary, size = Large) { "Click me" }
        
        // Card with structure
        Card(bordered = true) {
            CardBody() {
                CardTitle() { "Card Title" }
                p() { "Card content goes here" }
            }
        }
        
        // Badge
        Badge(color = Success) { "New" }
        
        // Form inputs
        FormControl() {
            Label() {
                LabelText() { "Your Name" }
            }
            TextInput(placeholder = "Enter name", bordered = true)
        }
    }
```

## Component Categories

### Actions
- `Button`, `Dropdown`, `Modal`, `Swap`, `Fab`, `Collapse`, `ThemeController`

### Data Display
- `Badge`, `Card`, `Avatar`, `Stats`, `Table`, `Timeline`, `Chat`, `Carousel`, `Countdown`, `Diff`, `Mask`, `List`, `Status`

### Data Input
- `Checkbox`, `Radio`, `TextInput`, `Textarea`, `Select`, `Range`, `Toggle`, `FileInput`, `Rating`, `Kbd`, `Filter`, `Fieldset`
- Form helpers: `FormControl`, `Label`, `LabelText`, `LabelTextAlt`

### Layout
- `Artboard`, `Divider`, `Drawer`, `Footer`, `Hero`, `Indicator`, `Join`, `Stack`, `Toast`

### Navigation
- `Breadcrumbs`, `BottomNav`, `Link`, `Menu`, `Navbar`, `Steps`, `Tabs`, `Pagination`

### Feedback
- `Alert`, `Loading`, `Progress`, `RadialProgress`, `Skeleton`, `Tooltip`

### Mockup
- `MockupBrowser`, `MockupCode`, `MockupPhone`, `MockupWindow`
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
## Type-Safe Variants

The library provides discriminated unions for common modifiers:

```fsharp
type ColorVariant =
    | Primary | Secondary | Accent | Neutral
    | Info | Success | Warning | Error | Ghost

type Size =
    | ExtraSmall | Small | Medium | Large | ExtraLarge

type Orientation =
    | Vertical | Horizontal
```

### Example Usage
```fsharp
Button(color = Primary, size = Large) { "Large Primary Button" }
Badge(color = Success, size = Small) { "Success" }
Menu(orientation = Vertical) { ... }
```

## Complete Example

```fsharp
[<SolidComponent>]
let MyApp() =
    div(class' = "min-h-screen bg-base-200") {
        Navbar() {
            div(class' = "flex-1") {
                a(class' = "btn btn-ghost text-xl") { "My App" }
            }
        }
        
        Hero() {
            HeroContent(class' = "text-center") {
                div(class' = "max-w-md") {
                    h1(class' = "text-5xl font-bold") { "Welcome!" }
                    p(class' = "py-6") { "Get started with DaisyUI" }
                    Button(color = Primary, size = Large) { "Get Started" }
                }
            }
        }
        
        div(class' = "container mx-auto p-4") {
            Card(bordered = true) {
                CardBody() {
                    CardTitle() { "Example Card" }
                    p() { "This demonstrates the clean API syntax" }
                    CardActions(class' = "justify-end") {
                        Button(color = Primary) { "Action" }
                    }
                }
            }
        }
    }
```

## More Examples

See the [Component Reference](COMPONENT_REFERENCE.md) for detailed examples of all components.

## License

MIT
