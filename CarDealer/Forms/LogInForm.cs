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
    public partial class LogInForm : Form
    {
        StartingForm StartingForm { get; set; }

        SQLDataAccess sql = new SQLDataAccess();
        public LogInForm()
        {
            InitializeComponent();

            textBoxPassword.PasswordChar = '*';
        }

        public LogInForm(StartingForm startingForm)
        {

            InitializeComponent();

            textBoxPassword.PasswordChar = '*';


            StartingForm = startingForm;
        }

        private void LogInForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            User user = sql.getUserByUsernameAndPassword(textBoxUsername.Text, textBoxPassword.Text);

            //todo - napraviti da bude funkcionalno
            /*if (user != null) MessageBox.Show("USPJESNO");
            else MessageBox.Show("GRESKA");*/
            int userType = sql.getUserType(user);
            
            if(userType == 0 || userType == 1)
            {
                this.Close();
                StartingForm.SetUser(user);

                StartingForm.Show();

            }
        }
    }
}
