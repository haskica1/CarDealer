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
    public partial class PurchaseForm : Form
    {
        SQLDataAccess sql = new SQLDataAccess();
        Car Car { get; set; }
        User User { get; set; }
        Store Store { get; set; }
        public PurchaseForm(CarSpecificationForm carSpecificationForm)
        {
            InitializeComponent();

            Car = carSpecificationForm.getCar();
            Store = carSpecificationForm.getStore();
            User = carSpecificationForm.getUser();

            labelNameOfProduct.Text = Car.CarName;

            if(User != null)
            {
                textBoxFirstName.Text = User.FirstName;
                textBoxLastName.Text = User.LastName;
                textBoxAddress.Text = User.Address;
                textBoxEmail.Text = User.Email;
                textBoxPhoneNumber.Text = User.PhoneNumber;

                textBoxFirstName.Enabled = false;
                textBoxLastName.Enabled = false;
                textBoxAddress.Enabled = false;
                textBoxEmail.Enabled = false;
                textBoxPhoneNumber.Enabled = false;
            }

        }

        private void PurchaseForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonBuy_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                MessageBox.Show("uspjesno");
                //dodati u bazu pod.
                //poslati email
            }

            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
            textBoxAddress.Text = "";
            textBoxEmail.Text = "";
            textBoxPhoneNumber.Text = "";
        }

        private bool ValidateForm()
        {
            //for 0 user type
            if((textBoxFirstName.Text == "" || textBoxLastName.Text == "" || textBoxAddress.Text == "" || textBoxEmail.Text == "" || textBoxPhoneNumber.Text == "") && sql.getUserType(User) == 0)
            {
                MessageBox.Show("Please fill in the fields provided for the user.", "Data doesn't exist!!!");
                return false;
            }else if(sql.getUserType(User) == 1){
                MessageBox.Show("VIP korisnik koji ima popust.");
            }
            return true;
        }
    }
}
