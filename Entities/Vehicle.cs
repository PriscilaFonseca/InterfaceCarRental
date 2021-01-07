using System;

namespace InterfaceCarRental.Entities
{
    class Vehicle
    {
        public string Model { get; set; }

        public Vehicle(string model)
        {
            Model = model;
        }
    }
}
