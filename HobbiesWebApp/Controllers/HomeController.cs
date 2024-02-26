using Mission07_Watts.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            ViewBag.Categories = _context.Categories
                .OrderBy(x => x.CategoryName)
                .ToList();
            return View(new Movie());
        }

        [HttpPost]
        public IActionResult Form(Movie response)
        {
            if (ModelState.IsValid)
            {
                _context.Movies.Add(response); //Add record to the database
                _context.SaveChanges();
            }
            else //Invalid data
            {
                ViewBag.Categories = _context.Categories
                    .OrderBy(x => x.CategoryName)
                    .ToList();
                return View(response);
            }

            return View("completion", response);
        }

        public IActionResult Collection()  //Database colection view
        {
            //linq
            var applications = _context.Movies
                .Include("Category")
                .OrderBy(x => x.Title)
                .ToList();

            return View(applications);
        }

        [HttpGet]
        public IActionResult Edit(int id) //Edit view
        {
            ViewBag.Categories = _context.Categories
                .OrderBy(x => x.CategoryName)
                .ToList();

            var recordToEdit = _context.Movies
                .Single(x => x.MovieId == id);

            return View("form", recordToEdit);
        }

        [HttpPost]
        public IActionResult Edit(Movie updatedInfo) //Confirm Update changes
        {
            _context.Update(updatedInfo);
            _context.SaveChanges();

            return RedirectToAction("collection");
        }

        [HttpGet]
        public IActionResult Delete(int id) //Send to delete age
        {
            var recordToDelete = _context.Movies
                .Single(x => x.MovieId == id);

            return View(recordToDelete);
        }

        [HttpPost]
        public IActionResult Delete(Movie application) //Confirm deletion
        {
            _context.Movies.Remove(application);
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
