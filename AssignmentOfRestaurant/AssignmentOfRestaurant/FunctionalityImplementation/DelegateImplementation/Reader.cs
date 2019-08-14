using System;
using System.Collections.Generic;
using System.Text;
using AssignmentOfRestaurant.FunctionalityImplementation.CustomerFunctionality;
using AssignmentOfRestaurant.FunctionalityImplementation;


namespace AssignmentOfRestaurant.FunctionalityImplementation.DelegateImplementation
{
    
    public class Reader
     {
            public Reader(RestroFunctions fileDownloader)
            {
            fileDownloader.FileDownloaded += OnFileDownloaded;
            }
 
            private void OnFileDownloaded(object sender, DownloadCompleteEventArgs e)
            {
            Console.WriteLine("\nThe book '" + e.FileName + "' has been read by Reader A");
            }
     }
}


   