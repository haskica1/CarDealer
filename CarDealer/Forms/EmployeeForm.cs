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
        public EmployeeForm(PurchaseForm purchaseForm)
        {
            InitializeComponent();
            User = purchaseForm.getUser();
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
            Form form = new AddUserForm(this);
            form.Show();

            this.Hide();
        }

        private void buttonAddCar_Click(object sender, EventArgs e)
        {
            Form form = new CarForm(this);
            form.Show();

            this.Hide();
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

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new AddStoreForm();
            form.Show();

            this.Hide();
        }

        private void buttonAddStorage_Click(object sender, EventArgs e)
        {
            Form form = new AddStorageForm(this);
            form.Show();

            this.Hide();
        }
    }
}
