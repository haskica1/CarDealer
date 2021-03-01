using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealer.Models
{
    public enum CustomersType
    {
        VIP,
        REGULAR
    }
    class Customer : User
    {
        private CustomersType Type { get; set; }
        public Customer(string firstName, string lastName, string phoneNumber, string address, string email, CustomersType customersType) : base(firstName, lastName, phoneNumber, address, email)
        {
            Type = customersType;
        }


    }
}
