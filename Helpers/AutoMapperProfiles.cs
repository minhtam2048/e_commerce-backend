using AutoMapper;
using Shop_API.Dtos;
using Shop_API.Models;

namespace Shop_API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Product, ProductForListDto>();
            CreateMap<Product, ProductForDetailedDto>();
        }
    }
}