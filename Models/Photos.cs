using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Photos
    {
        [Key]
        public int Id { get; set; }
        public string? Url { get; set; }
        public string? DateAdded { get; set; } = DateTime.Now.ToString();
       
    }
}
