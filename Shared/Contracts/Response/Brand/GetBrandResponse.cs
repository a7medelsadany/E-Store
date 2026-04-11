using Shared.DTOS.ProductDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Contracts.Response.Brand
{
    public class GetBrandResponse : ResponseBase
    {
        public BrandDto Brand { get; set; }
    }
}
