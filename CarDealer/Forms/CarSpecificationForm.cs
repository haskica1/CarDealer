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
        SQLDataAccess sql = new SQLDataAccess();
        public CarSpecificationForm(VehiclesFormForNotRegisterCusttomers vehiclesFormForNotRegisterCusttomers)
        {
            InitializeComponent();
            Car = vehiclesFormForNotRegisterCusttomers.GetSelectedCar();

            labelBrandName.Text = Car.Brand;
            labelModelName.Text = Car.Model;
            labelEngineType.Text = Car.Engine;
            labelColorName.Text = Car.Color;
            labelChassisNumber.Text = Car.Chassis;
            labelPriceAmount.Text = Car.Price.ToString();

            listBoxEquipment.DataSource = sql.getEquipmentsOfCar(Car);
            listBoxEquipment.DisplayMember = "FullEquipmentName";

        }

        private void CarSpecificationForm_Load(object sender, EventArgs e)
        {

        }
    }
}
