# CabinOps Icon Mapping

## ?? Icons Location

All SVG icons are located in: `wwwroot/images/icons/`

Source: `C:\Users\Viman Kavinda\Desktop\Airline\VS(2022)\Cabin-Crew\LOGO\`

## ?? Icons Used in Application

### Sidebar Navigation Icons

| Icon File | Used For | Location |
|-----------|----------|----------|
| `Icon.svg` | Dashboard | Sidebar - Main Dashboard |
| `Icon-2.svg` | Incident Reports | Sidebar - Incident Management |
| `Icon-3.svg` | Voyage Reports | Sidebar - Voyage Management |
| `Icon-17.svg` | Unsubmitted Reports | Sidebar - Voyage Management |
| `edit.svg` | Manual Voyage Entry | Sidebar - Voyage Management |
| `Icon-4.svg` | CabinOps iPad Tracker | Sidebar - Crew Management |
| `Icon-5.svg` | Cabin Crew by Flight | Sidebar - Crew Management |
| `Icon-6.svg` | Signature Recovery | Sidebar - Crew Management |
| `Icon-7.svg` | Update Pilot Details | Sidebar - Crew Management |
| `Icon-8.svg` | Generate Reports | Sidebar - Reports |
| `Icon-9.svg` | Access Control | Sidebar - Configuration |

### Dashboard Statistics Icons

| Icon File | Used For | Color Theme |
|-----------|----------|-------------|
| `Icon-3.svg` | Voyage Reports Count | Blue (#dbeafe) |
| `Icon-2.svg` | Incidents Count | Red (#fee2e2) |
| `Icon-17.svg` | Unsubmitted Reports Count | Orange (#fed7aa) |

### Dashboard Flight Icons

| Icon File | Used For |
|-----------|----------|
| `Icon-15.svg` | Flight entries (airplane icon) |

### Quick Actions Icons

| Icon File | Used For |
|-----------|----------|
| `edit.svg` | New Voyage Entry button |
| `Icon-8.svg` | Generate Report button |
| `Icon-4.svg` | Print Upload button |

## ??? Logo

**File**: `wwwroot/images/cabinops-logo.jpg`  
**Source**: `LOGO/Image.jpeg`  
**Used in**: Sidebar logo container

## ?? Icon Styling

### Sidebar Icons
```css
.nav-icon-svg {
  width: 18px;
  height: 18px;
  filter: brightness(0) saturate(100%) invert(87%);
}

/* On hover/active - white */
.sidebar .nav-link:hover .nav-icon-svg,
.sidebar .nav-link.active .nav-icon-svg {
  filter: brightness(0) invert(100%);
}
```

### Dashboard Stat Icons
- **Blue (Voyage)**: `filter: brightness(0) invert(32%) sepia(96%) saturate(1831%)`
- **Red (Incidents)**: `filter: brightness(0) invert(28%) sepia(82%) saturate(2876%)`
- **Orange (Unsubmitted)**: `filter: brightness(0) invert(64%) sepia(98%) saturate(1773%)`

### Quick Action Icons
- **Primary button**: `filter: brightness(0) invert(1)` (white)
- **Secondary buttons**: No filter (original color)

## ?? Available Icons (Not Yet Used)

The following icons are available in `wwwroot/images/icons/` but not currently used:

- `Icon-1.svg`
- `Icon-10.svg`
- `Icon-11.svg`
- `Icon-12.svg`
- `Icon-13.svg`
- `Icon-14.svg`
- `Icon-16.svg`
- `Icon-18.svg`
- `Icon-19.svg`
- `Icon-20.svg`
- `Group.svg` (gradient background)
- `Group-1.svg` through `Group-5.svg`
- `User plus.svg`
- `Vector.svg`, `Vector-1.svg`, `Vector-2.svg`
- `X circle.svg`

## ?? How to Add New Icons

1. **Place SVG in folder**: Copy to `wwwroot/images/icons/`

2. **Use in sidebar**:
```html
<a class="nav-link" asp-controller="YourController" asp-action="YourAction">
    <img src="~/images/icons/your-icon.svg" class="nav-icon-svg" alt="" />
    <span>Menu Item</span>
</a>
```

3. **Use in dashboard**:
```html
<img src="~/images/icons/your-icon.svg" alt="Description" 
     style="width:24px;height:24px;" />
```

4. **Apply color filter** (if needed):
```css
filter: brightness(0) saturate(100%) invert(X%) sepia(Y%) saturate(Z%);
```

Use [CSS Filter Generator](https://codepen.io/sosuke/pen/Pjoqqp) to convert hex colors to CSS filters.

## ?? Icon Sizes

| Location | Size |
|----------|------|
| Sidebar navigation | 18×18px |
| Dashboard stat cards | 28×28px |
| Flight icons | 24×24px |
| Quick action buttons | 18×18px |
| Sidebar logo | Auto height (max 32px) |

## ? Implementation Complete

All icons from the LOGO folder have been:
- ? Copied to `wwwroot/images/icons/`
- ? Integrated into sidebar navigation
- ? Used in dashboard statistics
- ? Applied to flight entries
- ? Added to quick actions
- ? Styled with appropriate filters

The application now uses professional SVG icons throughout instead of emojis!
