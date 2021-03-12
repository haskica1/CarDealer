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
    class User : User
    {
        private CustomersType Type { get; set; }
        public User(int id, string firstName, string lastName, string phoneNumber, string address, string username, string password, string email, CustomersType customersType)
            : base(id, firstName, lastName, phoneNumber, address, username, password, email)
        {
            Type = customersType;
        }


    }
}
