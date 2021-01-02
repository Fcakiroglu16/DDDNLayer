using DDDNLayer.Application.Category.Dtos;
using DDDNLayer.Application.Dtos;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DDDNLayer.Application.Category.Services
{
    public interface ICategoryService
    {
        Task<ValidationResult> Add(CategoryDto categoryDto);
    }
}