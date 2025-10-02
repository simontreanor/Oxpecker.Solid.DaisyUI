# Changelog

All notable changes to Oxpecker.Solid.DaisyUI will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## [Unreleased]

### Added
- Complete DaisyUI component library for Oxpecker.Solid
- Type-safe F# bindings for all 76 DaisyUI components
- 40 part types for structured components (ModalBox, CardBody, ListRow, DockLabel, ValidatorHint, etc.)
- Seven component categories:
  - **Actions**: Button, Dropdown, Modal, Swap, Fab, Collapse, ThemeController
  - **DataDisplay**: Badge, Card, Avatar, Stats, Table, Timeline, Chat, Carousel, Countdown, Diff, Mask, List, Status, HoverGallery
  - **DataInput**: Checkbox, Radio, TextInput, Textarea, Select, Range, Toggle, FileInput, Rating, Kbd, Filter, Fieldset, Validator
  - **Layout**: Artboard, Divider, Drawer, Footer, Hero, Indicator, Join, Stack, Toast
  - **Navigation**: Breadcrumbs, BottomNav, Dock, Link, Menu, Navbar, Steps, Tabs, Pagination
  - **Feedback**: Alert, Loading, Progress, RadialProgress, Skeleton, Tooltip
  - **Mockup**: MockupBrowser, MockupCode, MockupPhone, MockupWindow
- Type-safe discriminated unions:
  - `ColorVariant`: Primary, Secondary, Accent, Neutral, Info, Success, Warning, Error, Ghost
  - `Size`: ExtraSmall, Small, Medium, Large, ExtraLarge
  - `Orientation`: Vertical, Horizontal
  - `Alignment`: AlignStart, AlignEnd
  - `AvatarStatus`: Online, Offline
  - `CarouselSnap`: SnapCenter, SnapEnd
  - `ModalPosition`: ModalTop, ModalMiddle, ModalBottom
  - `Position`: Top, Bottom, Left, Right, TopStart, TopEnd, BottomStart, BottomEnd
- PascalCase naming convention for all components
- `class'` parameter support on all components for custom styling
- CSS class composition utilities
- Full integration with Oxpecker.Solid and SolidJS
- Comprehensive documentation and examples

### Features
- Clean component syntax with optional parameters
- Type safety for component parameters
- IntelliSense support for all components and variants
- Seamless Oxpecker.Solid integration via `[<SolidComponent>]` attribute
- Support for DaisyUI v4+ theming system
- Works with Tailwind CSS v4+

### Documentation
- Complete README with installation guide
- Quick start examples
- Component reference
- DaisyUI v4 configuration guide
