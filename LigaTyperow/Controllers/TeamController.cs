using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LigaTyperow.Models;
using LigaTyperow.Models.League;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace LigaTyperow.Controllers
{
    [Route("api/teams")]
    [ApiController]
    public class TeamController : ControllerBase
    {
        private readonly ILogger<MatchController> _logger;

        public TeamController(ILogger<MatchController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Team> Get() => new List<Team>();

        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}