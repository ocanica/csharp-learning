using FerriesDirect_WebApi.Api.Contracts.V1;
using FerriesDirect_WebApi.Api.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace FerriesDirect_WebApi.Api.Controllers
{
    public class GetController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly Task<List<PersonDto>> _repo;

        public GetController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
            _repo = DeserialiseJsonAsnyc();
        }

        public async Task<List<PersonDto>> DeserialiseJsonAsnyc()
        {
            
            var client = _httpClientFactory.CreateClient("mockable");
            var response = await client.GetStringAsync("");
            var result = JsonSerializer.Deserialize<List<PersonDto>>(response);
            return result;
        }

        public async void TestGetMethod(List<PersonDto> results)
        {
            results = await DeserialiseJsonAsnyc();
        }

        /// <summary>
        /// GET api/v1/get
        /// Function returns all the results from the current end-point 
        /// </summary>
        [HttpGet(ApiRoutes.Items.GetAll)]
        public ActionResult GetAll()
        {
            var result = JsonSerializer.Serialize(_repo);
            return Ok(result);
        }

        [HttpGet("api/v1/test")]
        public ActionResult ListPersonByName()
        {
            
            // var result = _repo.OrderBy(x => x.FirstName).ToList();
            return Ok();
        }
    }
}
