namespace Oxpecker.Solid.DaisyUI

open Fable.Core
open Oxpecker.Solid

/// DaisyUI Layout components
module Layout =
    
    /// Artboard component
    type artboard =
        [<SolidComponent>]
        static member Invoke(?phone: bool, ?horizontal: bool) =
            let classes = [
                "artboard"
                if phone = Some true then "artboard-demo phone-1"
                if horizontal = Some true then "artboard-horizontal"
            ]
            div(class' = CssClass.combine classes)
    
    /// Divider component
    type divider =
        [<SolidComponent>]
        static member Invoke(?vertical: bool, ?horizontal: bool) =
            let classes = [
                "divider"
                if vertical = Some true then "divider-vertical"
                if horizontal = Some true then "divider-horizontal"
            ]
            div(class' = CssClass.combine classes)
    
    /// Drawer component
    type drawer =
        [<SolidComponent>]
        static member Invoke(?isEnd: bool) =
            let classes = [
                "drawer"
                if isEnd = Some true then "drawer-end"
            ]
            div(class' = CssClass.combine classes)
    
    /// Footer component
    type footer_layout =
        [<SolidComponent>]
        static member Invoke(?center: bool) =
            let classes = [
                "footer"
                if center = Some true then "footer-center"
            ]
            footer(class' = CssClass.combine classes)
    
    /// Hero component
    type hero =
        [<SolidComponent>]
        static member Invoke(?overlay: bool) =
            let classes = [
                "hero"
                if overlay = Some true then "hero-overlay"
            ]
            div(class' = CssClass.combine classes)
    
    /// Indicator component
    type indicator =
        [<SolidComponent>]
        static member Invoke() =
            div(class' = "indicator")
    
    /// Join component
    type join =
        [<SolidComponent>]
        static member Invoke(?vertical: bool, ?horizontal: bool) =
            let classes = [
                "join"
                if vertical = Some true then "join-vertical"
                if horizontal = Some true then "join-horizontal"
            ]
            div(class' = CssClass.combine classes)
    
    /// Stack component
    type stack =
        [<SolidComponent>]
        static member Invoke() =
            div(class' = "stack")
    
    /// Toast component
    type toast =
        [<SolidComponent>]
        static member Invoke(?position: Position) =
            let classes = [
                "toast"
                if position.IsSome then
                    match position.Value with
                    | Top -> "toast-top"
                    | Bottom -> "toast-bottom"
                    | Left -> "toast-start"
                    | Right -> "toast-end"
                    | TopStart -> "toast-top toast-start"
                    | TopEnd -> "toast-top toast-end"
                    | BottomStart -> "toast-bottom toast-start"
                    | BottomEnd -> "toast-bottom toast-end"
            ]
            div(class' = CssClass.combine classes)
