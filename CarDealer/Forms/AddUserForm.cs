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
        List<string> types = new List<string> {"VIP","REGULAR","SALESMAN", "ADMINISTRATION", "DIRECTOR" };
        StartingForm StartingForm { get; set; }
        EmployeeForm EmployeeForm { get; set; }
        AddStoreForm AddStoreForm { get; set; }

        public AddUserForm(StartingForm startingForm)
        {
            InitializeComponent();

            StartingForm = startingForm;
            WireUp();
        }

        public AddUserForm(AddStoreForm addStoreForm)
        {
            InitializeComponent();

            AddStoreForm = addStoreForm;
            types.Remove("VIP");
            types.Remove("REGULAR");
            comboBoxType.Visible = true;
            labelType.Visible = true;
            WireUp();
        }

        public AddUserForm(EmployeeForm employeeForm)
        {
            InitializeComponent();

            EmployeeForm = employeeForm;

            comboBoxType.Visible = true;
            labelType.Visible = true;
            WireUp();
        }
        private void WireUp()
        {
            textBoxPassword.PasswordChar = '*';
            types.ForEach(delegate (string data) { comboBoxType.Items.Add(data); });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User newUser = null;
            if(!ValidateFields(textBoxUsername.Text, textBoxEmail.Text, textBoxPhoneNumber.Text))
            {
                MessageBox.Show("Wrong data!!! \nPlease try again.", "Wrong data!!!");
            }else if (sql.isThereUser(textBoxFirstName.Text, textBoxLastName.Text, textBoxEmail.Text, textBoxAddress.Text, textBoxPhoneNumber.Text))
            {
                newUser = sql.updateUser(textBoxFirstName.Text, textBoxLastName.Text, textBoxEmail.Text, textBoxAddress.Text, textBoxPhoneNumber.Text, textBoxUsername.Text, textBoxPassword.Text, comboBoxType.Text);
            }
            else
            {
                switch (comboBoxType.Text)
                {
                    case "ADMINISTRATION":
                        newUser = new Employee(0, textBoxFirstName.Text, textBoxLastName.Text, textBoxPhoneNumber.Text, textBoxAddress.Text, textBoxUsername.Text, textBoxPassword.Text, textBoxEmail.Text, EmployeeType.ADMINISTRATION);
                        break;
                    case "VIP":
                        newUser = new Customer(0, textBoxFirstName.Text, textBoxLastName.Text, textBoxPhoneNumber.Text, textBoxAddress.Text, textBoxUsername.Text, textBoxPassword.Text, textBoxEmail.Text, CustomersType.VIP);
                        break;
                    case "SALESMAN":
                        newUser = new Employee(0, textBoxFirstName.Text, textBoxLastName.Text, textBoxPhoneNumber.Text, textBoxAddress.Text, textBoxUsername.Text, textBoxPassword.Text, textBoxEmail.Text, EmployeeType.SALESMAN);
                        break;
                    case "DIRECTOR":
                        newUser = new Employee(0, textBoxFirstName.Text, textBoxLastName.Text, textBoxPhoneNumber.Text, textBoxAddress.Text, textBoxUsername.Text, textBoxPassword.Text, textBoxEmail.Text, EmployeeType.DIRECTOR);
                        break;
                    default:
                        newUser = new Customer(0, textBoxFirstName.Text, textBoxLastName.Text, textBoxPhoneNumber.Text, textBoxAddress.Text, textBoxUsername.Text, textBoxPassword.Text, textBoxEmail.Text, CustomersType.REGULAR);
                        break;
                }
                sql.AddUser(newUser);
            }

            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
            textBoxEmail.Text = "";
            textBoxAddress.Text = "";
            textBoxPassword.Text = "";
            textBoxPhoneNumber.Text = "";
            textBoxUsername.Text = "";

            this.Hide();

            if (StartingForm != null)
            {
                StartingForm.setUser(newUser);
                StartingForm.Show();
            }
            else if (EmployeeForm != null)
                EmployeeForm.Show();
            else
            {
                AddStoreForm.Show();
                AddStoreForm.WireUp();
            }

        }

        private bool ValidateFields(string username, string email, string telephoneNumber)
        {
            List<User> users = sql.getAllUsers();

            foreach(User user in users)
            {
                if ((user.Username.Equals(username) || user.Email.Equals(email) || user.PhoneNumber.Equals(telephoneNumber)) && user.GetType != 0) return false;
            }
            return true;
        }

        private void AddUserForm_Load(object sender, EventArgs e)
        {

        }

        protected override void OnClosing(CancelEventArgs e)
        {

            const string message = "Are you sure that you would like to close the form?";
            const string caption = "Form Closing";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                e.Cancel = true;
            }

        }
    }
}
