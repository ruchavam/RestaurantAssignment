using System;
using System.Collections.Generic;
using AssignmentOfRestaurant.Models;
using AssignmentOfRestaurant.FunctionalityImplementation.DelegateImplementation;


namespace AssignmentOfRestaurant.FunctionalityImplementation
{
    public class RestroFunctions
    {
        public event EventHandler<DownloadCompleteEventArgs> FileDownloaded;
        int TableVar;
        public static List<FoodItems> TotalFoodItems = new List<FoodItems>();
        public static List<Tables> TotalTables = new List<Tables>();
        public static string RestaurantName { get; set; } = "Elborz";
        public static string RestaurantBranch { get; set; } = "Nagpur";
        //CustomerOrderedItems customerobj = new CustomerOrderedItems();
        //Input funtions for initialization
        public CustomerOrderedItems Customerobj = null;
        //private string _fileName = " Message Send ";

        public RestroFunctions()
        {           
            InputDishes();
            InputTables();

        }
        public void InputTables()
        {
            
            for(int i = 0; i < 6; i++)
            {
                TotalTables.Add(new Tables {TableNumber = i,Tablestatus = true });
            }
            
        }
        public void InputDishes()
        {
            //items.Add(new MenuItemModel { Id = 1, Name = "Coffee", Price = 70, IsAvailable = true });

            TotalFoodItems.Add(new FoodItems { ItemId = 1, ItemName = "pasta", Itemprice = 150, IsAvailable = true });
            TotalFoodItems.Add(new FoodItems { ItemId = 2, ItemName = "Maggie", Itemprice = 150, IsAvailable = true });
            TotalFoodItems.Add(new FoodItems { ItemId= 3, ItemName = "pizza", Itemprice = 150, IsAvailable = true });
            TotalFoodItems.Add(new FoodItems {ItemId =4, ItemName = "Noodles", Itemprice = 150, IsAvailable = false });
            TotalFoodItems.Add(new FoodItems {ItemId= 5, ItemName = "Crispy Veg", Itemprice = 150, IsAvailable = true });
            TotalFoodItems.Add(new FoodItems {ItemId= 6, ItemName = "Lasagna", Itemprice = 150, IsAvailable = true });
            TotalFoodItems.Add(new FoodItems {ItemId= 7, ItemName = "Fried Rice", Itemprice = 150, IsAvailable = true });
            TotalFoodItems.Add(new FoodItems{ItemId = 8, ItemName = "Milk Shake", Itemprice = 150,IsAvailable = true});
        }

        public void DisplayAvailableTables()
        {
            int counter = 0;
            Console.WriteLine("List of Tables Available");
            foreach(var item in TotalTables)
            {
                if (item.Tablestatus == true)
                {
                    counter++;
                    Console.WriteLine("Table Number " + (item.TableNumber+1) + "   is   " + item.Tablestatus);
                }
            }
            if (counter == 0)
            {
                Console.WriteLine("There is no table available. The customer is requested to wait...");
            }

        }

        public void DisplayTotalTables()
        {
            int counter = 0;
            Console.WriteLine("List of total Tables");
            foreach(var item in TotalTables)
            {

                counter++;
                 Console.WriteLine("Table Number " + (item.TableNumber +1) + "   is   " + item.Tablestatus);
                
            }

        }
        
        public void DisplayAvailableDishes()
        {
            int counter = 0;


            foreach (var itemdata in TotalFoodItems)
            {
                if (itemdata.IsAvailable == true)
                {
                    counter++;
                    Console.WriteLine(counter + "   " + itemdata.ItemName + "   " + itemdata.Itemprice +"   " + itemdata.IsAvailable );
                }
            }
            if(counter == 0)
            {
                Console.WriteLine("There Is no Table available. The customer is requested to wait...");
            }

        }
        public void DisplayTotalDishes()
        {

            int count = 0;
            foreach (var itemdata in TotalFoodItems)
            {

                count++;
                 Console.WriteLine(count + "   " + itemdata.ItemName + "   " + itemdata.Itemprice + "   " + itemdata.IsAvailable);
                
            }

        }

