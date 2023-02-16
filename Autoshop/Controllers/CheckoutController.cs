using Autoshop.Infrastructure;
using Autoshop.Models;
using Autoshop.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Stripe;

namespace Autoshop.Controllers
{
    public class CheckoutController : Controller
    {

        public CheckoutController() { }
        public IActionResult Purchase(Guid id)
        {
            return View();
        }

        public IActionResult Index()
        {
            List<CartItem> cart = HttpContext.Session.GetJson<List<CartItem>>("Cart") ?? new List<CartItem>();

            CheckoutViewModel checkoutVM = new()
            {
                GrandTotal = cart.Sum(x => x.Quantity * x.Price)
            };

            return View(checkoutVM);
        }

        /* [HttpPost]
         public IActionResult Create(string stripeToken, Guid id) 
         {
             var product = _productService.GetProductById(id);
             var charge = new ChargeCreateOptions()
             {
                 Amount = (long)(Convert.ToDouble(Item.Price) * 100),
                 Currency = "cad",
                 Source = stripeToken,
                 Metadata = new Dictionary<string, string>()
                 {
                     { }
                 } 
             };

         }*/
    }
}
