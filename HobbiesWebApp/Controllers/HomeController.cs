using Mission07_Watts.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Mission07_Watts.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() //View #1 Hobbies
        {
            return View();
        }

        public IActionResult About() //View #2 Calculation part of the assignment
        {
            return View();
        }

        [HttpGet]
        public IActionResult Form()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Form(Application response)
        {
            return View("completion");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
