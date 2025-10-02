namespace Oxpecker.Solid.DaisyUI

open Fable.Core
open Oxpecker.Solid

/// DaisyUI Layout components
module Layout =
    
    /// DaisyUI Artboard component
    [<SolidComponent>]
    let Artboard (children: #HtmlElement) =
        div(class' = "artboard") {
            children
        }
    
    /// DaisyUI Divider component
    [<SolidComponent>]
    let Divider (text: string) =
        div(class' = "divider") {
            text
        }
    
    /// DaisyUI Drawer component
    [<SolidComponent>]
    let Drawer (children: #HtmlElement) =
        div(class' = "drawer") {
            children
        }
    
    /// DaisyUI Footer component
    [<SolidComponent>]
    let Footer (children: #HtmlElement) =
        footer(class' = "footer") {
            children
        }
    
    /// DaisyUI Hero component
    [<SolidComponent>]
    let Hero (children: #HtmlElement) =
        div(class' = "hero") {
            children
        }
    
    /// DaisyUI Indicator component
    [<SolidComponent>]
    let Indicator (children: #HtmlElement) =
        div(class' = "indicator") {
            children
        }
    
    /// DaisyUI Join component
    [<SolidComponent>]
    let Join (children: #HtmlElement) =
        div(class' = "join") {
            children
        }
    
    /// DaisyUI Stack component
    [<SolidComponent>]
    let Stack (children: #HtmlElement) =
        div(class' = "stack") {
            children
        }
    
    /// DaisyUI Toast component
    [<SolidComponent>]
    let Toast (children: #HtmlElement) =
        div(class' = "toast") {
            children
        }
