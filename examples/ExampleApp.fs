module ExampleApp

open Oxpecker.Solid
open Oxpecker.Solid.DaisyUI
open Oxpecker.Solid.DaisyUI.Actions
open Oxpecker.Solid.DaisyUI.DataDisplay
open Oxpecker.Solid.DaisyUI.DataInput
open Oxpecker.Solid.DaisyUI.Feedback
open Oxpecker.Solid.DaisyUI.Navigation
open Oxpecker.Solid.DaisyUI.Layout

/// Hero section with title and description
[<SolidComponent>]
let HeroSection() =
    hero() {
        div().class'("hero-content text-center") {
            div().class'("max-w-md") {
                h1().class'("text-5xl font-bold") { "Hello DaisyUI!" }
                p().class'("py-6") {
                    "Welcome to Oxpecker.Solid.DaisyUI - Build beautiful UIs with F# and DaisyUI"
                }
                btn(color = Primary, size = Large) {
                    "Get Started"
                }
            }
        }
    }

/// Stats showcase
[<SolidComponent>]
let StatsSection() =
    stats().class'("shadow w-full") {
        stat() {
            div().class'("stat-figure text-primary") {
                svg().class'("w-8 h-8") { }
            }
            div().class'("stat-title") { "Downloads" }
            div().class'("stat-value text-primary") { "31K" }
            div().class'("stat-desc") { "Jan 1st - Feb 1st" }
        }
        
        stat() {
            div().class'("stat-title") { "New Users" }
            div().class'("stat-value text-secondary") { "4,200" }
            div().class'("stat-desc") { "↗︎ 400 (22%)" }
        }
        
        stat() {
            div().class'("stat-title") { "New Registers" }
            div().class'("stat-value") { "1,200" }
            div().class'("stat-desc") { "↘︎ 90 (14%)" }
        }
    }

/// Interactive modal example
[<SolidComponent>]
let ModalExample() =
    let isOpen, setIsOpen = createSignal false
    
    Fragment() {
        btn(color = Primary).onClick(fun _ -> setIsOpen(true)) {
            "Open Modal"
        }
        
        // Modal with backdrop
        Show(``when`` = isOpen) <| Fragment() {
            modal(isOpen = isOpen()).attr("open", "true") {
                div().class'("modal-box") {
                    h3().class'("font-bold text-lg") { "Congratulations!" }
                    p().class'("py-4") {
                        "You've opened a modal using Oxpecker.Solid.DaisyUI"
                    }
                    div().class'("modal-action") {
                        btn().onClick(fun _ -> setIsOpen(false)) {
                            "Close"
                        }
                    }
                }
                form().class'("modal-backdrop").attr("method", "dialog") {
                    button().onClick(fun _ -> setIsOpen(false)) { }
                }
            }
        }
    }

/// Card grid with various examples
[<SolidComponent>]
let CardGrid() =
    div().class'("grid grid-cols-1 md:grid-cols-2 lg:grid-cols-3 gap-4") {
        // Card 1: Basic Info
        card(bordered = true) {
            cardBody() {
                cardTitle() { "Basic Card" }
                p() { "This is a simple card component with title and text." }
                div().class'("card-actions justify-end") {
                    btn(color = Primary, size = Small) { "Learn More" }
                }
            }
        }
        
        // Card 2: With Badge
        card(bordered = true) {
            cardBody() {
                cardTitle() {
                    span() { "Featured" }
                    badge(color = Accent) { "NEW" }
                }
                p() { "Check out our latest features and updates." }
            }
        }
        
        // Card 3: With Stats
        card(color = Primary) {
            cardBody() {
                cardTitle() { "Quick Stats" }
                stats() {
                    stat() {
                        div().class'("stat-value text-primary") { "89%" }
                        div().class'("stat-desc") { "Task completion" }
                    }
                }
            }
        }
    }

/// Form example
[<SolidComponent>]
let FormExample() =
    let name, setName = createSignal ""
    let email, setEmail = createSignal ""
    let message, setMessage = createSignal ""
    
    card(bordered = true) {
        cardBody() {
            cardTitle() { "Contact Form" }
            
            form().class'("space-y-4") {
                div().class'("form-control") {
                    label().class'("label") {
                        span().class'("label-text") { "Name" }
                    }
                    textInput(placeholder = "Your name", bordered = true)
                }
                
                div().class'("form-control") {
                    label().class'("label") {
                        span().class'("label-text") { "Email" }
                    }
                    textInput(placeholder = "your@email.com", bordered = true, color = Primary)
                }
                
                div().class'("form-control") {
                    label().class'("label") {
                        span().class'("label-text") { "Message" }
                    }
                    textarea_input(placeholder = "Your message here...", bordered = true, rows = 4)
                }
                
                div().class'("form-control") {
                    label().class'("label cursor-pointer justify-start gap-2") {
                        checkbox(color = Primary)
                        span().class'("label-text") { "Subscribe to newsletter" }
                    }
                }
                
                btn(color = Primary, block = true) { "Submit" }
            }
        }
    }

/// Navigation bar
[<SolidComponent>]
let AppNavbar() =
    navbar() {
        div().class'("flex-1") {
            a().class'("btn btn-ghost text-xl") { "Oxpecker.Solid.DaisyUI" }
        }
        div().class'("flex-none") {
            menu(horizontal = true).class'("px-1") {
                li() {
                    link(hover = true).href("#home") { "Home" }
                }
                li() {
                    link(hover = true).href("#docs") { "Docs" }
                }
                li() {
                    link(hover = true).href("#examples") { "Examples" }
                }
            }
        }
    }

/// Main application
[<SolidComponent>]
let App() =
    div().class'("min-h-screen bg-base-200") {
        AppNavbar()
        
        div().class'("container mx-auto p-4 space-y-8") {
            HeroSection()
            
            StatsSection()
            
            div().class'("flex gap-4") {
                ModalExample()
                
                // Dropdown example
                dropdown() {
                    btn(color = Secondary).attr("tabindex", "0") { "Open Dropdown" }
                    
                    ul().class'("dropdown-content menu bg-base-100 rounded-box z-[1] w-52 p-2 shadow")
                       .attr("tabindex", "0") {
                        li() { a() { "Item 1" } }
                        li() { a() { "Item 2" } }
                        li() { a() { "Item 3" } }
                    }
                }
            }
            
            CardGrid()
            
            FormExample()
            
            footer_layout(center = true).class'("p-4") {
                div() {
                    p() { "Built with Oxpecker.Solid.DaisyUI ❤️" }
                }
            }
        }
        
        toast(position = TopEnd) {
            alert(color = Success) {
                span() { "✓ App loaded successfully!" }
            }
        }
    }

