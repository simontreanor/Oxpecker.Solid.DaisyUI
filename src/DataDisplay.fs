namespace Oxpecker.Solid.DaisyUI

open Fable.Core
open Oxpecker.Solid

/// DaisyUI Data Display components
module DataDisplay =
    
    /// Badge component - Small status indicator
    type Badge =
        [<SolidComponent>]
        static member Invoke(?class': string, ?color: ColorVariant, ?size: Size, ?outline: bool) =
            let classes = [
                "badge"
                if outline = Some true then "badge-outline"
                if color.IsSome then CssClass.ofColorVariant "badge" color.Value
                if size.IsSome then CssClass.ofSize "badge" size.Value
                if class'.IsSome then class'.Value
            ]
            span(class' = CssClass.combine classes)
    
    /// Card component - Content container
    type Card =
        [<SolidComponent>]
        static member Invoke(?class': string, ?bordered: bool, ?imageFull: bool, ?color: ColorVariant, ?compact: bool, ?side: bool) =
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
                if class'.IsSome then class'.Value
            ]
            div(class' = CssClass.combine classes)
    
    /// Card body component
    type CardBody =
        [<SolidComponent>]
        static member Invoke(?class': string) = 
            let classes = ["card-body"; if class'.IsSome then class'.Value]
            div(class' = CssClass.combine classes)
    
    /// Card title component
    type CardTitle =
        [<SolidComponent>]
        static member Invoke(?class': string) = 
            let classes = ["card-title"; if class'.IsSome then class'.Value]
            h2(class' = CssClass.combine classes)
    
    /// Card actions component
    type CardActions =
        [<SolidComponent>]
        static member Invoke(?class': string) = 
            let classes = ["card-actions"; if class'.IsSome then class'.Value]
            div(class' = CssClass.combine classes)
    
    /// Avatar component - Profile image container
    type Avatar =
        [<SolidComponent>]
        static member Invoke(?class': string, ?online: bool, ?offline: bool, ?placeholder: bool) =
            let classes = [
                "avatar"
                if online = Some true then "online"
                if offline = Some true then "offline"
                if placeholder = Some true then "placeholder"
                if class'.IsSome then class'.Value
            ]
            div(class' = CssClass.combine classes)
    
    /// Stats container component
    type Stats =
        [<SolidComponent>]
        static member Invoke(?class': string, ?vertical: bool, ?horizontal: bool) =
            let classes = [
                "stats"
                if vertical = Some true then "stats-vertical"
                if horizontal = Some true then "stats-horizontal"
                if class'.IsSome then class'.Value
            ]
            div(class' = CssClass.combine classes)
    
    /// Stat item component
    type Stat =
        [<SolidComponent>]
        static member Invoke(?class': string) = 
            let classes = ["stat"; if class'.IsSome then class'.Value]
            div(class' = CssClass.combine classes)
    
    /// Stat figure component - Icon or image for the stat
    type StatFigure =
        [<SolidComponent>]
        static member Invoke(?class': string) =
            let classes = ["stat-figure"; if class'.IsSome then class'.Value]
            div(class' = CssClass.combine classes)
    
    /// Stat title component - Label for the stat
    type StatTitle =
        [<SolidComponent>]
        static member Invoke(?class': string) =
            let classes = ["stat-title"; if class'.IsSome then class'.Value]
            div(class' = CssClass.combine classes)
    
    /// Stat value component - Main value display
    type StatValue =
        [<SolidComponent>]
        static member Invoke(?class': string) =
            let classes = ["stat-value"; if class'.IsSome then class'.Value]
            div(class' = CssClass.combine classes)
    
    /// Stat description component - Additional info
    type StatDesc =
        [<SolidComponent>]
        static member Invoke(?class': string) =
            let classes = ["stat-desc"; if class'.IsSome then class'.Value]
            div(class' = CssClass.combine classes)
    
    /// Stat actions component - Action buttons for the stat
    type StatActions =
        [<SolidComponent>]
        static member Invoke(?class': string) =
            let classes = ["stat-actions"; if class'.IsSome then class'.Value]
            div(class' = CssClass.combine classes)
    
    /// Table component - Data table (no conflict with PascalCase)
    type Table =
        [<SolidComponent>]
        static member Invoke(?class': string, ?zebra: bool, ?pinRows: bool, ?pinCols: bool, ?size: Size) =
            let classes = [
                "table"
                if zebra = Some true then "table-zebra"
                if pinRows = Some true then "table-pin-rows"
                if pinCols = Some true then "table-pin-cols"
                if size.IsSome then CssClass.ofSize "table" size.Value
                if class'.IsSome then class'.Value
            ]
            table(class' = CssClass.combine classes)
    
    /// Timeline component - Event timeline
    type Timeline =
        [<SolidComponent>]
        static member Invoke(?class': string, ?vertical: bool, ?horizontal: bool, ?compact: bool) =
            let classes = [
                "timeline"
                if vertical = Some true then "timeline-vertical"
                if horizontal = Some true then "timeline-horizontal"
                if compact = Some true then "timeline-compact"
                if class'.IsSome then class'.Value
            ]
            ul(class' = CssClass.combine classes)
