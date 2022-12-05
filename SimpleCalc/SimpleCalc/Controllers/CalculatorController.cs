using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SimpleCalc.Models;
using SimpleCalc.Interfaces;
using SimpleCalc.Services;
using SimpleCalc.Data;

namespace SimpleCalc.Controllers
{
    [Route("[controller]")]
    public class CalculatorController : Controller
    {
        private readonly ILogger<CalculatorController> _logger;
        private readonly ICalculationService _calculationService;

        public CalculatorController(ILogger<CalculatorController> logger,
            ICalculationService calculationService, CalculatorDbContext context)
        {
            _logger = logger;
            _calculationService = calculationService;
        }

        /// <summary>
        /// Сложение
        /// </summary>
        /// <param name="cal"></param>
        /// <returns></returns>
        [HttpPost("addition")]
        public IActionResult Add(Params cal)
        {
            var res = _calculationService.Add(cal.Value1, cal.Value2);

            string str = $"Сложение числа " +
                $"{cal.Value1} и числа {cal.Value2} = {res}";

            return Ok(str);
        }

        /// <summary>
        /// Вычитание
        /// </summary>
        /// <param name="cal"></param>
        /// <returns></returns>
        [HttpPost("difference")]
        public IActionResult Dif(Params cal)
        {
            var res = _calculationService.Sub(cal.Value1, cal.Value2);

            string str = $"Результат вычитания из числа " +
                $"{cal.Value1} число {cal.Value2} = {res}";

            return Ok(str);
        }

        /// <summary>
        /// Умножение
        /// </summary>
        /// <param name="cal"></param>
        /// <returns></returns>
        [HttpPost("multiplication")]
        public IActionResult Mul(Params cal)
        {
            var res = _calculationService.Mul(cal.Value1, cal.Value2);

            string str = $"Результат умножения числа " +
                $"{cal.Value1} на число {cal.Value2} = {res}";

            return Ok(str);
        }

        /// <summary>
        /// Деление
        /// </summary>
        /// <param name="cal"></param>
        /// <returns></returns>
        [HttpPost("division")]
        public IActionResult Div(Params cal)
        {
            var res = _calculationService.Div(cal.Value1, cal.Value2);

            string str = $"Результат деления числа " +
                $"{cal.Value1} на число {cal.Value2} = {res}";

            return Ok(str);
        }

        /// <summary>
        /// Взятие корня
        /// </summary>
        /// <param name="cal"></param>
        /// <returns></returns>
        [HttpPost("Root")]
        public IActionResult Sqrt(Params cal)
        {
            var res = _calculationService.Sqrt(cal.Value1, cal.Value2);

            string str = $"Результат возведения  в степень 1/" +
                $"{cal.Value2} числа {cal.Value1} = {res}";

            return Ok(str);
        }

        /// <summary>
        /// Возведение в степень
        /// </summary>
        /// <param name="cal"></param>
        /// <returns></returns>
        [HttpPost("Pow")]
        public IActionResult Pow(Params cal)
        {
            var res = _calculationService.Pow(cal.Value1, cal.Value2);

            string str = $"Результат возведения в степень " +
                $"{cal.Value2} числа {cal.Value1} = {res}";

            return Ok(str);
        }

    }
}
