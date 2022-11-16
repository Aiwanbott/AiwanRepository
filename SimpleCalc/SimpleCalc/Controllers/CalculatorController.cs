using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SimpleCalc.Models;

namespace SimpleCalc.Controllers
{
    [Route("[controller]")]
    public class CalculatorController : Controller
    {
        private readonly ILogger<CalculatorController> _logger;
        public CalculatorController(ILogger<CalculatorController> logger)
        {
            _logger = logger;
        }
        [HttpPost("addition")]
        public IActionResult Add(Calculator cal)
        {
            double a, b;
            a = cal.value1;
            b = cal.value2;
            return Ok(a + b);

        }

        [HttpPost("difference")]
        public IActionResult Dif(Calculator cal)
        {
            double a, b;
            a = cal.value1;
            b = cal.value2;
            return Ok(a - b);
        }
        [HttpPost("multiplication")]
        public IActionResult Mul(Calculator cal)
        {
            double a,b;
            a = cal.value1;
            b = cal.value2;
            return Ok(a * b);
        }
        [HttpPost("division")]
        public IActionResult Div(Calculator cal)
        {
            double a, b;
            a = cal.value1;
            b = cal.value2;
            return Ok(a / b);
        }
        
        
    }
}
