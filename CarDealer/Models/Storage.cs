using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealer.Models
{
    class Storage
    {

        public int Id { get; set; }
        public string Name { get; set; }

        public string Address { get; set; }
        public List<Car> Cars { get; set; }
        public Employee Manager { get; set; }

        public Storage(int id, string name, string address, List<Car> cars, Employee manager)
        {
            Name = name;
            Address = address;
            Cars = cars;
            Manager = manager;
        }

        public Storage(int id, string storageName, string storageAddress, int managerID)
        {
            Name = storageName;
            Address = storageAddress;
            Cars = null;
            Manager = null;
        }


        public string StorageName {
            get {
                return $"{Name} {Address}";

            }
        }
    }
}
