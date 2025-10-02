namespace Oxpecker.Solid.DaisyUI

open Fable.Core
open Oxpecker.Solid

/// DaisyUI Navigation components
module Navigation =
    
    /// DaisyUI Breadcrumbs component
    [<SolidComponent>]
    let Breadcrumbs (children: #HtmlElement) =
        div(class' = "breadcrumbs") {
            children
        }
    
    /// DaisyUI Bottom Navigation component
    [<SolidComponent>]
    let BottomNav (children: #HtmlElement) =
        div(class' = "btm-nav") {
            children
        }
    
    /// DaisyUI Link component
    [<SolidComponent>]
    let Link (href: string) (children: #HtmlElement) =
        a(class' = "link", href = href) {
            children
        }
    
    /// DaisyUI Menu component
    [<SolidComponent>]
    let Menu (children: #HtmlElement) =
        ul(class' = "menu") {
            children
        }
    
    /// DaisyUI Navbar component
    [<SolidComponent>]
    let Navbar (children: #HtmlElement) =
        div(class' = "navbar") {
            children
        }
    
    /// DaisyUI Pagination component
    [<SolidComponent>]
    let Pagination (children: #HtmlElement) =
        div(class' = "join") {
            children
        }
    
    /// DaisyUI Steps component
    [<SolidComponent>]
    let Steps (children: #HtmlElement) =
        ul(class' = "steps") {
            children
        }
    
    /// DaisyUI Tab component
    [<SolidComponent>]
    let Tabs (children: #HtmlElement) =
        div(class' = "tabs") {
            children
        }
