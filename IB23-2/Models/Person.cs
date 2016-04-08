using System.ComponentModel.DataAnnotations;

namespace IB23_2.Models
{
    public class Person
    {
        [Key] 
        public int Id { get; set; }
        public string Name { get; set; }
        public string Insurance { get; set; }
        public string Passport { get; set; }
        public string Position { get; set; }
        public bool Licence { get; set; }

    }
}