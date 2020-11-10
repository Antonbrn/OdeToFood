using System;
using System.Collections.Generic;
using OdeToFood.Core;
using System.Linq;

namespace OdeToFood.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
    }

    public class InMemoryRestaurantData : IRestaurantData
    {
        readonly List<Restaurant> restaurants;
        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>();
            {
                new Restaurant { Id = 1, Name = "Anton's Pizza", Location = "Luleå", Cuisine = CuisineType.Italian };
                new Restaurant { Id = 2, Name = "Vato loco", Location = "Luleå", Cuisine = CuisineType.Mexican };
                new Restaurant { Id = 3, Name = "Tikka masala", Location = "Luleå", Cuisine = CuisineType.Indian };
            }

        }

        public IEnumerable<Restaurant> GetAll()
        {
            return from r in restaurants
                   orderby r.Name
                   select r;
        }
    }
      
}
