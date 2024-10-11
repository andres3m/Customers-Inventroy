using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using customers_inventory.Models;

namespace customers_inventory.Data
{
    public class customers_inventoryContext : DbContext
    {
        public customers_inventoryContext (DbContextOptions<customers_inventoryContext> options)
            : base(options)
        {
        }

        public DbSet<customers_inventory.Models.Customer> Customer { get; set; } = default!;
    }
}
