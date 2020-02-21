using FerriesDirect_WebApi.Api.Contracts.V1;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace FerriesDirect_WebApi.Api.Controllers
{
    public class GetController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public GetController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        /// <summary>
        /// GET api/v1/get
        /// This returns all the information from the current end-point 
        /// </summary>
        [HttpGet(ApiRoutes.Items.GetAll)]
        public async Task<ActionResult> GetAll()
        {
            var client = _httpClientFactory.CreateClient("mockable");
            var result = await client.GetStringAsync("");
            return Ok(result);
        }

    }
}
