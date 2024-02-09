using HobbiesWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HobbiesWebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() //View #1 Hobbies
        {
            return View();
        }

        public IActionResult lessons() //View #2 Calculation part of the assignment
        {
            return View();
        }

        public IActionResult schedule()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
