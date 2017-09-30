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
    public partial class frm_AddOrder : Form
    {
        DataTable DT = new DataTable();
        BL.Order Ord = new BL.Order();
        public frm_AddOrder()
        {
            InitializeComponent();

            btn_Save.Enabled = false;
            btn_Print.Enabled = false;
            txtB_Username.Text = Program.Username;
            CreateDT();
        }

        public void CreateDT()
        {
            DT.Columns.Add("ID");
            DT.Columns.Add("Name");
            DT.Columns.Add("Price");
            DT.Columns.Add("Quantity");
            DT.Columns.Add("Amount");
            DT.Columns.Add("Discount");
            DT.Columns.Add("Total Amount");
            dataGridView1.DataSource = DT;

            //Resize Cells
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.Columns[0].Width = 105;
            this.dataGridView1.Columns[1].Width = 240;
            this.dataGridView1.Columns[2].Width = 105;
            this.dataGridView1.Columns[3].Width = 105;
            this.dataGridView1.Columns[4].Width = 105;
            this.dataGridView1.Columns[5].Width = 105;
            this.dataGridView1.Columns[6].Width = 105;
        }
        public void CalculateAmount()
        {
            if (txtb_ProductPrice.Text != string.Empty && txtb_ProductQuantity.Text != string.Empty)
            {
                txtb_ProductAmount.Text = (Convert.ToDouble(txtb_ProductQuantity.Text) * Convert.ToDouble(txtb_ProductPrice.Text)).ToString();
                
            }
        }
        public void CalculateTotalAmount()
        {
            if (txtb_ProductAmount.Text != string.Empty && txtb_ProductDiscount.Text != string.Empty)
            {
                txtb_ProductTotal.Text = ( Convert.ToDouble(txtb_ProductAmount.Text) - Convert.ToDouble(txtb_ProductAmount.Text) *( Convert.ToDouble(txtb_ProductDiscount.Text)/100)).ToString();

            }
        }
        void ClearTextboxes()
        {
            txtb_ProductID.Clear();
            txtb_ProductName.Clear();
            txtb_ProductPrice.Clear();
            txtb_ProductQuantity.Clear();
            txtb_ProductAmount.Clear();
            txtb_ProductDiscount.Clear();
            txtb_ProductTotal.Clear();
        }
        void ClearData()
        {
            ClearTextboxes();
            txtB_OrderDescription.Clear(); txtB_OrderNo.Clear();
            txtB_ID.Clear(); txtb_FName.Clear(); txtB_SName.Clear(); txtb_Email.Clear(); txtb_PhoneNo.Clear();
            pictureB_ClientImage.Image = Sales_Management.Properties.Resources.Contacts;
            DT.Clear();
            
        }
        void CalculateTotalPaid()
        {
            double totalPaid = 0;
            txt_Total.Text = string.Empty;
            ///////////////////////////////////////////////////////
            /*
                bug when delete all product in data grid view total still have value 
            */
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                totalPaid = totalPaid + Convert.ToDouble(dataGridView1.Rows[i].Cells[6].Value);
                txt_Total.Text = totalPaid.ToString();
            }
        }
        private void btn_New_Click(object sender, EventArgs e)
        {
            ClearData();
            txtB_OrderNo.Text = Ord.GetTheLastOrderID().Rows[0][0].ToString();
            btn_New.Enabled = false;
            btn_Save.Enabled = true; 
 
        }

        private void btn_SelectClient_Click(object sender, EventArgs e)
        {
            frm_AllClient frm = new frm_AllClient();
            frm.ShowDialog();
            txtB_ID.Text = frm.dataGridView_Clients.CurrentRow.Cells[0].Value.ToString();
            txtb_FName.Text = frm.dataGridView_Clients.CurrentRow.Cells[1].Value.ToString(); 
            txtB_SName.Text = frm.dataGridView_Clients.CurrentRow.Cells[2].Value.ToString();
            txtb_Email.Text = frm.dataGridView_Clients.CurrentRow.Cells[4].Value.ToString();
            txtb_PhoneNo.Text = frm.dataGridView_Clients.CurrentRow.Cells[3].Value.ToString();
            byte[] Pic = (byte[]) frm.dataGridView_Clients.CurrentRow.Cells[5].Value;
            MemoryStream MS = new MemoryStream(Pic);
            pictureB_ClientImage.Image = Image.FromStream(MS);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClearTextboxes();
            frm_AllProducts frm = new frm_AllProducts();
            frm.ShowDialog();
            this.txtb_ProductID.Text = frm.dataGridView_Products.CurrentRow.Cells[0].Value.ToString();
            this.txtb_ProductName.Text = frm.dataGridView_Products.CurrentRow.Cells[1].Value.ToString();
            this.txtb_ProductPrice.Text = frm.dataGridView_Products.CurrentRow.Cells[3].Value.ToString();
            txtb_ProductQuantity.Focus();
        }

        private void txtb_ProductPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char DSeperator = Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar !=DSeperator)
            {
                e.Handled = true;
            }
        }

        private void txtb_ProductQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txtb_ProductDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            char DSeperator = Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != DSeperator)
            {
                e.Handled = true;
            }
        }

        private void txtb_ProductPrice_KeyUp(object sender, KeyEventArgs e)
        {
            CalculateAmount();
        }

        private void txtb_ProductQuantity_KeyUp(object sender, KeyEventArgs e)
        {
            CalculateAmount();
        }

        private void txtb_ProductDiscount_KeyUp(object sender, KeyEventArgs e)
        {
            CalculateTotalAmount();
        }

        private void txtb_ProductDiscount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Ord.VerifyQuantity(txtb_ProductID.Text, Convert.ToInt32(txtb_ProductQuantity.Text) ).Rows.Count <1)
                {
                    MessageBox.Show("This Quantity isn't available", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
                {
                    if (dataGridView1.Rows[i].Cells[1].Value.ToString() == txtb_ProductName.Text)
                    {
                        MessageBox.Show("This Product is already added","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                        return;
                    }
                }
                DataRow DR = DT.NewRow();
                DR[0] = txtb_ProductID.Text;
                DR[1] = txtb_ProductName.Text;
                DR[2] = txtb_ProductPrice.Text;
                DR[3] = txtb_ProductQuantity.Text;
                DR[4] = txtb_ProductAmount.Text;
                DR[5] = txtb_ProductDiscount.Text;
                DR[6] = txtb_ProductTotal.Text;
                DT.Rows.Add(DR);

                ClearTextboxes();
                btn_SelectProduct.Focus();
                CalculateTotalPaid();
            }
        }
        private void txtb_ProductTotal_KeyDown(object sender, KeyEventArgs e)
        {
            txtb_ProductDiscount_KeyDown(sender, e);
        }
        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            CalculateTotalPaid();
        }

        private void dataGridView1_ColumnRemoved(object sender, DataGridViewColumnEventArgs e)
        {
            CalculateTotalPaid();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
                this.txtb_ProductID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                this.txtb_ProductName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                this.txtb_ProductPrice.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                this.txtb_ProductQuantity.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                this.txtb_ProductAmount.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                this.txtb_ProductDiscount.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                this.txtb_ProductTotal.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count-1 < 0)
            {
                MessageBox.Show("You must add Products", "Warn", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtB_OrderNo.Text == string.Empty || dateTime_OrderDate.Text == string.Empty || txtB_ID.Text == string.Empty || txtB_Username.Text == string.Empty)
            {
                MessageBox.Show("Error : Incomplete Data, Please fill all missing data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            else
            {
                Ord.AddOrder(Convert.ToInt32(txtB_OrderNo.Text), dateTime_OrderDate.Value, Convert.ToInt32(txtB_ID.Text), txtB_OrderDescription.Text, txtB_Username.Text);
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    Ord.AddOrderDetails(dataGridView1.Rows[i].Cells[0].Value.ToString(),
                                         Convert.ToInt32(txtB_OrderNo.Text),
                         Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value),
                                         dataGridView1.Rows[i].Cells[2].Value.ToString(),
                        Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value),
                                         dataGridView1.Rows[i].Cells[4].Value.ToString(),
                                         dataGridView1.Rows[i].Cells[6].Value.ToString());
                }

                MessageBox.Show("Saved successfully", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btn_New.Enabled = true;
                btn_Save.Enabled = false;
                btn_Print.Enabled = true;
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            Rpt.frm_ReportProduct frm = new Rpt.frm_ReportProduct();
            Rpt.rpt_Order Report = new Rpt.rpt_Order();
            Report.SetDataSource( Ord.ReportOrder(txtB_OrderNo.Text) );
            frm.crystalReportViewer1.ReportSource = Report;
            frm.Text = "Order";
            frm.ShowDialog();
            this.Cursor = Cursors.Default;
        }
    }
}
