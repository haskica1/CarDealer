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
    public partial class VehiclesFormForNotRegisterCusttomers : Form
    {
        List<Car> cars = new List<Car>();
        List<string> brands = new List<string>();
        List<string> models = new List<string>();
        List<string> colors = new List<string>();
        SQLDataAccess sql = new SQLDataAccess();
        Car SelectedCar { get; set; }
        User User { get;  set; }
        Store Store { get; set; }
        public VehiclesFormForNotRegisterCusttomers(StartingForm startingForm)
        {
            InitializeComponent();

            User = startingForm.getUser();
            Store = startingForm.getStore();
            WireUp();  
        }

        private void WireUp()
        {
            cars = sql.getAllVehiclesOfStore(Store);
            brands = sql.getAllBrands();
            colors = sql.getAllColors();

            comboBoxBrand.DataSource = brands;
            comboBoxModel.DataSource = models;
            comboBoxColor.DataSource = colors;

            textBoxLowestPrice.Text = "0";
            textBoxMaximumPrice.Text = "0";
            listBoxVehicles.DataSource = cars;
            listBoxVehicles.DisplayMember = "CarSpecifications";
        }

        internal Store getStore()
        {
            return Store;
        }

        internal Car getSelectedCar()
        {
            return SelectedCar;
        }
        internal User getUser()
        {
            return User;
        }

        private void buttonSpecification_Click(object sender, EventArgs e)
        {
            SelectedCar = (Car)listBoxVehicles.SelectedItem;
            Form carSpecificationForm = new CarSpecificationForm(this);

            carSpecificationForm.Show();

            this.Hide();
        }

        private void VehiclesFormForNotRegisterCusttomers_Load(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cars = sql.searchCar((string)comboBoxBrand.SelectedItem, (string)comboBoxModel.SelectedItem, (string)comboBoxColor.SelectedItem,textBoxLowestPrice.Text,textBoxMaximumPrice.Text);

            listBoxVehicles.DataSource = cars;
            listBoxVehicles.DisplayMember = "CarSpecifications";
        }

        private void buttonDeletFilters_Click(object sender, EventArgs e)
        {
            cars = sql.getAllVehicles();

            listBoxVehicles.DataSource = cars;
            listBoxVehicles.DisplayMember = "CarSpecifications";
        }

        private void comboBoxModel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            models = sql.getAllModels((string)comboBoxBrand.SelectedItem);

            comboBoxModel.DataSource = models;
        }

        protected override void OnClosing(CancelEventArgs e) {

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
