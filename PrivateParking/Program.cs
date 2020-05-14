using PrivateParking.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PrivateParking
{
    class Program
    {
        static void Main(string[] args)
        {
            //AddData();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
        //public static void AddData()
        //{

        //    using (var db = new DataContext())
        //    {
        //        var customers = new List<Customer>
        //        {
        //            new Customer { FirstName = "Ahmad ", LastName = "Yassin" },
        //            new Customer { FirstName = "Khalid ", LastName = "Ahmad"},
        //            new Customer { FirstName = "Yasmin ", LastName = "Khalaili"},
        //            new Customer { FirstName = "Osama", LastName = "Zidan"},
        //            new Customer { FirstName = "Abdulrahman ", LastName = "Khalid"}
        //        };

        //        foreach (var customer in customers)
        //        {
        //            db.Customer.Add(customer);
        //            db.SaveChanges();
        //        }
        //        foreach (var customer in db.Customer.ToList())
        //        {
        //            Console.WriteLine(customer.FirstName + customer.LastName);
        //            db.Customer.Remove(customer);
        //            db.SaveChanges();
        //        }
        //    }
        //}
    }

}
