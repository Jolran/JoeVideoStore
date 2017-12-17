using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JoeVideoStore.Models
{
    public class RentalMovie
    {
        //public RentalMovie(){}

        //public RentalMovie(int movieid, int customerid )
        //{
        //    MovieId = movieid;
        //    CustomerId = customerid;
        //    RentStart = DateTime.Now;
        //}

        [Key]
        public int Id { get; set; } // dont touch (EF)
        [Required]
        public int MovieId { get; set; }
        [Required]
        public int CustomerId { get; set; }
        [Required]
        public DateTime RentStart { get; set; }
        public DateTime RentEnd { get; set; } 
    }
}

