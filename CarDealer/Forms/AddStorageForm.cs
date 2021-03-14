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
    public partial class AddStorageForm : Form
    {
        AddStoreForm AddStoreForm { get; set; }

        public AddStorageForm()
        {
            InitializeComponent();
        }

        public AddStorageForm(AddStoreForm addStoreForm)
        {
            InitializeComponent();
            AddStoreForm = addStoreForm;
        }

        private void labelLastName_Click(object sender, EventArgs e)
        {

        }

        private void AddStorageForm_Load(object sender, EventArgs e)
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
    }
}
