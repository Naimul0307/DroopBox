using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoorBoxApp.Models
{
    public class MerchantTarrif
    {

        public int Id { get; set; }

        public int PackageCatagoryId { get; set; }
        public PackageCatagory PackageCatagory { get; set; }
        public int MerchantId { get; set; }
        public Merchant Merchant { get; set; }

        public int LocationFromId { get; set; }
        public Location LocationFrom { get; set; }
        public int LocationToId { get; set; }
        public Location LocationTo { get; set; }


        public double Weight { get; set; }

        public double FixedAmountFirstKG { get; set; }

        public double IncrementPerKG { get; set; }

        public int Status { get; set; }
    }
}
