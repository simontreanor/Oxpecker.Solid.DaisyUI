# API Improvements: Discriminated Unions for Mutually Exclusive Parameters

## Overview
Replaced mutually exclusive boolean parameters with discriminated unions for better type safety and clearer API.

## New Discriminated Union Types

### Common.fs

```fsharp
/// Orientation for components that support vertical/horizontal layout
type Orientation =
    | Vertical
    | Horizontal

/// Alignment for chat and similar components  
type Alignment =
    | AlignStart
    | AlignEnd

/// Avatar status
type AvatarStatus =
    | Online
    | Offline

/// Carousel snap position
type CarouselSnap =
    | SnapCenter
    | SnapEnd
```

## Components Changed

### Layout Components

#### 1. Divider
**Before:**
```fsharp
Divider(vertical = true)
Divider(horizontal = true)
```

**After:**
```fsharp
Divider(orientation = Vertical)
Divider(orientation = Horizontal)
```

#### 2. Join
**Before:**
```fsharp
Join(vertical = true)
Join(horizontal = true)
```

**After:**
```fsharp
Join(orientation = Vertical)
Join(orientation = Horizontal)
```

### Navigation Components

#### 3. Menu
**Before:**
```fsharp
Menu(vertical = true, size = Large)
Menu(horizontal = true, size = Small)
```

**After:**
```fsharp
Menu(orientation = Vertical, size = Large)
Menu(orientation = Horizontal, size = Small)
```

#### 4. Steps
**Before:**
```fsharp
Steps(vertical = true)
Steps(horizontal = true)
```

**After:**
```fsharp
Steps(orientation = Vertical)
Steps(orientation = Horizontal)
```

### Data Display Components

#### 5. Stats
**Before:**
```fsharp
Stats(vertical = true)
Stats(horizontal = true)
```

**After:**
```fsharp
Stats(orientation = Vertical)
Stats(orientation = Horizontal)
```

#### 6. Timeline
**Before:**
```fsharp
Timeline(vertical = true, compact = true)
Timeline(horizontal = true)
```

**After:**
```fsharp
Timeline(orientation = Vertical, compact = true)
Timeline(orientation = Horizontal)
```

#### 7. Chat
**Before:**
```fsharp
Chat(start = true)
Chat(``end`` = true)
```

**After:**
```fsharp
Chat(alignment = AlignStart)
Chat(alignment = AlignEnd)
```

#### 8. Avatar
**Before:**
```fsharp
Avatar(online = true)
Avatar(offline = true)
```

**After:**
```fsharp
Avatar(status = Online)
Avatar(status = Offline)
```

#### 9. Carousel
**Before:**
```fsharp
Carousel(center = true, vertical = true)
Carousel(``end`` = true)
```

**After:**
```fsharp
Carousel(snap = SnapCenter, vertical = true)
Carousel(snap = SnapEnd)
```

### Action Components

#### 10. Modal
**Before:**
```fsharp
Modal(top = true)
Modal(middle = true)
Modal(bottom = true)
```

**After:**
```fsharp
Modal(position = ModalTop)
Modal(position = ModalMiddle)
Modal(position = ModalBottom)
```

## Benefits

1. **Type Safety**: Impossible to pass both `vertical = true` and `horizontal = true` simultaneously
2. **IntelliSense**: IDE shows only valid options for each parameter
3. **Clearer Intent**: `orientation = Vertical` is more explicit than `vertical = true`
4. **Compile-Time Validation**: F# compiler ensures exhaustive pattern matching
5. **Better Documentation**: Discriminated unions are self-documenting

## Migration Guide

Replace boolean pairs with the appropriate discriminated union:

- `vertical/horizontal` → `orientation: Orientation`
- `start/end` (Chat) → `alignment: Alignment`
- `online/offline` → `status: AvatarStatus`
- `center/end` (Carousel) → `snap: CarouselSnap`
- `top/middle/bottom` (Modal) → `position: ModalPosition`
