using ChicoFood.Core;
using ChicoFood.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ChicoFood.Pages.Resturants
{
    public class DetailModel : PageModel
    {
        private readonly IRestaurantData restaurantData;

        [TempData]
        public string Message { get; set; }

        public  Restaurant Restaurant { get; set; }

        public DetailModel(IRestaurantData restaurantData)
        {
            this.restaurantData = restaurantData;
        }

        public IActionResult OnGet(int restaturantId)
        {
            Restaurant = restaurantData.GetById(restaturantId);

            if (Restaurant == null)
                return RedirectToPage("./NotFound");

            return Page();
        }
    }
}
