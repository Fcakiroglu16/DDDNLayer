using DDDNLayer.Application.Category.Dtos;
using DDDNLayer.Application.Dtos;
using DDDNLayer.Data;
using DDDNLayer.Domain.Core.Mediator;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DDDNLayer.Application.Category.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IMediatorHandler _mediatorHandler;

        public CategoryService(IMediatorHandler mediatorHandler)
        {
            _mediatorHandler = mediatorHandler;
        }

        public Task<ValidationResult> Add(CreateCategoryDto categoryDto)
        {
            var AddCategoryCommand = ObjectMapper.Mapper.Map<Domain.CategoryDomain.AddCategoryCommand>(categoryDto);

            return _mediatorHandler.SendCommand(AddCategoryCommand);
        }
    }
}