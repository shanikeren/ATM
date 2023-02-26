using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace ATM
{
    public partial class PinForm : Form
    {
        public PinForm()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (Program.ATMsystem.CurrCostumer.VerifyPin(int.Parse(textBoxPin.Text)))
            {
                OptionsForm optionsForm = new OptionsForm();
                optionsForm.Show(); 
                
                this.Hide();
                this.Close();
            }
            else 
            {
                ChangeLabelAndWait();
            }
        }

        private async void ChangeLabelAndWait()
        {
            labelError.Text = "Wrong pin code";
            await Task.Delay(5000);
            this.Close();
        }

    }
}
