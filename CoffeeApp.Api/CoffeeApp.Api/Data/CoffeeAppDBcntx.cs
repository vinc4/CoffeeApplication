
using CoffeeApp.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace CoffeeApp.Api.Data
{
    public class CoffeeAppDBcntx : DbContext
    {
        public CoffeeAppDBcntx(DbContextOptions options) : base(options) 
        {
        
        }

        public DbSet<Clients> Clients { get; set; } 
    }
}
