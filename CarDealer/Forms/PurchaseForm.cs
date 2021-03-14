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


using System.Web;
using System.Net.Mail;
using System.Net;

namespace CarDealer.Forms
{
    public partial class PurchaseForm : Form
    {
        SQLDataAccess sql = new SQLDataAccess();
        Car Car { get; set; }
        User User { get; set; }
        Store Store { get; set; }
        Order Order { get; set; }
        Bill Bill { get; set; }
        CarSpecificationForm CarSpecificationForm { get; set; }
        private bool logIn = true;
        private string companyEmailAddress = "";
        private string companyEmailPassword = "";
        internal User getUser()
        {
            return User;
        }

        public PurchaseForm(CarSpecificationForm carSpecificationForm)
        {
            InitializeComponent();
            CarSpecificationForm = carSpecificationForm;

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
            int rabate = 0;
            if (ValidateForm())
            {
                MessageBox.Show("uspjesno");
                //dodati u bazu pod.
                //poslati email
            }


            User = CheckUser(User);
            if (User.GetType == 0)
                rabate = 0;
            else if (User.GetType == 1)
                rabate = 10;
            else
                rabate = 20;

            Bill = sql.AddBill(Store, User, DateTime.Now, Car, rabate);
            if (radioButtonDelivery.Checked)
                Order = sql.AddOrder(Bill, TypeOfDelivery.DELIVERY);
            else
                Order = sql.AddOrder(Bill, TypeOfDelivery.STORE);

            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
            textBoxAddress.Text = "";
            textBoxEmail.Text = "";
            textBoxPhoneNumber.Text = "";

            //sendEmail(User, Car);


            sql.deleteCar(Car);
            this.Hide();

            if (logIn)
            {
                Form form = new EmployeeForm(this);
                form.Show();
            }
            else {
                Form form = new StartingForm();
                form.Show();
            }
            
        }

        private void sendEmail(User user, Car car)
        {
            try
            {
                MailMessage mail = new MailMessage();
                mail.To.Add(companyEmailAddress);
                mail.To.Add(User.Email);
                mail.From = new MailAddress(companyEmailAddress);
                mail.Subject = "Purchase car";
                string Body = "Congratulations on purchase " + car.CarName;
                mail.IsBodyHtml = true;

                SmtpClient smtp = new SmtpClient("localhost", 25);
                smtp.Host = "smtp.gmail.com"; //Or Your SMTP Server Address
                smtp.Credentials = new System.Net.NetworkCredential
                     (companyEmailAddress, companyEmailPassword);
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.EnableSsl = true;
                smtp.Send(mail);
                MessageBox.Show("Mail Send");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private User CheckUser(User user)
        {
            //ako si usao odmah bez da si se prijavio
            if(user == null)
            {
                logIn = false;
                //trazis u bazi jel ima upisani neki korisnik sa tim podacima
                user = sql.searchUser(textBoxFirstName.Text, textBoxLastName.Text, textBoxAddress.Text, textBoxEmail.Text, textBoxPhoneNumber.Text);
                if (user == null)
                {
                    //ako nema, dodati novog korisnika ali bez username i passworda to neka bude random i njegov tip mora biti 0.
                    string randomUsername = textBoxFirstName.Text + textBoxLastName.Text + textBoxAddress.Text + textBoxEmail.Text + textBoxPhoneNumber.Text;
                    string randomPassword = randomUsername;

                    user = new Customer(0, textBoxFirstName.Text, textBoxLastName.Text, textBoxPhoneNumber.Text, textBoxAddress.Text, randomUsername, randomPassword, textBoxEmail.Text, CustomersType.REGULAR);
                    sql.AddUser(user);
                }
            }
            return user;
        }

        private bool ValidateForm()
        {
            //for 0 user type
            if((textBoxFirstName.Text == "" || textBoxLastName.Text == "" || textBoxAddress.Text == "" || textBoxEmail.Text == "" || textBoxPhoneNumber.Text == "") && sql.getUserType(User) == 0)
            {
                MessageBox.Show("Please fill in the fields provided for the user.", "Data doesn't exist!!!");
                return false;
            }
            return true;
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
