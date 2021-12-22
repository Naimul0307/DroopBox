using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoorBoxApp.Models.ViewModels
{
    public class TarrifPriceViewModel
    {
        public int? TarrifId { get; set; }
        public Tarrif Tarrif { get; set; }

        public int? MerchantTarrifId { get; set; }
        public MerchantTarrif MerchantTarrif { get; set; }




        public double ExtraweightPrice { get; set; }
        public double TotalPrice { get; set; }
    }
}
