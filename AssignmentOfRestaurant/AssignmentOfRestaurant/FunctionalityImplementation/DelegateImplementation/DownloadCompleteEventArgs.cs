using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentOfRestaurant.FunctionalityImplementation.DelegateImplementation
{
    
    
        public class DownloadCompleteEventArgs : EventArgs
        {
            public DownloadCompleteEventArgs(string fileName)
            {
                FileName = fileName;
            }

            public string FileName { get; }
        }
    
}
