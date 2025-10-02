namespace Oxpecker.Solid.DaisyUI

open Fable.Core
open Oxpecker.Solid

/// DaisyUI Layout components
module Layout =

    /// Artboard component - Mobile device mockup
    type Artboard =
        [<SolidComponent>]
        static member Invoke(?class': string, ?phone: bool, ?horizontal: bool) =
            let classes = [
                "artboard"
                if phone = Some true then
                    "artboard-demo phone-1"
                if horizontal = Some true then
                    "artboard-horizontal"
                if class'.IsSome then
                    class'.Value
            ]

            div (class' = CssClass.combine classes)

    /// Divider component - Visual separator
    type Divider =
        [<SolidComponent>]
        static member Invoke(?class': string, ?orientation: Orientation) =
            let classes = [
                "divider"
                if orientation.IsSome then
                    match orientation.Value with
                    | Vertical -> "divider-vertical"
                    | Horizontal -> "divider-horizontal"
                if class'.IsSome then
                    class'.Value
            ]

            div (class' = CssClass.combine classes)

    /// Drawer component - Sidebar drawer
    type Drawer =
        [<SolidComponent>]
        static member Invoke(?class': string, ?isEnd: bool) =
            let classes = [
                "drawer"
                if isEnd = Some true then
                    "drawer-end"
                if class'.IsSome then
                    class'.Value
            ]

            div (class' = CssClass.combine classes)

    /// Footer component (no conflict with PascalCase)
    type Footer =
        [<SolidComponent>]
        static member Invoke(?class': string, ?center: bool) =
            let classes = [
                "footer"
                if center = Some true then
                    "footer-center"
                if class'.IsSome then
                    class'.Value
            ]

            footer (class' = CssClass.combine classes)

    /// Hero component - Hero section
    type Hero =
        [<SolidComponent>]
        static member Invoke(?class': string, ?overlay: bool) =
            let classes = [
                "hero"
                if overlay = Some true then
                    "hero-overlay"
                if class'.IsSome then
                    class'.Value
            ]

            div (class' = CssClass.combine classes)

    /// Hero content component - Content area for hero
    type HeroContent =
        [<SolidComponent>]
        static member Invoke(?class': string) =
            let classes = [
                "hero-content"
                if class'.IsSome then
                    class'.Value
            ]

            div (class' = CssClass.combine classes)

    /// Indicator component - Badge indicator
    type Indicator =
        [<SolidComponent>]
        static member Invoke(?class': string) =
            let classes = [
                "indicator"
                if class'.IsSome then
                    class'.Value
            ]

            div (class' = CssClass.combine classes)

    /// Join component - Grouped elements
    type Join =
        [<SolidComponent>]
        static member Invoke(?class': string, ?orientation: Orientation) =
            let classes = [
                "join"
                if orientation.IsSome then
                    match orientation.Value with
                    | Vertical -> "join-vertical"
                    | Horizontal -> "join-horizontal"
                if class'.IsSome then
                    class'.Value
            ]

            div (class' = CssClass.combine classes)

    /// Stack component - Stacked elements
    type Stack =
        [<SolidComponent>]
        static member Invoke(?class': string) =
            let classes = [
                "stack"
                if class'.IsSome then
                    class'.Value
            ]

            div (class' = CssClass.combine classes)

    /// Toast component - Toast notification
    type Toast =
        [<SolidComponent>]
        static member Invoke(?class': string, ?position: Position) =
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
                if class'.IsSome then
                    class'.Value
            ]

            div (class' = CssClass.combine classes)
