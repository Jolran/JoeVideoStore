using JoeVideoStore.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace JoeVideoStore.Contexts
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext() : base("name=DataBaseContext")
        {

        }

        public DbSet<MovieModel> Movies { get; set; }
        public DbSet<RentalCustomer> Customers { get; set; }
        public DbSet<RentalMovie> RentalMovies { get; set; }
    }
}