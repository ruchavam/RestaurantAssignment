using System;
using System.Collections.Generic;
using System.Text;
using AssignmentOfRestaurant.FunctionalityImplementation.Restaurants;

namespace AssignmentOfRestaurant.FunctionalityImplementation.Different_Restaurants
{
    class Dominoes : MainRestro
    {
        public Dominoes()
        {
            MainRestro main = new MainRestro();
            main.RestroFunction();
        }
    }
}
