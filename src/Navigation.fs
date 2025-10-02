namespace Oxpecker.Solid.DaisyUI

open Fable.Core
open Oxpecker.Solid

/// DaisyUI Navigation components
module Navigation =
    
    /// Breadcrumbs component - Breadcrumb navigation
    type Breadcrumbs =
        [<SolidComponent>]
        static member Invoke(?class': string) =
            let classes = [
                "breadcrumbs"
                if class'.IsSome then class'.Value
            ]
            div(class' = CssClass.combine classes)
    
    /// Bottom navigation component
    type BottomNav =
        [<SolidComponent>]
        static member Invoke(?class': string, ?size: Size) =
            let classes = [
                "btm-nav"
                if size.IsSome then CssClass.ofSize "btm-nav" size.Value
                if class'.IsSome then class'.Value
            ]
            div(class' = CssClass.combine classes)
    
    /// Link component (no conflict with PascalCase)
    type Link =
        [<SolidComponent>]
        static member Invoke(?class': string, ?color: ColorVariant, ?hover: bool) =
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
                if class'.IsSome then class'.Value
            ]
            a(class' = CssClass.combine classes)
    
    /// Menu component - Menu list
    type Menu =
        [<SolidComponent>]
        static member Invoke(?class': string, ?orientation: Orientation, ?size: Size) =
            let classes = [
                "menu"
                if orientation.IsSome then
                    match orientation.Value with
                    | Vertical -> "menu-vertical"
                    | Horizontal -> "menu-horizontal"
                if size.IsSome then CssClass.ofSize "menu" size.Value
                if class'.IsSome then class'.Value
            ]
            ul(class' = CssClass.combine classes)
    
    /// Navbar component - Navigation bar
    type Navbar =
        [<SolidComponent>]
        static member Invoke(?class': string) =
            let classes = [
                "navbar bg-base-100"
                if class'.IsSome then class'.Value
            ]
            div(class' = CssClass.combine classes)
    
    /// Steps component - Step indicator
    type Steps =
        [<SolidComponent>]
        static member Invoke(?class': string, ?orientation: Orientation) =
            let classes = [
                "steps"
                if orientation.IsSome then
                    match orientation.Value with
                    | Vertical -> "steps-vertical"
                    | Horizontal -> "steps-horizontal"
                if class'.IsSome then class'.Value
            ]
            ul(class' = CssClass.combine classes)
    
    /// Step item component
    type Step =
        [<SolidComponent>]
        static member Invoke(?class': string, ?color: ColorVariant) =
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
                if class'.IsSome then class'.Value
            ]
            li(class' = CssClass.combine classes)
    
    /// Tabs component - Tab navigation
    type Tabs =
        [<SolidComponent>]
        static member Invoke(?class': string, ?boxed: bool, ?lifted: bool, ?bordered: bool, ?size: Size) =
            let classes = [
                "tabs"
                if boxed = Some true then "tabs-boxed"
                if lifted = Some true then "tabs-lifted"
                if bordered = Some true then "tabs-bordered"
                if size.IsSome then CssClass.ofSize "tabs" size.Value
                if class'.IsSome then class'.Value
            ]
            div(class' = CssClass.combine classes)
    
    /// Tab item component
    type Tab =
        [<SolidComponent>]
        static member Invoke(?class': string, ?active: bool, ?disabled: bool) =
            let classes = [
                "tab"
                if active = Some true then "tab-active"
                if disabled = Some true then "tab-disabled"
                if class'.IsSome then class'.Value
            ]
            a(class' = CssClass.combine classes)
    
    /// Pagination component - Note: Uses Join component for grouping buttons
    /// This is just a type alias for better semantics
    type Pagination = Join
    
    /// Dock component - Bottom navigation that sticks to bottom of screen
    type Dock =
        [<SolidComponent>]
        static member Invoke(?class': string, ?size: Size) =
            let classes = 
                [
                    "dock"
                    match size with
                    | Some ExtraSmall -> "dock-xs"
                    | Some Small -> "dock-sm"
                    | Some Medium -> "dock-md"
                    | Some Large -> "dock-lg"
                    | Some ExtraLarge -> "dock-xl"
                    | None -> ""
                    if class'.IsSome then class'.Value
                ]
            nav(class' = CssClass.combine classes)
    
    /// DockLabel part - Text label for Dock items
    type DockLabel =
        [<SolidComponent>]
        static member Invoke(?class': string, ?active: bool) =
            let classes = 
                [
                    "dock-label"
                    if active = Some true then "dock-label-active"
                    if class'.IsSome then class'.Value
                ]
            span(class' = CssClass.combine classes)