        public void OrderDishes()
        {
            int option;
            
            do
            {
                restartLoop:
                Console.WriteLine("Enter The Number Of Dish You Want To Order :");
                
                int dishVar = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter The Quantity Of the Dish :");
                int dishQuantity = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < dishQuantity; i++)
                {
                    switch (dishVar)
                    {
                        case 1:
                            Customerobj.ItemsOrdered.Add(TotalFoodItems[0]);
                            break;
                        case 2:
                            Customerobj.ItemsOrdered.Add(TotalFoodItems[1]);
                            break;
                        case 3:
                            Customerobj.ItemsOrdered.Add(TotalFoodItems[2]);
                            break;
                        case 4:
                            Customerobj.ItemsOrdered.Add(TotalFoodItems[3]);
                            break;
                        case 5:
                            Customerobj.ItemsOrdered.Add(TotalFoodItems[4]);
                            break;
                        case 6:
                            Customerobj.ItemsOrdered.Add(TotalFoodItems[5]);
                            break;
                        case 7:
                            Customerobj.ItemsOrdered.Add(TotalFoodItems[6]);
                            break;
                        case 8:
                            Customerobj.ItemsOrdered.Add(TotalFoodItems[7]);
                            break;
                        default:
                            Console.WriteLine("Enter a valid option");
                            goto restartLoop;
                    }
                }
                Console.WriteLine("Do you want to order more ?Press 1 for yes, 2 for no ");
                option  = Convert.ToInt32(Console.ReadLine());
            } while (option == 1);
        }






        public void BookTable()
        {
            //CustomerOrderedItems obj = new CustomerOrderedItems();

            Console.WriteLine("select table");
            
            
            TableVar = (Convert.ToInt32(Console.ReadLine()) - 1);
            
            foreach(var item in TotalTables)
            {

             //var selectedTable =   TotalTables.Where(x => x.TableNumber == TableVar).FirstOrDefault();

             //   selectedTable.Tablestatus = false;

                if (item.TableNumber == TableVar)
                {
                    item.Tablestatus = false;
                    
                    Customerobj.BookedTable = item;
                    Console.WriteLine("Please proceed towards your table...");
                }

            }
            
                
            


        }


        public float PrintBill()
        {
            float total=0;
            Int32 bill = 0;
            Console.WriteLine("Do you want to print bill ? Enter 1 for yes");
            bill = Convert.ToInt32( Console.ReadLine());
            int j = 0;
            if (bill == 1)
            {
                
                foreach (var itemdata in Customerobj.ItemsOrdered)
                {
                    j++;
                    Console.WriteLine(j + "  " + itemdata.ItemName + "  " + itemdata.Itemprice);
                    total += itemdata.Itemprice;
                }


               
            }
            //RaiseFileDownloadedEvent(new DownloadCompleteEventArgs(_fileName));

            return total;

        }

        protected virtual void RaiseFileDownloadedEvent(DownloadCompleteEventArgs eventArgs)
        {
            FileDownloaded?.Invoke(this, eventArgs);
        }
        public void LeftTable()
        {
            TotalTables[TableVar].Tablestatus = true;
        }



        //
        //
        //
        //
        //
        //
        //
        //Admin Functions:
        //
        //
        //
        //
        //
        //
        //

        
        
        public void ChangeNameOfRestaurant()
        {
            Console.WriteLine("Enter the new name");
             RestaurantName = Console.ReadLine();
            Console.WriteLine("The name Of the Restaurant is changed to :");
            Console.WriteLine(RestaurantName);
        }

        public void ChangeBranchOfRestaurant()
        {
            Console.WriteLine("Enter the new branch");
            RestaurantBranch = Console.ReadLine();
            Console.WriteLine("The Branch Of the Restaurant is changed to :");
            Console.WriteLine(RestaurantBranch);
        }

