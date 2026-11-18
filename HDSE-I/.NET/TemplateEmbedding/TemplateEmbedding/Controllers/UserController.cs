using System.Linq;
using System.Net.Mail;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TemplateEmbedding.Models;

namespace TemplateEmbedding.Controllers
{
    public class UserController : Controller
    {
        private readonly MiniprojectContext udb;

        public UserController(MiniprojectContext _udb)
        {
            udb = _udb;
        }
        public IActionResult Index()
        {
                var pros = udb.Products.ToList();
                return View(pros);
        }

        [HttpPost]
        public IActionResult Index(string searchpro)
        {

            var products = from p in udb.Products select p;
            if (!string.IsNullOrEmpty(searchpro))
            {
                products = products.Where(s => s.ProductName!.Contains(searchpro) || s.ProductDescription!.Contains(searchpro));
            }
            var pros = products.ToList();
            return View(pros);


        }

        public IActionResult About()
        {
            return View();
        } 
        public IActionResult SingleProduct(int id)
        {
            var foundId = udb.Products.FirstOrDefault(x => x.ProductId == id);
            return View(foundId);
        }

        [HttpPost]
        public IActionResult AddToCart(int proid, int quantity)
        {
            int? userId = HttpContext.Session.GetInt32("UserId");

            if (userId == null)
            {
                // User is not logged in, redirect to login page
                return RedirectToAction("SignIn", "Auth");
            }

            var existingCartItem = udb.Carts
                .FirstOrDefault(c => c.ProductId == proid && c.UserId == userId.Value);

            if (existingCartItem != null)
            {
                existingCartItem.Quantity += quantity;
                existingCartItem.CreatedAt = DateTime.Now;
                udb.Carts.Update(existingCartItem);
            }
            else
            {
                Cart newCart = new Cart
                {
                    ProductId = proid,
                    UserId = userId.Value,
                    Quantity = quantity,
                    CreatedAt = DateTime.Now
                };

                udb.Carts.Add(newCart);
            }

            udb.SaveChanges();

            return RedirectToAction("Cart", "User");
        }


        public IActionResult Cart()
        {
            int? userId = HttpContext.Session.GetInt32("UserId");

            if (userId == null)
            {
                return RedirectToAction("SignIn", "Auth");
            }

            var cartItems = udb.Carts
                .Include(c => c.Product)
                .Where(c => c.UserId == userId)
                .ToList();

            return View(cartItems);
        }

        public IActionResult Checkout()
        {
            int? userId = HttpContext.Session.GetInt32("UserId");
            if (userId == null)
                return RedirectToAction("SignIn", "Auth");

            var cartItems = udb.Carts
                .Include(c => c.Product)
                .Where(c => c.UserId == userId)
                .ToList();

            if (!cartItems.Any())
                return RedirectToAction("Cart");

            int? totalAmount = cartItems.Sum(c => c.Quantity * c.Product.ProductPrice);

            // Create Order
            var order = new Order
            {
                UserId = userId.Value,
                OrderDate = DateTime.Now,
                TotalAmount = totalAmount
            };

            udb.Orders.Add(order);
            udb.SaveChanges(); // Save to get OrderId

            // Add OrderDetails
            foreach (var item in cartItems)
            {
                var orderDetail = new OrderDetail
                {
                    OrderId = order.OrderId,
                    ProductId = item.ProductId,
                    Quantity = item.Quantity,
                    UnitPrice = item.Product.ProductPrice
                };

                udb.OrderDetails.Add(orderDetail);
            }

            // Clear cart
            udb.Carts.RemoveRange(cartItems);

            udb.SaveChanges();


            //Email Integration
            var user = udb.Users.FirstOrDefault(u => u.UserId == userId);
            if (user != null && !string.IsNullOrEmpty(user.Email))
            {
                try
                {
                    MailMessage message = new MailMessage();

                    message.From = new MailAddress("faraz_inam@aptechnorth.edu.pk");//Replace with sender email

                    message.To.Add(user.Email); // Customer's email

                    message.Subject = "Order Confirmation - Order #" + order.OrderId;

                    message.Body = $"Dear {user.Username},\n\n Thank you for your order #{order.OrderId} placed on {order.OrderDate:dd MMM yyyy}.\n" +
               $"Total Amount: ₹{order.TotalAmount}\n\n We’ll notify you when it’s shipped.\n\nThanks, Faraz Inam PVT limited.";

                    SmtpClient smtp = new SmtpClient("smtp.gmail.com")
                    {
                        Port = 587,
                        Credentials = new NetworkCredential("faraz_inam@aptechnorth.edu.pk", "eqvo fgph nhds pbcy"),
                        EnableSsl = true,
                    };

                    smtp.Send(message);
                }
                catch (Exception ex)
                {
                    // Optionally log the error or show a message
                    TempData["Error"] = "Order placed but failed to send confirmation email.";
                }
            }


            TempData["Success"] = "Order placed successfully!";

            return RedirectToAction("Index", "User");
        }

    }
}
