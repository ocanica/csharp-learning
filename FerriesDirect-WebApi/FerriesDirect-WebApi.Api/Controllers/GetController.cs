using FerriesDirect_WebApi.Api.Contracts.V1;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FerriesDirect_WebApi.Api.Controllers
{
    public class GetController : Controller
    {
        /// <summary>
        /// GET api/v1/get
        /// This returns all the information from the current end-point 
        /// </summary>
        [HttpGet(ApiRoutes.Items.GetAll)]
        public IActionResult GetAll()
        {
            return Ok();
        }

    }
}
