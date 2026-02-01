using ChicoFood.Core;
using Microsoft.EntityFrameworkCore;

namespace ChicoFood.Data
{
    public class SqlRestaurantData : IRestaurantData
    {
        private readonly ChicoFoodDbContext db;

        public SqlRestaurantData(ChicoFoodDbContext db)
        {
            this.db = db;
        }
        public int Commit()
        {
            return db.SaveChanges();
        }

        public Restaurant Add(Restaurant newRestaurant)
        {
            db.Add(newRestaurant);
            return newRestaurant;
        }

        public Restaurant Delete(int id)
        {
            var restaurant = GetById(id);
            if (restaurant != null)
                db.Restaurants.Remove(restaurant);

            return restaurant;
        }

        public IEnumerable<Restaurant> GetAllByName(string name)
        {
            return db.Restaurants.Where(r => r.Name.StartsWith(name) || string.IsNullOrEmpty(name)).OrderBy(r => r.Name);
        }

        public Restaurant GetById(int id)
        {
            return db.Restaurants.Find(id);
        }

        public Restaurant Update(Restaurant restaurant)
        {
            var entity = db.Restaurants.Attach(restaurant);
            entity.State = EntityState.Modified;
            return restaurant;
        }
    }
}
