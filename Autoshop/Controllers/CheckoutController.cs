using Autoshop.Models;
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

        [HttpPost]
        public IActionResult Create(string stripeToken, Guid id) 
        {
            var product = _productService.GetProductById(id);
            var charge = new ChargeCreateOptions()
            {
                Amount = (long)(Convert.ToDouble(Item.Price)*100),
                Currency = "cad",
                Source = stripeToken,
                Metadata = new Dictionary<string, string>()
                {
                    { }
                }
            }
        
        }
    }
}
