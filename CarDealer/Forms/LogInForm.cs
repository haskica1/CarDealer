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
        User User { get; set; }
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
            User = sql.getUserByUsernameAndPassword(textBoxUsername.Text, textBoxPassword.Text);

            int userType = sql.getUserType(User);
            
            if(userType == 0 || userType == 1)
            {
                this.Close();
                StartingForm.setUser(User);

                StartingForm.Show();

            }else if(userType == 2 || userType == 3 || userType == 4)
            {
                Form form = new EmployeeForm(this);

                form.Show();

                this.Hide();
            }
        }

        internal User getUser()
        {
            return User;
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
