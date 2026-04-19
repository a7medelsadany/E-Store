using Shared.DTOS.ProductDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTOS.CartDtos
{
    public class CartItemDto
    {
        public long Id { get; set; }
        public long CartId  { get; set; }
        public ProductDto Product { get; set; }
        public int Quantity { get; set; }
    }
}
