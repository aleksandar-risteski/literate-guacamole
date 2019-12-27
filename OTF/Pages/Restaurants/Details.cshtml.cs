 using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OTFC;
using OTFD;

namespace OTF.Pages.Restaurants
{
    public class Details : PageModel
    {

        private readonly IRestaurantData restaurantData;

        public Restaurant Restaurant { get; set; }

        public Details(IRestaurantData restaurantData)
        {
            this.restaurantData = restaurantData;
        }
        
        public IActionResult OnGet(int restaurantId)
        {
            Restaurant = restaurantData.GetRestaurantById(restaurantId);
                if(Restaurant == null)
            {
                return RedirectToPage("./NotFount");
            }
            return Page();
        }
    }
}