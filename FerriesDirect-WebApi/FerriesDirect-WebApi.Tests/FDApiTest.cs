using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using FerriesDirect_WebApi;
using Xunit;

namespace FerriesDirect_WebApi.Tests
{
    public class FDApiTest
    {
        private IHttpClientFactory _httpClientFactory;
        private HttpClient _client;

        public FDApiTest(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
            _client = _httpClientFactory.CreateClient("mockable");
        }

        [Fact]
        public async Task TestStatusCodeReturnsOK()
        {
            // "AAA" testing pattern
            // Arrange
            var response = await _client.GetAsync("");
            // Act
            response.EnsureSuccessStatusCode();
            // Assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}
