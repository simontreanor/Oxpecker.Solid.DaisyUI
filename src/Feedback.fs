namespace Oxpecker.Solid.DaisyUI

open Fable.Core
open Oxpecker.Solid

/// DaisyUI Feedback components
module Feedback =
    
    /// Div feedback extensions
    type div with
        /// Apply alert styles
        [<Erase>]
        member this.alert(?color: ColorVariant) =
            let classes = [
                "alert"
                if color.IsSome then
                    match color.Value with
                    | Info -> "alert-info"
                    | Success -> "alert-success"
                    | Warning -> "alert-warning"
                    | Error -> "alert-error"
                    | _ -> ""
            ]
            this.class' <- CssClass.combine classes
            this
        
        /// Apply skeleton styles
        [<Erase>]
        member this.skeleton() =
            this.class' <- "skeleton"
            this
        
        /// Apply tooltip styles
        [<Erase>]
        member this.tooltip(?position: Position, ?color: ColorVariant, ?isOpen: bool) =
            let classes = [
                "tooltip"
                if position.IsSome then
                    match position.Value with
                    | Top -> "tooltip-top"
                    | Bottom -> "tooltip-bottom"
                    | Left -> "tooltip-left"
                    | Right -> "tooltip-right"
                    | _ -> ""
                if color.IsSome then
                    match color.Value with
                    | Primary -> "tooltip-primary"
                    | Secondary -> "tooltip-secondary"
                    | Accent -> "tooltip-accent"
                    | Info -> "tooltip-info"
                    | Success -> "tooltip-success"
                    | Warning -> "tooltip-warning"
                    | Error -> "tooltip-error"
                    | _ -> ""
                if isOpen = Some true then "tooltip-open"
            ]
            this.class' <- CssClass.combine classes
            this
        
        /// Apply radial progress styles
        [<Erase>]
        member this.radialProgress(value: int, ?color: ColorVariant, ?size: string) =
            let sizeValue = defaultArg size "12rem"
            let classes = [
                "radial-progress"
                if color.IsSome then
                    match color.Value with
                    | Primary -> "text-primary"
                    | Secondary -> "text-secondary"
                    | Accent -> "text-accent"
                    | Info -> "text-info"
                    | Success -> "text-success"
                    | Warning -> "text-warning"
                    | Error -> "text-error"
                    | _ -> ""
            ]
            this.class' <- CssClass.combine classes
            this.attr("role", "progressbar").style'($"--value:{value}; --size:{sizeValue}")
    
    /// Span loading extensions
    type span with
        /// Apply loading styles
        [<Erase>]
        member this.loading(?variant: string, ?size: Size, ?color: ColorVariant) =
            let classes = [
                "loading"
                match variant with
                | Some "spinner" -> "loading-spinner"
                | Some "dots" -> "loading-dots"
                | Some "ring" -> "loading-ring"
                | Some "ball" -> "loading-ball"
                | Some "bars" -> "loading-bars"
                | Some "infinity" -> "loading-infinity"
                | _ -> "loading-spinner"
                if size.IsSome then
                    match size.Value with
                    | ExtraSmall -> "loading-xs"
                    | Small -> "loading-sm"
                    | Medium -> "loading-md"
                    | Large -> "loading-lg"
                    | _ -> ""
                if color.IsSome then
                    match color.Value with
                    | Primary -> "text-primary"
                    | Secondary -> "text-secondary"
                    | Accent -> "text-accent"
                    | Info -> "text-info"
                    | Success -> "text-success"
                    | Warning -> "text-warning"
                    | Error -> "text-error"
                    | _ -> ""
            ]
            this.class' <- CssClass.combine classes
            this
    
    /// Progress bar extensions
    type progress with
        /// Apply progress styles
        [<Erase>]
        member this.progress(?color: ColorVariant) =
            let classes = [
                "progress"
                if color.IsSome then
                    match color.Value with
                    | Primary -> "progress-primary"
                    | Secondary -> "progress-secondary"
                    | Accent -> "progress-accent"
                    | Info -> "progress-info"
                    | Success -> "progress-success"
                    | Warning -> "progress-warning"
                    | Error -> "progress-error"
                    | _ -> ""
            ]
            this.class' <- CssClass.combine classes
            this
