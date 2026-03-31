# ?? CabinOps Frontend Implementation - Complete Guide

## ? What Has Been Built

Based on the Business Requirements Document (BRD), I've implemented the frontend for the CabinOps Cabin Crew Web Application.

---

## ?? Pages Implemented

### 1. **Dashboard** (`/` or `/Home/Index`)
? **Status: Complete**

**Features:**
- Welcome banner with user greeting and date
- 3 Statistics cards:
  - Voyage Reports (6) - with trend indicator
  - Incidents (10) - with alert count
  - Unsubmitted Reports (2) - action required
- 2 Interactive charts:
  - Incidents by Category (Bar chart)
  - Activity Trends (Line chart)
- Upcoming Flights section (4 flights with status)
- Recent Incidents list
- Quick Actions buttons

**Route:** `/` or `/Home/Index`  
**File:** `Views/Home/Index.cshtml`

---

### 2. **Generate Reports** (`/Reports/Index`)
? **Status: Complete** - **Matches BRD Screenshots**

**Features:**
- **Left Panel - Report Configuration:**
  - Report Type dropdown (Incident/Voyage)
  - Start Date picker
  - End Date picker
  - Generate button
  - Quick Time Period Presets:
    - Last 7 Days
    - Last 14 Days
    - Last 30 Days

- **Right Panel - Report Preview:**
  - Empty state (before generation)
  - Report header with date range
  - Statistics cards:
    - Total Records
    - Open Items
    - Closed Items
  - Sample data table preview
  - Export buttons (PDF & Excel)

**Route:** `/Reports/Index`  
**File:** `Views/Reports/Index.cshtml`  
**BRD Section:** 2.3.1 - Generate Reports by Time Period

---

### 3. **Access Control** (`/Config/Control`)
? **Status: Complete** - **Matches BRD Screenshots**

**Features:**
- **Left Panel - Search & Configuration:**
  - Search Ground Staff by ID or Name
  - Staff details card display
  - Current Access Configuration table:
    - Staff ID
    - Name
    - Department
    - Incident Reports access
    - Voyage Reports access

- **Right Panel - Module Permissions:**
  - Toggle switches for:
    - Incident Reports (View for assigned flights)
    - Voyage Reports (View for assigned flights)
  - Save Configuration button
  - Access Control Notes (yellow info card)

**Route:** `/Config/Control`  
**File:** `Views/Config/Control.cshtml`  
**BRD Section:** 2.2.9 - Settings / Access Control

---

### 4. **Sidebar Navigation**
? **Status: Complete with Professional Icons**

**Sections:**
- Dashboard
- **INCIDENT MANAGEMENT**
  - Incident Reports
- **VOYAGE MANAGEMENT**
  - Voyage Reports
  - Unsubmitted Reports
  - Manual Voyage Entry
- **CREW MANAGEMENT**
  - CabinOps iPad Tracker
  - Cabin Crew by Flight
  - Signature Recovery
  - Update Pilot Details
- **REPORTS**
  - Generate Reports
- **CONFIGURATION**
  - Access Control

**File:** `Views/Shared/_Layout.cshtml`

---

## ?? Design System

### Color Palette
```css
Primary Blue:    #3b82f6, #1e40af, #1e3a8a
Success Green:   #10b981, #d1fae5
Warning Orange:  #f59e0b, #fed7aa
Danger Red:      #ef4444, #fee2e2
Neutral Gray:    #e5e7eb, #f9fafb, #111827
```

### Typography
```css
Font Family:     Inter, sans-serif
Base Size:       16px (1rem)
Headings:        600-700 weight
Body:            400-500 weight
```

### Components
- **Circular Icon Badges** (56×56px) for statistics
- **Rounded Cards** (12px radius) for content
- **Toggle Switches** for permissions
- **Status Badges** for OPEN/CLOSED/ENABLED/DISABLED
- **Data Tables** with hover effects
- **Export Buttons** (PDF=Red, Excel=Green)

---

## ?? File Structure

