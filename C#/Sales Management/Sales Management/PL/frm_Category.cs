using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Sales_Management.PL
{
    public partial class frm_Category : Form
    {
        SqlConnection sqlConnection = new SqlConnection("Server=.\\SQLEXPRESS ; Database=Product_DB ; integrated Security=True");
        SqlDataAdapter DA = new SqlDataAdapter();
        DataTable DT = new DataTable();
        BindingManagerBase BMB;
        SqlCommandBuilder CB;
        public frm_Category()
        {
            InitializeComponent();
            DA = new SqlDataAdapter("Select ID_Category as 'ID', Description_Category as 'Description' from Categories", sqlConnection);
            DA.Fill(DT);
            dataGridV_Category.DataSource = DT;

            btn_Add.Enabled = false;

            txtb_IDCategory.DataBindings.Add("Text", DT, "ID");
            txtb_Description.DataBindings.Add("Text", DT, "Description");
            BMB = BindingContext[DT];
            lbl_Position.Text = (BMB.Position+1) + " / " + BMB.Count;
        }

        private void btn_First_Click(object sender, EventArgs e)
        {
            BMB.Position = 0;
            lbl_Position.Text = (BMB.Position + 1) + " / " + BMB.Count;
        }

        private void btn_Previous_Click(object sender, EventArgs e)
        {
            BMB.Position -= 1; 
            lbl_Position.Text = (BMB.Position + 1) + " / " + BMB.Count;
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            BMB.Position += 1; 
            lbl_Position.Text = (BMB.Position + 1) + " / " + BMB.Count;
        }

        private void btn_Last_Click(object sender, EventArgs e)
        {
            BMB.Position = BMB.Count; 
            lbl_Position.Text = (BMB.Position + 1) + " / " + BMB.Count;
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            BMB.AddNew();
            btn_New.Enabled = false;
            btn_Add.Enabled = true;
            txtb_Description.Focus();
            txtb_IDCategory.Text = (DT.Rows.Count+1).ToString();
            lbl_Position.Text = (BMB.Position + 1) + " / " + BMB.Count;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (txtb_Description.Text == string.Empty)
            {
                MessageBox.Show("Error : Incomplete Data, Please fill all missing data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            btn_New.Enabled = true;
            btn_Add.Enabled = false;
            BMB.EndCurrentEdit();
            CB = new SqlCommandBuilder(DA);
            DA.Update(DT);
            MessageBox.Show("Added Successfully","Add",MessageBoxButtons.OK,MessageBoxIcon.Information);
            lbl_Position.Text = (BMB.Position + 1) + " / " + BMB.Count;
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (txtb_Description.Text == string.Empty)
            {
                MessageBox.Show("Error : Incomplete Data, Please fill all missing data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            BMB.EndCurrentEdit();
            CB = new SqlCommandBuilder(DA);
            DA.Update(DT);
            MessageBox.Show("Updateed Successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lbl_Position.Text = (BMB.Position + 1) + " / " + BMB.Count;
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            BMB.RemoveAt(BMB.Position);
            
            CB = new SqlCommandBuilder(DA);
            DA.Update(DT);
            
            MessageBox.Show("Deleteed Successfully", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lbl_Position.Text = (BMB.Position + 1) + " / " + BMB.Count;
        }

        private void btn_CategoryReport_Click(object sender, EventArgs e)
        {
            Rpt.rpt_CategoryReport CatReport = new Rpt.rpt_CategoryReport();
            Rpt.frm_ReportProduct frm = new Rpt.frm_ReportProduct(); 
            CatReport.SetParameterValue("@ID", Convert.ToInt32(txtb_IDCategory.Text));
            frm.crystalReportViewer1.ReportSource = CatReport;
            frm.ShowDialog();
        }

        private void btn_AllCategoriesReport_Click(object sender, EventArgs e)
        {
            Rpt.rpt_AllCategoriesReport CatReport = new Rpt.rpt_AllCategoriesReport();
            Rpt.frm_ReportProduct frm = new Rpt.frm_ReportProduct();
            CatReport.Refresh();
            frm.crystalReportViewer1.ReportSource = CatReport;
            frm.Text = "Categories Report";
            frm.ShowDialog();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
