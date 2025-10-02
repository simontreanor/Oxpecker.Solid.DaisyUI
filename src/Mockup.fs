namespace Oxpecker.Solid.DaisyUI

open Fable.Core
open Oxpecker.Solid

/// DaisyUI Mockup components
module Mockup =

    /// Browser mockup component - Shows a box that looks like a browser window
    type MockupBrowser =
        [<SolidComponent>]
        static member Invoke(?class': string) =
            let classes = [
                "mockup-browser"
                if class'.IsSome then
                    class'.Value
            ]

            div (class' = CssClass.combine classes)

    /// Browser toolbar component - Toolbar part which can include addressbar, etc
    type MockupBrowserToolbar =
        [<SolidComponent>]
        static member Invoke(?class': string) =
            let classes = [
                "mockup-browser-toolbar"
                if class'.IsSome then
                    class'.Value
            ]

            div (class' = CssClass.combine classes)

    /// Code mockup component - Shows a block of code in a box that looks like a code editor
    type MockupCode =
        [<SolidComponent>]
        static member Invoke(?class': string) =
            let classes = [
                "mockup-code"
                if class'.IsSome then
                    class'.Value
            ]

            div (class' = CssClass.combine classes)

    /// Phone mockup component - Shows a mockup of an iPhone
    type MockupPhone =
        [<SolidComponent>]
        static member Invoke(?class': string) =
            let classes = [
                "mockup-phone"
                if class'.IsSome then
                    class'.Value
            ]

            div (class' = CssClass.combine classes)

    /// Phone camera component - Camera part of phone mockup
    type MockupPhoneCamera =
        [<SolidComponent>]
        static member Invoke(?class': string) =
            let classes = [
                "camera"
                if class'.IsSome then
                    class'.Value
            ]

            div (class' = CssClass.combine classes)

    /// Phone display component - Display part of phone mockup
    type MockupPhoneDisplay =
        [<SolidComponent>]
        static member Invoke(?class': string) =
            let classes = [
                "display"
                if class'.IsSome then
                    class'.Value
            ]

            div (class' = CssClass.combine classes)

    /// Window mockup component - Shows a box that looks like an operating system window
    type MockupWindow =
        [<SolidComponent>]
        static member Invoke(?class': string) =
            let classes = [
                "mockup-window"
                if class'.IsSome then
                    class'.Value
            ]

            div (class' = CssClass.combine classes)
