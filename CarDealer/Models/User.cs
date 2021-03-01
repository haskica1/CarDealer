using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealer.Models
{
    class User
    {
        protected string FirstName { get; set; }
        protected string LastName { get; set; }
        protected string PhoneNumber { get; set; }
        protected string Address { get; set; }

        protected string Email { get; set; }

        public User(string firstName, string lastName, string phoneNumber, string address, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Address = address;
            Email = email;
        }
    }
}
