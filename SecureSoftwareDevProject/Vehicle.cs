using System;
using System.Collections.Generic;
using System.Text;

namespace SecureSoftwareDevProject
{
    class Vehicle
    {
        public int ID { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Colour { get; set; }
        public int Year { get; set; }
        public float Price { get; set; }
        public float EngineSize { get; set; }
    }
    class Car : Vehicle
    {
        public string BodyType { get; set; }
    }
    class Van : Vehicle
    {
        public string Wheelbase { get; set; }
    }
    class Motorbike : Vehicle
    {
        public string Type { get; set; }
    }
}
