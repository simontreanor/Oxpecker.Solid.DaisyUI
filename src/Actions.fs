namespace Oxpecker.Solid.DaisyUI

open Fable.Core
open Oxpecker.Solid

/// DaisyUI Action components
module Actions =
    
    /// Button builder  
    type btn =
        /// Invoke to create a DaisyUI button
        [<SolidComponent>]
        static member Invoke(?color: ColorVariant, ?size: Size, ?outline: bool, ?wide: bool,
                             ?block: bool, ?circle: bool, ?square: bool, ?glass: bool,
                             ?disabled: bool, ?loading: bool, ?active: bool) =
            let classes = [
                "btn"
                if outline = Some true then "btn-outline"
                if wide = Some true then "btn-wide"
                if block = Some true then "btn-block"
                if circle = Some true then "btn-circle"
                if square = Some true then "btn-square"
                if glass = Some true then "btn-glass"
                if loading = Some true then "loading"
                if active = Some true then "btn-active"
                if color.IsSome then CssClass.ofColorVariant "btn" color.Value
                if size.IsSome then CssClass.ofSize "btn" size.Value
            ]
            let htmlBtn : button = button(class' = CssClass.combine classes)
            if disabled = Some true then htmlBtn.disabled <- true
            htmlBtn
