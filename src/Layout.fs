namespace Oxpecker.Solid.DaisyUI

open Fable.Core
open Oxpecker.Solid

/// DaisyUI Layout components
module Layout =
    
    /// Div layout extensions
    type div with
        /// Apply artboard styles
        [<Erase>]
        member this.artboard(?phone: bool, ?horizontal: bool) =
            let classes = [
                "artboard"
                if phone = Some true then "artboard-demo phone-1"
                if horizontal = Some true then "artboard-horizontal"
            ]
            this.class' <- CssClass.combine classes
            this
        
        /// Apply divider styles
        [<Erase>]
        member this.divider(?vertical: bool, ?horizontal: bool) =
            let classes = [
                "divider"
                if vertical = Some true then "divider-vertical"
                if horizontal = Some true then "divider-horizontal"
            ]
            this.class' <- CssClass.combine classes
            this
        
        /// Apply drawer styles
        [<Erase>]
        member this.drawer(?isEnd: bool) =
            let classes = [
                "drawer"
                if isEnd = Some true then "drawer-end"
            ]
            this.class' <- CssClass.combine classes
            this
        
        /// Apply hero styles
        [<Erase>]
        member this.hero(?overlay: bool) =
            let classes = [
                "hero"
                if overlay = Some true then "hero-overlay"
            ]
            this.class' <- CssClass.combine classes
            this
        
        /// Apply indicator styles
        [<Erase>]
        member this.indicator() =
            this.class' <- "indicator"
            this
        
        /// Apply join styles
        [<Erase>]
        member this.join(?vertical: bool, ?horizontal: bool) =
            let classes = [
                "join"
                if vertical = Some true then "join-vertical"
                if horizontal = Some true then "join-horizontal"
            ]
            this.class' <- CssClass.combine classes
            this
        
        /// Apply stack styles
        [<Erase>]
        member this.stack() =
            this.class' <- "stack"
            this
        
        /// Apply toast styles
        [<Erase>]
        member this.toast(?position: Position) =
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
                    | _ -> ""
            ]
            this.class' <- CssClass.combine classes
            this
    
    /// Footer extensions
    type footer with
        /// Apply footer styles
        [<Erase>]
        member this.footer(?center: bool) =
            let classes = [
                "footer"
                if center = Some true then "footer-center"
            ]
            this.class' <- CssClass.combine classes
            this
