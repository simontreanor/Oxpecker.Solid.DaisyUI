namespace Oxpecker.Solid.DaisyUI

open Fable.Core
open Oxpecker.Solid

/// DaisyUI Feedback components
module Feedback =
    
    /// DaisyUI Alert component
    [<SolidComponent>]
    let Alert (children: #HtmlElement) =
        div(class' = "alert") {
            children
        }
    
    /// DaisyUI Loading component
    [<SolidComponent>]
    let Loading () =
        span(class' = "loading loading-spinner")
    
    /// DaisyUI Progress component
    [<SolidComponent>]
    let Progress (value: int) (max: int) =
        progress(class' = "progress", value = string value, max = string max)
    
    /// DaisyUI Radial Progress component
    [<SolidComponent>]
    let RadialProgress (value: int) =
        div(class' = "radial-progress").attr("role", "progressbar").style'($"--value:{value}")
    
    /// DaisyUI Skeleton component
    [<SolidComponent>]
    let Skeleton () =
        div(class' = "skeleton")
    
    /// DaisyUI Tooltip component
    [<SolidComponent>]
    let Tooltip (tip: string) (children: #HtmlElement) =
        div(class' = "tooltip").data("tip", tip) {
            children
        }
