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

        public string Address { get; set; }
        public List<Storage> Storages { get; set; }
        public List<Employee> Employees { get; set; }

        public Store(string name, string address, List<Storage> storages, List<Employee> employees)
        {
            Name = name;
            Address = address;
            Storages = storages;
            Employees = employees;
        }
    }
}
