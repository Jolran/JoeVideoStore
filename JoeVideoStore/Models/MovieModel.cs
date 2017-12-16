using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

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


        public static readonly List<SelectListItem> Ratings = new List<SelectListItem>()
        {
            new SelectListItem {Text = "1", Value = "1" },
            new SelectListItem {Text = "2", Value = "2" },
            new SelectListItem {Text = "3", Value = "3" },
            new SelectListItem {Text = "4", Value = "4" },
            new SelectListItem {Text = "5", Value = "5" }
        };

        public static readonly List<SelectListItem> Genres = new List<SelectListItem>()
        {
            new SelectListItem {Text = "Action", Value = "Action" },
            new SelectListItem {Text = "Adventure", Value = "Adventure" },
            new SelectListItem {Text = "Carton", Value = "Carton" },
            new SelectListItem {Text = "Comedy", Value = "Comedy" },
            new SelectListItem {Text = "Documentary", Value = "Documentary" },
            new SelectListItem {Text = "Drama", Value = "Drama" },
            new SelectListItem {Text = "Horror", Value = "Horror" },
            new SelectListItem {Text = "Musical", Value = "Musical" },
            new SelectListItem {Text = "Romantic", Value = "Romantic" },
            new SelectListItem {Text = "Sci-Fi", Value = "Sci-Fi" },
            new SelectListItem {Text = "Thriller", Value = "Thriller" },
            new SelectListItem {Text = "Western", Value = "Western" },
            new SelectListItem {Text = "Other", Value = "Other" }
        };

    }
}



