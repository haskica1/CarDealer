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
    public partial class AddStorageForm : Form
    {
        AddStoreForm AddStoreForm { get; set; }
        EmployeeForm EmployeeForm { get; set; }
        User User { get; set; }
        SQLDataAccess sql = new SQLDataAccess();
        public AddStorageForm()
        {
            InitializeComponent();
        }

        public AddStorageForm(AddStoreForm addStoreForm)
        {
            InitializeComponent();
            AddStoreForm = addStoreForm;
        }

        public AddStorageForm(EmployeeForm employeeForm)
        {
            InitializeComponent();
            EmployeeForm = employeeForm;
        }

        private void labelLastName_Click(object sender, EventArgs e)
        {

        }

        private void AddStorageForm_Load(object sender, EventArgs e)
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form form = new AddUserForm(this);

            form.Show();
            this.Hide();
        }

        internal void setUser(User newUser)
        {
            User = newUser;
        }

        private void buttonAddStorage_Click(object sender, EventArgs e)
        {
            if (User == null)
            {
                MessageBox.Show("Need to add manager of storage!!!", "Error");
                return;
            }

            sql.addStorage(textBoxName.Text,textBoxAddress.Text,User);
            this.Hide();
            if (AddStoreForm != null)
            {
                AddStoreForm.Show();
                AddStoreForm.WireUp();
            }
            else
            {
                EmployeeForm.Show();
            }
        }
    }
}
