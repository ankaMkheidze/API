using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace trying_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "v1", "v2" };
        }
        [HttpGet("{id}")]
        public ActionResult<string> Get(string id) { return "value"; }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value) { }

        [HttpDelete("{id}")]
        public void Delete(int id) { }
    }
}