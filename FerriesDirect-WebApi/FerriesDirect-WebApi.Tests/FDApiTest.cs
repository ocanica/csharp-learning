using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;

namespace FerriesDirect_WebApi.Tests
{
    public class FDApiTest
        :IClassFixture<WebApplicationFactory<FerriesDirect_WebApi.Api.Startup>>
    {
        private readonly WebApplicationFactory<FerriesDirect_WebApi.Api.Startup> _factory;
        private readonly HttpClient _client;

        public FDApiTest(WebApplicationFactory<FerriesDirect_WebApi.Api.Startup> factory)
        {
            _factory = factory;
            _client = _factory.CreateClient();
        }

        [Fact]
        public async Task Get_EndpointReturnsStatusCodeOK()
        {
            // "AAA" testing pattern
            // Arrange
            var response = await _client.GetAsync("get");
            // Act
            response.EnsureSuccessStatusCode();
            // Assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task Get_EndpointReturnsJsonResult()
        {
            var response = await _client.GetAsync("get");
            Assert.Equal("application/json; charset=utf-8", response.Content.Headers.ContentType.ToString());
        }
    }
}
