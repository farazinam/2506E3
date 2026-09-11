using System.Diagnostics;
using m_web.Models;
using Microsoft.AspNetCore.Mvc;

namespace m_web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewData["name"] = "ViewData Work";
            return View();
        }

        public IActionResult Privacy()
        {
            ViewBag.center = "Aptech Learning";
            ViewBag.center = "Aptech Learning II";

            TempData["Msg"] = "Temp Data Saved Successfully";
            TempData.Keep("Msg");
            return View();
        }
        public IActionResult About()
        {
            string[] months =
            { "Jan", "Feb", "Mar", "Apr", "May"};

            ViewBag.Mahinay = months;

            ViewBag.CurrentDate = DateTime.Now;
            return View();
        }
        public IActionResult Contact()
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
