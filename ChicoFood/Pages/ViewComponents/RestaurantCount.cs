using ChicoFood.Data;
using Microsoft.AspNetCore.Mvc;

namespace ChicoFood.Pages.ViewComponents
{
    public class RestaurantCount : ViewComponent
    {
        private readonly IRestaurantData restaurantData;

        public RestaurantCount(IRestaurantData restaurantData)
        {
            this.restaurantData = restaurantData;
        }
        public IViewComponentResult Invoke()
        {
            var count = restaurantData.GetCountOfRestaurants();
            return View(count);
        }
    }
}
