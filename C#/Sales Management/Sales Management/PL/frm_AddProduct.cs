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
    public partial class frm_AddProduct : Form
    {
        //Fields
        BL.Product Pro = new BL.Product();
        //For Control (True/False) ProductID Replication Validate
        //False = Replication Banned In case Of Adding/True = Replication Allowed in case of Editing
        public bool IDReplicationState = false;
        //===============================================================================================

        //Constructor
        public frm_AddProduct()
        {
            InitializeComponent();
            FillComboBox();
        }
        //Methods
        //Fill Combo  box with categories Stuff 
        public void FillComboBox()
        {
            cmbb_CategoryID.DataSource = Pro.GetAllCategories();
            cmbb_CategoryID.ValueMember = "ID_Category";
            cmbb_CategoryID.DisplayMember = "Description_Category";
        }
        //store Pic into Array
        public void RestorePicIntoArray()
        {
            MemoryStream MS = new MemoryStream();
            pictureB_ProductImage.Image.Save(MS, pictureB_ProductImage.Image.RawFormat);
            byte[] PicArr = MS.ToArray();
            Pro.AddProduct(txtb_ProductID.Text, txtb_Label.Text, Convert.ToInt32(txtb_Quantity.Text), txtb_Price.Text, PicArr, Convert.ToInt32(cmbb_CategoryID.SelectedValue));
        }
        //restore Array into Pic
        public void RestoreArrayIntoPic()
        {
            MemoryStream MS = new MemoryStream();
            pictureB_ProductImage.Image.Save(MS, pictureB_ProductImage.Image.RawFormat);
            byte[] PicArr = MS.ToArray();
            Pro.UpdateProduct(txtb_ProductID.Text, txtb_Label.Text, Convert.ToInt32(txtb_Quantity.Text), txtb_Price.Text, PicArr, Convert.ToInt32(cmbb_CategoryID.SelectedValue));

        }
        //===============================================================================================

        private void btn_SelectImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog FD = new OpenFileDialog();
            FD.Filter="Images | *.JPG; *.PNG; *.GIF";
            if (FD.ShowDialog() == DialogResult.OK)
            {
                pictureB_ProductImage.Image = Image.FromFile(FD.FileName);
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (txtb_Label.Text ==string.Empty || txtb_Price.Text==string.Empty || txtb_ProductID.Text==string.Empty || txtb_Quantity.Text==string.Empty)
            {
                MessageBox.Show("Error : Incomplete Data, Please fill all missing data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //For Control (Allowed/Banned) ProductID Replication Validate
            //False = Replication Banned In case Of Adding/True = Replication Allowed in case of Editing
            if (IDReplicationState == false)
            {
                //restore Pic into Array
                MemoryStream MS = new MemoryStream();
                pictureB_ProductImage.Image.Save(MS, pictureB_ProductImage.Image.RawFormat);
                byte[] PicArr = MS.ToArray();
                Pro.AddProduct(txtb_ProductID.Text, txtb_Label.Text, Convert.ToInt32(txtb_Quantity.Text), txtb_Price.Text, PicArr, Convert.ToInt32(cmbb_CategoryID.SelectedValue));
                MessageBox.Show("New Product Added Successfully", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //restore Pic into Array
                MemoryStream MS = new MemoryStream();
                pictureB_ProductImage.Image.Save(MS, pictureB_ProductImage.Image.RawFormat);
                byte[] PicArr = MS.ToArray();
                Pro.UpdateProduct(txtb_ProductID.Text, txtb_Label.Text, Convert.ToInt32(txtb_Quantity.Text), txtb_Price.Text, PicArr, Convert.ToInt32(cmbb_CategoryID.SelectedValue));
                MessageBox.Show("Product Updated Successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //refresh DataGridView
            frm_Products.GetProductForm.dataGridV_Product.DataSource = Pro.GetAllProducts();
            this.Close();
        }
        //Verify Product ID (warn For any replication)
        private void txtb_ProductID_Validated(object sender, EventArgs e)
        {
            //For Control (Allowed/Banned) ProductID Replication Validate
            //False = Replication Banned In case Of Adding/True = Replication Allowed in case of Editing
            if (IDReplicationState == false)
            {
                DataTable Dt = new DataTable();
                Dt = Pro.VerifyProductID(txtb_ProductID.Text);
                if (Dt.Rows.Count > 0)
                {
                    MessageBox.Show("This ID Product is already in use", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtb_ProductID.Focus();
                    txtb_ProductID.SelectionStart = 0;
                    txtb_ProductID.SelectionLength = txtb_ProductID.TextLength;
                }
            }
        }

    }
}
