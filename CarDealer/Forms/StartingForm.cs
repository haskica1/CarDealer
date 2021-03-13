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
    public partial class StartingForm : Form
    {
        SQLDataAccess sql = new SQLDataAccess();
        List<Store> stores;
        private User User { get; set; }

        public StartingForm()
        {
            InitializeComponent();
            stores = sql.getAllStores();

            comboBoxStore.DataSource = stores;
            comboBoxStore.DisplayMember = "FullStoreName";
        }

        public StartingForm(EmployeeForm employeeForm)
        {
            InitializeComponent();
            stores = sql.getAllStores();
            User = employeeForm.getUser();

            linkLabelLogIn.Enabled = false;
            linkLabelRegister.Enabled = false;

            comboBoxStore.DataSource = stores;
            comboBoxStore.DisplayMember = "FullStoreName";
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void StartingForm_Load(object sender, EventArgs e)
        {
            

        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            Form vehicleForm = new VehiclesFormForNotRegisterCusttomers(this);

            vehicleForm.Show();

            this.Hide();

        }

        internal Store getStore()
        {
            return (Store)comboBoxStore.SelectedItem;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void linkLabelLogIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form logInForm = new LogInForm(this);
            logInForm.Show();

            this.Hide();
        }

        internal void setUser(User user)
        {
            User = user;
            labelWelcome.Text = labelWelcome.Text + $"\n{User.FullUserName}";
        }
        internal User getUser()
        {
            return User;
        }

        private void linkLabelRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form registerForm = new AddUserForm(this);
            registerForm.Show();

            this.Hide();
        }
    }
}
