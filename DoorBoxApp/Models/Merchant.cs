using DoorBoxApp.Models.Common.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoorBoxApp.Models
{
    public class Merchant
    {
        public int Id { get; set; }
        public string MerchantIdNo { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }


        public List<MerchantTarrif> MerchantTarrifs { get; set; }
        public List<Package> Packages { get; set; }


    }
}
