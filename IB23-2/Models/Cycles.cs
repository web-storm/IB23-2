using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IB23_2.Models
{
    public class Cycles
    {
        [Key]
        public int Id { get; set; }
        public int Number { get; set; }
        public DateTime StartTime { get; set; }
        public Cycles(int number)
        {
            Number = number;
            StartTime = DateTime.Now;
        }
    }
}