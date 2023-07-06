using MyMiddleWebServer.ActionResults;

namespace MyMiddleWebServer.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Cont()
    {
        return Content();
    }

    public IActionResult JsonFile()
    {
        return Json();
    }

    public IActionResult Nothing()
    {
        return Empty();
    }

    public IActionResult Pdf()
    {
        return File();
    }

    public IActionResult Rdrct()
    {
        return Redirect();
    }
}
