using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FerriesDirect_WebApi.Api.Models
{
    public class PersonDto
    {
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public int Score { get; set; }
    }
}
