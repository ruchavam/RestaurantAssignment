using System.Collections.Generic;

namespace AssignmentOfRestaurant.Models
{
    public class CustomerOrderedItems
    {
        public List<FoodItems> ItemsOrdered = new List<FoodItems>();
        public Tables BookedTable;
    }
}
