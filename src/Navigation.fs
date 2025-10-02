namespace Oxpecker.Solid.DaisyUI

open Fable.Core
open Oxpecker.Solid

/// DaisyUI Navigation components
module Navigation =
    
    /// Breadcrumbs component - Breadcrumb navigation
    type Breadcrumbs =
        [<SolidComponent>]
        static member Invoke() =
            div(class' = "breadcrumbs")
    
    /// Bottom navigation component
    type BottomNav =
        [<SolidComponent>]
        static member Invoke(?size: Size) =
            let classes = [
                "btm-nav"
                if size.IsSome then CssClass.ofSize "btm-nav" size.Value
            ]
            div(class' = CssClass.combine classes)
    
    /// Link component (no conflict with PascalCase)
    type Link =
        [<SolidComponent>]
        static member Invoke(?color: ColorVariant, ?hover: bool) =
            let classes = [
                "link"
                if hover = Some true then "link-hover"
                if color.IsSome then
                    match color.Value with
                    | Primary -> "link-primary"
                    | Secondary -> "link-secondary"
                    | Accent -> "link-accent"
                    | Neutral -> "link-neutral"
                    | Success -> "link-success"
                    | Info -> "link-info"
                    | Warning -> "link-warning"
                    | Error -> "link-error"
                    | _ -> ""
            ]
            a(class' = CssClass.combine classes)
    
    /// Menu component - Menu list
    type Menu =
        [<SolidComponent>]
        static member Invoke(?vertical: bool, ?horizontal: bool, ?size: Size) =
            let classes = [
                "menu"
                if vertical = Some true then "menu-vertical"
                if horizontal = Some true then "menu-horizontal"
                if size.IsSome then CssClass.ofSize "menu" size.Value
            ]
            ul(class' = CssClass.combine classes)
    
    /// Navbar component - Navigation bar
    type Navbar =
        [<SolidComponent>]
        static member Invoke() =
            div(class' = "navbar bg-base-100")
    
    /// Steps component - Step indicator
    type Steps =
        [<SolidComponent>]
        static member Invoke(?vertical: bool, ?horizontal: bool) =
            let classes = [
                "steps"
                if vertical = Some true then "steps-vertical"
                if horizontal = Some true then "steps-horizontal"
            ]
            ul(class' = CssClass.combine classes)
    
    /// Step item component
    type Step =
        [<SolidComponent>]
        static member Invoke(?color: ColorVariant) =
            let classes = [
                "step"
                if color.IsSome then
                    match color.Value with
                    | Primary -> "step-primary"
                    | Secondary -> "step-secondary"
                    | Accent -> "step-accent"
                    | Info -> "step-info"
                    | Success -> "step-success"
                    | Warning -> "step-warning"
                    | Error -> "step-error"
                    | _ -> ""
            ]
            li(class' = CssClass.combine classes)
    
    /// Tabs component - Tab navigation
    type Tabs =
        [<SolidComponent>]
        static member Invoke(?boxed: bool, ?lifted: bool, ?bordered: bool, ?size: Size) =
            let classes = [
                "tabs"
                if boxed = Some true then "tabs-boxed"
                if lifted = Some true then "tabs-lifted"
                if bordered = Some true then "tabs-bordered"
                if size.IsSome then CssClass.ofSize "tabs" size.Value
            ]
            div(class' = CssClass.combine classes)
    
    /// Tab item component
    type Tab =
        [<SolidComponent>]
        static member Invoke(?active: bool, ?disabled: bool) =
            let classes = [
                "tab"
                if active = Some true then "tab-active"
                if disabled = Some true then "tab-disabled"
            ]
            a(class' = CssClass.combine classes)
