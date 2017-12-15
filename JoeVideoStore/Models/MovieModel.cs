using System.ComponentModel.DataAnnotations;

namespace JoeVideoStore.Models
{
    public class MovieModel
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public int Length { get; set; }
        public int Rating { get; set; }
        public string Genre { get; set; }
    }
}