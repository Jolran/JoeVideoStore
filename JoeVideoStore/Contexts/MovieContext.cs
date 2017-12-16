using JoeVideoStore.Models;
using System.Data.Entity;

namespace JoeVideoStore.Contexts
{
    public class MovieContext : DbContext
    {
        public DbSet<MovieModel> Movies { get; set; }
    }
}