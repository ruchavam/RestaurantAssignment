using System;
using System.Collections.Generic;
using System.Text;
using AssignmentOfRestaurant.FunctionalityImplementation.Restaurants;

namespace AssignmentOfRestaurant.FunctionalityImplementation.Different_Restaurants
{
    class Mcdonalds : MainRestro
    {
        public Mcdonalds()
        {
            MainRestro main = new MainRestro();
            main.RestroFunction();
        }       
    }
}
