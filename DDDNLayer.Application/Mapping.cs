using AutoMapper;
using DDDNLayer.Application.Category.Dtos;
using DDDNLayer.Application.Dtos;
using DDDNLayer.Domain.CategoryDomain;

namespace DDDNLayer.Application
{
    internal class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<Domain.CategoryAggregate.Category, CategoryDto>().ReverseMap();
            CreateMap<CreateCategoryDto, AddCategoryCommand>().ReverseMap();
        }
    }
}