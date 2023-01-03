using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

namespace WebApplication1.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? Type { get; set; }

    }
}
