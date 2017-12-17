using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JoeVideoStore.Models
{
    public class RentalMovie
    {
        public RentalMovie(){}

        public RentalMovie(int movieid, int customerid )
        {
            MovieId = movieid;
            CustomerId = customerid;
            RentStart = DateTime.Now;
        }

        [Key]
        public int Id { get; set; } // dont touch (EF)
        public int MovieId { get; set; }
        public int CustomerId { get; set; }
        public DateTime RentStart { get; set; }
        public DateTime RentEnd { get; set; } 
    }
}