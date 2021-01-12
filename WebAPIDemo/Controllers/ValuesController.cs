using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPIDemo.Controllers
{
    public class ValuesController : ApiController
    {
        
        static List<string> str = new List<string>() 
        { 
        "value1","value2","value3","value4"
        };
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return str;
        }
        [HttpGet]
        // GET api/values/5
        public string Get(int id)
        {
            return str[id];
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
            str.Add(value);
        }

        // PUT api/values/5
        [HttpPut]
        public void Put(int id, [FromBody] string value)
        {
            str[id] = value;
        }

        // DELETE api/values/5
        [HttpDelete]
        public void Delete(int id)
        {
            str.RemoveAt(id);

        }
    }
}
