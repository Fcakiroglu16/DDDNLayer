using FluentValidation.Results;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DDDNLayer.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomBaseController : ControllerBase
    {
        protected IActionResult Response(ValidationResult validationResult, int successfullStatusCode)
        {
            if (validationResult.IsValid)
            {
            }
            else
            {
            }

            return Ok();
        }
    }
}