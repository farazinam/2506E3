using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TemplateEmbedding.Models;

namespace TemplateEmbedding.Controllers
{
    public class AuthController : Controller
    {

        private readonly MiniprojectContext adb;

        public AuthController(MiniprojectContext _adb)
        {
            adb = _adb;
        }

        public IActionResult Signup()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Signup(User u, string cpassword)
        {
            var CheckExistingUser = adb.Users.FirstOrDefault(t => t.Email == u.Email);

            if (u.Password != cpassword)
            {
               ViewBag.DoNotMatch =  "Passwords do not Match";
                return View();
            }

            else if (CheckExistingUser != null)
            {
                ViewBag.AlreadyExist = "User Already Exists";
                return View();
            }

            else
            {
            var hasher = new PasswordHasher<string>();  //Convert password in hash
            u.Password = hasher.HashPassword(u.Email, u.Password);
            ViewBag.AccountCreated = "Account Created";
            adb.Users.Add(u);
            adb.SaveChanges();
            return View();
            }
        }


        public IActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignIn(string email, string password)
        {
            var user = await adb.Users.FirstOrDefaultAsync(u => u.Email == email);
            if (user == null)
            {
                ViewBag.InvalidEmail = "User Not Found";
                return View();
            }

            else
            {
                var hasher = new PasswordHasher<User>();
                var result = hasher.VerifyHashedPassword(user, user.Password!, password);
                if (result == PasswordVerificationResult.Failed)
                {
                    ViewBag.InvalidPass = "Incorrect Password";
                }

                HttpContext.Session.SetInt32("UserId", user.UserId);
                HttpContext.Session.SetString("UserName", user.Username);
                HttpContext.Session.SetString("UserEmail", user.Email);
                HttpContext.Session.SetInt32("RoleId", user.RoleId);

                return RedirectToAction("Index", "User");
            }
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            HttpContext.Session.Remove("UserId");
            HttpContext.Session.Remove("UserName");
            HttpContext.Session.Remove("UserEmail");
            HttpContext.Session.Remove("RoleId");
            return RedirectToAction("SignIn", "Auth");
        }

    }
}
