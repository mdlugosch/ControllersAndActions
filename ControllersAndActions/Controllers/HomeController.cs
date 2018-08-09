using ControllersAndActions.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllersAndActions.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index() => View("SimpleForm");

        //public ViewResult ReceiveForm()
        //{
        //    var name = Request.Form["name"];
        //    var city = Request.Form["city"];
        //    return View("Result", $"{name} lives in {city}");
        //}

        // Actionmethode die über gleichlautende Parameternamen vom Client Parameterwerte zugewiesen bekommt
        //public ViewResult ReceiveForm(string name, string city)
        //    => View("Result", $"{name} lives in {city}");

        // Pattern: Post/Redirect/Get
        [HttpPost]
        public RedirectToActionResult ReceiveForm(string name, string city)
        {
            TempData["name"] = name;
            TempData["city"] = city;
            return RedirectToAction(nameof(Data));
        }

        public ViewResult Data()
        {
            string name = (string)TempData["name"];
            string city = (string)TempData["city"];
            return View("Result", $"{name} lives in {city}");
        }
        // Generieren einer Antwort über ein Http Response context object
        //public void ReceiveForm(string name, string city)
        //{
        //    Response.StatusCode = 200;
        //    Response.ContentType = "text/html";
        //    byte[] content = Encoding.ASCII.GetBytes($"<html><body>{name} lives in {city}</body>");
        //    Response.Body.WriteAsync(content, 0, content.Length);
        //}

        //public IActionResult ReceiveForm(string name, string city)      
        //    => new CustomHtmlResult
        //       {
        //           Content = $"{name} lives in {city}"
        //       };

    }
}
