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
    public partial class frm_AllProducts : Form
    {
        BL.Product Prod = new BL.Product();
        public frm_AllProducts()
        {
            InitializeComponent();

            this.dataGridView_Products.DataSource = Prod.GetAllProducts();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            dataGridView_Products.DataSource = Prod.SearchProduct(txtB_ProductSearch.Text);
        }

        private void dataGridView_Products_DoubleClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
