using AutoMapper;
using Domain.Entities.ProductModule;
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
        }
    }
}
