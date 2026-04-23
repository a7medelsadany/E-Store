using Domain.Entities.ProductModule;

namespace Domain.Entities.AddressModule
{
    public class Address:BaseObject
    {
        public string Name { get; set; }=string.Empty;
        public string AddressLine1 { get; set; }=string.Empty;
        public string AddressLine2 { get; set; }=string.Empty;
        public string City { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public string ZipCode { get; set; } = string.Empty;
    }
}
