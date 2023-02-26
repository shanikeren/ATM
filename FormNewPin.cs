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
    public partial class FormNewPin : Form
    {
        public FormNewPin()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            Program.ATMsystem.CurrCostumer.Pin = int.Parse(textBoxNewPin.Text);

            Close();
        }
    }
}