        public void Addtable()
        {
            int tableNum = 0;
            bool tableStatus = true;
            Int32 isy = 0;
            startpoint:
            Console.WriteLine("Are you Sure to add a new table to your restaurant ? press 1 to continue adding and 2 to cancel adding.");
          
            isy = Convert.ToInt32( Console.ReadLine());
            if (isy == 1)
            {
                tableNum = ((TotalTables.Count));
                Tables newTable = new Tables {TableNumber = tableNum,Tablestatus= tableStatus };
                TotalTables.Add(newTable);
                Console.WriteLine("added successfully !");
            }
            else if(isy == 2)
            {
                return;
            }
            else
            {
                Console.WriteLine("Enter valid option :");
                goto startpoint;
            }
            DisplayTotalTables();
            return;
        }
        public void AddDish()
        {
            int itemId = ((TotalFoodItems.Count));
            string itemName = "";
            int itemPrice = 0;
            bool available = true;
            Console.WriteLine("Enter the dish details :");
            Console.WriteLine("Enter the Name Of the Dish");
            itemName = Console.ReadLine();
            Console.WriteLine("Enter the price of the dish :");
            itemPrice = Convert.ToInt32(Console.ReadLine());
            TotalFoodItems.Add(new FoodItems {ItemId = itemId,ItemName= itemName,Itemprice = itemPrice,IsAvailable= available });
            DisplayTotalDishes();            
        }
        public void DeleteDish()
        {
            int deleteItemId = 0;
            DisplayTotalDishes();
            Console.WriteLine("Enter the itemId of the item you want to delete :");
            deleteItemId = Convert.ToInt32(Console.ReadLine()) - 1;

            TotalFoodItems.Remove(TotalFoodItems[deleteItemId]);
            DisplayTotalDishes();

        }
        public void ChangeaAvailabilityOfDishes()
        {
            
            int changeItemAvailability = 0;
            DisplayTotalDishes();
            Console.WriteLine("Enter the itemId of the item you want to change the availability of :");
            changeItemAvailability = Convert.ToInt32(Console.ReadLine()) - 1;
            if (TotalFoodItems[changeItemAvailability].IsAvailable == true)
            {
                TotalFoodItems[changeItemAvailability].IsAvailable = false;
            }
            else
            {
                TotalFoodItems[changeItemAvailability].IsAvailable = true;
            }
        }
        public void ShowAcquiredTables()
        {
            int count = 0;
            foreach (var Item in TotalTables)
            {
                if (Item.Tablestatus == false)
                {
                    count++;
                    Console.WriteLine(count + "   " + Item.Tablestatus);
                    
                }
                

            }
            if(count == 0)
            {
               
                
                Console.WriteLine("All the tables are empty !");
                
            }
            //DisplayTotalTables();

        }
        public void DeleteTable()
        {
            Int32 isloop = 0;
            DisplayTotalTables();
            //Console.WriteLine("Are you Sure to delete this table from your restaurant ? press 1 to continue deleting.");
            Console.WriteLine("enter the table you wish to remove : ");
            isloop = (Convert.ToInt32(Console.ReadLine())- 1);
            
            foreach (var item in TotalTables)
            {
                if (item.TableNumber == isloop)
                {
                    //i = item.TableNumber;
                    //j = item.Tablestatus;
                    TotalTables.Remove(item);
                    Console.WriteLine("deleted successfully !");
                    break;
                }

            }           
            DisplayTotalTables();         
        }
        public void ChangePriceOfdish()
        {
            float total = 0;
            int changeItemprice = 0, priceId = 0;
            DisplayTotalDishes();
            Console.WriteLine("Enter the itemId of the item whose price you wish to change :");
            priceId = ((Convert.ToInt32(Console.ReadLine())) - 1);
            Console.WriteLine("Enter the price to which you wish to change :");
            changeItemprice = Convert.ToInt32(Console.ReadLine());
            TotalFoodItems[priceId].Itemprice = changeItemprice;
            Console.WriteLine("The total price to be paid :" + total);
            DisplayTotalDishes();
        }

    }

    
}

