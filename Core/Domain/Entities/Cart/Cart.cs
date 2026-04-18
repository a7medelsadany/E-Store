using Domain.Entities.ProductModule;

namespace Domain.Entities.Cart
{
    public class Cart:BaseObject
    {
        public Cart()
        {
            CartItems = new List<CartItem>();
        }
        public CartStatus CartStatus { get; set; }
        public ICollection<CartItem> CartItems { get; set; }
    }
}
