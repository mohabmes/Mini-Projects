using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sales_Management.PL
{
    public partial class frm_ViewOrderDetails : Form
    {
        public frm_ViewOrderDetails()
        {
            InitializeComponent();
            btn_Print.Focus();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            BL.Order Ord = new BL.Order();
            this.Cursor = Cursors.WaitCursor;
            Rpt.frm_ReportProduct frm = new Rpt.frm_ReportProduct();
            Rpt.rpt_Order Report = new Rpt.rpt_Order();
            Report.SetDataSource(Ord.ReportOrder(txtB_OrderNo.Text.ToString()));
            frm.crystalReportViewer1.ReportSource = Report;
            frm.Text = "Order";
            frm.ShowDialog();
            this.Cursor = Cursors.Default;
        }
    }
}
