using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Sales_Management.PL
{
    public partial class frm_Orders : Form
    {
        BL.Order Ord = new BL.Order();
        public frm_Orders()
        {
            InitializeComponent();
            DataTable DT = new DataTable();
            DT = Ord.GetAllOrders();
            dgv_Orders.DataSource = DT;
        }

        private void txtb_search_TextChanged(object sender, EventArgs e)
        {
            DataTable DT = new DataTable();
            DT = Ord.SearchOrder(txtb_search.Text);
            dgv_Orders.DataSource = DT;
        }

        private void btn_AddOrder_Click(object sender, EventArgs e)
        {
            frm_AddOrder frm = new frm_AddOrder();
            frm.ShowDialog();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            DataTable DT = new DataTable();
            DT = Ord.GetAllOrders();
            dgv_Orders.DataSource = DT;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_PrintOrder_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            Rpt.frm_ReportProduct frm = new Rpt.frm_ReportProduct();
            Rpt.rpt_Order Report = new Rpt.rpt_Order();
            Report.SetDataSource(Ord.ReportOrder(dgv_Orders.CurrentRow.Cells[0].Value.ToString()));
            frm.crystalReportViewer1.ReportSource = Report;
            frm.Text = "Order";
            frm.ShowDialog();
            this.Cursor = Cursors.Default;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_ViewOrderDetails frm = new frm_ViewOrderDetails();
            DataTable dt = new DataTable();
            dt = Ord.GetOrder(dgv_Orders.CurrentRow.Cells[0].Value.ToString());

            frm.txtB_OrderNo.Text = dt.Rows[0][0].ToString();
            frm.txtB_OrderDescription.Text = dt.Rows[0][3].ToString();
            frm.dateTime_OrderDate.Text = dt.Rows[0][1].ToString();
            frm.txtB_Username.Text = dt.Rows[0][4].ToString();
            frm.txtB_ID.Text = dt.Rows[0][2].ToString();
            frm.txtb_FName.Text = dt.Rows[0][5].ToString();
            frm.txtB_SName.Text = dt.Rows[0][6].ToString();
            frm.txtb_PhoneNo.Text = dt.Rows[0][7].ToString();
            frm.txtb_Email.Text = dt.Rows[0][8].ToString();
            //frm.txt_Total.Text=
            byte[] PicArr = (byte[])dt.Rows[0][9];
            MemoryStream MS = new MemoryStream(PicArr);
            frm.pictureB_ClientImage.Image = Image.FromStream(MS);

            DataTable dt2 = new DataTable();
            dt2 = Ord.GetOrderDetails(dgv_Orders.CurrentRow.Cells[0].Value.ToString());
            frm.dgv_products.DataSource = dt2;

            double totalPaid = 0;
            for (int i = 0; i < frm.dgv_products.Rows.Count ; i++)
            {
                totalPaid = totalPaid + Convert.ToDouble(dt2.Rows[i][7].ToString());
            }
            frm.txt_Total.Text = totalPaid.ToString();
            frm.ShowDialog();
        }
    }
}
