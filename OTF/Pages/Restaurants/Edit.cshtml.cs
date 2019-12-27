using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using OTFC;
using OTFD;

namespace OTF.Pages.Restaurants
{
    public class EditModel : PageModel
    {
        private IRestaurantData restaurantData;
        private readonly IHtmlHelper htmlHelper;

        public Restaurant Restaurant { get; set; }

        private IEnumerable<SelectListItem> CuisineTypes;

        public EditModel(IRestaurantData restaurantData, IHtmlHelper htmlHelper)
        {
            this.restaurantData = restaurantData;
            this.htmlHelper = htmlHelper;

        }



        public IActionResult OnGet(int restaurantId)
        {
            Restaurant = restaurantData.GetRestaurantById(restaurantId);
            CuisineTypes = htmlHelper.GetEnumSelectList<CuisineType>();
            {
                return RedirectToPage("./NotFound");
            }
            return Page();
        }
        public IActionResult OnPost()
        {
            
            Restaurant = restaurantData.Update(Restaurant);
            restaurantData.Commit();
            CuisineTypes = htmlHelper.GetEnumSelectList<CuisineType>();
            return Page();
        }
    }
}