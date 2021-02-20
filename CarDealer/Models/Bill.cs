using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealer.Models
{
    class Bill
    {
        private Store Store { get; set; }
        private Customer Customer { get; set; }
        private Employee Employee { get; set; }
        private DateTime Date { get; set; }
        private List<Car> Cars { get; set; }
        private int Rebate { get; set; }

        public Bill(Store store, Customer customer, Employee employee, DateTime date, List<Car> cars, int rebate)
        {
            Store = store;
            Customer = customer;
            Employee = employee;
            Date = date;
            Cars = cars;
            Rebate = rebate;
        }
    }
}
