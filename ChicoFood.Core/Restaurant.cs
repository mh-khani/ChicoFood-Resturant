using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ChicoFood.Core
{
    public class Restaurant
    {
        public int Id { get; set; }
        [Required, MaxLength(80)]
        public string Name { get; set; }
        [Required, MaxLength(150)]
        public string Location { get; set; }
        public CuisineType Cuisine { get; set; }
    }
}
