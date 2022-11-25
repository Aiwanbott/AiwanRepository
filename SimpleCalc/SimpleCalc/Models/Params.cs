using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleCalc.Models
{
    public class Params
    {
        [Required]
        public double Value1 { get; set; }

        [Required]
        public double Value2 { get; set; }
    }
}
