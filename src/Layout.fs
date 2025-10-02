namespace Oxpecker.Solid.DaisyUI

open Fable.Core
open Oxpecker.Solid

/// DaisyUI Layout components
module Layout =
    
    /// Artboard component - Mobile device mockup
    type Artboard =
        [<SolidComponent>]
        static member Invoke(?phone: bool, ?horizontal: bool) =
            let classes = [
                "artboard"
                if phone = Some true then "artboard-demo phone-1"
                if horizontal = Some true then "artboard-horizontal"
            ]
            div(class' = CssClass.combine classes)
    
    /// Divider component - Visual separator
    type Divider =
        [<SolidComponent>]
        static member Invoke(?vertical: bool, ?horizontal: bool) =
            let classes = [
                "divider"
                if vertical = Some true then "divider-vertical"
                if horizontal = Some true then "divider-horizontal"
            ]
            div(class' = CssClass.combine classes)
    
    /// Drawer component - Sidebar drawer
    type Drawer =
        [<SolidComponent>]
        static member Invoke(?isEnd: bool) =
            let classes = [
                "drawer"
                if isEnd = Some true then "drawer-end"
            ]
            div(class' = CssClass.combine classes)
    
    /// Footer component (no conflict with PascalCase)
    type Footer =
        [<SolidComponent>]
        static member Invoke(?center: bool) =
            let classes = [
                "footer"
                if center = Some true then "footer-center"
            ]
            footer(class' = CssClass.combine classes)
    
    /// Hero component - Hero section
    type Hero =
        [<SolidComponent>]
        static member Invoke(?overlay: bool) =
            let classes = [
                "hero"
                if overlay = Some true then "hero-overlay"
            ]
            div(class' = CssClass.combine classes)
    
    /// Indicator component - Badge indicator
    type Indicator =
        [<SolidComponent>]
        static member Invoke() =
            div(class' = "indicator")
    
    /// Join component - Grouped elements
    type Join =
        [<SolidComponent>]
        static member Invoke(?vertical: bool, ?horizontal: bool) =
            let classes = [
                "join"
                if vertical = Some true then "join-vertical"
                if horizontal = Some true then "join-horizontal"
            ]
            div(class' = CssClass.combine classes)
    
    /// Stack component - Stacked elements
    type Stack =
        [<SolidComponent>]
        static member Invoke() =
            div(class' = "stack")
    
    /// Toast component - Toast notification
    type Toast =
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
