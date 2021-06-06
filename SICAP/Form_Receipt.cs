using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SICAP
{
    public partial class Form_Receipt : Form
    {
        private string total, change, money, cashier;

        private void Form_Receipt_Load(object sender, EventArgs e)
        {
            lblTotal.Text = total;
            lblChange.Text = change;
            lblCash.Text = money;
            lblCashier.Text = cashier;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public Form_Receipt(string total, string change, string money, string cashier)
        {
            InitializeComponent();
            this.total = total;
            this.change = change;
            this.money = money;
            this.cashier = cashier;
        }


    }
}
