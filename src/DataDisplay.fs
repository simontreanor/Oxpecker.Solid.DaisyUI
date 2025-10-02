namespace Oxpecker.Solid.DaisyUI

open Fable.Core
open Oxpecker.Solid

/// DaisyUI Data Display components  
module DataDisplay =
    
    /// Badge component
    type badge =
        [<SolidComponent>]
        static member Invoke(?color: ColorVariant, ?size: Size, ?outline: bool) =
            let classes = [
                "badge"
                if outline = Some true then "badge-outline"
                if color.IsSome then CssClass.ofColorVariant "badge" color.Value
                if size.IsSome then CssClass.ofSize "badge" size.Value
            ]
            span(class' = CssClass.combine classes)
    
    /// Card component
    type card =
        [<SolidComponent>]
        static member Invoke(?bordered: bool, ?imageFull: bool, ?color: ColorVariant, ?compact: bool, ?side: bool) =
            let classes = [
                "card"
                if bordered = Some true then "card-bordered"
                if imageFull = Some true then "image-full"
                if compact = Some true then "card-compact"
                if side = Some true then "card-side"
                if color.IsSome then
                    match color.Value with
                    | Primary -> "bg-primary text-primary-content"
                    | Secondary -> "bg-secondary text-secondary-content"
                    | Accent -> "bg-accent text-accent-content"
                    | Neutral -> "bg-neutral text-neutral-content"
                    | _ -> ""
            ]
            div(class' = CssClass.combine classes)
    
    /// Card body component
    [<SolidComponent>]
    let cardBody() = div(class' = "card-body")
    
    /// Card title component
    [<SolidComponent>]
    let cardTitle() = h2(class' = "card-title")
    
    /// Card actions component
    [<SolidComponent>]
    let cardActions() = div(class' = "card-actions")
    
    /// Avatar component
    type avatar =
        [<SolidComponent>]
        static member Invoke(?online: bool, ?offline: bool, ?placeholder: bool) =
            let classes = [
                "avatar"
                if online = Some true then "online"
                if offline = Some true then "offline"
                if placeholder = Some true then "placeholder"
            ]
            div(class' = CssClass.combine classes)
    
    /// Stats container component
    type stats =
        [<SolidComponent>]
        static member Invoke(?vertical: bool, ?horizontal: bool) =
            let classes = [
                "stats"
                if vertical = Some true then "stats-vertical"
                if horizontal = Some true then "stats-horizontal"
            ]
            div(class' = CssClass.combine classes)
    
    /// Stat item component
    [<SolidComponent>]
    let stat() = div(class' = "stat")
    
    /// Table component - rename to avoid shadowing
    type daisy_table =
        [<SolidComponent>]
        static member Invoke(?zebra: bool, ?pinRows: bool, ?pinCols: bool, ?size: Size) =
            let classes = [
                "table"
                if zebra = Some true then "table-zebra"
                if pinRows = Some true then "table-pin-rows"
                if pinCols = Some true then "table-pin-cols"
                if size.IsSome then CssClass.ofSize "table" size.Value
            ]
            table(class' = CssClass.combine classes)
    
    /// Timeline component
    type timeline =
        [<SolidComponent>]
        static member Invoke(?vertical: bool, ?horizontal: bool, ?compact: bool) =
            let classes = [
                "timeline"
                if vertical = Some true then "timeline-vertical"
                if horizontal = Some true then "timeline-horizontal"
                if compact = Some true then "timeline-compact"
            ]
            ul(class' = CssClass.combine classes)
