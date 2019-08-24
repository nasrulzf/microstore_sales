using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace MicrostoreSalesService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new String[] { "Test1", "Test2" };
        }

        [HttpGet("{detail}")]
        public ActionResult<string> Get(String detail)
        {
            return "Item : " + detail;
        }
    }
}