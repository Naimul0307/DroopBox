using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoorBoxApp.Models
{
    public class Location
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Status { get; set; }

        public bool IsOutOfTown { get; set; }

    }
}
