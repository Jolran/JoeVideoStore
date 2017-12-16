using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JoeVideoStore.Models
{
    public class Customer
    {
        public Customer()
        {
            rentedmovies = new List<int>();
        }

        private List<int> rentedmovies;
        public List<int> RentedMoviesId { get { return rentedmovies; } }

        [Key]
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Address { get; set; }
        public string Email { get; set; }

        
    }
}