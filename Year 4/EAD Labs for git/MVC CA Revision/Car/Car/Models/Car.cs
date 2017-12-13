using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Car.Models
{
    public enum CarEngineType { Petrol, Disel, Hybrid };
    public class Car
    {
        public String Make { get; set; }
        public String Model { get; set; }
        public CarEngineType EngineType { get; set; }
        public uint EngineSize { get; set; }
    }
}