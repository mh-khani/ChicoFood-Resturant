using ChicoFood.Core;

namespace ChicoFood.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAllByName(string name);
        Restaurant GetById(int id);
        Restaurant Update(Restaurant restaurant);
        Restaurant Add(Restaurant newRestaurant);
        Restaurant Delete(int id);
        int Commit();
    }
}
