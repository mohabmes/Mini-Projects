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
    public partial class frm_AllClient : Form
    {
        BL.Clients Clnt = new BL.Clients();
        DataTable DT = new DataTable();
        public frm_AllClient()
        {
            InitializeComponent();

            DT = Clnt.GetAllClients();
            dataGridView_Clients.DataSource = DT;
            //hide Client Image Column
            dataGridView_Clients.Columns[5].Visible = false;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            dataGridView_Clients.DataSource = Clnt.SearchClients(txtB_ClientSearch.Text);
        }

        private void dataGridView_Clients_DoubleClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
