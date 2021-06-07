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
    public partial class Form_Receipt : Form
    {
        private List<Payment> purchasedItemList = new List<Payment>();
        private string total, change, cash, cashier, date;

        public Form_Receipt(List<Payment> purchasedItemList, string total, string cash, string change, string cashier, string date)
        {
            InitializeComponent();
            this.purchasedItemList = purchasedItemList;
            this.total = total;
            this.cash = cash;
            this.change = change;
            this.cashier = cashier;
            this.date = date;
        }

        private void Form_Receipt_Load(object sender, EventArgs e)
        {
            ReportParameter[] para = new ReportParameter[]
            {
                new ReportParameter("pTotal", total),
                new ReportParameter("pChange", change),
                new ReportParameter("pCash", cash),
                new ReportParameter("pCashier", cashier),
                new ReportParameter("pDate", date)
            };
            this.reportViewer1.LocalReport.SetParameters(para);
            this.reportViewer1.RefreshReport();
        }
    }
}
