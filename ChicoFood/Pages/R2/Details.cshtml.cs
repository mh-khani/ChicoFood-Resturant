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
    public class DetailsModel : PageModel
    {
        private readonly ChicoFood.Data.ChicoFoodDbContext _context;

        public DetailsModel(ChicoFood.Data.ChicoFoodDbContext context)
        {
            _context = context;
        }

        public Restaurant Restaurant { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var restaurant = await _context.Restaurants.FirstOrDefaultAsync(m => m.Id == id);

            if (restaurant is not null)
            {
                Restaurant = restaurant;

                return Page();
            }

            return NotFound();
        }
    }
}
