using Shared.DTOS.CartDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Contracts.Response.Cart
{
    public class FetchCartResponse:ResponseBase
    {
        public CartDto Cart { get; set; }
    }
}
