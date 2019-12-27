using OTFC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OTFD
{
   public class RestaurantDataInMemory : IRestaurantData
    {
        private List<Restaurant> restaurants;
        public RestaurantDataInMemory()
        {
            restaurants = new List<Restaurant>
            {
                new Restaurant
                {
                    Id = 1,
                    Name = "Dominos",
                    Location = "Skopje",
                    Cuisine = CuisineType.Italian
                },
                new Restaurant
                {
                    Id = 2,
                    Name = "Jakomo",
                    Location = "Veles",
                    Cuisine = CuisineType.Mexican
                },
                new Restaurant
                {
                    Id=3,
                    Name = "La Pizza",
                    Location = "Radovish",
                    Cuisine = CuisineType.Franch
                }   
            };
        }
        public Restaurant GetOne(int i)
        {
            Restaurant restaurant = null;
            for(int j = 0; j < restaurants.Count; j++)
            {
                if(i == j)
                {
                    restaurant = restaurants.ElementAt(j);
                }
            }
            return restaurant;
        }
        public IEnumerable<Restaurant> GetAll()
        {
            string name = null;
            return restaurants.Where(r => string.IsNullOrEmpty(name) || r.Name.StartsWith(name)).OrderBy(r => r.Name);
        }
           
        public IEnumerable<Restaurant> GetRestaurants(string name = null)
        {
            return restaurants.Where(r => string.IsNullOrEmpty(name) || r.Name.StartsWith(name.ToLower())).OrderBy(r => r.Name);
        }

        public Restaurant GetRestaurantById(int restaurantId)
        {
            return restaurants.SingleOrDefault(r => r.Id == restaurantId);
        }
        public Restaurant Update(Restaurant restaurant)
        {
            var tempRestaurant = restaurants.SingleOrDefault(r => r.Id == restaurant.Id);
            return tempRestaurant;

        }

        public int Commit()
        {
            return 0;
        }
    }
}
