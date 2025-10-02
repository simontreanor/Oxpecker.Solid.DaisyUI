namespace Oxpecker.Solid.DaisyUI

open Oxpecker.Solid

/// Common types and utilities for DaisyUI components
[<AutoOpen>]
module Common =
    
    /// DaisyUI color variants
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
        
    /// DaisyUI size variants
    type Size =
        | ExtraSmall
        | Small
        | Medium
        | Large
        | ExtraLarge
        
    /// DaisyUI button styles
    type ButtonStyle =
        | Outline
        | Link
        | Glass
        
    /// DaisyUI positions
    type Position =
        | Top
        | Bottom
        | Left
        | Right
        | TopStart
        | TopEnd
        | BottomStart
        | BottomEnd
        | LeftStart
        | LeftEnd
        | RightStart
        | RightEnd
        
    /// DaisyUI responsive positions
    type ResponsivePosition =
        | Start
        | Center
        | End
        
    /// Helper functions for converting types to CSS classes
    module CssClass =
        
        let ofColorVariant = function
            | Primary -> "btn-primary"
            | Secondary -> "btn-secondary"
            | Accent -> "btn-accent"
            | Neutral -> "btn-neutral"
            | Info -> "btn-info"
            | Success -> "btn-success"
            | Warning -> "btn-warning"
            | Error -> "btn-error"
            | Ghost -> "btn-ghost"
            
        let ofSize = function
            | ExtraSmall -> "btn-xs"
            | Small -> "btn-sm"
            | Medium -> ""
            | Large -> "btn-lg"
            | ExtraLarge -> "btn-xl"
            
        let ofButtonStyle = function
            | Outline -> "btn-outline"
            | Link -> "btn-link"
            | Glass -> "glass"
            
        let ofPosition = function
            | Top -> "dropdown-top"
            | Bottom -> "dropdown-bottom"
            | Left -> "dropdown-left"
            | Right -> "dropdown-right"
            | TopStart -> "dropdown-top dropdown-start"
            | TopEnd -> "dropdown-top dropdown-end"
            | BottomStart -> "dropdown-bottom dropdown-start"
            | BottomEnd -> "dropdown-bottom dropdown-end"
            | LeftStart -> "dropdown-left dropdown-start"
            | LeftEnd -> "dropdown-left dropdown-end"
            | RightStart -> "dropdown-right dropdown-start"
            | RightEnd -> "dropdown-right dropdown-end"
            
        let ofResponsivePosition = function
            | Start -> "start"
            | Center -> "center"
            | End -> "end"
            
        let combine (classes: string list) =
            classes 
            |> List.filter (fun s -> not (System.String.IsNullOrWhiteSpace(s)))
            |> String.concat " "
