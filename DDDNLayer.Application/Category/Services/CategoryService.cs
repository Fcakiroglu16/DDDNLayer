using DDDNLayer.Application.Category.Dtos;
using DDDNLayer.Application.Dtos;
using DDDNLayer.Application.Mediator;
using DDDNLayer.Data;

using DDDNLayer.Domain.Core.Models;
using DDNLayer.Application.Queries;
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

        public async Task<Response> Add(CreateCategoryDto categoryDto)
        {
            var AddCategoryCommand = ObjectMapper.Mapper.Map<DDDNLayer.Application.Commands.AddCategoryCommand>(categoryDto);

            return await _mediatorHandler.SendCommand(AddCategoryCommand);
        }

        public async Task<Response> GetAll()
        {
            return await _mediatorHandler.SendQuery(new GetCategoryListQuery());
        }

        public async Task<Response> GetAllByName(string name)
        {
            return await _mediatorHandler.SendQuery(new GetCategoryListByNameQuery() { Name = name });
        }
    }
}