using AutoMapper;
using ECommerce.API.DTOs;
using ECommerce.API.Models;

namespace ECommerce.API.Mappings
{
    public class ProductMappingProfile : Profile
    {
        public ProductMappingProfile()
        {
            CreateMap<Product, ProductDto>();
            CreateMap<CreateProductDto, Product>();
        }
    }
}
