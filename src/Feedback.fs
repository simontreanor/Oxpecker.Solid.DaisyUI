namespace Oxpecker.Solid.DaisyUI

open Fable.Core
open Oxpecker.Solid

/// DaisyUI Feedback components
module Feedback =

    /// Alert component - Alert message
    type Alert =
        [<SolidComponent>]
        static member Invoke(?class': string, ?color: Color) =
            let classes = [
                "alert"
                if color.IsSome then
                    match color.Value with
                    | Color.Info -> "alert-info"
                    | Color.Success -> "alert-success"
                    | Color.Warning -> "alert-warning"
                    | Color.Error -> "alert-error"
                    | _ -> ""
                if class'.IsSome then
                    class'.Value
            ]

            div (class' = CssClass.combine classes)

    /// Loading spinner component
    type Loading =
        [<SolidComponent>]
        static member Invoke(?class': string, ?variant: string, ?size: Size, ?color: Color) =
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
                    | Color.Primary -> "text-primary"
                    | Color.Secondary -> "text-secondary"
                    | Color.Accent -> "text-accent"
                    | Color.Info -> "text-info"
                    | Color.Success -> "text-success"
                    | Color.Warning -> "text-warning"
                    | Color.Error -> "text-error"
                    | _ -> ""
                if class'.IsSome then
                    class'.Value
            ]

            span (class' = CssClass.combine classes)

    /// Progress bar component
    type Progress =
        [<SolidComponent>]
        static member Invoke(?class': string, ?color: Color) =
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
        static member Invoke(value: int, ?class': string, ?color: Color, ?size: string) =
            let sizeValue = defaultArg size "12rem"

            let classes = [
                "radial-progress"
                if color.IsSome then
                    match color.Value with
                    | Color.Primary -> "text-primary"
                    | Color.Secondary -> "text-secondary"
                    | Color.Accent -> "text-accent"
                    | Color.Info -> "text-info"
                    | Color.Success -> "text-success"
                    | Color.Warning -> "text-warning"
                    | Color.Error -> "text-error"
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
        static member Invoke(?class': string, ?position: Position, ?color: Color, ?isOpen: bool) =
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
