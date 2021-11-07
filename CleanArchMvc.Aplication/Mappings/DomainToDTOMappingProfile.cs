using AutoMapper;
using CleanArchMvc.Aplication.DTO;
using CleanArchMvc.Domain.Entities;

namespace CleanArchMvc.Aplication.Mappings
{
    public class DomainToDTOMappingProfile : Profile
    {
        public DomainToDTOMappingProfile()
        {
            CreateMap<Product, ProductDTO>().ReverseMap();
            CreateMap<Category, CategoryDTO>().ReverseMap();
        }
    }
}