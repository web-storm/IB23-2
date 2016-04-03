using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace IB23_2.Models
{
    public class Session
    {
        [Key]
        public int Id { get; set; }

        public Session() {  }
    
    }

}