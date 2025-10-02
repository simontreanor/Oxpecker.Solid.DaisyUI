namespace Oxpecker.Solid.DaisyUI

open Fable.Core
open Oxpecker.Solid

/// DaisyUI Feedback components
module Feedback =

    /// Alert component - Alert message
    type Alert =
        [<SolidComponent>]
        static member Invoke(?class': string, ?color: ColorVariant) =
            let classes = [
                "alert"
                if color.IsSome then
                    match color.Value with
                    | Info -> "alert-info"
                    | Success -> "alert-success"
                    | Warning -> "alert-warning"
                    | Error -> "alert-error"
                    | _ -> ""
                if class'.IsSome then
                    class'.Value
            ]

            div (class' = CssClass.combine classes)

    /// Loading spinner component
    type Loading =
        [<SolidComponent>]
        static member Invoke(?class': string, ?variant: string, ?size: Size, ?color: ColorVariant) =
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
                    CssClass.ofSize "loading" size.Value
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
                if class'.IsSome then
                    class'.Value
            ]

            span (class' = CssClass.combine classes)

    /// Progress bar component
    type Progress =
        [<SolidComponent>]
        static member Invoke(?class': string, ?color: ColorVariant) =
            let classes = [
                "progress"
                if color.IsSome then
                    CssClass.ofColorVariant "progress" color.Value
                if class'.IsSome then
                    class'.Value
            ]

            progress (class' = CssClass.combine classes)

    /// Radial progress component
    type RadialProgress =
        [<SolidComponent>]
        static member Invoke(value: int, ?class': string, ?color: ColorVariant, ?size: string) =
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
                if class'.IsSome then
                    class'.Value
            ]

            div(class' = CssClass.combine classes)
                .attr("role", "progressbar")
                .style' ($"--value:{value}; --size:{sizeValue}")

    /// Skeleton component - Loading placeholder
    type Skeleton =
        [<SolidComponent>]
        static member Invoke(?class': string) =
            let classes = [
                "skeleton"
                if class'.IsSome then
                    class'.Value
            ]

            div (class' = CssClass.combine classes)

    /// Tooltip component
    type Tooltip =
        [<SolidComponent>]
        static member Invoke(?class': string, ?position: Position, ?color: ColorVariant, ?isOpen: bool) =
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
                    CssClass.ofColorVariant "tooltip" color.Value
                if isOpen = Some true then
                    "tooltip-open"
                if class'.IsSome then
                    class'.Value
            ]

            div (class' = CssClass.combine classes)
