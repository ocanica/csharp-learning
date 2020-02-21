using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FerriesDirect_WebApi.Api.Models
{
    public class PersonDto
    {
        [JsonPropertyName("FirstName")]
        public string FirstName { get; set; }
        [JsonPropertyName("Surname")]
        public string Surname { get; set; }
        [JsonPropertyName("Score")]
        public int Score { get; set; }
    }
}
