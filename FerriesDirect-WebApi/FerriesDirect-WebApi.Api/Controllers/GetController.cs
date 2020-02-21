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
        private readonly PersonDto _person;

        public GetController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public PersonDto DeserialisePerson(string json)
        {
            return JsonSerializer.Deserialize<PersonDto>(json);
        }

        [HttpGet("api/v1/test")]
        public async Task<List<PersonDto>> Index()
        {
            
            var client = _httpClientFactory.CreateClient("mockable");
            var response = await client.GetStringAsync("");
            var personDto = JsonSerializer.Deserialize<List<PersonDto>>(response);
            return personDto;
        }

        /// <summary>
        /// GET api/v1/get
        /// Function returns all the results from the current end-point 
        /// </summary>
        [HttpGet(ApiRoutes.Items.GetAll)]
        public async Task<ActionResult> GetAll()
        {
            var client = _httpClientFactory.CreateClient("mockable");
            var response = await client.GetStringAsync("");
            return Ok(response);
        }
    }
}
