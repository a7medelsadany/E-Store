using Domain.Entities.AddressModule;
using Domain.Entities.ProductModule;

namespace Domain.Entities.Order
{
    public class Order:BaseObject
    {
        public decimal OrderTotal { get; set; }
        public decimal OrderItemTotal { get; set; }
        public decimal ShippingCharge { get; set; }
        public long CustomerId { get; set; }
        public Customer.Customer Customer { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public long AddressId { get; set; }
        public Address DeliveryAddress  { get; set; }
        public IEnumerable<OrderItem> OrderItems { get; set; }

    }
}
