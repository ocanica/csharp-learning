using System;
using System.Net;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using FerriesDirect_WebApi.Api.Models;
using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;

namespace FerriesDirect_WebApi.Tests
{
    public class FDApiTest
    {
        private readonly HttpClient _client;
        private readonly string url = "people";

        public FDApiTest()
        {
            var factory = new WebApplicationFactory<Api.Startup>();
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
            var response = await _client.GetAsync(url);
            // Act
            response.EnsureSuccessStatusCode();
            // Assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task Get_ReturnsJsonResult()
        {
            var response = await _client.GetAsync(url);
            Assert.Equal("application/json; charset=utf-8", response.Content.Headers.ContentType.ToString());
        }

        [Fact]
        public async Task Get_ResturnsFirstJsonResult()
        {
            var testItem = new PersonDto()
            {
                FirstName = "Nazim",
                Surname = "Ellis",
                Score = 100
            };

            //var peopleController = new PeopleController();
            var response = await _client.GetAsync($"{url}/first");
            //var actionResult = await peopleC
            var assertion = JsonSerializer.Serialize(testItem);
            //Assert.Equal(assertion,);
        }
    }
}
