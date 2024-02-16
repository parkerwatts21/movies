using Mission07_Watts.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Mission07_Watts.Controllers
{
    public class HomeController : Controller
    {
        private MovieApplicationContext _context;
        public HomeController(MovieApplicationContext temp) //Constructor
        {
            _context = temp;
        }
        public IActionResult Index() //View #1 Main Mage
        {
            return View();
        }

        public IActionResult About() //View #2 About Joel Hilton part of the assignment
        {
            return View();
        }

        [HttpGet]
        public IActionResult Form() //View #3 From part of the assignment
        {
            return View();
        }

        [HttpPost]
        public IActionResult Form(Application response)
        {
            _context.Applications.Add(response); //Add record to the database
            _context.SaveChanges();
            return View("completion");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
