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
    public partial class AddStoreForm : Form
    {

        SQLDataAccess sql = new SQLDataAccess();
        List<Employee> allEmployees;
        List<Storage> allStorages;
        List<Employee> employees = new List<Employee>();
        List<Storage> storages = new List<Storage>();
        public AddStoreForm()
        {
            InitializeComponent();
            WireUp();
        }

        public void WireUp()
        {
            allEmployees = sql.getAllEmployees();


            comboBoxEmployee.DataSource = allEmployees;
            comboBoxEmployee.DisplayMember = "FullUserName";

            allStorages = sql.getAllStorages();
            comboBoxStorage.DataSource = allStorages;
            comboBoxStorage.DisplayMember = "StorageName";


            listBoxEmployees.DisplayMember = "FullUserName";
            listBoxStorages.DisplayMember = "StorageName";
        }

        private void buttonAddEmployee_Click(object sender, EventArgs e)
        {
            if (!ValidateEmployee((Employee)comboBoxEmployee.SelectedItem)) return;
            listBoxEmployees.Items.Add(comboBoxEmployee.SelectedItem);
            employees.Add((Employee)comboBoxEmployee.SelectedItem);
        }

        private bool ValidateEmployee(Employee employee)
        {
            foreach(Employee e in employees)
            {
                if (e.Id == employee.Id) return false;
            }
            return true;
        }

        private void buttonAddStorage_Click(object sender, EventArgs e)
        {
            listBoxStorages.Items.Add(comboBoxStorage.SelectedItem);
            storages.Add((Storage)comboBoxStorage.SelectedItem);
        }

        private void buttonDeleteEmployee_Click(object sender, EventArgs e)
        {
            listBoxEmployees.Items.Remove(listBoxEmployees.SelectedItem);
            employees.Remove((Employee)listBoxEmployees.SelectedItem);
        }

        private void buttonDeleteStorage_Click(object sender, EventArgs e)
        {
            listBoxStorages.Items.Remove(listBoxStorages.SelectedItem);
            storages.Remove((Storage)listBoxStorages.SelectedItem);
        }

        private void buttonAddStore_Click(object sender, EventArgs e)
        {
            sql.AddStore(textBoxName.Text, textBoxAddress.Text, employees, storages);

            Form form2 = new EmployeeForm();
            form2.Show();
            this.Hide();
        }

        private void AddStoreForm_Load(object sender, EventArgs e)
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

        private void linkLabelCreateEmployee_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form form = new AddUserForm(this);
            form.Show();

            this.Hide();
        }

        private void linkLabelCreateStorage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form form = new AddStorageForm(this);
            form.Show();

            this.Hide();
        }
    }
}
