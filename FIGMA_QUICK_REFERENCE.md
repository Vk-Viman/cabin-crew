# ?? Figma CSS Export - Quick Reference Card

## 5 Ways to Export CSS from Figma

### 1?? BUILT-IN INSPECTOR (Fastest)
```
1. Select element in Figma
2. Right panel ? Inspect tab
3. Click </> Code icon
4. Switch to "CSS"
5. Copy code
```
**Best for**: Individual elements, quick checks

---

### 2?? FIGMA PLUGINS (Most Popular)

#### "Figma to Code"
```
Plugins ? Find ? "Figma to Code"
? Select frames
? Choose "HTML + CSS"
? Copy
```
**Best for**: Complete pages, layouts

#### "Design Tokens"
```
Plugins ? "Design Tokens"
? Export as CSS Variables
```
**Best for**: Design system tokens

#### "CSS Gen"
```
Plugins ? "CSS Gen"
? Select component
? Get clean CSS
```
**Best for**: Component styles

---

### 3?? DEV MODE (Pro/Enterprise)
```
1. Toggle Dev Mode (top right)
2. Select element
3. Code tab ? CSS
4. Copy
```
**Best for**: Accurate measurements, production code

---

### 4?? MANUAL EXTRACTION
```
Colors:    Local Styles ? Copy hex values
Fonts:     Text Styles ? Note family/size/weight
Spacing:   Measure gaps ? Convert to rem/px
```
**Best for**: Design system setup

---

### 5?? FIGMA API (Advanced)
```javascript
fetch('https://api.figma.com/v1/files/YOUR_FILE_KEY', {
  headers: { 'X-Figma-Token': 'YOUR_TOKEN' }
})
```
**Best for**: Automation, CI/CD pipelines

---

## ? Quick Setup in Your Project

### Already Done ?
```
? figma-tokens.css created
? Layout.cshtml updated
? Export helper script ready
```

### Your Next Steps:

1. **Export from Figma** (pick method above)
2. **Paste CSS** into `wwwroot/css/figma-tokens.css`
3. **Update variables** to match your design
4. **Use classes** in your Razor views

---

## ?? Usage Examples

### Using Design Tokens:
```css
.my-component {
  color: var(--figma-primary);
  padding: var(--figma-space-4);
  border-radius: var(--figma-radius-md);
  font-size: var(--figma-text-lg);
}
```

### Using Figma Classes:
```html
<h1 class="figma-heading-1">Title</h1>
<button class="figma-btn figma-btn-primary">Click</button>
<div class="figma-card">Content</div>
```

---

## ?? Pro Tips

? Export as **CSS Variables** (not hardcoded values)  
? Use **semantic names** (primary, not blue-500)  
? Test **responsiveness** before copying  
? Keep **Figma as source of truth**  
? Export **design system first**, then components  

---

## ?? Need Help?

Share with me:
1. Exported CSS from Figma
2. Screenshot of design
3. Which component to build

I'll integrate it into your CabinOps project! ??

---

**File Created**: `wwwroot/css/figma-tokens.css`  
**Documentation**: `FIGMA_EXPORT_GUIDE.md`  
**Status**: ? Ready for your Figma CSS!
