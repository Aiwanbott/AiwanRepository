using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleCalc.Models
{
    public class Calculator
    {
        [Required]
        public double value1 { get; set; }

        [Required]
        public double value2 { get; set; }
    }
}
