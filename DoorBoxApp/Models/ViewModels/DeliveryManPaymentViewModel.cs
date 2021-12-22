using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoorBoxApp.Models.ViewModels
{
    public class DeliveryManPaymentViewModel
    {
        public int DeliveryManId { get; set; }
        public DeliveryMan DeliveryMan { get; set; }
        public int TotalPick { get; set; }
        public int TotalDrop { get; set; }
        public int TotalCancel { get; set; }
        public double TotalPayable { get; set; }
        public double TotalPaid { get; set; }
        public double TotalDue{ get; set; }
        public double TotalPending { get; set; }
    }
}
