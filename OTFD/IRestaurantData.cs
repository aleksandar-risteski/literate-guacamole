using OTFC;
using System;
using System.Collections.Generic;
using System.Text;

namespace OTFD
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
        Restaurant GetOne(int i);
        IEnumerable<Restaurant> GetRestaurants(string name = null);

        Restaurant GetRestaurantById(int restaurantId);
        Restaurant Update(Restaurant restaurant);

        int Commit();
    }

}   
