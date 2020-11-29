using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using part4.Models;

namespace part4.Pages
{
    public class DeleteModel : PageModel
    {
        private readonly part4.Data.OrderContext _context;

        public DeleteModel(part4.Data.OrderContext context)
        {
            _context = context;
        }
        [BindProperty]
        public Order Order { get; set; }
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Order = await _context.Orders
            .AsNoTracking()
            .FirstOrDefaultAsync(m => m.OrderID == id);

            if (Order == null)
            {
                return NotFound();
            }
            return Page();
        }
        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var order = await _context.Orders.FindAsync(id);
            if (order == null)
            {
                return NotFound();
            }

                _context.Orders.Remove(order);
                await _context.SaveChangesAsync();
                return RedirectToPage("./Orders");
        
        }
    }
}
