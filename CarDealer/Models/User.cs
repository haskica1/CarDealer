using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealer.Models
{
    class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }


        public User() { }

        public User(int id, string firstName, string lastName, string phoneNumber, string address, string  username, string password, string email, int userType = -1)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Address = address;
            Username = username;
            Password = password;
            Email = email;
        }


        public string FullUserName
        {
            get {
                return $"{FirstName} {LastName}";
            }
        }

    }
}
