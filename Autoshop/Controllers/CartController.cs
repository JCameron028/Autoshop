using Autoshop.Infrastructure;
using Autoshop.Models;
using Autoshop.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Autoshop.Controllers
{
    public class CartController : Controller
    {

        private readonly DataContext _context;
        public CartController(DataContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<CartItem> cart = HttpContext.Session.GetJson<List<CartItem>>("Cart") ?? new List<CartItem>();

            CartViewModel CartVM = new()
            {
                CartItems = cart,
                GrandTotal = cart.Sum(x => x.Quantity * x.Price),
            };

            return View(CartVM);
        }

        public async Task<IActionResult> Add(long id)
        {
            Product product = await _context.Products.FindAsync(id);
            List<CartItem> cart = HttpContext.Session.GetJson<List<CartItem>>("Cart") ?? new List<CartItem>();
            CartItem cartItem = cart.Where(c => c.ProductId == id).FirstOrDefault();

            if (cartItem == null)
            {
                cart.Add(new CartItem(product));
            }
            else
            {
                cartItem.Quantity += 1;
            }

            HttpContext.Session.SetJson("Cart",cart);

            TempData["Success"] = "The product has beed added!";

            return Redirect(Request.Headers["Referer"].ToString());
        }
    }
}

