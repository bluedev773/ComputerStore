using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Authorization;
using part4.Models;
using Microsoft.EntityFrameworkCore;

namespace part4.Pages
{
    public class OrdersModel : PageModel
    {

        private readonly part4.Data.OrderContext _context;
        public OrdersModel(part4.Data.OrderContext context)
        {
            _context = context;
        }
        public string UserID { get; set; }
        public IList<Order> Orders { get; set; }
        

        public async Task OnGetAsync()
        {
            UserID = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            IQueryable<Order> usersID = from s in _context.Orders
                                             select s;
            if (UserID != null)
            {
                usersID = usersID.Where(s => s.UserID == UserID);
            }

            Orders = await usersID.AsNoTracking().ToListAsync();

        }
    }
}