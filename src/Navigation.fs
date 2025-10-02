namespace Oxpecker.Solid.DaisyUI

open Fable.Core
open Oxpecker.Solid

/// DaisyUI Navigation components
module Navigation =
    
    /// Div navigation extensions
    type div with
        /// Apply breadcrumbs styles
        [<Erase>]
        member this.breadcrumbs() =
            this.class' <- "breadcrumbs"
            this
        
        /// Apply bottom navigation styles
        [<Erase>]
        member this.btmNav(?size: Size) =
            let classes = [
                "btm-nav"
                if size.IsSome then
                    match size.Value with
                    | ExtraSmall -> "btm-nav-xs"
                    | Small -> "btm-nav-sm"
                    | Medium -> "btm-nav-md"
                    | Large -> "btm-nav-lg"
                    | _ -> ""
            ]
            this.class' <- CssClass.combine classes
            this
        
        /// Apply navbar styles
        [<Erase>]
        member this.navbar() =
            this.class' <- "navbar bg-base-100"
            this
        
        /// Apply tabs styles
        [<Erase>]
        member this.tabs(?boxed: bool, ?lifted: bool, ?bordered: bool, ?size: Size) =
            let classes = [
                "tabs"
                if boxed = Some true then "tabs-boxed"
                if lifted = Some true then "tabs-lifted"
                if bordered = Some true then "tabs-bordered"
                if size.IsSome then
                    match size.Value with
                    | ExtraSmall -> "tabs-xs"
                    | Small -> "tabs-sm"
                    | Medium -> "tabs-md"
                    | Large -> "tabs-lg"
                    | _ -> ""
            ]
            this.class' <- CssClass.combine classes
            this
    
    /// Link extensions
    type a with
        /// Apply link styles
        [<Erase>]
        member this.link(?color: ColorVariant, ?hover: bool) =
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
            this.class' <- CssClass.combine classes
            this
        
        /// Apply tab styles
        [<Erase>]
        member this.tab(?active: bool, ?disabled: bool) =
            let classes = [
                "tab"
                if active = Some true then "tab-active"
                if disabled = Some true then "tab-disabled"
            ]
            this.class' <- CssClass.combine classes
            this
    
    /// Menu extensions
    type ul with
        /// Apply menu styles
        [<Erase>]
        member this.menu(?vertical: bool, ?horizontal: bool, ?size: Size) =
            let classes = [
                "menu"
                if vertical = Some true then "menu-vertical"
                if horizontal = Some true then "menu-horizontal"
                if size.IsSome then
                    match size.Value with
                    | ExtraSmall -> "menu-xs"
                    | Small -> "menu-sm"
                    | Medium -> "menu-md"
                    | Large -> "menu-lg"
                    | _ -> ""
            ]
            this.class' <- CssClass.combine classes
            this
        
        /// Apply steps styles
        [<Erase>]
        member this.steps(?vertical: bool, ?horizontal: bool) =
            let classes = [
                "steps"
                if vertical = Some true then "steps-vertical"
                if horizontal = Some true then "steps-horizontal"
            ]
            this.class' <- CssClass.combine classes
            this
    
    /// Step item extensions
    type li with
        /// Apply step styles
        [<Erase>]
        member this.step(?color: ColorVariant) =
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
            this.class' <- CssClass.combine classes
            this
