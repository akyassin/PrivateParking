using System.Collections;
using System.Collections.Generic;

namespace PrivateParking.Models
{
    public class ParkingLot
    {
        public int Id { get; set; }
        public int NumberOfParkings { get; set; }
        public string Address { get; set; }
        public string OwnerCompany { get; set; }
        public virtual ICollection<ParkingBlock> ParkingBlock { get; set; }
    }
}