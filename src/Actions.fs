namespace Oxpecker.Solid.DaisyUI

open Fable.Core
open Oxpecker.Solid

/// DaisyUI Actions components
module Actions =
    
    /// Creates a DaisyUI button element with optional modifiers
    type button with
        /// Apply button with color variant
        [<Erase>]
        member this.btn(?color: ColorVariant, ?size: Size, ?style: ButtonStyle, ?wide: bool, ?block: bool, ?circle: bool, ?square: bool, ?loading: bool, ?active: bool, ?noAnimation: bool) =
            let classes = [
                "btn"
                if color.IsSome then CssClass.ofColorVariant color.Value
                if size.IsSome then CssClass.ofSize size.Value
                if style.IsSome then CssClass.ofButtonStyle style.Value
                if wide = Some true then "btn-wide"
                if block = Some true then "btn-block"
                if circle = Some true then "btn-circle"
                if square = Some true then "btn-square"
                if loading = Some true then "loading"
                if active = Some true then "btn-active"
                if noAnimation = Some true then "no-animation"
            ]
            this.class' <- CssClass.combine classes
            this
    
    /// Creates a DaisyUI dropdown wrapper
    type div with
        /// Apply dropdown styles
        [<Erase>]
        member this.dropdown(?position: Position, ?hover: bool, ?isOpen: bool) =
            let classes = [
                "dropdown"
                if position.IsSome then CssClass.ofPosition position.Value
                if hover = Some true then "dropdown-hover"
                if isOpen = Some true then "dropdown-open"
            ]
            this.class' <- CssClass.combine classes
            this
        
        /// Apply modal styles
        [<Erase>]
        member this.modal(?isOpen: bool, ?bottom: bool, ?middle: bool) =
            let classes = [
                "modal"
                if isOpen = Some true then "modal-open"
                if bottom = Some true then "modal-bottom"
                if middle = Some true then "modal-middle"
            ]
            this.class' <- CssClass.combine classes
            this
        
        /// Apply modal box styles
        [<Erase>]
        member this.modalBox() =
            this.class' <- "modal-box"
            this
        
        /// Apply modal action styles
        [<Erase>]
        member this.modalAction() =
            this.class' <- "modal-action"
            this
        
        /// Apply swap styles
        [<Erase>]
        member this.swap(?active: bool, ?rotate: bool, ?flip: bool) =
            let classes = [
                "swap"
                if active = Some true then "swap-active"
                if rotate = Some true then "swap-rotate"
                if flip = Some true then "swap-flip"
            ]
            this.class' <- CssClass.combine classes
            this
        
        /// Apply swap-on styles
        [<Erase>]
        member this.swapOn() =
            this.class' <- "swap-on"
            this
        
        /// Apply swap-off styles
        [<Erase>]
        member this.swapOff() =
            this.class' <- "swap-off"
            this
    
    /// Creates a dropdown content container
    type ul with
        /// Apply dropdown content styles
        [<Erase>]
        member this.dropdownContent() =
            this.class' <- "dropdown-content menu bg-base-100 rounded-box z-[1] w-52 p-2 shadow"
            this
    
    /// Modal as dialog element
    type dialog with
        /// Apply modal styles
        [<Erase>]
        member this.modal(?isOpen: bool, ?bottom: bool, ?middle: bool) =
            let classes = [
                "modal"
                if isOpen = Some true then "modal-open"
                if bottom = Some true then "modal-bottom"
                if middle = Some true then "modal-middle"
            ]
            this.class' <- CssClass.combine classes
            this
    
    /// Swap as label element
    type label with
        /// Apply swap styles
        [<Erase>]
        member this.swap(?active: bool, ?rotate: bool, ?flip: bool) =
            let classes = [
                "swap"
                if active = Some true then "swap-active"
                if rotate = Some true then "swap-rotate"
                if flip = Some true then "swap-flip"
            ]
            this.class' <- CssClass.combine classes
            this
    
    /// Theme controller as input
    type input with
        /// Apply theme controller styles
        [<Erase>]
        member this.themeController(themeName: string) =
            this.type' <- "checkbox"
            this.class' <- "theme-controller"
            this.value <- themeName
            this

