using DoorBoxApp.Models.Common.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoorBoxApp.Models
{
    public class DeliveryMan
    {
        public int Id { get; set; }
        public string DeliveryManIdNo { get; set; }
       
        public string Email { get; set; }
        public string Name { get; set; }
        public string NIDNumber { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public double Salary { get; set; }
        public double PickUpRate { get; set; }
        public double DeliveryRate { get; set; }
        public string EmergencyVontact { get; set; }
        public int Status { get; set; }
        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}
