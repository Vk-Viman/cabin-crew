using Cabin_Crew.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace Cabin_Crew.Web.Controllers;

public class CrewController : Controller
{
    private readonly ICrewMemberService _service;

    public CrewController(ICrewMemberService service)
    {
        _service = service;
    }

    public IActionResult Index()
    {
        var crew = _service.GetCrew();
        return View(crew);
    }

    public IActionResult Tracker()
    {
        ViewData["Title"] = "CabinOps iPad Tracker";
        return View();
    }

    public IActionResult Flight()
    {
        ViewData["Title"] = "Cabin Crew by Flight";
        return View();
    }

    public IActionResult Details()
    {
        ViewData["Title"] = "Update Pilot Details";
        return View();
    }

    public IActionResult Recovery()
    {
        ViewData["Title"] = "Signature Recovery";
        return View();
    }
}
