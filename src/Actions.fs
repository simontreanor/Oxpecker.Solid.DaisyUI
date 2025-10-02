namespace Oxpecker.Solid.DaisyUI

open Fable.Core
open Oxpecker.Solid

/// DaisyUI Actions components
module Actions =
    
    /// DaisyUI Button component
    type DaisyButton() =
        member val color: ColorVariant option = None with get, set
        member val size: Size option = None with get, set
        member val style: ButtonStyle option = None with get, set
        member val wide = false with get, set
        member val block = false with get, set
        member val circle = false with get, set
        member val square = false with get, set
        member val loading = false with get, set
        member val disabled = false with get, set
        member val active = false with get, set
        member val noAnimation = false with get, set
        
        [<SolidComponent>]
        member this.render(children: #HtmlElement) =
            let classes = [
                "btn"
                if this.color.IsSome then CssClass.ofColorVariant this.color.Value
                if this.size.IsSome then CssClass.ofSize this.size.Value
                if this.style.IsSome then CssClass.ofButtonStyle this.style.Value
                if this.wide then "btn-wide"
                if this.block then "btn-block"
                if this.circle then "btn-circle"
                if this.square then "btn-square"
                if this.loading then "loading"
                if this.active then "btn-active"
                if this.noAnimation then "no-animation"
            ]
            
            button(class' = CssClass.combine classes).bool("disabled", this.disabled) {
                children
            }
    
    /// DaisyUI Dropdown component  
    type DaisyDropdown() =
        member val position: Position option = None with get, set
        member val hover = false with get, set
        member val isOpen = false with get, set
        
        [<SolidComponent>]
        member this.render(children: #HtmlElement) =
            let classes = [
                "dropdown"
                if this.position.IsSome then CssClass.ofPosition this.position.Value
                if this.hover then "dropdown-hover"
                if this.isOpen then "dropdown-open"
            ]
            
            div(class' = CssClass.combine classes) {
                children
            }
    
    /// Create a dropdown content container
    [<SolidComponent>]
    let DropdownContent (children: #HtmlElement) =
        ul(class' = "dropdown-content menu bg-base-100 rounded-box z-[1] w-52 p-2 shadow") {
            children
        }
    
    /// DaisyUI Modal component
    type DaisyModal() =
        member val isOpen = false with get, set
        member val bottom = false with get, set
        member val middle = false with get, set
        
        [<SolidComponent>]
        member this.render(children: #HtmlElement) =
            let classes = [
                "modal"
                if this.isOpen then "modal-open"
                if this.bottom then "modal-bottom"
                if this.middle then "modal-middle"
            ]
            
            dialog(class' = CssClass.combine classes) {
                children
            }
    
    /// Create a modal box
    [<SolidComponent>]
    let ModalBox (children: #HtmlElement) =
        div(class' = "modal-box") {
            children
        }
    
    /// Create a modal action area
    [<SolidComponent>]
    let ModalAction (children: #HtmlElement) =
        div(class' = "modal-action") {
            children
        }
    
    /// Create a modal backdrop
    [<SolidComponent>]
    let ModalBackdrop() =
        form(method = "dialog", class' = "modal-backdrop")
    
    /// DaisyUI Swap component
    type DaisySwap() =
        member val active = false with get, set
        member val rotate = false with get, set
        member val flip = false with get, set
        
        [<SolidComponent>]
        member this.render(children: #HtmlElement) =
            let classes = [
                "swap"
                if this.active then "swap-active"
                if this.rotate then "swap-rotate"
                if this.flip then "swap-flip"
            ]
            
            label(class' = CssClass.combine classes) {
                children
            }
    
    /// Create a swap on element
    [<SolidComponent>]
    let SwapOn (children: #HtmlElement) =
        div(class' = "swap-on") {
            children
        }
    
    /// Create a swap off element
    [<SolidComponent>]
    let SwapOff (children: #HtmlElement) =
        div(class' = "swap-off") {
            children
        }
    
    /// Theme controller component
    [<SolidComponent>]
    let ThemeController (themeName: string) =
        input(type' = "checkbox", class' = "theme-controller", value = themeName)

