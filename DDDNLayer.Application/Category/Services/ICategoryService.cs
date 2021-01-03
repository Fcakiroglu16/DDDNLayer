using DDDNLayer.Application.Category.Dtos;
using DDDNLayer.Application.Dtos;
using DDDNLayer.Domain.Core.Models;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DDDNLayer.Application.Category.Services
{
    public interface ICategoryService
    {
        Task<Response> Add(CreateCategoryDto categoryDto);
    }
}