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
    public partial class LogInForm : Form
    {

        SQLDataAccess sql = new SQLDataAccess();
        public LogInForm()
        {
            InitializeComponent();

            textBoxPassword.PasswordChar = '*';
        }

        private void LogInForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            User user = sql.getUserByUsernameAndPassword(textBoxUsername.Text, textBoxPassword.Text);

            //todo - napraviti da bude funkcionalno
            if (user != null) MessageBox.Show("USPJESNO");
            else MessageBox.Show("GRESKA");
        }
    }
}
