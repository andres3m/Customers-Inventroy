using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using customers_inventory.Data;
using customers_inventory.Models;

namespace customers_inventory.Pages.Customers
{
    public class IndexModel : PageModel
    {
        private readonly customers_inventory.Data.customers_inventoryContext _context;

        public IndexModel(customers_inventory.Data.customers_inventoryContext context)
        {
            _context = context;
        }

        public IList<Customer> Customer { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Customer = await _context.Customer.ToListAsync();
        }
    }
}
