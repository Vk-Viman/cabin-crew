using Microsoft.AspNetCore.Mvc;

namespace Cabin_Crew.Web.Controllers;

public class ReportsController : Controller
{
    public IActionResult Index()
    {
        ViewData["Title"] = "Generate Reports";
        return View();
    }
}
