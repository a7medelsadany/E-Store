using Domain.Entities.ProductModule;

namespace Domain.Entities.Customer
{
    public class Person:BaseObject
    {
        public string FirstName { get; set; }=string.Empty;
        public string MiddleName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string EmailAddress { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public Gender Gender { get; set; }
        public string DateOfBirth { get; set; } = string.Empty;
    }
}
