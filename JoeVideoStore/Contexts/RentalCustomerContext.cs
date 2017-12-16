using JoeVideoStore.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace JoeVideoStore.Contexts
{
    public class RentalCustomerContext : DbContext
    {
        public DbSet<RentalCustomer> Customers { get; set; } 
    }
}