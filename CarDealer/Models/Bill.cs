using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealer.Models
{
    class Bill
    {
        public int Id { get; set; }
        public Store Store { get; set; }
        public User Customer { get; set; }
        public Employee Employee { get; set; }
        public DateTime Date { get; set; }
        public Car Car { get; set; }
        public int Rebate { get; set; }

        public Bill(int id, Store store, User customer, Employee employee, DateTime date, Car car, int rebate)
        {
            Id = id;
            Store = store;
            Customer = customer;
            Employee = employee;
            Date = date;
            Car = car;
            Rebate = rebate;
        }
    }
}
