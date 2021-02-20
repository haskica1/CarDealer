using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealer.Models
{
    class Store
    {
        public string Name { get; set; }
        public Storage Storage { get; set; }
        public List<Employee> Employees { get; set; }

        public Store(string name, Storage storage, List<Employee> employees)
        {
            Name = name;
            Storage = storage;
            Employees = employees;
        }
    }
}
