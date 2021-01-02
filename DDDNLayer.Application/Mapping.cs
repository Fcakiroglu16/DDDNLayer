using AutoMapper;
using DDDNLayer.Application.Dtos;
using DDDNLayer.Domain.Commands.Category;
using DDDNLayer.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDDNLayer.Application
{
    internal class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<CategoryDto, AddCategoryCommand>().ReverseMap();
        }
    }
}