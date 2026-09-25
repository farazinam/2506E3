using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TemplateEmbedding.Models;

namespace TemplateEmbedding.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        private readonly MiniprojectContext db;

        public HomeController(MiniprojectContext _db)
        {
            db = _db;
        }

        //Home Page
        public IActionResult Index()
        {
            return View();
        }


        //Add Category
        [HttpGet]
        public IActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddCategory(Category c)
        {
            db.Categories.Add(c);
            db.SaveChanges();
            return RedirectToAction("ViewCategory");
        }


        //View Category
        public IActionResult ViewCategory()
        {
            var getdata = db.Categories.ToList();
            return View(getdata);
        }


        //Delete Cteagory
        [HttpGet]
        public IActionResult DeleteCategory(int id)
        {
            var del = db.Categories.FirstOrDefault(x => x.CategoryId == id);
            db.Categories.Remove(del);
            db.SaveChanges();
            return RedirectToAction("ViewCategory");
        }








        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
