namespace Oxpecker.Solid.DaisyUI

open Fable.Core
open Oxpecker.Solid

/// DaisyUI Data Input components
module DataInput =
    
    /// Form control component - Wrapper for form inputs
    type FormControl =
        [<SolidComponent>]
        static member Invoke(?class': string) =
            let classes = ["form-control"; if class'.IsSome then class'.Value]
            div(class' = CssClass.combine classes)
    
    /// Label component - Form label
    type Label =
        [<SolidComponent>]
        static member Invoke(?class': string) =
            let classes = ["label"; if class'.IsSome then class'.Value]
            label(class' = CssClass.combine classes)
    
    /// Label text component - Text for labels
    type LabelText =
        [<SolidComponent>]
        static member Invoke(?class': string) =
            let classes = ["label-text"; if class'.IsSome then class'.Value]
            span(class' = CssClass.combine classes)
    
    /// Label text alt component - Alternative/helper text for labels
    type LabelTextAlt =
        [<SolidComponent>]
        static member Invoke(?class': string) =
            let classes = ["label-text-alt"; if class'.IsSome then class'.Value]
            span(class' = CssClass.combine classes)
    
    /// Checkbox component - Checkbox input
    type Checkbox =
        [<SolidComponent>]
        static member Invoke(?class': string, ?color: ColorVariant, ?size: Size) =
            let classes = [
                "checkbox"
                if color.IsSome then CssClass.ofColorVariant "checkbox" color.Value
                if size.IsSome then CssClass.ofSize "checkbox" size.Value
                if class'.IsSome then class'.Value
            ]
            input(class' = CssClass.combine classes, type' = "checkbox")
    
    /// Radio button component
    type Radio =
        [<SolidComponent>]
        static member Invoke(?class': string, ?name: string, ?color: ColorVariant, ?size: Size) =
            let classes = [
                "radio"
                if color.IsSome then CssClass.ofColorVariant "radio" color.Value
                if size.IsSome then CssClass.ofSize "radio" size.Value
                if class'.IsSome then class'.Value
            ]
            let inp : input = input(class' = CssClass.combine classes, type' = "radio")
            if name.IsSome then inp.name <- name.Value
            inp
    
    /// Text input component
    type TextInput =
        [<SolidComponent>]
        static member Invoke(?class': string, ?placeholder: string, ?bordered: bool, ?ghost: bool, ?color: ColorVariant, ?size: Size) =
            let classes = [
                "input"
                if bordered = Some true then "input-bordered"
                if ghost = Some true then "input-ghost"
                if color.IsSome then CssClass.ofColorVariant "input" color.Value
                if size.IsSome then CssClass.ofSize "input" size.Value
                if class'.IsSome then class'.Value
            ]
            let inp : input = input(class' = CssClass.combine classes, type' = "text")
            if placeholder.IsSome then inp.placeholder <- placeholder.Value
            inp
    
    /// Textarea component
    type Textarea =
        [<SolidComponent>]
        static member Invoke(?class': string, ?placeholder: string, ?bordered: bool, ?ghost: bool, ?color: ColorVariant, ?size: Size, ?rows: int) =
            let classes = [
                "textarea"
                if bordered = Some true then "textarea-bordered"
                if ghost = Some true then "textarea-ghost"
                if color.IsSome then CssClass.ofColorVariant "textarea" color.Value
                if size.IsSome then CssClass.ofSize "textarea" size.Value
                if class'.IsSome then class'.Value
            ]
            let ta : textarea = textarea(class' = CssClass.combine classes)
            let ta = if placeholder.IsSome then ta.placeholder <- placeholder.Value; ta else ta
            if rows.IsSome then ta.rows <- rows.Value; ta else ta
    
    /// Select component (no conflict with PascalCase)
    type Select =
        [<SolidComponent>]
        static member Invoke(?class': string, ?bordered: bool, ?ghost: bool, ?color: ColorVariant, ?size: Size) =
            let classes = [
                "select"
                if bordered = Some true then "select-bordered"
                if ghost = Some true then "select-ghost"
                if color.IsSome then CssClass.ofColorVariant "select" color.Value
                if size.IsSome then CssClass.ofSize "select" size.Value
                if class'.IsSome then class'.Value
            ]
            select(class' = CssClass.combine classes)
    
    /// Range slider component
    type Range =
        [<SolidComponent>]
        static member Invoke(?class': string, ?min: int, ?max: int, ?step: int, ?color: ColorVariant, ?size: Size) =
            let classes = [
                "range"
                if color.IsSome then CssClass.ofColorVariant "range" color.Value
                if size.IsSome then CssClass.ofSize "range" size.Value
                if class'.IsSome then class'.Value
            ]
            let rng : input = input(class' = CssClass.combine classes, type' = "range")
            let rng = if min.IsSome then rng.min <- string min.Value; rng else rng
            let rng = if max.IsSome then rng.max <- string max.Value; rng else rng
            if step.IsSome then rng.step <- string step.Value; rng else rng
    
    /// Toggle switch component
    type Toggle =
        [<SolidComponent>]
        static member Invoke(?class': string, ?color: ColorVariant, ?size: Size) =
            let classes = [
                "toggle"
                if color.IsSome then CssClass.ofColorVariant "toggle" color.Value
                if size.IsSome then CssClass.ofSize "toggle" size.Value
                if class'.IsSome then class'.Value
            ]
            input(class' = CssClass.combine classes, type' = "checkbox")
    
    /// File input component
    type FileInput =
        [<SolidComponent>]
        static member Invoke(?class': string, ?bordered: bool, ?ghost: bool, ?color: ColorVariant, ?size: Size) =
            let classes = [
                "file-input"
                if bordered = Some true then "file-input-bordered"
                if ghost = Some true then "file-input-ghost"
                if color.IsSome then CssClass.ofColorVariant "file-input" color.Value
                if size.IsSome then CssClass.ofSize "file-input" size.Value
                if class'.IsSome then class'.Value
            ]
            input(class' = CssClass.combine classes, type' = "file")
    
    /// Rating component
    type Rating =
        [<SolidComponent>]
        static member Invoke(?class': string, ?size: Size, ?half: bool) =
            let classes = [
                "rating"
                if half = Some true then "rating-half"
                if size.IsSome then CssClass.ofSize "rating" size.Value
                if class'.IsSome then class'.Value
            ]
            div(class' = CssClass.combine classes)
    
    /// Kbd component - Display keyboard shortcuts
    type Kbd =
        [<SolidComponent>]
        static member Invoke(?class': string, ?size: Size) =
            let classes = [
                "kbd"
                if size.IsSome then CssClass.ofSize "kbd" size.Value
                if class'.IsSome then class'.Value
            ]
            kbd(class' = CssClass.combine classes)
    
    /// Filter component - Group of radio buttons for filtering
    type Filter =
        [<SolidComponent>]
        static member Invoke(?class': string) =
            let classes = ["filter"; if class'.IsSome then class'.Value]
            div(class' = CssClass.combine classes)
    
    /// Filter reset component - Alternative to reset button (when not using HTML form)
    type FilterReset =
        [<SolidComponent>]
        static member Invoke(?class': string) =
            let classes = ["filter-reset"; if class'.IsSome then class'.Value]
            button(class' = CssClass.combine classes)
    
    /// Fieldset component - Container for grouping related form elements
    type Fieldset =
        [<SolidComponent>]
        static member Invoke(?class': string) =
            let classes = ["fieldset"; if class'.IsSome then class'.Value]
            fieldset(class' = CssClass.combine classes)
    
    /// Fieldset legend component - Title for the fieldset
    type FieldsetLegend =
        [<SolidComponent>]
        static member Invoke(?class': string) =
            let classes = ["fieldset-legend"; if class'.IsSome then class'.Value]
            legend(class' = CssClass.combine classes)
