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
    public partial class CarSpecificationForm : Form
    {
        Car Car { get; set; }
        Store Store { get; set; }
        SQLDataAccess sql = new SQLDataAccess();
        public CarSpecificationForm(VehiclesFormForNotRegisterCusttomers vehiclesFormForNotRegisterCusttomers)
        {
            InitializeComponent();
            Car = vehiclesFormForNotRegisterCusttomers.getSelectedCar();
            Store = vehiclesFormForNotRegisterCusttomers.getStore();

            labelBrandName.Text = Car.Brand;
            labelModelName.Text = Car.Model;
            labelEngineType.Text = Car.Engine;
            labelColorName.Text = Car.Color;
            labelChassisNumber.Text = Car.Chassis;
            labelPriceAmount.Text = Car.Price.ToString();

            listBoxEquipment.DataSource = sql.getEquipmentsOfCar(Car);
            listBoxEquipment.DisplayMember = "FullEquipmentName";

        }

        internal Store getStore()
        {
            return Store;
        }

        internal Car getCar()
        {
            return Car;
        }

        private void CarSpecificationForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonPurchase_Click(object sender, EventArgs e)
        {
            Form purchaseForm = new PurchaseForm(this);

            purchaseForm.Show();

            this.Hide();
        }
    }
}
