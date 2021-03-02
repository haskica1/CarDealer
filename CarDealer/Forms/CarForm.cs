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
    public partial class CarForm : Form
    {

        private SQLDataAccess sql = new SQLDataAccess();
        private List<Equipment> equipments = new List<Equipment>();


        public CarForm()
        {
            InitializeComponent();

            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonAddCar_Click(object sender, EventArgs e)
        {
            Car car = new Car(0,textBoxBrand.Text, textBoxModel.Text, textBoxColor.Text, textBoxEngine.Text, textBoxChassis.Text, Double.Parse(textBoxPrice.Text));
            sql.AddCar(car);


            textBoxChassis.Text = "";
            textBoxBrand.Text = "";
            textBoxColor.Text = "";
            textBoxModel.Text = "";
            textBoxEngine.Text = "";
            textBoxPrice.Text = "";



        }

        private void buttonAddEquipment_Click(object sender, EventArgs e)
        {

            Equipment equipment = new Equipment(0, textBoxNameOfEquipment.Text, richTextBoxInfoOfEquipment.Text);
            sql.AddEquipment(equipment);

            textBoxNameOfEquipment.Text = "";
            richTextBoxInfoOfEquipment.Text = "";

            equipments.Add(equipment);

            listBoxEquipment.Items.Add(equipment);
            listBoxEquipment.DisplayMember = "FullEquipmentName";

        }


    }
}
