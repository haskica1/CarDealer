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
        User User { get; set; }
        Store Store { get; set; }
        SQLDataAccess sql = new SQLDataAccess();
        VehiclesFormForNotRegisterCusttomers VehiclesFormForNotRegisterCusttomers { get; set; }
        public CarSpecificationForm(VehiclesFormForNotRegisterCusttomers vehiclesFormForNotRegisterCusttomers)
        {
            InitializeComponent();
            Car = vehiclesFormForNotRegisterCusttomers.getSelectedCar();
            Store = vehiclesFormForNotRegisterCusttomers.getStore();
            User = vehiclesFormForNotRegisterCusttomers.getUser();

            labelBrandName.Text = Car.Brand;
            labelModelName.Text = Car.Model;
            labelEngineType.Text = Car.Engine;
            labelColorName.Text = Car.Color;
            labelChassisNumber.Text = Car.Chassis;
            labelPriceAmount.Text = Car.Price.ToString();

            listBoxEquipment.DataSource = sql.getEquipmentsOfCar(Car);
            listBoxEquipment.DisplayMember = "FullEquipmentName";

            VehiclesFormForNotRegisterCusttomers = vehiclesFormForNotRegisterCusttomers;
        }

        internal Store getStore()
        {
            return Store;
        }

        internal Car getCar()
        {
            return Car;
        }

        internal User getUser()
        {
            return User;
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
