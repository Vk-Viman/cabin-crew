using Microsoft.AspNetCore.Mvc;

namespace Cabin_Crew.Web.Controllers;

public class IncidentsController : Controller
{
    public IActionResult Index()
    {
        ViewData["Title"] = "Incident Reports";
        return View();
    }
}
