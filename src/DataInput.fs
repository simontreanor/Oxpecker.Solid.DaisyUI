namespace Oxpecker.Solid.DaisyUI

open Fable.Core
open Oxpecker.Solid

/// DaisyUI Data Input components
module DataInput =
    
    /// DaisyUI Checkbox component
    [<SolidComponent>]
    let Checkbox (children: #HtmlElement) =
        input(type' = "checkbox", class' = "checkbox")
    
    /// DaisyUI Radio component
    [<SolidComponent>]
    let Radio (name: string) =
        input(type' = "radio", class' = "radio", name = name)
    
    /// DaisyUI Text Input component
    [<SolidComponent>]
    let TextInput (placeholder: string) =
        input(type' = "text", class' = "input input-bordered", placeholder = placeholder)
    
    /// DaisyUI Textarea component
    [<SolidComponent>]
    let Textarea (placeholder: string) =
        textarea(class' = "textarea textarea-bordered", placeholder = placeholder)
    
    /// DaisyUI Select component
    [<SolidComponent>]
    let Select (children: #HtmlElement) =
        select(class' = "select select-bordered") {
            children
        }
    
    /// DaisyUI Range component
    [<SolidComponent>]
    let Range (min: int) (max: int) =
        input(type' = "range", class' = "range", min = string min, max = string max)
    
    /// DaisyUI Toggle component
    [<SolidComponent>]
    let Toggle () =
        input(type' = "checkbox", class' = "toggle")
    
    /// DaisyUI File Input component
    [<SolidComponent>]
    let FileInput () =
        input(type' = "file", class' = "file-input file-input-bordered")
    
    /// DaisyUI Rating component
    [<SolidComponent>]
    let Rating (children: #HtmlElement) =
        div(class' = "rating") {
            children
        }
