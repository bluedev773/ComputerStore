using System;
using System.Threading.Tasks;
using part4.Data;
using part4.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace part4.Pages
{
    public class OrderModel : PageModel
    {
        // private StoreContext db;
        // public OrderModel(StoreContext db) => this.db = db;

        // public int Id { get; set; }
        // public Product Product { get; set; }


        //public async Task OnGetAsync() => Product = await db.Products.FindAsync(Id);

        private readonly part4.Data.OrderContext _context;

        public OrderModel(part4.Data.OrderContext context)
        {
            _context = context;
        }
        [BindProperty(SupportsGet = true)]
        public int id { get; set; }
        public Product Product { get; set; }
        public Upgrade Upgrade { get; set; }
        public Order Order { get; set; }

        public List<Upgrade> Upgrades { get; set; } = new List<Upgrade>();



        //public async Task OnGetAsync() => Product = await _context.Products.FindAsync(id);
        public async Task OnGetAsync()
        {
            Product = await _context.Products.FindAsync(id);
            Upgrades = await _context.Upgrades.ToListAsync();
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            //_context.Orders.Add();
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }

    }

}