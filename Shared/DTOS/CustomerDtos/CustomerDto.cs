using Shared.DTOS.AddressDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTOS.CustomerDtos
{
    public class CustomerDto
    {
        public long Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string MiddleName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string EmailAddress { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public int Gender { get; set; }
        public string DateOfBirth { get; set; } = string.Empty;
        public DateTimeOffset CreateDate { get; set; }
        public DateTimeOffset ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
        //public IEnumerable<OrderDto> Orders { get; set; }
        public IEnumerable<AddressDto> Addresses { get; set; }
    }
}
