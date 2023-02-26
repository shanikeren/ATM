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

namespace ATM
{
    public partial class OptionsForm : Form
    {
        public OptionsForm()
        {
            InitializeComponent();
            labelHey.Text = "Hey " + Program.ATMsystem.CurrCostumer.CostumerName;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Transaction transaction = new Transaction(20);
            bool res = Program.ATMsystem.CurrCostumer.AddTransaction(transaction);
        }

        private void button50_Click(object sender, EventArgs e)
        {
            Transaction transaction = new Transaction(50);
            bool res = Program.ATMsystem.CurrCostumer.AddTransaction(transaction);
        }

        private void button100_Click(object sender, EventArgs e)
        {
            Transaction transaction = new Transaction(100);
            bool res = Program.ATMsystem.CurrCostumer.AddTransaction(transaction);
        }

        private void buttonBalance_Click(object sender, EventArgs e)
        {
            CashForm cashForm = new CashForm();
            cashForm.Show();
        }

        private void buttonNewPin_Click(object sender, EventArgs e)
        {
            FormNewPin formNewPin = new FormNewPin();
            formNewPin.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Program.ATMsystem.CurrCostumer = null;
            Close();
        }

        private void buttonOther_Click(object sender, EventArgs e)
        {
            OtherAmountForm otherAmountForm = new OtherAmountForm();
            otherAmountForm.Show();
        }
    }
}
