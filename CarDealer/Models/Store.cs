using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealer.Models
{
    class Store
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Address { get; set; }
        public List<Storage> Storages { get; set; }
        public List<Employee> Employees { get; set; }

        public Store(int id,string name, string address, List<Storage> storages, List<Employee> employees)
        {
            Id = id;
            Name = name;
            Address = address;
            Storages = storages;
            Employees = employees;
        }

        public Store(int id, string name, string address)
        {
            Id = id;
            Name = name;
            Address = address;
            Storages = null;
            Employees = null;
        }


        public string FullStoreName
        {
            get {
                return $"{Name} in {Address}";
            }
        }
    }
}
