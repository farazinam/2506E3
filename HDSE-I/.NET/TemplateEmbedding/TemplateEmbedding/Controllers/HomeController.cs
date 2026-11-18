using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Update.Internal;
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
            //below three lines are for removing session from cache
            Response.Headers["Cache-Control"] = "no-cache, no-store, must-revalidate";
            Response.Headers["Pragma"] = "no-cache";
            Response.Headers["Expires"] = "0";

            if (HttpContext.Session.GetInt32("RoleId") == 1)
            {
                return View();
            }
            else if (HttpContext.Session.GetInt32("RoleId") == 2)
            {
                return RedirectToAction("Index", "User");
            }
            else
            {
                return RedirectToAction("SignIn", "Auth");
            }
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
            if (ModelState.IsValid)
            {
                db.Categories.Add(c);
                db.SaveChanges();
                return RedirectToAction("ViewCategory");
            }
            else
            {
                return View("AddCategory");
            }
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
            var category = db.Categories.Find(id);

            if (category == null)
            {
                TempData["Error"] = "Category not found.";
                return RedirectToAction("ViewCategory");
            }

            // Check whether products use this category
            bool hasProducts = db.Products
                .Any(p => p.CatId == id);

            if (hasProducts)
            {
                TempData["Error"] =
                    "This category cannot be deleted because products are associated with it.";

                return RedirectToAction("ViewCategory");
            }

            db.Categories.Remove(category);
            db.SaveChangesAsync();

            TempData["Success"] = "Category deleted successfully.";

            return RedirectToAction("ViewCategory");
        }


        //Update Category
        [HttpGet]
        public IActionResult UpdateCategory(int id)
        {
            var upd = db.Categories.FirstOrDefault(x => x.CategoryId == id);
            return View(upd);
        }

        [HttpPost]
        public IActionResult UpdateCategory(Category c)
        {
            db.Categories.Update(c);
            db.SaveChanges();
            return RedirectToAction("ViewCategory");
        }


        //----------------------------------------------


        //Add Category
        [HttpGet]
        public IActionResult AddProduct()
        {
            ViewBag.Cats = new SelectList(db.Categories, "CategoryId", "CategoryName");
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(Product p, IFormFile f)
        {
            if (ModelState.IsValid) {
                var imgname = Path.GetFileName(f.FileName);

                string imagePath = Path.Combine(HttpContext.Request.PathBase.Value, "wwwroot/images");
                string imgSavePath = Path.Combine(imagePath, imgname);

                using (var stream = new FileStream(imgSavePath, FileMode.Create))
                {
                    f.CopyTo(stream);
                }

                p.ProductImage = imgname;

                db.Products.Add(p);
                db.SaveChanges();
                return RedirectToAction("ViewProduct");
            }
            else
            {
                return View("AddProduct");
            }
        }


        public IActionResult ViewProduct()
        {
            var getdata = db.Products.Include(p => p.Cat).ToList();
            return View(getdata);
        }

        //Delete Cteagory
        [HttpGet]
        public IActionResult DeleteProduct(int id)
        {
            var del = db.Products.FirstOrDefault(x => x.ProductId == id);
            db.Products.Remove(del);
            db.SaveChanges();
            return RedirectToAction("ViewProduct");
        }

        //Update Category
        [HttpGet]
        public IActionResult UpdateProduct(int id)
        {
            ViewBag.Cats = new SelectList(db.Categories, "CategoryId", "CategoryName");
            var upd = db.Products.FirstOrDefault(x => x.ProductId == id);
            return View(upd);
        }

        [HttpPost]
        public IActionResult UpdateProduct(Product p, IFormFile f, string oldimg)
        {
            if (f != null && f.Length > 0) {
                var imgname = Path.GetFileName(f.FileName);

                string imagePath = Path.Combine(HttpContext.Request.PathBase.Value, "wwwroot/images");
                string imgSavePath = Path.Combine(imagePath, imgname);

                using (var stream = new FileStream(imgSavePath, FileMode.Create))
                {
                    f.CopyTo(stream);
                }

                p.ProductImage = imgname;
                db.Products.Update(p);
                db.SaveChanges();

            }
            else
            {
                p.ProductImage = oldimg;
                db.Products.Update(p);
                db.SaveChanges();
            }

                return RedirectToAction("ViewProduct");
        }

        //Delete Cteagory
        [HttpGet]
        public IActionResult DeleteBrand(int id)
        {
            var brand = db.Brands.Find(id);

            db.Brands.Remove(brand);
            db.SaveChangesAsync();

            return RedirectToAction("ViewBrand");
        }


        //Update Category
        [HttpGet]
        public IActionResult UpdateBrand(int id)
        {
            var upd = db.Brands.FirstOrDefault(x => x.BrandId == id);
            return View(upd);
        }

        [HttpPost]
        public IActionResult UpdateBrand(Brand b)
        {
            db.Brands.Update(b);
            db.SaveChanges();
            return RedirectToAction("ViewBrand");
        }



        // ------------ Brand CRUD
        [HttpGet]
        public IActionResult AddBrand()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddBrand(Brand b)
        {
            db.Brands.Add(b);
            db.SaveChanges();
            return RedirectToAction();
        }

        //View Brand
        public IActionResult ViewBrand()
        {
            var getdata = db.Brands.ToList();
            return View(getdata);
        }




        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
