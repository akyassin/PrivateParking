using System;
using System.Collections.Generic;
using System.Text;

namespace PrivateParking.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int MobileNumber { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PlateNumber { get; set; }
        public ParkingBlock ParkingBlock { get; set; }
    }
}
