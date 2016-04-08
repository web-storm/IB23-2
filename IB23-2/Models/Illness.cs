
using System.ComponentModel.DataAnnotations;
namespace IB23_2.Models
{
    public class Illness
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Pills { get; set; }
    }
}