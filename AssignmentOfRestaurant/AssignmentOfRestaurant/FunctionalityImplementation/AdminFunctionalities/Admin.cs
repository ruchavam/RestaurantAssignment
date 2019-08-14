using System;
using System.Collections.Generic;
using System.Text;
using AssignmentOfRestaurant.FunctionalityImplementation;

namespace AssignmentOfRestaurant.FunctionalityImplementation
{
    class Admin
    {
        public Admin()
        {            
            
        }


        public static string adminName { get; set; }
        public static string adminUsername { get; set; } //= "Elborz";
        public static string adminPassword { get; set; } //= "1234";
        public RestroFunctions restrofunctionobj = null;
        public void AdminFunction()
        {
            //restrofunctionobj =restr
            //restrofunctionobj.InputDishes();
            //restrofunctionobj.InputTables();

            int carryOn = 0;
            do
            {

                int choice =0;
                
                Console.WriteLine("1. Change the name of the restraunt ");
                Console.WriteLine("2. Change the branch of the restraunt ");
                Console.WriteLine("3. Add a table ");
                Console.WriteLine("4. Add a new Dish");
                Console.WriteLine("5. Delete a  dish");
                Console.WriteLine("6. Change availability of a dish");
                Console.WriteLine("7. show acquired tables");
                Console.WriteLine("8. Delete a defective table");
                Console.WriteLine("9. Change the price of the Dish");
                Console.WriteLine("10. Display total Tables in the restro");
                Console.WriteLine("11. Display All the dishes in the restro");
                Console.WriteLine("12. Exit");
                Console.WriteLine("Please enter Your choice :");


                //Console.WriteLine("10.");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    
                    case 1:
                        restrofunctionobj.ChangeNameOfRestaurant();
                        break;
                    case 2:
                        restrofunctionobj.ChangeBranchOfRestaurant();
                        break;
                    case 3:
                        restrofunctionobj.Addtable();
                        break;
                    case 4:
                        restrofunctionobj.AddDish();
                        break;
                    case 5:
                        restrofunctionobj.DeleteDish();
                        break;
                    case 6:
                        restrofunctionobj.ChangeaAvailabilityOfDishes();
                        break;
                    case 7:
                        restrofunctionobj.ShowAcquiredTables();
                        break;
                    case 8:
                        restrofunctionobj.DeleteTable();
                        break;
                    case 9:
                        restrofunctionobj.ChangePriceOfdish();
                        break;
                    case 10:
                        restrofunctionobj.DisplayTotalTables();
                        break;
                    case 11:
                        restrofunctionobj.DisplayTotalDishes();
                        break;
                    case 12:
                        
                        return;
                    default:
                        Console.WriteLine("Please enter a valid option !");
                        break;

                }
                Startover:
                Console.WriteLine("Do you want to continue ? Type 1 for yes 2 for no.");
                carryOn = Convert.ToInt32(Console.ReadLine());
                if(carryOn == 2)
                {
                    break;
                }
                else if(carryOn != 1 && carryOn !=2)
                {
                    Console.WriteLine("enter a valid option :");
                    goto Startover;
                }
                else{
                    continue;
                }

            } while (carryOn == 1);



        }


    }
}
