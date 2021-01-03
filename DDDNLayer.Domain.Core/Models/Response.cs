using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace DDDNLayer.Domain.Core.Models
{
    public class Response
    {
        public Object Data { get; private set; }
        public int StatusCode { get; private set; }

        [JsonIgnore]
        public bool IsSuccessful { get; private set; }

        public ErrorDto Fail { get; private set; }

        public static Response Success(Object data, int statusCode)
        {
            return new Response { Data = data, StatusCode = statusCode, IsSuccessful = true };
        }

        public static Response Success(int statusCode)
        {
            return new Response { Data = null, StatusCode = statusCode, IsSuccessful = true };
        }

        public static Response UnSuccess(ErrorDto errorDto, int statusCode)
        {
            return new Response
            {
                Fail = errorDto,
                StatusCode = statusCode,
                IsSuccessful = false
            };
        }

        public static Response UnSuccess(string errorMessage, int statusCode, bool isShow)
        {
            var errorDto = new ErrorDto(errorMessage, isShow);

            return new Response { Fail = errorDto, StatusCode = statusCode, IsSuccessful = false };
        }
    }
}