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
    [Route("api/matches")]
    [ApiController]
    public class MatchController : ControllerBase
    {
        private readonly ILogger<MatchController> _logger;

        public MatchController(ILogger<MatchController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Match> Get() => new List<Match>();

    }
}