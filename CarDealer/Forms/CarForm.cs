﻿using CarDealer.DataAccess;
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
        private List<Equipment> allEquipments = new List<Equipment>();
        private List<Storage> storages = new List<Storage>();
        EmployeeForm EmployeeForm { get; set; }
        User User { get; set; }
        public CarForm()
        {
            InitializeComponent();

            
            WireUpLists();
        }
        public CarForm(EmployeeForm employeeForm)
        {
            InitializeComponent();
            EmployeeForm = employeeForm;
            User = employeeForm.getUser();
            WireUpLists();
        }

        private void WireUpLists()
        {
            allEquipments = sql.GetAllEquipments();
            if(User.GetType == 2 || User.GetType == 3)
            {
                storages = sql.getAllStoragesInSpecificStore(User);
            }else if(User.GetType == 4)
            {
                storages = sql.getAllStorages();
            }
            
            comboBoxEquipment.DataSource = allEquipments;
            comboBoxEquipment.DisplayMember = "Name";

            comboBoxStorage.DataSource = storages;
            comboBoxStorage.DisplayMember = "StorageName";


            listBoxEquipment.DisplayMember = "FullEquipmentName";
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
            sql.AddCar(car, equipments);
            sql.AddCarToStorage(car, (Storage)comboBoxStorage.SelectedItem);

            textBoxChassis.Text = "";
            textBoxBrand.Text = "";
            textBoxColor.Text = "";
            textBoxModel.Text = "";
            textBoxEngine.Text = "";
            textBoxPrice.Text = "";


            textBoxNameOfEquipment.Text = "";
            richTextBoxInfoOfEquipment.Text = "";

            listBoxEquipment.Items.Clear();

            this.Hide();

            if (EmployeeForm != null)
            {
                EmployeeForm.Show();
            }
        }

        private void buttonAddEquipment_Click(object sender, EventArgs e)
        {
            Equipment equipment;

            if (textBoxNameOfEquipment.Text != "")
            {
                if (!ValidateField(textBoxNameOfEquipment.Text))
                {
                    MessageBox.Show("Equipment already exist in dropdown box!", "Error");
                    return;
                }

                equipment = new Equipment(0,textBoxNameOfEquipment.Text, richTextBoxInfoOfEquipment.Text);
            }
            else
            {
                equipment = (Equipment)comboBoxEquipment.SelectedItem;
            }

            if (ValidateEquipment(equipment)) { 
                equipments.Add(equipment);
                listBoxEquipment.Items.Add(equipment);
            }

            textBoxNameOfEquipment.Text = "";
            richTextBoxInfoOfEquipment.Text = "";

            
            //WireUpLists();
        }

        private bool ValidateEquipment(Equipment equipment)
        {
            foreach (Equipment e in equipments)
            {
                if (e.Name.Equals(equipment.Name)) return false;
            }
            return true;
        }

        private bool ValidateField(string equipmentName)
        {
            foreach(Equipment equinpment in allEquipments)
            {
                if (equinpment.Name.Equals(equipmentName)) return false;
            }
            return true;
        }

        private void buttonDeleteEquipment_Click(object sender, EventArgs e)
        {
            equipments.Remove((Equipment)listBoxEquipment.SelectedItem);
            listBoxEquipment.Items.Remove((Equipment)listBoxEquipment.SelectedItem);
        }

        private void CarForm_Load(object sender, EventArgs e)
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

        private void comboBoxStorage_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
