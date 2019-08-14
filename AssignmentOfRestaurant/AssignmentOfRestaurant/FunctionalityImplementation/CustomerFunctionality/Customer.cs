using System;
using System.Collections.Generic;
using System.Text;
using AssignmentOfRestaurant.Models;

using AssignmentOfRestaurant.FunctionalityImplementation.DelegateImplementation;

namespace AssignmentOfRestaurant.FunctionalityImplementation.CustomerFunctionality
{
    

    class Customer
    {
        
        public string CustomerName { get; set; }
        
        
        public RestroFunctions RestroObj = null;
        public RestroFunctions fileDownloader { get; set; }

        public Customer()
        {
            //CustomerOrderedItems Customerobj = new CustomerOrderedItems();
            
        }
        public void CustomerFunctions()
        {
            float TotalPrice;

            CustomerOrderedItems Customerobj = new CustomerOrderedItems();
            RestroObj.Customerobj = Customerobj;
            
            //Reader clientA = new Reader(fileDownloader);
            Console.WriteLine("Enter the name of the customer");
            CustomerName = Console.ReadLine();            
            RestroObj.DisplayAvailableTables();
            RestroObj.BookTable();
            RestroObj.DisplayAvailableDishes();
            RestroObj.OrderDishes();
            TotalPrice=RestroObj.PrintBill();
            //RestroObj.CustomerDelegate();
            //RestroObj.Customerobj = Customerobj;
            //public delegate void EventHandler<TEventArgs>(object sender, TEventArgs e);
            //public event EventHandler< > FileDownloaded;


    }
    }
}
