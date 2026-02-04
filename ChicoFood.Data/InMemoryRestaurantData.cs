using ChicoFood.Core;

namespace ChicoFood.Data
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        readonly List<Restaurant> restaurants;
        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant{Id=1, Name="Venzo",Location="Qom",Cuisine=CuisineType.Italian},
                new Restaurant{Id=2,Name="Vitto",Location="Tehran",Cuisine=CuisineType.Chinease},
                new Restaurant{Id=3,Name="Takko",Location="Shiraz",Cuisine=CuisineType.Mexican},
            };
        }

        public int Commit()
        {
            return 0;
        }

        public Restaurant Add(Restaurant newRestaurant)
        {
            restaurants.Add(newRestaurant);
            newRestaurant.Id = restaurants.Max(r => r.Id) + 1;
            return newRestaurant;
        }

        public IEnumerable<Restaurant> GetAllByName(string name = "")
        {
            return restaurants.OrderBy(r => r.Name).Where(a => string.IsNullOrEmpty(name) || a.Name.StartsWith(name));
        }
        public Restaurant GetById(int id)
        {
            return restaurants.SingleOrDefault(a => a.Id.Equals(id));
        }
        public Restaurant Update(Restaurant _restaurant)
        {
            var restaurant = restaurants.SingleOrDefault(r => r.Id == _restaurant.Id);
            if (restaurant != null)
            {
                restaurant.Name = _restaurant.Name;
                restaurant.Location = _restaurant.Location;
                restaurant.Cuisine = _restaurant.Cuisine;
            }
            return restaurant;
        }
        public Restaurant Delete(int id)
        {
            var restaurant = GetById(id);
            if(restaurant != null)
                restaurants.Remove(restaurant);

            return restaurant;
        }

        public int GetCountOfRestaurants()
        {
            return restaurants.Count;
        }
    }
}
