using System;
using System.Collections.Generic;
using System.Text;
using AssignmentOfRestaurant.FunctionalityImplementation.Restaurants;

namespace AssignmentOfRestaurant.FunctionalityImplementation.Different_Restaurants
{
    class Pizzahut : MainRestro
    {
        public Pizzahut()
        {
            MainRestro main = new MainRestro();
            main.RestroFunction();
        }
    }
}
