using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;

namespace Redi_Cache.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        private readonly IDistributedCache _cache;
        public ValuesController(IDistributedCache cache)
        {
            _cache = cache;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            _cache.SetString("test", "Hi Rizla", new DistributedCacheEntryOptions{AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(30)});
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            string a = _cache.GetString("test");
            string b = _cache.GetString("foo");
            return string.Format("{0},{1}", a, b);
            //return "value";
            //ConnectionMultiplexer connection = ConnectionMultiplexer.Connect(redisCacheConnection);
            //IEnumerable<RedisKey> keys = connection.GetServer(redisServerLocation).Keys();
            //RedisKey key = keys.FirstOrDefault(k =>k.ToString().Contains("") && k.ToString().Contains(""));
            //string newkey = key.ToString().Substring(6); // Remove instance name from the key and generate key string in this case "master"
            //return await _cache.GetStringAsync(newkey);
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
