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
        static member Invoke(?class': string, ?status: AvatarStatus, ?placeholder: bool) =
            let classes = [
                "avatar"
                if status.IsSome then
                    match status.Value with
                    | Online -> "online"
                    | Offline -> "offline"
                if placeholder = Some true then "placeholder"
                if class'.IsSome then class'.Value
            ]
            div(class' = CssClass.combine classes)
    
    /// Stats container component
    type Stats =
        [<SolidComponent>]
        static member Invoke(?class': string, ?orientation: Orientation) =
            let classes = [
                "stats"
                if orientation.IsSome then
                    match orientation.Value with
                    | Vertical -> "stats-vertical"
                    | Horizontal -> "stats-horizontal"
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
        static member Invoke(?class': string, ?orientation: Orientation, ?compact: bool) =
            let classes = [
                "timeline"
                if orientation.IsSome then
                    match orientation.Value with
                    | Vertical -> "timeline-vertical"
                    | Horizontal -> "timeline-horizontal"
                if compact = Some true then "timeline-compact"
                if class'.IsSome then class'.Value
            ]
            ul(class' = CssClass.combine classes)
    
    /// Chat component - Container for one line of conversation
    type Chat =
        [<SolidComponent>]
        static member Invoke(?class': string, ?alignment: Alignment) =
            let classes = [
                "chat"
                if alignment.IsSome then
                    match alignment.Value with
                    | AlignStart -> "chat-start"
                    | AlignEnd -> "chat-end"
                if class'.IsSome then class'.Value
            ]
            div(class' = CssClass.combine classes)
    
    /// Chat image component - Author image in chat
    type ChatImage =
        [<SolidComponent>]
        static member Invoke(?class': string) =
            let classes = ["chat-image"; if class'.IsSome then class'.Value]
            div(class' = CssClass.combine classes)
    
    /// Chat header component - Text above the chat bubble
    type ChatHeader =
        [<SolidComponent>]
        static member Invoke(?class': string) =
            let classes = ["chat-header"; if class'.IsSome then class'.Value]
            div(class' = CssClass.combine classes)
    
    /// Chat footer component - Text below the chat bubble
    type ChatFooter =
        [<SolidComponent>]
        static member Invoke(?class': string) =
            let classes = ["chat-footer"; if class'.IsSome then class'.Value]
            div(class' = CssClass.combine classes)
    
    /// Chat bubble component - The actual chat message bubble
    type ChatBubble =
        [<SolidComponent>]
        static member Invoke(?class': string, ?color: ColorVariant) =
            let classes = [
                "chat-bubble"
                if color.IsSome then CssClass.ofColorVariant "chat-bubble" color.Value
                if class'.IsSome then class'.Value
            ]
            div(class' = CssClass.combine classes)
    
    /// Carousel component - Shows images or content in a scrollable area
    type Carousel =
        [<SolidComponent>]
        static member Invoke(?class': string, ?snap: CarouselSnap, ?vertical: bool) =
            let classes = [
                "carousel"
                if snap.IsSome then
                    match snap.Value with
                    | SnapCenter -> "carousel-center"
                    | SnapEnd -> "carousel-end"
                if vertical = Some true then "carousel-vertical"
                if class'.IsSome then class'.Value
            ]
            div(class' = CssClass.combine classes)
    
    /// Carousel item component - Item in carousel
    type CarouselItem =
        [<SolidComponent>]
        static member Invoke(?class': string) =
            let classes = ["carousel-item"; if class'.IsSome then class'.Value]
            div(class' = CssClass.combine classes)
    
    /// Countdown component - Countdown timer with transition effect
    type Countdown =
        [<SolidComponent>]
        static member Invoke(?class': string) =
            let classes = ["countdown"; if class'.IsSome then class'.Value]
            span(class' = CssClass.combine classes)
    
    /// Diff component - Side-by-side comparison container
    type Diff =
        [<SolidComponent>]
        static member Invoke(?class': string) =
            let classes = ["diff"; if class'.IsSome then class'.Value]
            div(class' = CssClass.combine classes)
    
    /// Diff item 1 component - First item in diff
    type DiffItem1 =
        [<SolidComponent>]
        static member Invoke(?class': string) =
            let classes = ["diff-item-1"; if class'.IsSome then class'.Value]
            div(class' = CssClass.combine classes)
    
    /// Diff item 2 component - Second item in diff
    type DiffItem2 =
        [<SolidComponent>]
        static member Invoke(?class': string) =
            let classes = ["diff-item-2"; if class'.IsSome then class'.Value]
            div(class' = CssClass.combine classes)
    
    /// Diff resizer component - The resizer control in diff
    type DiffResizer =
        [<SolidComponent>]
        static member Invoke(?class': string) =
            let classes = ["diff-resizer"; if class'.IsSome then class'.Value]
            div(class' = CssClass.combine classes)
    
    /// Mask component - Crops content to common shapes
    type Mask =
        [<SolidComponent>]
        static member Invoke(?class': string, ?variant: string, ?half1: bool, ?half2: bool) =
            let classes = [
                "mask"
                match variant with
                | Some "squircle" -> "mask-squircle"
                | Some "heart" -> "mask-heart"
                | Some "hexagon" -> "mask-hexagon"
                | Some "hexagon-2" -> "mask-hexagon-2"
                | Some "decagon" -> "mask-decagon"
                | Some "pentagon" -> "mask-pentagon"
                | Some "diamond" -> "mask-diamond"
                | Some "square" -> "mask-square"
                | Some "circle" -> "mask-circle"
                | Some "star" -> "mask-star"
                | Some "star-2" -> "mask-star-2"
                | Some "triangle" -> "mask-triangle"
                | Some "triangle-2" -> "mask-triangle-2"
                | Some "triangle-3" -> "mask-triangle-3"
                | Some "triangle-4" -> "mask-triangle-4"
                | _ -> ""
                if half1 = Some true then "mask-half-1"
                if half2 = Some true then "mask-half-2"
                if class'.IsSome then class'.Value
            ]
            div(class' = CssClass.combine classes)
    
    /// List component - Vertical layout to display information in rows
    type List =
        [<SolidComponent>]
        static member Invoke(?class': string) =
            let classes = ["list"; if class'.IsSome then class'.Value]
            ul(class' = CssClass.combine classes)
    
    /// ListRow part - List item row
    type ListRow =
        [<SolidComponent>]
        static member Invoke(?class': string) =
            let classes = ["list-row"; if class'.IsSome then class'.Value]
            li(class' = CssClass.combine classes)
    
    /// Status component - Small icon showing current status
    type Status =
        [<SolidComponent>]
        static member Invoke(?class': string) =
            let classes = ["status"; if class'.IsSome then class'.Value]
            div(class' = CssClass.combine classes)
    
    /// HoverGallery component - Image gallery that reveals images on horizontal hover
    type HoverGallery =
        [<SolidComponent>]
        static member Invoke(?class': string) =
            let classes = ["hover-gallery"; if class'.IsSome then class'.Value]
            div(class' = CssClass.combine classes)
