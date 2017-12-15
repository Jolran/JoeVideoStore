using System.ComponentModel.DataAnnotations;

namespace JoeVideoStore.Models
{
    public class MovieModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public int Length { get; set; }
        [Required]
        public int Rating { get; set; }
        [Required]
        public string Genre { get; set; }
    }
}