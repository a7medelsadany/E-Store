using Domain.Entities.AddressModule;
using Domain.Entities.ProductModule;

namespace Domain.Entities.Customer
{
    public class Customer:BaseObject
    {
        public long PersonId { get; set; }
        public Person Person { get; set; }
        //public IEnumerable<Order> Orders { get; set; }
        public  IEnumerable<Address> Addresses { get; set; }
    }
}
