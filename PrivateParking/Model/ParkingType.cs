using System.Collections;
using System.Collections.Generic;

namespace PrivateParking.Models
{
    public class ParkingType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Area { get; set; }
        public double MonthlyRent { get; set; }
        public ICollection<ParkingBlock> ParkingBlock { get; set; }
    }
}