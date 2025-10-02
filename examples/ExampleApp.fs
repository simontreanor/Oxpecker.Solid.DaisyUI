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
    Hero <| Fragment() {
        div(class' = "hero-content text-center") {
            div(class' = "max-w-md") {
                h1(class' = "text-5xl font-bold") { "Hello DaisyUI!" }
                p(class' = "py-6") {
                    "Welcome to Oxpecker.Solid.DaisyUI - Build beautiful UIs with F# and DaisyUI"
                }
                let btn = DaisyButton()
                btn.color <- Some Primary
                btn.size <- Some Large
                btn.render <| Fragment() {
                    "Get Started"
                }
            }
        }
    }

/// Stats showcase
[<SolidComponent>]
let StatsSection() =
    div(class' = "stats shadow w-full") {
        Stat <| Fragment() {
            div(class' = "stat-figure text-primary") {
                svg(class' = "w-8 h-8") { }
            }
            div(class' = "stat-title") { "Downloads" }
            div(class' = "stat-value text-primary") { "31K" }
            div(class' = "stat-desc") { "Jan 1st - Feb 1st" }
        }
        
        Stat <| Fragment() {
            div(class' = "stat-title") { "New Users" }
            div(class' = "stat-value text-secondary") { "4,200" }
            div(class' = "stat-desc") { "↗︎ 400 (22%)" }
        }
        
        Stat <| Fragment() {
            div(class' = "stat-title") { "New Registers" }
            div(class' = "stat-value") { "1,200" }
            div(class' = "stat-desc") { "↘︎ 90 (14%)" }
        }
    }

/// Interactive modal example
[<SolidComponent>]
let ModalExample() =
    let isOpen, setIsOpen = createSignal false
    
    Fragment() {
        let openBtn = DaisyButton()
        openBtn.color <- Some Primary
        openBtn.render <| button(onClick = fun _ -> setIsOpen(true)) {
            "Open Modal"
        }
        
        let modal = DaisyModal()
        modal.isOpen <- isOpen()
        modal.middle <- true
        modal.render <| Fragment() {
            ModalBox <| Fragment() {
                h3(class' = "font-bold text-lg") { "Congratulations!" }
                p(class' = "py-4") {
                    "You've opened a modal using Oxpecker.Solid.DaisyUI"
                }
                ModalAction <| Fragment() {
                    let closeBtn = DaisyButton()
                    closeBtn.render <| button(onClick = fun _ -> setIsOpen(false)) {
                        "Close"
                    }
                }
            }
        }
    }

/// Card grid with various examples
[<SolidComponent>]
let CardGrid() =
    div(class' = "grid grid-cols-1 md:grid-cols-2 lg:grid-cols-3 gap-4") {
        // Card 1: Basic Info
        Card <| Fragment() {
            div(class' = "card-body") {
                CardTitle <| Fragment() { "Basic Card" }
                p() { "This is a simple card component with title and text." }
                div(class' = "card-actions justify-end") {
                    let btn = DaisyButton()
                    btn.color <- Some Primary
                    btn.size <- Some Small
                    btn.render <| Fragment() { "Learn More" }
                }
            }
        }
        
        // Card 2: With Badge
        Card <| Fragment() {
            div(class' = "card-body") {
                CardTitle <| Fragment() {
                    "Featured"
                    Badge <| Fragment() { "NEW" }
                }
                p() { "Check out our latest features and updates." }
            }
        }
        
        // Card 3: With Stats
        Card <| Fragment() {
            div(class' = "card-body") {
                CardTitle <| Fragment() { "Quick Stats" }
                Stats <| Fragment() {
                    Stat <| Fragment() {
                        div(class' = "stat-value text-primary") { "89%" }
                        div(class' = "stat-desc") { "Task completion" }
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
    
    Card <| Fragment() {
        div(class' = "card-body") {
            CardTitle <| Fragment() { "Contact Form" }
            
            form(class' = "space-y-4") {
                div(class' = "form-control") {
                    label(class' = "label") {
                        span(class' = "label-text") { "Name" }
                    }
                    TextInput "Your name"
                }
                
                div(class' = "form-control") {
                    label(class' = "label") {
                        span(class' = "label-text") { "Email" }
                    }
                    input(type' = "email", class' = "input input-bordered", placeholder = "your@email.com")
                }
                
                div(class' = "form-control") {
                    label(class' = "label") {
                        span(class' = "label-text") { "Message" }
                    }
                    Textarea "Your message here..."
                }
                
                div(class' = "form-control") {
                    label(class' = "label cursor-pointer justify-start gap-2") {
                        Checkbox <| Fragment() { }
                        span(class' = "label-text") { "Subscribe to newsletter" }
                    }
                }
                
                let submitBtn = DaisyButton()
                submitBtn.color <- Some Primary
                submitBtn.block <- true
                submitBtn.render <| Fragment() { "Submit" }
            }
        }
    }

/// Navigation bar
[<SolidComponent>]
let AppNavbar() =
    Navbar <| Fragment() {
        div(class' = "flex-1") {
            a(class' = "btn btn-ghost text-xl") { "Oxpecker.Solid.DaisyUI" }
        }
        div(class' = "flex-none") {
            Menu <| Fragment() {
                li() {
                    Link "#home" <| Fragment() { "Home" }
                }
                li() {
                    Link "#docs" <| Fragment() { "Docs" }
                }
                li() {
                    Link "#examples" <| Fragment() { "Examples" }
                }
            }
        }
    }

/// Main application
[<SolidComponent>]
let App() =
    div(class' = "min-h-screen bg-base-200") {
        AppNavbar()
        
        div(class' = "container mx-auto p-4 space-y-8") {
            HeroSection()
            
            StatsSection()
            
            div(class' = "flex gap-4") {
                ModalExample()
                
                let dropdownDemo = DaisyDropdown()
                dropdownDemo.render <| Fragment() {
                    let btn = DaisyButton()
                    btn.render <| Fragment() { "Open Dropdown" }
                    
                    DropdownContent <| Fragment() {
                        li() { a() { "Item 1" } }
                        li() { a() { "Item 2" } }
                        li() { a() { "Item 3" } }
                    }
                }
            }
            
            CardGrid()
            
            FormExample()
            
            Footer <| Fragment() {
                div(class' = "footer-center p-4") {
                    p() { "Built with Oxpecker.Solid.DaisyUI ❤️" }
                }
            }
        }
        
        Toast <| Fragment() {
            Alert <| Fragment() {
                span() { "✓ App loaded successfully!" }
            }
        }
    }
