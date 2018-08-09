using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControllersAndActions.Controllers
{
    public class ExampleController : Controller
    {
        //public ViewResult Index()
        //{
        //    ViewBag.Message = "Hello";
        //    ViewBag.Date = DateTime.Now;
        //    return View();
        //}

        //public JsonResult Index() => Json(new[] { "Alice", "Bob", "Joe" });
        //public ContentResult Index() => Content("[\"Alice\",\"Bob\",\"Joe\"]", "application/json");
        public ObjectResult Index() => Ok(new string[] { "Alice", "Bob", "Joe" });

        public VirtualFileResult bootstrap()
        => File("/lib/bootstrap/dist/css/bootstrap.css", "text/css");

        //public RedirectToActionResult Redirect() => RedirectToAction(nameof(HomeController), nameof(HomeController.Index));
        public RedirectToActionResult Redirect() => RedirectToAction(nameof(Index));

        // Mit dem Cast der Zeichenkette zum Objekt verhindert man das MVC
        // den String fehlinterpretiert und als Viewnamen deutet (und nach etwas suchen würde was nicht exesatiert)
        public ViewResult Result() => View((object)"Hello World");

        /*public RedirectResult Redirect() => Redirect("/Example/Index");*/

        //public RedirectToRouteResult Redirect() =>
        //    RedirectToRoute(new { controller = "Example",
        //        action = "Index",
        //        ID = "MyID" });
    }
}
