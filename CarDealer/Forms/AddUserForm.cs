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
        StartingForm StartingForm { get; set; }
        public AddUserForm(StartingForm startingForm)
        {
            InitializeComponent();

            StartingForm = startingForm;

            textBoxPassword.PasswordChar = '*';
            types.ForEach(delegate (string data) { comboBoxType.Items.Add(data); } );
            
        }

        public AddUserForm()
        {
            InitializeComponent();
            textBoxPassword.PasswordChar = '*';
            types.ForEach(delegate (string data) { comboBoxType.Items.Add(data); });
            comboBoxType.Visible = true;
            labelType.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Customer newUser = null;
            if(!ValidateFields(textBoxUsername.Text, textBoxEmail.Text, textBoxPhoneNumber.Text))
            {
                MessageBox.Show("Wrong data!!! \nPlease try again.", "Wrong data!!!");
            }
            else
            {
                newUser = new Customer(0, textBoxFirstName.Text, textBoxLastName.Text, textBoxPhoneNumber.Text, textBoxAddress.Text, textBoxUsername.Text, textBoxPassword.Text, textBoxEmail.Text,CustomersType.REGULAR);
                sql.AddUser(newUser);
            }


            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
            textBoxEmail.Text = "";
            textBoxAddress.Text = "";
            textBoxPassword.Text = "";
            textBoxPhoneNumber.Text = "";
            textBoxUsername.Text = "";

            this.Close();

            StartingForm.setUser(newUser);
            StartingForm.Show();


        }

        private bool ValidateFields(string username, string email, string telephoneNumber)
        {
            List<User> users = sql.getAllUsers();

            //TODO -  NAPRAVITI ZA SVAKI FIELD NJEGOVO ISPITIVANJE.

            //todo - provjeriti dodavanje korisnika kako pri registraciji tako i pri dodavanju novog.

            foreach(User user in users)
            {
                if (user.Username.Equals(username) || user.Email.Equals(email) || user.PhoneNumber.Equals(telephoneNumber)) return false;
            }
            return true;
        }

        private void AddUserForm_Load(object sender, EventArgs e)
        {

        }
    }
}
