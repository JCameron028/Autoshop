namespace Autoshop.Models.ViewModels
{
    public class CheckoutViewModel
    {
        public List<CartItem> CartItem { get; set; }
        public string ProductName { get; set; }
        public decimal? Price { get; set; }
        public decimal GrandTotal { get; set; }
    }
}
