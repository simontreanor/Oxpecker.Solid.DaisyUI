namespace Oxpecker.Solid.DaisyUI

open Fable.Core
open Oxpecker.Solid

/// DaisyUI Data Display components
module DataDisplay =
    
    /// DaisyUI Badge component
    [<SolidComponent>]
    let Badge (children: #HtmlElement) =
        span(class' = "badge") {
            children
        }
    
    /// DaisyUI Card component
    [<SolidComponent>]
    let Card (children: #HtmlElement) =
        div(class' = "card") {
            children
        }
    
    /// Card body
    [<SolidComponent>]
    let CardBody (children: #HtmlElement) =
        div(class' = "card-body") {
            children
        }
    
    /// Card title
    [<SolidComponent>]
    let CardTitle (children: #HtmlElement) =
        h2(class' = "card-title") {
            children
        }
    
    /// Avatar component
    [<SolidComponent>]
    let Avatar (children: #HtmlElement) =
        div(class' = "avatar") {
            children
        }
    
    /// Stat component
    [<SolidComponent>]
    let Stat (children: #HtmlElement) =
        div(class' = "stat") {
            children
        }
    
    /// Stats container
    [<SolidComponent>]
    let Stats (children: #HtmlElement) =
        div(class' = "stats") {
            children
        }
    
    /// Table component
    [<SolidComponent>]
    let Table (children: #HtmlElement) =
        table(class' = "table") {
            children
        }
    
    /// Timeline component
    [<SolidComponent>]
    let Timeline (children: #HtmlElement) =
        ul(class' = "timeline") {
            children
        }

