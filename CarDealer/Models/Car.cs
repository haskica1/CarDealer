using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealer.Models
{
    class Car
    {
        private string Brand { get; set; }
        private string Model { get; set; }
        private string Color { get; set; }
        private string Engine { get; set; }
        private double Prize { get; set; }
        private Equipment Equipment { get; set; }

        public Car(string brand, string model, string color, string engine, double prize, Equipment equipment) {
            Brand = brand;
            Model = model;
            Color = color;
            Engine = engine;
            Prize = prize;
            Equipment = equipment;
        }

    }
}
