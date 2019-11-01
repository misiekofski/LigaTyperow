using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LigaTyperow.Models.League;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LigaTyperow.Controllers
{
    [Route("api/bets")]
    [ApiController]
    public class BetController : ControllerBase
    {
        // GET: api/Bet
        [HttpGet]
        public IEnumerable<Bet> Get() => new List<Bet>();

        // GET: api/Bet/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Bet
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Bet/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
