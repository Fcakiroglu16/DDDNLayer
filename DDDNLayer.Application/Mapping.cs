using AutoMapper;
using DDDNLayer.Application.Category.Dtos;
using DDDNLayer.Domain.Commands.Category;

namespace DDDNLayer.Application
{
    internal class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<Domain.Entities.Category, CategoryDto>().ReverseMap();
            CreateMap<CategoryDto, AddCategoryCommand>().ReverseMap();
        }
    }
}