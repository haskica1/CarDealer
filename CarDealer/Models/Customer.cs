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
        public Customer(int id, string firstName, string lastName, string phoneNumber, string address, string username, string password, string email, CustomersType customersType)
            : base(id, firstName, lastName, phoneNumber, address, username, password, email)
        {
            Type = customersType;
        }

        public override int GetType
        {
            get
            {
                if (Type == CustomersType.REGULAR) return 0;
                return 1;
            }
        }

    }
}
