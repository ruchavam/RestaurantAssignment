using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentOfRestaurant.Models
{
    public class FoodItems
    {
        
        public  int ItemId { get; set; }
        public  string ItemName { get; set; }
        public float Itemprice { get; set; }
        public bool IsAvailable { get; set; }
    }
}
