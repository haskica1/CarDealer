using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealer.Models
{
    class Storage
    {

        private string Name { get; set; }
        private List<Car> Cars { get; set; }
        private Employee Manager { get; set; }

        public Storage(string name, List<Car> cars, Employee manager)
        {
            Name = name;
            Cars = cars;
            Manager = manager;
        }
    }
}