```
Cabin-Crew.Web/
??? Controllers/
?   ??? HomeController.cs          ? Dashboard
?   ??? ReportsController.cs       ? Generate Reports
?   ??? ConfigController.cs        ? Access Control
?
??? Views/
?   ??? Home/
?   ?   ??? Index.cshtml           ? Dashboard page
?   ??? Reports/
?   ?   ??? Index.cshtml           ? Generate Reports (NEW)
?   ??? Config/
?   ?   ??? Control.cshtml         ? Access Control (UPDATED)
?   ??? Shared/
?       ??? _Layout.cshtml         ? Sidebar & Top Bar
?
??? wwwroot/
?   ??? css/
?   ?   ??? site.css               ? Global styles
?   ?   ??? sidebar.css            ? Navigation styles
?   ?   ??? figma-tokens.css       ? Design tokens
?   ??? images/
?       ??? icons/                 ? 33 SVG icons
?       ??? cabinops-logo.jpg      ? Logo
?
??? Documentation/
    ??? FRONTEND_SETUP.md          ? Setup guide
    ??? ICON_MAPPING.md            ? Icon reference
    ??? DASHBOARD_ICON_STYLING.md  ? Styling guide
    ??? FIGMA_EXPORT_GUIDE.md      ? Figma integration
```

---

## ?? Pages To Be Built (From BRD)

Based on your BRD, here are the remaining pages to implement:

### **INCIDENT MANAGEMENT**

#### 1. Incident Reports List (`/Incidents/Index`)
**User Stories:** 01 (Ground Staff), 05 (Crew Admin)  
**Features Needed:**
- Sortable table (Flight Date, Board Point, Flight No, Description, Status)
- Search bar
- Entries per page dropdown
- Ascending/descending sort
- Click row to view details
- Details view with:
  - Full incident information
  - Image gallery
  - Inspector comments (Admin only)
  - Assign button (Admin only)

**Files to Create:**
- `Views/Incidents/Index.cshtml` - List view
- `Views/Incidents/Details.cshtml` - Detail view
- Update `Controllers/IncidentsController.cs`

---

### **VOYAGE MANAGEMENT**

#### 2. Voyage Reports List (`/Voyage/Reports`)
**User Stories:** 02 (Ground Staff), 06 (Crew Admin)  
**Features Needed:**
- Sortable table (Flight Date, Flight No, Board Point, Off Point)
- Search bar
- Click row to view full voyage report
- Details include:
  - General Information
  - Crew Information
  - Regulatory
  - Confirmation of Safety
  - Incidents
  - Delay Report
  - General Comments
  - SNY Crew
  - Passengers
  - FlySmiles PAX
  - Special Needs PAX
  - Neighbor Free Seat
  - Water
  - Meal Consumption

**Files to Create:**
- `Views/Voyage/Reports.cshtml` - List view
- `Views/Voyage/Details.cshtml` - Full report view

---

#### 3. Unsubmitted Voyage Reports (`/Voyage/Unsubmitted`)
**User Story:** 07 (Crew Admin)  
**Features Needed:**
- Sortable by Date
- Display columns:
  - FLT Date Operate
  - FlightNo
  - AC RegNO
  - SEC ARV
  - SEC DEPT
  - STATUS
  - PURSER
  - CABIN SUPERVISORS

**Files to Create:**
- `Views/Voyage/Unsubmitted.cshtml`

---

#### 4. Manual Voyage Entry (`/Voyage/ManualEntry`)
**User Story:** 11 (Crew Admin)  
**Features Needed:**
- Common Voyage Report Info form
- Crew Information - Add (with staff search)
- Crew Information - View/Delete table
- Incidents Related form
- Incidents Reported table
- Submit/Delete buttons

**Files to Create:**
- `Views/Voyage/ManualEntry.cshtml`

---

### **CREW MANAGEMENT**

#### 5. CabinOps iPad Tracker (`/Crew/Tracker`)
**User Story:** 08 (Crew Admin)  
**Features Needed:**
- Sortable by Flight No, Flight Date, Boardpoint
- Display:
  - Flight Date
  - Flight Number
  - BoardPoint
  - Action Date Time
  - Task Performed
  - Device ID
  - Record Indicator

**Files to Create:**
- `Views/Crew/Tracker.cshtml`

---

#### 6. Cabin Crew by Flight (`/Crew/Flight`)
**User Story:** 12 (Crew Admin)  
**Features Needed:**
- Sortable by Date, Flight Number
- List of flights (Flight No, Origin, Destination)
- Click to view crew details:
  - CAT, EMPNo, Name, Date of Promotion
  - Gender, Nationality, Onboard, Position
  - Safety sign, Sign

