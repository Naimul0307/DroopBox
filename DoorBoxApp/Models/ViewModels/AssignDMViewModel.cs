﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoorBoxApp.Models.ViewModels
{
    public class AssignDMViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        

        public List<int> Packages { get; set; }
        public List<int> PickUpRequests { get; set; }
    }
}
