using CarDealer.DataAccess;
using CarDealer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarDealer.Forms
{
    public partial class AddUserForm : Form
    {
        SQLDataAccess sql = new SQLDataAccess();
        List<string> types = new List<string> {"VIP","REGULAR","SALESMAN", "ADMINISTRATION" };
        public AddUserForm()
        {
            InitializeComponent();

            textBoxPassword.PasswordChar = '*';
            types.ForEach(delegate (string data) { comboBoxType.Items.Add(data); } );
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!ValidateFields(textBoxUsername.Text, textBoxEmail.Text, textBoxPhoneNumber.Text))
            {
                MessageBox.Show("Wrong data!!! \nPlease try again.", "Wrong data!!!");
            }
            else
            {
                Customer newUser = new Customer(0, textBoxFirstName.Text, textBoxLastName.Text, textBoxPhoneNumber.Text, textBoxAddress.Text, textBoxUsername.Text, textBoxPassword.Text, textBoxEmail.Text,CustomersType.REGULAR);
                sql.AddUser(newUser);
            }


            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
            textBoxEmail.Text = "";
            textBoxAddress.Text = "";
            textBoxPassword.Text = "";
            textBoxPhoneNumber.Text = "";
            textBoxUsername.Text = "";


        }

        private bool ValidateFields(string username, string email, string telephoneNumber)
        {
            List<User> users = sql.GetAllUsers();

            //TODO -  NAPRAVITI ZA SVAKI FIELD NJEGOVO ISPITIVANJE.

            foreach(User user in users)
            {
                if (user.Username.Equals(username) || user.Email.Equals(email) || user.PhoneNumber.Equals(telephoneNumber)) return false;
            }
            return true;
        }
    }
}
