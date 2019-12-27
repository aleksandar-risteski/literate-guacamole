
using System;
using System.ComponentModel.DataAnnotations;

namespace OTFC
{
    public class Restaurant
    {
        public int Id { get; set; }
        [Required]
        [StringLength(10)]
        public string Name { get; set; }
        [Required]
        public string Location { get; set; }

        public CuisineType Cuisine { get; set; }
    }
}
