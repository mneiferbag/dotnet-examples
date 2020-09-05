/*
 * Copyright (c) 2020 Markus Neifer. All rights reserved.
 */
namespace MnCons.Samples.Properties
{
    class TimePeriod
    {
        private double seconds;
    
        public double Hours
        {
            get { return seconds / 3600; }
            set { seconds = value * 3600; }
        }
    }
    // This class is mutable. Its data can be modified from 
    // outside the class. 
    class Customer
    {
        // Auto-Impl Properties for trivial get and set 
        public double TotalPurchases { get; set; }
        public string Name { get; set; }
        public int CustomerID { get; set; }
    
        // Constructor 
        public Customer(double purchases, string name, int ID)
        {
            TotalPurchases = purchases;
            Name = name;
            CustomerID = ID;
        }
        // Methods 
        public string GetContactInfo() {return "ContactInfo";}
        public string GetTransactionHistory() {return "History";}
    
        // .. Additional methods, events, etc.
    }
    class Program
    {
        static void Main()
        {
            var t = new TimePeriod();
    
            // Assigning the Hours property causes the 'set' accessor to be called.
            t.Hours = 24;
    
            // Evaluating the Hours property causes the 'get' accessor to be called.
            System.Console.WriteLine("Time in hours: " + t.Hours);
    
            // Object initializer.
            t = new TimePeriod { Hours = 12 };
    
            System.Console.WriteLine("Time in hours: " + t.Hours);
    
            // Intialize a new object.
            var cust1 = new Customer( 4987.63, "Northwind", 90108 );
    
            //Modify a property
            cust1.TotalPurchases += 499.99;
        }
    }
}
