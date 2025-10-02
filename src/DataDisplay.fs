namespace Oxpecker.Solid.DaisyUI

open Fable.Core
open Oxpecker.Solid

/// DaisyUI Data Display components
module DataDisplay =
    
    /// Badge extensions
    type span with
        /// Apply badge styles
        [<Erase>]
        member this.badge(?color: ColorVariant, ?size: Size, ?outline: bool) =
            let classes = [
                "badge"
                if color.IsSome then
                    match color.Value with
                    | Primary -> "badge-primary"
                    | Secondary -> "badge-secondary"
                    | Accent -> "badge-accent"
                    | Neutral -> "badge-neutral"
                    | Info -> "badge-info"
                    | Success -> "badge-success"
                    | Warning -> "badge-warning"
                    | Error -> "badge-error"
                    | Ghost -> "badge-ghost"
                if size.IsSome then
                    match size.Value with
                    | ExtraSmall | Small -> "badge-sm"
                    | Medium -> "badge-md"
                    | Large | ExtraLarge -> "badge-lg"
                if outline = Some true then "badge-outline"
            ]
            this.class' <- CssClass.combine classes
            this
    
    /// Card and Stats extensions for div
    type div with
        /// Apply card styles
        [<Erase>]
        member this.card(?compact: bool, ?bordered: bool, ?imageFull: bool) =
            let classes = [
                "card"
                if compact = Some true then "card-compact"
                if bordered = Some true then "card-bordered"
                if imageFull = Some true then "image-full"
            ]
            this.class' <- CssClass.combine classes
            this
        
        /// Apply card body styles
        [<Erase>]
        member this.cardBody() =
            this.class' <- "card-body"
            this
        
        /// Apply card actions styles
        [<Erase>]
        member this.cardActions() =
            this.class' <- "card-actions"
            this
        
        /// Apply avatar styles
        [<Erase>]
        member this.avatar(?isOnline: bool, ?placeholder: bool) =
            let classes = [
                "avatar"
                if isOnline = Some true then "online"
                elif isOnline = Some false then "offline"
                if placeholder = Some true then "placeholder"
            ]
            this.class' <- CssClass.combine classes
            this
        
        /// Apply stat styles
        [<Erase>]
        member this.stat() =
            this.class' <- "stat"
            this
        
        /// Apply stat title styles
        [<Erase>]
        member this.statTitle() =
            this.class' <- "stat-title"
            this
        
        /// Apply stat value styles
        [<Erase>]
        member this.statValue() =
            this.class' <- "stat-value"
            this
        
        /// Apply stat desc styles
        [<Erase>]
        member this.statDesc() =
            this.class' <- "stat-desc"
            this
        
        /// Apply stats container styles
        [<Erase>]
        member this.stats(?vertical: bool) =
            let classes = [
                "stats"
                if vertical = Some true then "stats-vertical"
            ]
            this.class' <- CssClass.combine classes
            this
    
    /// Card title extension for h2
    type h2 with
        /// Apply card title styles
        [<Erase>]
        member this.cardTitle() =
            this.class' <- "card-title"
            this
    
    /// Table extensions
    type table with
        /// Apply table styles
        [<Erase>]
        member this.table(?zebra: bool, ?pinRows: bool, ?pinCols: bool) =
            let classes = [
                "table"
                if zebra = Some true then "table-zebra"
                if pinRows = Some true then "table-pin-rows"
                if pinCols = Some true then "table-pin-cols"
            ]
            this.class' <- CssClass.combine classes
            this
    
    /// Timeline extensions
    type ul with
        /// Apply timeline styles
        [<Erase>]
        member this.timeline(?vertical: bool, ?compact: bool) =
            let classes = [
                "timeline"
                if vertical = Some true then "timeline-vertical"
                if compact = Some true then "timeline-compact"
            ]
            this.class' <- CssClass.combine classes
            this