**Files to Create:**
- `Views/Crew/Flight.cshtml` - List
- `Views/Crew/CrewDetails.cshtml` - Details

---

#### 7. Signature Recovery (`/Crew/Recovery`)
**User Story:** 13 (Crew Admin)  
**Features Needed:**
- Sortable by Flight No, Flight Date, Boardpoint
- "Recover" button per entry

**Files to Create:**
- `Views/Crew/Recovery.cshtml`

---

#### 8. Update Pilot Details (`/Crew/Details`)
**User Story:** 14 (Crew Admin)  
**Features Needed:**
- Sort by Flight No, Flight Date, Boardpoint
- "Load" button
- Editable table:
  - Staff ID, First Name, Last Name
  - Departure, Citizenship, Sex
  - Is Landing/Operating/Relief Pilot dropdowns
- "Add or Update" button

**Files to Create:**
- `Views/Crew/Details.cshtml`

---

## ?? Implementation Priority

### **Phase 1: Core Viewing** (Recommended Next)
1. ? Dashboard - **DONE**
2. ? Generate Reports - **DONE**
3. ? Access Control - **DONE**
4. ?? Incident Reports List & Details
5. ?? Voyage Reports List & Details

### **Phase 2: Management Features**
6. Unsubmitted Voyage Reports
7. Manual Voyage Entry
8. Cabin Crew by Flight

### **Phase 3: Admin Tools**
9. CabinOps iPad Tracker
10. Signature Recovery
11. Update Pilot Details

---

## ?? Usage Instructions

### Current Pages

#### **Dashboard**
```
Navigate to: / or /Home/Index
Features: View statistics, charts, flights, incidents
Dummy Data: Yes
```

#### **Generate Reports**
```
Navigate to: /Reports/Index
1. Select Report Type (Incident/Voyage)
2. Enter Start Date & End Date
3. Click "Generate" button
4. View report preview with stats
5. Export as PDF or Excel
```

#### **Access Control**
```
Navigate to: /Config/Control
1. Search for Ground Staff by ID or Name
2. View current permissions table
3. Toggle module permissions (Incident/Voyage Reports)
4. Click "Save Configuration"
```

---

## ?? How to Run

```bash
# Build the project
dotnet build

# Run the application
dotnet run --project Cabin-Crew.Web.csproj

# Or press F5 in Visual Studio
```

Then navigate to:
- **Dashboard:** https://localhost:5001/
- **Reports:** https://localhost:5001/Reports
- **Access Control:** https://localhost:5001/Config/Control

---

## ?? Dummy Data

All pages currently use dummy/mock data. You can replace with real data by:

1. Creating ViewModels in `ViewModels/` folder
2. Updating Controllers to fetch data from services
3. Passing models to views

**Example:**
```csharp
// ViewModel
public class IncidentReportViewModel
{
    public string FlightNo { get; set; }
    public DateTime FlightDate { get; set; }
    public string Description { get; set; }
    public string Status { get; set; }
}

// Controller
public IActionResult Index()
{
    var incidents = _incidentService.GetAll();
    return View(incidents);
}

// View
@model List<IncidentReportViewModel>
@foreach(var incident in Model)
{
    <tr>
        <td>@incident.FlightNo</td>
        <td>@incident.FlightDate</td>
        ...
    </tr>
}
```

---

## ? What's Next?

### **Tell me which page to build next:**

1. **Incident Reports** (High Priority - Core Feature)
2. **Voyage Reports** (High Priority - Core Feature)
3. **Unsubmitted Voyage Reports**
4. **Manual Voyage Entry**
5. **Cabin Crew by Flight**
6. **iPad Tracker**
7. **Signature Recovery**
8. **Update Pilot Details**

**Or** provide specific requirements/screenshots for any custom page!

---

## ?? Design Consistency

All pages follow:
- ? Same sidebar navigation
- ? Same top bar with user profile
- ? Consistent color scheme (blues, oranges, reds, greens)
- ? Professional SVG icons
- ? Responsive design
- ? Clean, modern UI matching BRD screenshots

---

## ?? Ready for Next Steps!

Your CabinOps frontend now has:
- ? Professional dashboard
- ? Report generation system
- ? Access control management
- ? Complete navigation structure
- ? Design system in place

**Just tell me which page to build next, and I'll implement it with dummy data!** ??
