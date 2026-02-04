using ChicoFood.Core;
using ChicoFood.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.IdentityModel.Tokens;

namespace ChicoFood.Pages.Resturants
{
    public class ListModel : PageModel
    {
        private readonly IConfiguration config;
        private readonly IRestaurantData restaurantData;

        public IEnumerable<Restaurant> Resturants { get; set; }
        [TempData]
        public string Message { get; set; }
        [BindProperty(SupportsGet = true)]
        public string Search { get; set; }

        public ListModel(IConfiguration config, IRestaurantData restaurantData)
        {
            this.config = config;
            this.restaurantData = restaurantData;
        }
        public void OnGet(string MyVal)
        {
            Resturants = restaurantData.GetAllByName(Search);
        }
    }
}
