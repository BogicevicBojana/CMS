using System.Linq.Expressions;
using CompanyManagementSystem.Data.Extensions;
using System.Collections.Generic;
using System;
using Newtonsoft.Json;

namespace CompanyManagementSystem.API.Response
{
    public class Response<T> where T : class
    {
        [JsonProperty(Order = 1)]
        public int Code { get; set; }

        [JsonProperty(Order = 2)]
        public string Message { get; set; }

        [JsonProperty(Order = 3)]
        public T? Data { get; set; }
        public Response() { }

        public Response(string message, T? data, int code)
        {
            this.Data = data;
            this.Code = code;
            this.Message = message;
        }
        public Response( T? data)
        {
            this.Data = data;
        }

        public void AddData(T Data)
        {
            this.Data = Data;
        }

        public void AddCode(string code)
        {
            this.Code = Code;
        }
    }
}