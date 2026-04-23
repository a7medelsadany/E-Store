using AutoMapper;
using Domain.Entities.Address;
using Domain.Entities.Cart;
using Domain.Entities.ProductModule;
using Shared.DTOS.AddressDtos;
using Shared.DTOS.CartDtos;
using Shared.DTOS.ProductDtos;


namespace Services
{
    public class MappingProfiles:Profile
    {
        public MappingProfiles()
        {
            #region Brand <--> BrandDto
            CreateMap<Brand, BrandDto>().ReverseMap();
            #endregion

            #region Product <---> ProductDto
            CreateMap<Product, ProductDto>().ReverseMap();
            #endregion

            #region Category <---> CategoryDto
            CreateMap<Category, CategoryDto>().ReverseMap();
            #endregion

            #region Cart <---> CartDto
            CreateMap<Cart, CartDto>().ReverseMap();
            #endregion

            #region CartItem <---> CartItemDto
            CreateMap<CartItem, CartItemDto>().ReverseMap();
            #endregion

            #region Address  <---> AddressDto
            CreateMap<Address, AddressDto>().ReverseMap(); 
            #endregion
        }
    }
}
