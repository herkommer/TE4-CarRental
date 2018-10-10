using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarRental.Models
{
    public class Car
    {
        public string Registration { get; set; }
        public string Model { get; set; } //Leaf, 3
        public string Make { get; set; } //Nissan, Tesla
    }
}