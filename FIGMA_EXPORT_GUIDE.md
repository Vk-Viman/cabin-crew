# ?? Figma to CSS Export Guide for CabinOps

## Quick Reference: How to Export CSS from Figma

### ? Method 1: Built-in CSS Inspector (Easiest)

#### Steps:
1. **Open Figma** file in browser or desktop app
2. **Select any element** (frame, button, text, etc.)
3. Look at **right panel** ? **Inspect** tab
4. Click **Code icon** (`</>`) at bottom right
5. Switch dropdown to **CSS**
6. Click **Copy** button

#### What You Get:
```css
.your-element {
  display: flex;
  padding: 24px;
  background: #3B82F6;
  border-radius: 12px;
  gap: 16px;
}
```

---

### ? Method 2: Figma Plugins (Recommended for Complete Export)

#### **Plugin A: "Figma to Code - HTML, Tailwind, React"**
**Best for**: Full page export with HTML + CSS

1. In Figma: **Plugins** ? **Find Plugins**
2. Search: **"Figma to Code"**
3. Install and run on selected frames
4. Choose **HTML + CSS** output
5. Copy generated code

#### **Plugin B: "Design Tokens"**
**Best for**: Exporting colors, typography, spacing

1. Search: **"Design Tokens"** plugin
2. Run on your design file
3. Export as **CSS Variables**
4. Get organized token structure

#### **Plugin C: "CSS Gen - Generate CSS"**
**Best for**: Individual component styles

1. Search: **"CSS Gen"**
2. Select element
3. Get clean, production-ready CSS

---

### ? Method 3: Figma Dev Mode (For Figma Professional/Enterprise)

#### Enable Dev Mode:
1. Toggle **Dev Mode** switch (top right)
2. Select any element
3. View **Code** tab
4. Choose **CSS** from dropdown
5. Copy code snippets with accurate measurements

#### Advantages:
- ? Accurate spacing measurements
- ? Export-ready CSS
- ? Component variants support
- ? Design token integration

---

## ?? Step-by-Step: Exporting Complete Design System

### 1?? Export Colors

#### In Figma:
- Go to **Local Styles** panel (paint bucket icon)
- Select color styles
- Copy hex values

#### Create CSS File:
```css
/* wwwroot/css/figma-colors.css */
:root {
  --color-primary: #3B82F6;
  --color-primary-dark: #1E40AF;
  --color-secondary: #8B5CF6;
  --color-success: #10B981;
  --color-warning: #F59E0B;
  --color-error: #EF4444;
  --color-neutral-50: #F9FAFB;
  --color-neutral-900: #111827;
}
```

### 2?? Export Typography

#### In Figma:
- Check **Text Styles** panel
- Note font families, sizes, weights

#### Create CSS File:
```css
/* wwwroot/css/figma-typography.css */
:root {
  --font-primary: 'Inter', sans-serif;
  --font-heading: 'Poppins', sans-serif;
  
  --text-xs: 0.75rem;
  --text-sm: 0.875rem;
  --text-base: 1rem;
  --text-lg: 1.125rem;
  --text-xl: 1.25rem;
  --text-2xl: 1.5rem;
}

h1 { font-size: var(--text-2xl); font-family: var(--font-heading); }
body { font-size: var(--text-base); font-family: var(--font-primary); }
```

### 3?? Export Layout & Spacing

#### In Figma:
- Measure gaps, padding, margins
- Note grid/layout structure

#### Create CSS File:
```css
/* wwwroot/css/figma-spacing.css */
:root {
  --space-1: 0.25rem;  /* 4px */
  --space-2: 0.5rem;   /* 8px */
  --space-3: 0.75rem;  /* 12px */
  --space-4: 1rem;     /* 16px */
  --space-6: 1.5rem;   /* 24px */
  --space-8: 2rem;     /* 32px */
}
```

### 4?? Export Components

#### For each component:
1. Select component in Figma
2. Copy CSS from Inspector
3. Create component class

```css
/* wwwroot/css/figma-components.css */
.btn-primary {
  background: var(--color-primary);
  color: white;
  padding: var(--space-3) var(--space-6);
  border-radius: 0.75rem;
  font-weight: 500;
  border: none;
  cursor: pointer;
}

.card {
  background: white;
  padding: var(--space-6);
  border-radius: 1rem;
  box-shadow: 0 1px 3px rgba(0,0,0,0.1);
}
```

---

