using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using DirectFerries_WebApi.Api.Models;
using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;

namespace FerriesDirect_WebApi.Tests
{
    public class DFApiTest
    {
        private readonly HttpClient _client;
        private readonly string baseUrl = "api/people";

        public DFApiTest()
        {
            var factory = new WebApplicationFactory<DirectFerries_WebApi.Api.Startup>();
            _client = factory.CreateClient();
        }

        [Fact]
        public void PassingTest()
        {
        }

        [Fact]
        public async Task Get_ReturnsStatusCodeOK()
        {
            // "AAA" testing pattern
            // Arrange
            var response = await _client.GetAsync(baseUrl);
            // Act
            response.EnsureSuccessStatusCode();
            // Assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task Get_ReturnsResult()
        {
            var response = await _client.GetAsync(baseUrl);
            response.EnsureSuccessStatusCode();
            Assert.NotNull(response.Content);
            Assert.Equal("text/plain; charset=utf-8", response.Content.Headers.ContentType.ToString());
        }

        [Fact]
        public async Task Get_ReturnAllResults()
        {
            var testItem = new List<PersonDto>()
            {
                new PersonDto { FirstName = "Nazim", Surname = "Ellis", Score = 100 },
                new PersonDto { FirstName = "Maximilian", Surname = "Vicker", Score = 12},
                new PersonDto { FirstName = "Cheyenne", Surname = "Flowers", Score = 47},
                new PersonDto { FirstName = "Tonya", Surname = "Lyons", Score = 12}
            };
            
            var response = await _client.GetAsync(baseUrl);
            response.EnsureSuccessStatusCode();
            Assert.Equal(JsonSerializer.Serialize(testItem), response.Content.ReadAsStringAsync().Result);
        }

        [Fact]
        public async Task Get_SortedScoreResult()
        {
            var testItem = new List<PersonDto>()
            {
                new PersonDto { FirstName = "Nazim", Surname = "Ellis", Score = 100 },
                new PersonDto { FirstName = "Cheyenne", Surname = "Flowers", Score = 47},
                new PersonDto { FirstName = "Maximilian", Surname = "Vicker", Score = 12},
                new PersonDto { FirstName = "Tonya", Surname = "Lyons", Score = 12}
            };

            var response = await _client.GetAsync($"{baseUrl}?ordertype=score");
            response.EnsureSuccessStatusCode();
            Assert.Equal(JsonSerializer.Serialize(testItem), response.Content.ReadAsStringAsync().Result);
        }

        // Old test
        /*[Fact]
        public async Task Get_ResturnsFirstJsonResult()
        {
            var testItem = new PersonDto()
            {
                FirstName = "Nazim",
                Surname = "Ellis",
                Score = 100
            };

            var response = await _client.GetAsync($"{url}/first");
            var assertion = JsonSerializer.Serialize(testItem);
            Assert.Equal(assertion, response.Content.ReadAsStringAsync().Result);
        }*/
    }
}
