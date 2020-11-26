using System;
using System.Threading.Tasks;
using part4.Data;
using part4.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;

namespace part4.Pages
{
    [Authorize]
    public class OrderModel : PageModel
    {
        public string UserID { get; set; }
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

        [BindProperty]
        public int[] UpgradeIDS { get; set; }

        //public async Task OnGetAsync() => Product = await _context.Products.FindAsync(id);
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            UserID = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            if (id == null)
            {
                return NotFound();
            }
            Product = await _context.Products.FindAsync(id);
            Upgrades = await _context.Upgrades.ToListAsync();
            Order = await _context.Orders
                .Include(s => s.UpgradePJT)
                .ThenInclude(e => e.Upgrade)
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.OrderID == id);
            if (Order == null)
            {
                return NotFound();
            }
            return Page();
        }
        
        public async Task<IActionResult> OnPostAsync()
        {
            var emptyOrder = new Order();

            if (await TryUpdateModelAsync<Order>(
                    emptyOrder,
                    "order",
                    s => s.ProductID, s => s.UserID, s => s.OrderDate, s => s.OrderPrice
                    ))
            {
                _context.Orders.Add(emptyOrder);
                await _context.SaveChangesAsync();
                return RedirectToPage("./Index");
            }
            return Page();
        }

    }

}