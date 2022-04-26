using System;
using System.Collections.Generic;
using System.Text;

namespace TiklaGelsin.Models
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public int RestaurantID { get; set; }
    }
}
