using DirectFerries_WebApi.Api.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace DirectFerries_WebApi.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PeopleController : ControllerBase
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly Task<List<PersonDto>> _repo;

        public PeopleController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
            _repo = DeserialiseJsonAsnyc();
        }

        /// <summary>
        /// Asynchronous network call that returns a deserialised list 
        /// of objects Task<List<T>>.
        /// </summary>
        /// <remarks>
        /// Needs refactoring to implement try catch block
        /// </remarks>
        private async Task<List<PersonDto>> DeserialiseJsonAsnyc()
        {
            var client = _httpClientFactory.CreateClient("mockable");
            var response = await client.GetStringAsync("");
            return JsonSerializer.Deserialize<List<PersonDto>>(response);
        }

        /// <summary>
        /// Returns a sorted, serialised JSON string object if queries name or
        /// score are passed; otherwise the function returns an unsorted string
        /// </summary>
        /// <param name="orderType">name, score</param>
        /// <remarks>
        /// Example usesage: api/people?ordertype=score
        /// </remarks>
        [HttpGet()]
        public async Task<ActionResult> Get([FromQuery] string orderType)
        {
            var repo = await _repo;
            IEnumerable<PersonDto> result;
            switch (orderType)
            {
                case "name":
                    result = repo.OrderBy(x => x.FirstName);
                    break;
                case "score":
                    result = repo.OrderByDescending(x => x.Score);
                    break;
                default:
                    return Ok(JsonSerializer.Serialize(repo));
            }

            return Ok(JsonSerializer.Serialize(result));
        }
    }
}
