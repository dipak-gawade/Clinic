using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClinicModel
{
    /// <summary>
    /// Model for machine
    /// </summary>
    public class Machine
    {
        public string SerialNumber { get; set; }

        public string ShortName { get; set; }

        public string Name { get; set; }
        
        public string Make { get; set; }
        
        public string Purpose { get; set; }
        
        public string Comments { get; set; }
        
        public int Price { get; set; }
        
        public DateTime PurchaseDate { get; set; }
        
        public string ImagePath { get; set; }
        
        public bool IsActive { get; set; }
        
        public int PerSessionPrice { get; set; }
        
        public int TimePerSessionInMinutes { get; set; }
    }
}
