namespace Oxpecker.Solid.DaisyUI

open Fable.Core
open Oxpecker.Solid

/// DaisyUI Action components
module Actions =
    
    /// Button component - Primary action element
    type Button =
        /// Invoke to create a DaisyUI button
        [<SolidComponent>]
        static member Invoke(?class': string, ?color: ColorVariant, ?size: Size, ?outline: bool, ?wide: bool,
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
                if class'.IsSome then class'.Value
            ]
            let htmlBtn : button = button(class' = CssClass.combine classes)
            if disabled = Some true then htmlBtn.disabled <- true
            htmlBtn
    
    /// Dropdown container component
    type Dropdown =
        [<SolidComponent>]
        static member Invoke(?class': string, ?hover: bool, ?``open``: bool, ?top: bool, ?bottom: bool, 
                             ?left: bool, ?right: bool, ?``end``: bool) =
            let classes = [
                "dropdown"
                if hover = Some true then "dropdown-hover"
                if ``open`` = Some true then "dropdown-open"
                if top = Some true then "dropdown-top"
                if bottom = Some true then "dropdown-bottom"
                if left = Some true then "dropdown-left"
                if right = Some true then "dropdown-right"
                if ``end`` = Some true then "dropdown-end"
                if class'.IsSome then class'.Value
            ]
            div(class' = CssClass.combine classes)
    
    /// Dropdown content component - The content part of dropdown
    type DropdownContent =
        [<SolidComponent>]
        static member Invoke(?class': string) =
            let classes = ["dropdown-content"; if class'.IsSome then class'.Value]
            div(class' = CssClass.combine classes)
    
    /// Modal component - Dialog box
    type Modal =
        [<SolidComponent>]
        static member Invoke(?class': string, ?``open``: bool, ?top: bool, ?middle: bool, ?bottom: bool) =
            let classes = [
                "modal"
                if ``open`` = Some true then "modal-open"
                if top = Some true then "modal-top"
                if middle = Some true then "modal-middle"
                if bottom = Some true then "modal-bottom"
                if class'.IsSome then class'.Value
            ]
            dialog(class' = CssClass.combine classes)
    
    /// Modal box component - The content part of modal
    type ModalBox =
        [<SolidComponent>]
        static member Invoke(?class': string) =
            let classes = ["modal-box"; if class'.IsSome then class'.Value]
            div(class' = CssClass.combine classes)
    
    /// Modal action component - Actions part (buttons, etc.) of modal
    type ModalAction =
        [<SolidComponent>]
        static member Invoke(?class': string) =
            let classes = ["modal-action"; if class'.IsSome then class'.Value]
            div(class' = CssClass.combine classes)
    
    /// Modal backdrop component - Backdrop that covers the page
    type ModalBackdrop =
        [<SolidComponent>]
        static member Invoke(?class': string) =
            let classes = ["modal-backdrop"; if class'.IsSome then class'.Value]
            form(class' = CssClass.combine classes)
    
    /// Swap component - Toggle visibility of two elements
    type Swap =
        [<SolidComponent>]
        static member Invoke(?class': string, ?active: bool, ?rotate: bool, ?flip: bool) =
            let classes = [
                "swap"
                if active = Some true then "swap-active"
                if rotate = Some true then "swap-rotate"
                if flip = Some true then "swap-flip"
                if class'.IsSome then class'.Value
            ]
            label(class' = CssClass.combine classes)
    
    /// Swap on component - Element visible when swap is active
    type SwapOn =
        [<SolidComponent>]
        static member Invoke(?class': string) =
            let classes = ["swap-on"; if class'.IsSome then class'.Value]
            div(class' = CssClass.combine classes)
    
    /// Swap off component - Element visible when swap is not active
    type SwapOff =
        [<SolidComponent>]
        static member Invoke(?class': string) =
            let classes = ["swap-off"; if class'.IsSome then class'.Value]
            div(class' = CssClass.combine classes)
    
    /// Swap indeterminate component - Element visible when swap is indeterminate
    type SwapIndeterminate =
        [<SolidComponent>]
        static member Invoke(?class': string) =
            let classes = ["swap-indeterminate"; if class'.IsSome then class'.Value]
            div(class' = CssClass.combine classes)
    
    /// FAB component - Floating Action Button
    type Fab =
        [<SolidComponent>]
        static member Invoke(?class': string, ?flower: bool) =
            let classes = [
                "fab"
                if flower = Some true then "fab-flower"
                if class'.IsSome then class'.Value
            ]
            div(class' = CssClass.combine classes)
    
    /// FAB close button component - Close button for FAB
    type FabClose =
        [<SolidComponent>]
        static member Invoke(?class': string) =
            let classes = ["fab-close"; if class'.IsSome then class'.Value]
            div(class' = CssClass.combine classes)
    
    /// FAB main action component - Main action button for FAB
    type FabMainAction =
        [<SolidComponent>]
        static member Invoke(?class': string) =
            let classes = ["fab-main-action"; if class'.IsSome then class'.Value]
            div(class' = CssClass.combine classes)
    
    /// Collapse component - Show/hide content
    type Collapse =
        [<SolidComponent>]
        static member Invoke(?class': string, ?arrow: bool, ?plus: bool, ?``open``: bool, ?close: bool) =
            let classes = [
                "collapse"
                if arrow = Some true then "collapse-arrow"
                if plus = Some true then "collapse-plus"
                if ``open`` = Some true then "collapse-open"
                if close = Some true then "collapse-close"
                if class'.IsSome then class'.Value
            ]
            div(class' = CssClass.combine classes)
    
    /// Collapse title component - Title part of collapse
    type CollapseTitle =
        [<SolidComponent>]
        static member Invoke(?class': string) =
            let classes = ["collapse-title"; if class'.IsSome then class'.Value]
            div(class' = CssClass.combine classes)
    
    /// Collapse content component - Content part of collapse
    type CollapseContent =
        [<SolidComponent>]
        static member Invoke(?class': string) =
            let classes = ["collapse-content"; if class'.IsSome then class'.Value]
            div(class' = CssClass.combine classes)
