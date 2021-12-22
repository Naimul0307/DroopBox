using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DoorBoxApp.Models
{
    public class PickUpRequest
    {
        public int Id { get; set; }
        public DateTime RequestDate { get; set; }
        public DateTime PickUpDate { get; set; }
        public string RequestId { get; set; }
        public string Details { get; set; }
        public string PickupAddress { get; set; }
        public int LocationFromId { get; set; }
        public Location LocationFrom { get; set; }
        public int? PickUpDeliveryManId { get; set; }
        public DeliveryMan PickUpDeliveryMan { get; set; }

        public int MerchantId { get; set; }
        public Merchant Merchant { get; set; }

        public int TotalPackageNumber { get; set; }
        public int PickedUpPackageNumber { get; set; }

        public int Status { get; set; }  // 0 means added ,  1 means finalized , 2 means forwarded, 3 means accepted , 4 means picked up by dm, 5 means crossmatched and received, 404 means decliend

        [NotMapped]
        public IFormFile UploadedFile { get; set; }

        public double? PaidForPickUp { get; set; }
        public bool PickupDeliveryManPaid { get; set; }

        public List<Package> Packages { get; set; }
    }
}
