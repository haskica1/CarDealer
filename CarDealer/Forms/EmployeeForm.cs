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
    public partial class EmployeeForm : Form
    {
        User User { get; set; }
        public EmployeeForm(LogInForm logInForm)
        {
            InitializeComponent();
            User = logInForm.getUser();
        }
        public EmployeeForm()
        {
            InitializeComponent();
        }
        internal void setUser(User user)
        {
            User = user;
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonPurchaseCar_Click(object sender, EventArgs e)
        {
            Form form = new StartingForm(this);
            form.Show();

            this.Hide();
        }

        internal User getUser()
        {
            return User;
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            Form form = new AddUserForm();
            form.Show();

            this.Hide();
        }

        private void buttonAddCar_Click(object sender, EventArgs e)
        {
            Form form = new CarForm();
            form.Show();

            this.Hide();
        }
    }
}
