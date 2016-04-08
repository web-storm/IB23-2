
using System.ComponentModel.DataAnnotations;

namespace IB23_2.Models
{
    public class News
    {
        [Key]
        public int Id { get; set; }
        public string Header { get; set; }
        public string Content { get; set; }
        public bool IsVisible { get; set; }
    }
}