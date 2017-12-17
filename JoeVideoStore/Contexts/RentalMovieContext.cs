using JoeVideoStore.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace JoeVideoStore.Contexts
{
    public class RentalMovieContext : DbContext
    {
        public DbSet<RentalMovie> RentalMovies { get; set; }
    }
}