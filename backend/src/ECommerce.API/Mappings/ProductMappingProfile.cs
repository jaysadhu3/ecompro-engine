using AutoMapper;
using ECommerce.API.Models;
using ECommerce.API.DTOs;

namespace ECommerce.API.Mappings;

public class ProductMappingProfile : Profile
{
    public ProductMappingProfile()
    {
        CreateMap<Product, ProductDto>()
            .ForMember(dest => dest.CategoryName,
                opt => opt.MapFrom(src => src.Category!.Name));

        CreateMap<CreateProductDto, Product>();
    }
}