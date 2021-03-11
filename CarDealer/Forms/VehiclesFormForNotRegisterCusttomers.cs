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
        public VehiclesFormForNotRegisterCusttomers(StartingForm startingForm)
        {
            InitializeComponent();

            cars = sql.getAllVehicles();
            brands = sql.getAllBrands();
            //models = sql.getAllModels();
            colors = sql.getAllColors();
            User = startingForm.GetUser();

            comboBoxBrand.DataSource = brands;
            comboBoxModel.DataSource = models;
            comboBoxColor.DataSource = colors;

            textBoxLowestPrice.Text = "0";
            textBoxMaximumPrice.Text = "0";
            listBoxVehicles.DataSource = cars;
            listBoxVehicles.DisplayMember = "CarSpecifications";
        }

        internal Car GetSelectedCar()
        {
            return SelectedCar;
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
    }
}
