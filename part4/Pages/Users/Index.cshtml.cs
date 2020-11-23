using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using part4.Data;
using part4.Models;

namespace part4.Pages.Users
{
    public class IndexModel : PageModel
    {
        private readonly part4.Data.OrderContext _context;

        public IndexModel(part4.Data.OrderContext context)
        {
            _context = context;
        }

        public IList<User> User { get;set; }

        public async Task OnGetAsync()
        {
            User = await _context.Users.ToListAsync();
        }
    }
}
