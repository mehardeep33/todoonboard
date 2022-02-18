
using System.ComponentModel.DataAnnotations;
namespace TodoApi.Models
{
    public class TodoItem
    {   [Key]
        public long Id { get; set; }
        public string? title { get; set; }
        public bool done { get; set; }
        public DateTime created { get; set; }
        public DateTime updated { get; set; }

        public Board bid {get; set;}

    }
}