using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IB23_2.Models
{
    public class Illness2People
    {
        [Key]
        public int Id { get; set; }
        public int PersonId { get; set; }
        public int IllnessId { get; set; }
    }
}