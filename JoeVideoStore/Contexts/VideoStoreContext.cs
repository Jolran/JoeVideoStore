using JoeVideoStore.Models;
using System.Data.Entity;

namespace JoeVideoStore.Contexts
{
    public class VideoStoreContext : DbContext
    {
        public DbSet<MovieModel> Movies { get; set; }
        public DbSet<CustomerModel> Customers { get; set; }
    }
}