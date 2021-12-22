using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoorBoxApp.Models.ViewModels
{
    public class PublicViewModel
    {
        public int Status { get; set; }
        public string Client { get; set; }
        public string Merchant { get; set; }
        public string Address { get; set; }
        public double Price { get; set; }
    }
}
