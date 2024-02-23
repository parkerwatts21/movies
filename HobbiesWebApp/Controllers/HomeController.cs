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
            return View(new Application());
        }

        [HttpPost]
        public IActionResult Form(Application response)
        {
            if (ModelState.IsValid)
            {
                _context.Applications.Add(response); //Add record to the database
                _context.SaveChanges();
            }
            else //Invalid data
            {
                return View(response);
            }

            return View("completion", response);
        }

        public IActionResult Collection()
        {
            //linq
            var applications = _context.Applications
                .OrderBy(x => x.movieTitle).ToList();

            return View(applications);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {

            var recordToEdit = _context.Applications
                .Single(x => x.movieID == id);

            return View("form", recordToEdit);
        }

        [HttpPost]
        public IActionResult Edit(Application updatedInfo)
        {
            _context.Update(updatedInfo);
            _context.SaveChanges();

            return RedirectToAction("collection");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var recordToDelete = _context.Applications
                .Single(x => x.movieID == id);

            return View(recordToDelete);
        }

        [HttpPost]
        public IActionResult Delete(Application application)
        {
            _context.Applications.Remove(application);
            _context.SaveChanges();

            return RedirectToAction("collection");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
