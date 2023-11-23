using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        //
        // GET: /HelloWorld/
        //public string Index() //HTTP endpoint
        //{
        //    return "This is my default action...";
        //}
        //
        // GET: /HelloWorld/Welcome 
        //public string Welcome(string name, int ID = 1) //HTTP endpoint
        //{
        //    return HtmlEncoder.Default.Encode($"Hello {name}, ID {ID}");
        //}


        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;
            return View();
        }
    }
}
