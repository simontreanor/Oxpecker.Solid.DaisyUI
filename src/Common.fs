namespace Oxpecker.Solid.DaisyUI

/// Color variants for DaisyUI components
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

/// Size variants for components
type Size =
    | ExtraSmall
    | Small
    | Medium
    | Large
    | ExtraLarge

/// Button style variants
type ButtonStyle =
    | Outline
    | Ghost
    | Link

/// Position variants
type Position =
    | Top
    | Bottom
    | Left
    | Right
    | TopStart
    | TopEnd
    | BottomStart
    | BottomEnd

/// Modal position
type ModalPosition =
    | ModalTop
    | ModalMiddle
    | ModalBottom

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

/// Helper module for CSS class manipulation
module CssClass =
    /// Combine multiple CSS classes into a single string
    let combine (classes: string list) =
        classes
        |> List.filter (fun s -> not (System.String.IsNullOrWhiteSpace s))
        |> String.concat " "

    /// Convert ColorVariant to CSS class with prefix
    let ofColorVariant (prefix: string) (variant: ColorVariant) =
        match variant with
        | Primary -> $"{prefix}-primary"
        | Secondary -> $"{prefix}-secondary"
        | Accent -> $"{prefix}-accent"
        | Neutral -> $"{prefix}-neutral"
        | Info -> $"{prefix}-info"
        | Success -> $"{prefix}-success"
        | Warning -> $"{prefix}-warning"
        | Error -> $"{prefix}-error"
        | ColorVariant.Ghost -> $"{prefix}-ghost"

    /// Convert Size to CSS class with prefix
    let ofSize (prefix: string) (size: Size) =
        match size with
        | ExtraSmall -> $"{prefix}-xs"
        | Small -> $"{prefix}-sm"
        | Medium -> $"{prefix}-md"
        | Large -> $"{prefix}-lg"
        | ExtraLarge -> $"{prefix}-xl"

    /// Convert ButtonStyle to CSS class
    let ofButtonStyle (style: ButtonStyle) =
        match style with
        | Outline -> "btn-outline"
        | ButtonStyle.Ghost -> "btn-ghost"
        | Link -> "btn-link"

    /// Convert Position to CSS class with prefix
    let ofPosition (prefix: string) (position: Position) =
        match position with
        | Top -> $"{prefix}-top"
        | Bottom -> $"{prefix}-bottom"
        | Left -> $"{prefix}-left"
        | Right -> $"{prefix}-right"
        | TopStart -> $"{prefix}-top {prefix}-start"
        | TopEnd -> $"{prefix}-top {prefix}-end"
        | BottomStart -> $"{prefix}-bottom {prefix}-start"
        | BottomEnd -> $"{prefix}-bottom {prefix}-end"
