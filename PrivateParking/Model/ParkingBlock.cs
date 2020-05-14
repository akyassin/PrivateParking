using System;
using System.Collections.Generic;
using System.Text;

namespace PrivateParking.Models
{
    public class ParkingBlock
    {
        public int Id { get; set; }
        public bool IsAvailable { get; set; }
        public ParkingType ParkingType { get; set; }
        public  ParkingLot ParkingLot { get; set; }
    }
}
