using System;
using System.Threading.Tasks;
using part4.Data;
using part4.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
namespace part4.Pages
{
    public class OrderModel : PageModel
    {
       // private StoreContext db;
       // public OrderModel(StoreContext db) => this.db = db;
        [BindProperty(SupportsGet = true)]
        public int Id { get; set; }
        public Product Product { get; set; }


        //public async Task OnGetAsync() => Product = await db.Products.FindAsync(Id);
    }


}