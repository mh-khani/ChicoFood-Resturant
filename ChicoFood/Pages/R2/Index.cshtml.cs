using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ChicoFood.Core;
using ChicoFood.Data;

namespace ChicoFood.Pages.R2
{
    public class IndexModel : PageModel
    {
        private readonly ChicoFood.Data.ChicoFoodDbContext _context;

        public IndexModel(ChicoFood.Data.ChicoFoodDbContext context)
        {
            _context = context;
        }

        public IList<Restaurant> Restaurant { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Restaurant = await _context.Restaurants.ToListAsync();
        }
    }
}
