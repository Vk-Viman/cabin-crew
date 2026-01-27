using Microsoft.AspNetCore.Mvc;

namespace Cabin_Crew.Web.Controllers;

public class VoyageController : Controller
{
    public IActionResult Reports()
    {
        ViewData["Title"] = "Voyage Reports";
        return View();
    }

    public IActionResult Unsubmitted()
    {
        ViewData["Title"] = "Unsubmitted Voyage Reports";
        return View();
    }

    public IActionResult ManualEntry()
    {
        ViewData["Title"] = "Manual Voyage Entry";
        return View();
    }
}
