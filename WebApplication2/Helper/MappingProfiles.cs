using AutoMapper;
using WebApplication2.Dto;
using WebApplication2.Models;

namespace WebApplication2.Helper;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<Country, CountryDto>();
        CreateMap<Product, ProductDto>();
        CreateMap<Harbor, HarborDto>();
    }
    
}