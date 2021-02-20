using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealer.Models
{
    public enum EmployeeType
    {
        DIRECTOR,
        SALESMAN,
        ADMINISTRATION

    };

    class Employee : User
    {
        private EmployeeType Type { get; set; }
        public Employee(string firstName, string lastName, string phoneNumber, string address, EmployeeType employeeType) : base(firstName,lastName,phoneNumber,address)
        {
            Type = employeeType;
        }

    }
}
