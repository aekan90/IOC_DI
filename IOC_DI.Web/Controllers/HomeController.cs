using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using IOC_DI.Web.Models;
using System.Security.AccessControl;
using IOC_DI.Web.Models.Services.Abstract;

namespace IOC_DI.Web.Controllers;

public class HomeController : Controller
{
    private readonly ISingletonDateService _singletonDateService;

    public HomeController(ISingletonDateService singletonDateServiceConst)
    {
        _singletonDateService = singletonDateServiceConst;
    }

    public IActionResult Index([FromServices]ISingletonDateService singletonDateServiceMetot)
    {
        ViewBag.time1 = _singletonDateService.GetDateTime.TimeOfDay.ToString();
        ViewBag.time2 = singletonDateServiceMetot.GetDateTime.TimeOfDay.ToString(); 
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
