using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OdeToFood.Core;
using OdeToFood.Data;

namespace OdeToFood.Pages.Restaurants
{
    public class ListModel : PageModel
    {

        public string Message { get; set; }
        private readonly IRestaurantData restaurantData;
        public IEnumerable<Restaurant> Restaurants { get; set; };

        public ListModel(IRestaurantData restaurantData)
        {
            this.restaurantData = restaurantData;
        }

        public void OnGet()
        {
            Message = "HELLO WORLD!";
        }

    }
}
