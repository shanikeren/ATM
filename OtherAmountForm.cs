using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class OtherAmountForm : Form
    {
        public OtherAmountForm()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            int amount = int.Parse(textBoxAmount.Text);
            if(amount > 1000)
            {
                labelError.Visible = true;
                textBoxAmount.Text = null;
            }
            else
            {
                bool res = Program.ATMsystem.CurrCostumer.Withdraw(amount);
                Close();
            }

        }
    }
}
