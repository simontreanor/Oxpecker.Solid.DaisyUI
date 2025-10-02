# Oxpecker.Solid.DaisyUI - PascalCase Component Reference

## 🎯 Naming Convention

All DaisyUI components use **PascalCase** naming to:
1. ✅ Avoid conflicts with Oxpecker.Solid HTML element functions
2. ✅ Match F# type and module conventions  
3. ✅ Provide IntelliSense-friendly component names
4. ✅ Align with DaisyUI documentation

## Complete Component List

### Actions
- **Button** - `Button(color = Primary, size = Large) { "Text" }`

### Data Display
- **Badge** - `Badge(color = Success) { "New" }`
- **Card** - `Card(bordered = true) { content }`
- **CardBody** - `CardBody() { content }`
- **CardTitle** - `CardTitle() { "Title" }`
- **CardActions** - `CardActions() { buttons }`
- **Avatar** - `Avatar(status = Online) { img }`
- **Stats** - `Stats(orientation = Vertical) { stat items }`
- **Stat** - `Stat() { stat content }`
- **Table** - `Table(zebra = true) { table content }`
- **Timeline** - `Timeline(orientation = Vertical) { events }`

### Data Input
- **Checkbox** - `Checkbox(color = Primary)`
- **Radio** - `Radio(name = "group", color = Primary)`
- **TextInput** - `TextInput(placeholder = "Name", bordered = true)`
- **Textarea** - `Textarea(rows = 4, bordered = true)`
- **Select** - `Select(bordered = true) { options }`
- **Range** - `Range(min = 0, max = 100)`
- **Toggle** - `Toggle(color = Primary)`
- **FileInput** - `FileInput(bordered = true)`
- **Rating** - `Rating(size = Large) { stars }`

### Layout
- **Artboard** - `Artboard(phone = true) { content }`
- **Divider** - `Divider(orientation = Vertical)`
- **Drawer** - `Drawer(isEnd = true) { sidebar }`
- **Footer** - `Footer(center = true) { content }`
- **Hero** - `Hero(overlay = true) { hero content }`
- **Indicator** - `Indicator() { badge content }`
- **Join** - `Join(orientation = Vertical) { grouped items }`
- **Stack** - `Stack() { stacked items }`
- **Toast** - `Toast(position = TopEnd) { notifications }`

### Navigation
- **Breadcrumbs** - `Breadcrumbs() { breadcrumb items }`
- **BottomNav** - `BottomNav(size = Large) { nav items }`
- **Link** - `Link(hover = true) { "Link text" }`
- **Menu** - `Menu(orientation = Horizontal) { menu items }`
- **Navbar** - `Navbar() { nav content }`
- **Steps** - `Steps(orientation = Vertical) { step items }`
- **Step** - `Step(color = Primary) { "Step 1" }`
- **Tabs** - `Tabs(boxed = true) { tab items }`
- **Tab** - `Tab(active = true) { "Tab 1" }`

### Feedback
- **Alert** - `Alert(color = Success) { message }`
- **Loading** - `Loading(variant = "spinner", size = Large)`
- **Progress** - `Progress(color = Primary)`
- **RadialProgress** - `RadialProgress(value = 75, color = Primary)`
- **Skeleton** - `Skeleton()`
- **Tooltip** - `Tooltip(position = Top) { content }`

## Why PascalCase?

### Before (Naming Conflicts)
```fsharp
// ❌ Conflicts with Oxpecker.Solid functions
select(class' = "select") // Ambiguous!
table(class' = "table")   // Which one?
```

### After (Clean & Clear)
```fsharp
// ✅ No conflicts - crystal clear
Select(bordered = true)   // DaisyUI component
Table(zebra = true)       // DaisyUI component
```

## Migration Guide

Simple find-and-replace from old names:

```fsharp
// Old → New
btn() → Button()
card() → Card()
badge() → Badge()
checkbox() → Checkbox()
textInput() → TextInput()
textarea_input() → Textarea()
daisy_table() → Table()
footer_layout() → Footer()
```
