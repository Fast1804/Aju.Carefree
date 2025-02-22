﻿using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Aju.Carefree.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ApiControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult Get()
        {
            return Json("test data");
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

    }
}
