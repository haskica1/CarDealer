using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealer.Models
{
    class Car
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public string Engine { get; set; }
        public string Chassis { get; set; }
        public double Price { get; set; }
        public Equipment Equipment { get; set; }


        public Car(int id, string brand, string model, string color, string engine, string chassis, double price)
        {
            Id = id;
            Brand = brand;
            Model = model;
            Color = color;
            Engine = engine;
            Chassis = chassis;
            Price = price;
            Equipment = null;
        }

        /*public Car(int  id, string brand, string model, string color, string engine, double prize, Equipment equipment) {
            Id = id;
            Brand = brand;
            Model = model;
            Color = color;
            Engine = engine;
            Price = prize;
            Equipment = equipment;
        }*/


        public string CarName {
            get
            {
                return $"{Brand} {Model}";
            }
                
        }

    }
}
