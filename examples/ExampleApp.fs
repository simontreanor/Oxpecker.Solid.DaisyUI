module ExampleApp

open Oxpecker.Solid
open Oxpecker.Solid.DaisyUI
open Oxpecker.Solid.DaisyUI.Actions
open Oxpecker.Solid.DaisyUI.DataDisplay
open Oxpecker.Solid.DaisyUI.DataInput
open Oxpecker.Solid.DaisyUI.Feedback
open Oxpecker.Solid.DaisyUI.Navigation
open Oxpecker.Solid.DaisyUI.Layout
open Oxpecker.Solid.DaisyUI.Mockup

/// Hero section with title and description
[<SolidComponent>]
let HeroSection () =
    Hero() {
        HeroContent(class' = "text-center") {
            div (class' = "max-w-md") {
                h1 (class' = "text-5xl font-bold") { "Hello DaisyUI!" }
                p (class' = "py-6") { "Welcome to Oxpecker.Solid.DaisyUI - Build beautiful UIs with F# and DaisyUI" }
                Button(color = Primary, size = Large) { "Get Started" }
            }
        }
    }

/// Stats showcase
[<SolidComponent>]
let StatsSection () =
    Stats(class' = "shadow w-full") {
        Stat() {
            StatFigure(class' = "text-primary") { svg (class' = "w-8 h-8") { } }
            StatTitle() { "Downloads" }
            StatValue(class' = "text-primary") { "31K" }
            StatDesc() { "Jan 1st - Feb 1st" }
        }

        Stat() {
            StatTitle() { "New Users" }
            StatValue(class' = "text-secondary") { "4,200" }
            StatDesc() { "↗︎ 400 (22%)" }
        }

        Stat() {
            StatTitle() { "New Registers" }
            StatValue() { "1,200" }
            StatDesc() { "↘︎ 90 (14%)" }
        }
    }

/// Interactive modal example
[<SolidComponent>]
let ModalExample () =
    let isOpen, setIsOpen = createSignal false

    Fragment() {
        Button(color = Primary).onClick (fun _ -> setIsOpen (true)) { "Open Modal" }

        // Modal with backdrop
        Show(``when`` = isOpen)
        <| Fragment() {
            Modal(``open`` = isOpen ()).attr ("open", "true") {
                ModalBox() {
                    h3 (class' = "font-bold text-lg") { "Congratulations!" }
                    p (class' = "py-4") { "You've opened a modal using Oxpecker.Solid.DaisyUI" }
                    ModalAction() { Button().onClick (fun _ -> setIsOpen (false)) { "Close" } }
                }

                ModalBackdrop().attr ("method", "dialog") { button().onClick (fun _ -> setIsOpen (false)) { } }
            }
        }
    }

/// Card grid with various examples
[<SolidComponent>]
let CardGrid () =
    div (class' = "grid grid-cols-1 md:grid-cols-2 lg:grid-cols-3 gap-4") {
        // Card 1: Basic Info
        Card(bordered = true) {
            CardBody() {
                CardTitle() { "Basic Card" }
                p () { "This is a simple card component with title and text." }
                div (class' = "card-actions justify-end") { Button(color = Primary, size = Small) { "Learn More" } }
            }
        }

        // Card 2: With Badge
        Card(bordered = true) {
            CardBody() {
                CardTitle() {
                    span () { "Featured" }
                    Badge(color = Accent) { "NEW" }
                }

                p () { "Check out our latest features and updates." }
            }
        }

        // Card 3: With Stats
        Card(color = Primary) {
            CardBody() {
                CardTitle() { "Quick Stats" }

                Stats() {
                    Stat() {
                        StatValue(class' = "text-primary") { "89%" }
                        StatDesc() { "Task completion" }
                    }
                }
            }
        }
    }

/// Form example
[<SolidComponent>]
let FormExample () =
    let name, setName = createSignal ""
    let email, setEmail = createSignal ""
    let message, setMessage = createSignal ""

    Card(bordered = true) {
        CardBody() {
            CardTitle() { "Contact Form" }

            form (class' = "space-y-4") {
                FormControl() {
                    Label() { LabelText() { "Name" } }
                    TextInput(placeholder = "Your name", bordered = true)
                }

                FormControl() {
                    Label() { LabelText() { "Email" } }
                    TextInput(placeholder = "your@email.com", bordered = true, color = Primary)
                }

                FormControl() {
                    Label() { LabelText() { "Message" } }
                    Textarea(placeholder = "Your message here...", bordered = true, rows = 4)
                }

                FormControl() {
                    Label(class' = "cursor-pointer justify-start gap-2") {
                        Checkbox(color = Primary)
                        LabelText() { "Subscribe to newsletter" }
                    }
                }

                Button(color = Primary, block = true) { "Submit" }
            }
        }
    }

/// Mockup examples
[<SolidComponent>]
let MockupExamples () =
    div (class' = "grid grid-cols-1 md:grid-cols-2 gap-4") {
        // Browser mockup
        div () {
            h3 (class' = "text-lg font-bold mb-2") { "Browser Mockup" }

            MockupBrowser(class' = "border bg-base-300") {
                MockupBrowserToolbar() { div (class' = "input") { "https://daisyui.com" } }
                div (class' = "bg-base-200 flex justify-center px-4 py-16") { "Hello from DaisyUI!" }
            }
        }

        // Code mockup
        div () {
            h3 (class' = "text-lg font-bold mb-2") { "Code Mockup" }

            MockupCode(class' = "bg-primary text-primary-content") {
                pre().attr ("data-prefix", "$") { code () { "npm i daisyui" } }
                pre().attr("data-prefix", ">").attr ("class", "text-warning") { code () { "installing..." } }
                pre().attr("data-prefix", ">").attr ("class", "text-success") { code () { "Done!" } }
            }
        }

        // Window mockup
        div () {
            h3 (class' = "text-lg font-bold mb-2") { "Window Mockup" }

            MockupWindow(class' = "border bg-base-300") {
                div (class' = "bg-base-200 flex justify-center px-4 py-16") { "Hello from Window!" }
            }
        }

        // Phone mockup
        div () {
            h3 (class' = "text-lg font-bold mb-2") { "Phone Mockup" }

            MockupPhone() {
                MockupPhoneCamera() { }

                MockupPhoneDisplay() {
                    div (class' = "bg-base-200 flex justify-center items-center h-full") { "It's Glowtime" }
                }
            }
        }
    }

/// Navigation bar
[<SolidComponent>]
let AppNavbar () =
    Navbar() {
        div (class' = "flex-1") { a (class' = "btn btn-ghost text-xl") { "Oxpecker.Solid.DaisyUI" } }

        div (class' = "flex-none") {
            Menu(class' = "px-1", orientation = Horizontal) {
                li () { Link(hover = true).href ("#home") { "Home" } }
                li () { Link(hover = true).href ("#docs") { "Docs" } }
                li () { Link(hover = true).href ("#examples") { "Examples" } }
            }
        }
    }

/// Main application
[<SolidComponent>]
let App () =
    div (class' = "min-h-screen bg-base-200") {
        AppNavbar()

        div (class' = "container mx-auto p-4 space-y-8") {
            HeroSection()

            StatsSection()

            div (class' = "flex gap-4") {
                ModalExample()

                // Dropdown example
                Dropdown() {
                    Button(color = Secondary).attr ("tabindex", "0") { "Open Dropdown" }

                    DropdownContent(class' = "menu bg-base-100 rounded-box z-[1] w-52 p-2 shadow") {
                        ul().attr ("tabindex", "0") {
                            li () { a () { "Item 1" } }
                            li () { a () { "Item 2" } }
                            li () { a () { "Item 3" } }
                        }
                    }
                }
            }

            CardGrid()

            FormExample()

            MockupExamples()

            Footer(class' = "p-4", center = true) { div () { p () { "Built with Oxpecker.Solid.DaisyUI ❤️" } } }
        }

        Toast(position = TopEnd) { Alert(color = Success) { span () { "✓ App loaded successfully!" } } }
    }
