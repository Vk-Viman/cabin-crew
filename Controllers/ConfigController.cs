using Microsoft.AspNetCore.Mvc;

namespace Cabin_Crew.Web.Controllers;

public class ConfigController : Controller
{
    public IActionResult Control()
    {
        ViewData["Title"] = "Access Control";
        return View();
    }
}
