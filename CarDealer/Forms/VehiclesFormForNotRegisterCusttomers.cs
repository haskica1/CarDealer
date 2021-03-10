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

        User User { get;  set; }
        public VehiclesFormForNotRegisterCusttomers(StartingForm startingForm)
        {
            InitializeComponent();

            User = startingForm.GetUser();

            listBoxVehicles.DataSource = cars;
            listBoxVehicles.DisplayMember = "CarName";
        }



        private void listViewVehicles_SelectedIndexChanged(object sender, EventArgs e)
        {

            SQLDataAccess sql = new SQLDataAccess();


            cars = sql.getAllVehicles();


            listBoxVehicles.DataSource = cars;
            listBoxVehicles.DisplayMember = "CarName";
        }

        private void buttonSpecification_Click(object sender, EventArgs e)
        {
            SQLDataAccess sql = new SQLDataAccess();


            cars = sql.getAllVehicles();


            listBoxVehicles.DataSource = cars;
            listBoxVehicles.DisplayMember = "CarName";
        }

        private void VehiclesFormForNotRegisterCusttomers_Load(object sender, EventArgs e)
        {

        }
    }
}
