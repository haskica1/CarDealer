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
        public Employee(int id, string firstName, string lastName, string phoneNumber, string address, string username, string password, string email, EmployeeType employeeType)
            : base(id, firstName,lastName,phoneNumber,address,username,password,email)
        {
            Type = employeeType;
        }

        public Employee(int id, string firstName, string lastName, string phoneNumber, string address, string username, string password, string email, int userType = -1)
            : base(id, firstName, lastName, phoneNumber, address, username, password, email)
        {
            //Type = employeeType;
        }

    }
}
