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
        readonly IHttpClientFactory _httpClientFactory;
        List<PersonDto> _repo;

        public GetController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
            GetJsonResponseAsync();
        }

        // Return deserialised JSON response to repository
        private async void GetJsonResponseAsync()
        {
            _repo = await DeserialiseJsonAsnyc();
        }

        private async Task<List<PersonDto>> DeserialiseJsonAsnyc()
        {
            var client = _httpClientFactory.CreateClient("mockable");
            var response = await client.GetStringAsync("");
            var result = JsonSerializer.Deserialize<List<PersonDto>>(response);
            return result;
        }

        /// <summary>
        /// GET api/v1/get
        /// Function returns all the results from the current end-point 
        /// </summary>
        [HttpGet(ApiRoutes.Items.GetAll)]
        public ActionResult GetAll()
        {
            return Ok(JsonSerializer.Serialize(_repo));
        }

        [HttpGet("api/v1/test")]
        public ActionResult ListPersonByName()
        {
            //var orderedBy = _repo.OrderByDescending(x => x.FirstName);
            //var result = JsonSerializer.Serialize(orderedBy);
            return Ok();
        }
    }
}
