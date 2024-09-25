using System.ComponentModel.DataAnnotations;

namespace TodoList.Models
{
    public class Mission
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }=string.Empty;
        public bool Done { get; set; } = false;
    }
}
