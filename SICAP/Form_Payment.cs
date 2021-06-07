using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace SICAP
{
    public partial class Form_Payment : Form
    {
        List<Payment> purchasedItemList = new List<Payment>();
        private string total, change, cash, cashier, date;
        private DataGridView dgv;
        ReportDataSource rs = new ReportDataSource();


        private void guna2Button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dgv.Rows)
            {
                purchasedItemList.Add(new Payment()
                {
                    ItemName = item.Cells[1].Value.ToString(),
                    Price = item.Cells[2].Value.ToString(),
                    Qty = item.Cells[3].Value.ToString(),
                    Total = item.Cells[4].Value.ToString()
                });
            }

            rs.Name = "ds";
            rs.Value = purchasedItemList;
            Form_Receipt frm = new Form_Receipt(purchasedItemList, total, cash, change, cashier, date);
            frm.reportViewer1.LocalReport.DataSources.Clear();
            frm.reportViewer1.LocalReport.DataSources.Add(rs);
            frm.reportViewer1.LocalReport.ReportEmbeddedResource = "SICAP.Report1.rdlc";

            frm.ShowDialog();
        }

        private void Form_Receipt_Load(object sender, EventArgs e)
        {
            lblTotal.Text = total;
            lblChange.Text = change;
            lblCash.Text = cash;
            lblCashier.Text = cashier;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public Form_Payment(string total, string change, string cash, string cashier, string date, DataGridView dgv)
        {
            InitializeComponent();
            this.total = total;
            this.change = change;
            this.cash = cash;
            this.cashier = cashier;
            this.date = date;
            this.dgv = dgv;
   
        }
    }
}
