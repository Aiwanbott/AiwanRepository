using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SimpleCalc.Models
{
    public class Calculation
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public decimal Param1 { get; set; }
                   
        public decimal Param2 { get; set; }

        public string ActionType { get; set; }

        public decimal Result { get; set; }
    }
}
