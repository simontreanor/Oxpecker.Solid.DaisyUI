namespace Oxpecker.Solid.DaisyUI

open Fable.Core
open Oxpecker.Solid

/// DaisyUI Feedback components
module Feedback =
    
    /// Alert component
    type alert =
        [<SolidComponent>]
        static member Invoke(?color: ColorVariant) =
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
            div(class' = CssClass.combine classes)
    
    /// Loading spinner component
    type loading =
        [<SolidComponent>]
        static member Invoke(?variant: string, ?size: Size, ?color: ColorVariant) =
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
                if size.IsSome then CssClass.ofSize "loading" size.Value
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
            span(class' = CssClass.combine classes)
    
    /// Progress bar component
    type progress_bar =
        [<SolidComponent>]
        static member Invoke(?color: ColorVariant) =
            let classes = [
                "progress"
                if color.IsSome then CssClass.ofColorVariant "progress" color.Value
            ]
            progress(class' = CssClass.combine classes)
    
    /// Radial progress component
    type radialProgress =
        [<SolidComponent>]
        static member Invoke(value: int, ?color: ColorVariant, ?size: string) =
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
            div(class' = CssClass.combine classes)
                .attr("role", "progressbar")
                .style'($"--value:{value}; --size:{sizeValue}")
    
    /// Skeleton component
    type skeleton =
        [<SolidComponent>]
        static member Invoke() =
            div(class' = "skeleton")
    
    /// Tooltip component
    type tooltip =
        [<SolidComponent>]
        static member Invoke(?position: Position, ?color: ColorVariant, ?isOpen: bool) =
            let classes = [
                "tooltip"
                if position.IsSome then
                    match position.Value with
                    | Top -> "tooltip-top"
                    | Bottom -> "tooltip-bottom"
                    | Left -> "tooltip-left"
                    | Right -> "tooltip-right"
                    | _ -> ""
                if color.IsSome then CssClass.ofColorVariant "tooltip" color.Value
                if isOpen = Some true then "tooltip-open"
            ]
            div(class' = CssClass.combine classes)
