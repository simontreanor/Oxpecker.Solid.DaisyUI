namespace Oxpecker.Solid.DaisyUI

open Fable.Core
open Oxpecker.Solid

/// DaisyUI Data Input components
module DataInput =
    
    /// Input element extensions
    type input with
        /// Apply checkbox styles
        [<Erase>]
        member this.checkbox(?color: ColorVariant, ?size: Size) =
            let classes = [
                "checkbox"
                if color.IsSome then
                    match color.Value with
                    | Primary -> "checkbox-primary"
                    | Secondary -> "checkbox-secondary"
                    | Accent -> "checkbox-accent"
                    | Success -> "checkbox-success"
                    | Warning -> "checkbox-warning"
                    | Info -> "checkbox-info"
                    | Error -> "checkbox-error"
                    | _ -> ""
                if size.IsSome then
                    match size.Value with
                    | ExtraSmall -> "checkbox-xs"
                    | Small -> "checkbox-sm"
                    | Medium -> "checkbox-md"
                    | Large -> "checkbox-lg"
                    | _ -> ""
            ]
            this.type' <- "checkbox"
            this.class' <- CssClass.combine classes
            this
        
        /// Apply radio styles
        [<Erase>]
        member this.radio(?color: ColorVariant, ?size: Size) =
            let classes = [
                "radio"
                if color.IsSome then
                    match color.Value with
                    | Primary -> "radio-primary"
                    | Secondary -> "radio-secondary"
                    | Accent -> "radio-accent"
                    | Success -> "radio-success"
                    | Warning -> "radio-warning"
                    | Info -> "radio-info"
                    | Error -> "radio-error"
                    | _ -> ""
                if size.IsSome then
                    match size.Value with
                    | ExtraSmall -> "radio-xs"
                    | Small -> "radio-sm"
                    | Medium -> "radio-md"
                    | Large -> "radio-lg"
                    | _ -> ""
            ]
            this.type' <- "radio"
            this.class' <- CssClass.combine classes
            this
        
        /// Apply text input styles
        [<Erase>]
        member this.textInput(?color: ColorVariant, ?size: Size, ?bordered: bool, ?ghost: bool) =
            let classes = [
                "input"
                if bordered = Some true then "input-bordered"
                if ghost = Some true then "input-ghost"
                if color.IsSome then
                    match color.Value with
                    | Primary -> "input-primary"
                    | Secondary -> "input-secondary"
                    | Accent -> "input-accent"
                    | Info -> "input-info"
                    | Success -> "input-success"
                    | Warning -> "input-warning"
                    | Error -> "input-error"
                    | _ -> ""
                if size.IsSome then
                    match size.Value with
                    | ExtraSmall -> "input-xs"
                    | Small -> "input-sm"
                    | Medium -> "input-md"
                    | Large -> "input-lg"
                    | _ -> ""
            ]
            this.type' <- "text"
            this.class' <- CssClass.combine classes
            this
        
        /// Apply range slider styles
        [<Erase>]
        member this.range(?color: ColorVariant, ?size: Size) =
            let classes = [
                "range"
                if color.IsSome then
                    match color.Value with
                    | Primary -> "range-primary"
                    | Secondary -> "range-secondary"
                    | Accent -> "range-accent"
                    | Success -> "range-success"
                    | Warning -> "range-warning"
                    | Info -> "range-info"
                    | Error -> "range-error"
                    | _ -> ""
                if size.IsSome then
                    match size.Value with
                    | ExtraSmall -> "range-xs"
                    | Small -> "range-sm"
                    | Medium -> "range-md"
                    | Large -> "range-lg"
                    | _ -> ""
            ]
            this.type' <- "range"
            this.class' <- CssClass.combine classes
            this
        
        /// Apply toggle styles
        [<Erase>]
        member this.toggle(?color: ColorVariant, ?size: Size) =
            let classes = [
                "toggle"
                if color.IsSome then
                    match color.Value with
                    | Primary -> "toggle-primary"
                    | Secondary -> "toggle-secondary"
                    | Accent -> "toggle-accent"
                    | Success -> "toggle-success"
                    | Warning -> "toggle-warning"
                    | Info -> "toggle-info"
                    | Error -> "toggle-error"
                    | _ -> ""
                if size.IsSome then
                    match size.Value with
                    | ExtraSmall -> "toggle-xs"
                    | Small -> "toggle-sm"
                    | Medium -> "toggle-md"
                    | Large -> "toggle-lg"
                    | _ -> ""
            ]
            this.type' <- "checkbox"
            this.class' <- CssClass.combine classes
            this
        
        /// Apply file input styles
        [<Erase>]
        member this.fileInput(?color: ColorVariant, ?size: Size, ?bordered: bool, ?ghost: bool) =
            let classes = [
                "file-input"
                if bordered = Some true then "file-input-bordered"
                if ghost = Some true then "file-input-ghost"
                if color.IsSome then
                    match color.Value with
                    | Primary -> "file-input-primary"
                    | Secondary -> "file-input-secondary"
                    | Accent -> "file-input-accent"
                    | Info -> "file-input-info"
                    | Success -> "file-input-success"
                    | Warning -> "file-input-warning"
                    | Error -> "file-input-error"
                    | _ -> ""
                if size.IsSome then
                    match size.Value with
                    | ExtraSmall -> "file-input-xs"
                    | Small -> "file-input-sm"
                    | Medium -> "file-input-md"
                    | Large -> "file-input-lg"
                    | _ -> ""
            ]
            this.type' <- "file"
            this.class' <- CssClass.combine classes
            this
    
    /// Textarea extensions
    type textarea with
        /// Apply textarea styles
        [<Erase>]
        member this.textarea(?color: ColorVariant, ?size: Size, ?bordered: bool, ?ghost: bool) =
            let classes = [
                "textarea"
                if bordered = Some true then "textarea-bordered"
                if ghost = Some true then "textarea-ghost"
                if color.IsSome then
                    match color.Value with
                    | Primary -> "textarea-primary"
                    | Secondary -> "textarea-secondary"
                    | Accent -> "textarea-accent"
                    | Info -> "textarea-info"
                    | Success -> "textarea-success"
                    | Warning -> "textarea-warning"
                    | Error -> "textarea-error"
                    | _ -> ""
                if size.IsSome then
                    match size.Value with
                    | ExtraSmall -> "textarea-xs"
                    | Small -> "textarea-sm"
                    | Medium -> "textarea-md"
                    | Large -> "textarea-lg"
                    | _ -> ""
            ]
            this.class' <- CssClass.combine classes
            this
    
    /// Select extensions
    type select with
        /// Apply select styles
        [<Erase>]
        member this.select(?color: ColorVariant, ?size: Size, ?bordered: bool, ?ghost: bool) =
            let classes = [
                "select"
                if bordered = Some true then "select-bordered"
                if ghost = Some true then "select-ghost"
                if color.IsSome then
                    match color.Value with
                    | Primary -> "select-primary"
                    | Secondary -> "select-secondary"
                    | Accent -> "select-accent"
                    | Info -> "select-info"
                    | Success -> "select-success"
                    | Warning -> "select-warning"
                    | Error -> "select-error"
                    | _ -> ""
                if size.IsSome then
                    match size.Value with
                    | ExtraSmall -> "select-xs"
                    | Small -> "select-sm"
                    | Medium -> "select-md"
                    | Large -> "select-lg"
                    | _ -> ""
            ]
            this.class' <- CssClass.combine classes
            this
    
    /// Rating container
    type div with
        /// Apply rating styles
        [<Erase>]
        member this.rating(?size: Size) =
            let classes = [
                "rating"
                if size.IsSome then
                    match size.Value with
                    | ExtraSmall -> "rating-xs"
                    | Small -> "rating-sm"
                    | Medium -> "rating-md"
                    | Large -> "rating-lg"
                    | ExtraLarge -> "rating-lg"
            ]
            this.class' <- CssClass.combine classes
            this
