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
    [Route("api/footballers")]
    [ApiController]
    public class FootballerController : ControllerBase
    {
        private readonly ILogger<FootballerController> _logger;

        public FootballerController(ILogger<FootballerController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Footballer> Get() => new List<Footballer>();
    }
}