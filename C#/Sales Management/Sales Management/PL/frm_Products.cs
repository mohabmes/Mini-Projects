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
    public partial class frm_Products : Form
    {
        //Fields
        BL.Product Pro = new BL.Product();
        //For Using one Static Form (banning Any object OR instance)
        private static frm_Products ProductForm;
        #region Static Product Form
        //To Make [AddProductForm] get the value of the orginal form
        public static frm_Products GetProductForm
        {
            get
            {
                if (ProductForm == null)
                    ProductForm = new frm_Products();
                return ProductForm;
            }
        }
        #endregion
        //Constructor
        public frm_Products()
        {
            InitializeComponent();
            if (ProductForm == null) {  ProductForm = this; }
            //This Method GetAllProducts Names to fill the dataGridView
            ViewAllProducts();
        }

        //Method
        //This Method GetAllProducts Names to fill the dataGridView or(as A Refresher)
        private void ViewAllProducts()
        {
            dataGridV_Product.DataSource = Pro.GetAllProducts();
        }
        //==================================================================================

        //Showing AddProduct Form
        private void btn_AddProduct_Click(object sender, EventArgs e)
        {
            frm_AddProduct frm = new frm_AddProduct();
            frm.ShowDialog();  
        }
        //This Method GetAllProducts Names to fill the dataGridView or(as A Refresher)
        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            ViewAllProducts();
        }
        //For Searching
        private void txtb_search_TextChanged(object sender, EventArgs e)
        {
            DataTable Dt = new DataTable();
            Dt = Pro.SearchProduct(txtb_search.Text);
            dataGridV_Product.DataSource = Dt;
        }
        //DeleteProduct Process Check
        private void btn_DeleteProduct_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Delete?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Pro.DeleteProduct(dataGridV_Product.CurrentRow.Cells[0].Value.ToString());
                MessageBox.Show("Product Deleted Successfully.","Delete",MessageBoxButtons.OK,MessageBoxIcon.Information);
                ViewAllProducts();
            }
            else
            {
                MessageBox.Show("Deleted Process Cancelled .", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //Close the form
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        //Form for Editing Detail of Product
        private void btn_EditDetails_Click(object sender, EventArgs e)
        {
            //EditDetails Form is Edited AddProduct form
            frm_AddProduct frm = new frm_AddProduct();
            #region EditDetailsForm Procedure
            //Fill EditDetails Form with Data From DataGridV_Product
            frm.txtb_ProductID.Text = dataGridV_Product.CurrentRow.Cells[0].Value.ToString();
            frm.txtb_Label.Text = dataGridV_Product.CurrentRow.Cells[1].Value.ToString();
            frm.txtb_Price.Text = dataGridV_Product.CurrentRow.Cells[3].Value.ToString();
            frm.txtb_Quantity.Text = dataGridV_Product.CurrentRow.Cells[2].Value.ToString();
            frm.cmbb_CategoryID.Text = dataGridV_Product.CurrentRow.Cells[4].Value.ToString();
            //Edit Form Title
            frm.Text = "Edit : " + dataGridV_Product.CurrentRow.Cells[1].Value.ToString();
            //Edit Button Title
            frm.btn_OK.Text = "Update";
            //Disable ProductID Editing
            frm.txtb_ProductID.ReadOnly=true;
            //For Control (Allowed/Banned) ProductID Replication Validate
            //False = Replication Banned In case Of Adding/True = Replication Allowed in case of Editing
            frm.IDReplicationState = true;
            //Get The Image Data and turn it into Image
            byte[] PicArr2 = (byte[])Pro.GetPicture(this.dataGridV_Product.CurrentRow.Cells[0].Value.ToString()).Rows[0][0];
            MemoryStream MS = new MemoryStream(PicArr2);
            frm.pictureB_ProductImage.Image = Image.FromStream(MS);
            #endregion
            //refresh DataGridView
            ViewAllProducts();
            frm.ShowDialog();
        }
        //View Image
        private void btn_ViewImage_Click(object sender, EventArgs e)
        {
            frm_ImagePreview frm = new frm_ImagePreview();
            frm.Text = "Image : " + dataGridV_Product.CurrentRow.Cells[1].Value.ToString();
            byte[] PicArr2 = (byte[])Pro.GetPicture(this.dataGridV_Product.CurrentRow.Cells[0].Value.ToString()).Rows[0][0];
            MemoryStream MS = new MemoryStream(PicArr2);
            frm.PictureB_ProductImage2.Image = Image.FromStream(MS);
            frm.ShowDialog();
        }

        private void btn_PrintProduct_Click(object sender, EventArgs e)
        {
            Rpt.rpt_ProductReport PReport = new Rpt.rpt_ProductReport();
            PReport.SetParameterValue("@ID", this.dataGridV_Product.CurrentRow.Cells[0].Value.ToString());
            Rpt.frm_ReportProduct frm = new Rpt.frm_ReportProduct();
            frm.crystalReportViewer1.ReportSource = PReport;
            frm.ShowDialog();
        }

        private void btn_PrintAllProducts_Click(object sender, EventArgs e)
        {
            Rpt.rpt_AllProductsReport APReport = new Rpt.rpt_AllProductsReport();
            Rpt.frm_ReportProduct frm = new Rpt.frm_ReportProduct();
            APReport.Refresh();
            frm.crystalReportViewer1.ReportSource = APReport;
            frm.Text = "Report All Products";
            frm.ShowDialog();
        }
    }
}
