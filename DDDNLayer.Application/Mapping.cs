using AutoMapper;
using DDDNLayer.Application.Category.Dtos;
using DDDNLayer.Application.Commands;
using DDDNLayer.Application.Dtos;

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