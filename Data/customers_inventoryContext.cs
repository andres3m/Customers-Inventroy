using Microsoft.EntityFrameworkCore;
using customers_inventory.Models;

namespace customers_inventory.Data
{
    public class customers_inventoryContext : DbContext
    {
        public customers_inventoryContext(DbContextOptions<customers_inventoryContext> options)
            : base(options)
        {
        }

        public DbSet<Customer> Customer { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Retrieve connection string from the environment variable
                var connectionString = Environment.GetEnvironmentVariable("DB_CONNECTION_STRING");

                if (!string.IsNullOrEmpty(connectionString))
                {
                    optionsBuilder.UseNpgsql(connectionString);
                }
                else
                {
                    throw new InvalidOperationException("The connection string was not found in environment variables.");
                }
            }
        }
    }
}
