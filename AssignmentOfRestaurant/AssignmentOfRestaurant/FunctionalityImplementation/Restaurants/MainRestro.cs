using System;
using System.Collections.Generic;
using System.Text;
using AssignmentOfRestaurant;

using AssignmentOfRestaurant.FunctionalityImplementation;
using AssignmentOfRestaurant.FunctionalityImplementation.CustomerFunctionality;
namespace AssignmentOfRestaurant.FunctionalityImplementation.Restaurants
{
    class MainRestro
    {
        
        RestroFunctions restroFun = new RestroFunctions();
        

        public void RestroFunction()
        {
            int choice1 = 0, choice = 0;
            do
            {

            
                Console.WriteLine("WELCOME!");
                Console.WriteLine("Enter the choice :");
                Console.WriteLine("1. Admin");
                Console.WriteLine("2. Customer");
                Console.WriteLine("3. Change Restaurant");
                Console.WriteLine("Enter your choice :");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Admin Admin = new Admin();
                        Admin.restrofunctionobj = restroFun;
                        Admin.AdminFunction();
                        break;
                    case 2:
                        Customer customer = new Customer();
                        //Restaurant.CustomerFunctions(cust = new CustomerOrderedItems());
                        customer.RestroObj = restroFun;
                        
                        customer.CustomerFunctions();

                        break;
                    default:
                        Console.WriteLine("Enter a valid option :");
                        break;
                    case 3:
                        choice1 = 2;
                        break;
                }
                if (choice1 == 2)
                {
                    break;
                }
                startloop:
                Console.WriteLine("Do you want to Continue ?Press 1 for yes, 2 for no ");
                choice1 = Convert.ToInt32(Console.ReadLine());
                if (choice1 != 1 && choice1 != 2)
                {
                    Console.WriteLine("Please enter a valid option :");
                    goto startloop;
                }

            } while (choice1 == 1);
        }      
 
    }
}

         
         
         
         
         
         
         
         
         
         