## ?? Integration Steps for Your Project

### Step 1: Create Token Files

Already created for you:
? `wwwroot/css/figma-tokens.css`

### Step 2: Link in Layout

Already updated:
? `Views/Shared/_Layout.cshtml` includes figma-tokens.css

### Step 3: Use in Your Views

```razor
@* Example: Using Figma classes in Razor Page *@

<div class="figma-card">
    <h2 class="figma-heading-2">Dashboard</h2>
    <p class="figma-body">Welcome back!</p>
    <button class="figma-btn figma-btn-primary">Get Started</button>
</div>
```

### Step 4: Custom Styling with Tokens

```css
/* Your custom component */
.custom-stat-card {
  background: white;
  padding: var(--figma-space-6);
  border-radius: var(--figma-radius-lg);
  box-shadow: var(--figma-shadow-md);
  color: var(--figma-gray-900);
}

.custom-stat-card:hover {
  box-shadow: var(--figma-shadow-lg);
  transform: translateY(-2px);
  transition: all var(--figma-transition-base);
}
```

---

## ?? Recommended Plugins for Your Project

### For Dashboard Components:
1. **"Figma to Code"** - Export full layouts
2. **"Design Tokens"** - Export design system
3. **"CSS Gen"** - Quick component CSS

### For Icons:
1. **"SVG Export"** - Bulk export SVG icons
2. **"Iconify"** - Icon library integration

### For Responsive Design:
1. **"Responsive Viewer"** - Test breakpoints
2. **"Auto Layout"** - Export flex/grid layouts

---

## ?? Best Practices

### ? DO:
- Export design tokens as CSS variables
- Organize by category (colors, typography, spacing)
- Use semantic naming (primary, secondary, not blue, red)
- Test exported CSS in your project first
- Keep Figma file as single source of truth

### ? DON'T:
- Copy fixed pixel values everywhere (use variables)
- Mix Figma units with your existing system
- Export without testing responsiveness
- Hardcode colors (use CSS variables)

---

## ?? Quick Start Workflow

### 1. Prepare Figma File
- Organize with proper naming
- Use consistent spacing/sizing
- Apply styles (not manual colors)
- Create components for reusable elements

### 2. Export Design Tokens
```bash
# Using plugin or manual export
1. Colors ? CSS variables
2. Typography ? Font styles
3. Spacing ? Space scale
4. Components ? Component classes
```

### 3. Create CSS Files in Your Project
```
wwwroot/css/
??? figma-tokens.css      ? Design tokens (DONE ?)
??? figma-colors.css      ? Color palette
??? figma-typography.css  ? Text styles
??? figma-components.css  ? Component styles
??? figma-layouts.css     ? Page layouts
```

### 4. Import in Order
```html
<!-- Views/Shared/_Layout.cshtml -->
<link rel="stylesheet" href="~/css/figma-tokens.css" />
<link rel="stylesheet" href="~/css/figma-colors.css" />
<link rel="stylesheet" href="~/css/figma-typography.css" />
<link rel="stylesheet" href="~/css/figma-components.css" />
```

### 5. Use in Your Pages
```razor
<div class="figma-card">
  <h1 class="figma-heading-1">Dashboard</h1>
  <button class="figma-btn figma-btn-primary">Action</button>
</div>
```

---

## ??? Tools & Resources

### Online Converters:
- **Figma to CSS**: https://figma-to-css.com/
- **CSS Filter Generator**: https://codepen.io/sosuke/pen/Pjoqqp (for icon colors)

### Figma Plugins:
- **Figma to Code**: Full export solution
- **Design Tokens**: Token management
- **CSS Gen**: Quick CSS generation
- **Anima**: Advanced code export

### Documentation:
- Figma API: https://www.figma.com/developers/api
- CSS Variables: https://developer.mozilla.org/en-US/docs/Web/CSS/--*

---

## ?? Next Steps

After exporting from Figma:

1. **Share the exported CSS** with me
2. **Identify which page/component** to implement first
3. **Provide screenshots** of the design
4. I'll help you:
   - Integrate the CSS
   - Create Razor Pages
   - Build components
   - Make it responsive

---

## ? You're Ready!

Your project now has:
- ? `figma-tokens.css` template ready
- ? Layout updated to include Figma styles
- ? Helper script for API export
- ? Documentation for all export methods

**Next**: Export your Figma design and share the CSS, and I'll integrate it into your CabinOps dashboard! ??
