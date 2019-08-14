using System;
using AssignmentOfRestaurant.FunctionalityImplementation;
using AssignmentOfRestaurant.Models;
using AssignmentOfRestaurant.FunctionalityImplementation.Restaurants;
using AssignmentOfRestaurant.FunctionalityImplementation.Different_Restaurants;


namespace AssignmentOfRestaurant
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            Int32 ch = 0;
            do
            {
                Console.WriteLine("1. Mcdonalds");
                Console.WriteLine("2. Dominoes");
                Console.WriteLine("3. Pizzahut");
                Console.WriteLine("Enter the restaurant you want to go to : ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Mcdonalds Mcdonalds = new Mcdonalds();
                        break;
                    case 2:
                        Dominoes Dominoes = new Dominoes();                       
                        break;
                    case 3:
                        Pizzahut Pizzahut = new Pizzahut();
                        Pizzahut.RestroFunction();
                        break;
                    default:
                        Console.WriteLine("Enter a valid option :");
                        break;
                }
                reprint:
                Console.WriteLine("Do you want to continue with restaurant selection ? press 1 for yes 2 for no");
                ch = Convert.ToInt32(Console.ReadLine());
                if(ch == 2)
                {
                    break;
                }
                else if(ch == 1)
                {
                }
                else
                {
                    Console.WriteLine("Enter valid option...");
                    goto reprint;
                }

            } while (ch == 1);
        }
    }
}
