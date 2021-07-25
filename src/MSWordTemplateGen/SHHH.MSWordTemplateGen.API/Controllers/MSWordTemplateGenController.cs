using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace SHHH.MSWordTemplateGen.API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class MSWordTemplateGenController : ControllerBase
    {
        private readonly ILogger<MSWordTemplateGenController> _logger;

        public MSWordTemplateGenController(ILogger<MSWordTemplateGenController> logger)
        {
            _logger = logger;
        }

        [HttpGet("Test")]
        public string Test()
        {
            return "working";
        }
    }
}
