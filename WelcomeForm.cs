using ATM.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ATM
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            labelTryAgain.Visible = false;

            if (!Program.ATMsystem.IsExist(Number.Text))
            {
                labelTryAgain.Visible = true;
                Number.Text = "";
                return;
            }
            Number.Text = "";
            PinForm pinForm = new PinForm();
            pinForm.Show();
           // this.Hide();
        }
    }
}
