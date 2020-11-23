using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using part4.Models;
using part4.Data;
using Microsoft.EntityFrameworkCore;

namespace part4.Pages
{
    public class ProductsModel : PageModel
    {
        // private readonly StoreContext db;
        //public ProductsModel(StoreContext db) => this.db = db;
        //  public List<Product> Products { get; set; } = new List<Product>();
        // public Product FeaturedProduct { get; set; }
        //public async Task OnGetAsync()
        //{
        // Products = await db.Products.ToListAsync();
        // }
        private readonly part4.Data.OrderContext _context;

        public ProductsModel(part4.Data.OrderContext context)
        {
            _context = context;
        }

        public List<Product> Products { get; set; } = new List<Product>();

        public async Task OnGetAsync()
        {
            Products = await _context.Products.ToListAsync();
        }
    }
}
