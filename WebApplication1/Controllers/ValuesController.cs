using System.Collections.Generic;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "Mono", "Linux", "WebAPI 2 works!" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return $"You requested item ID: {id}";
        }
    }
}