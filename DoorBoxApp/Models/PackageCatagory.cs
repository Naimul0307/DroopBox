using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoorBoxApp.Models
{
    public class PackageCatagory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Status { get; set; }

        public int? CatagoryTypeId { get; set; }
        public CatagoryType CatagoryType { get; set; }
    }
}
