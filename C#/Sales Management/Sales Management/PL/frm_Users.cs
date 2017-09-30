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
    public partial class frm_Users : Form
    {
        BL.User user = new BL.User();
        public frm_Users()
        {
            InitializeComponent();
            dgv_User.DataSource = user.SearchUser("");
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_AddOrder_Click(object sender, EventArgs e)
        {
            frm_AddUser frm = new frm_AddUser();
            frm.ShowDialog();
        }

        private void txtb_search_TextChanged(object sender, EventArgs e)
        {
            DataTable DT = new DataTable();
            DT = user.SearchUser(txtb_search.Text);
            dgv_User.DataSource = DT;
        }

        private void btn_PrintOrder_Click(object sender, EventArgs e)
        {
            frm_AddUser frm = new frm_AddUser();
            frm.Text = "Edit";
            frm.btn_add.Text = "Update";
            frm.btn_clear.Visible = false;
            frm.txtb_ID.Enabled = false;
            frm.txtb_Username.Text = dgv_User.CurrentRow.Cells[3].Value.ToString();
            frm.txtb_ID.Text = dgv_User.CurrentRow.Cells[0].Value.ToString();
            frm.txtb_EnterPassword.Text = dgv_User.CurrentRow.Cells[1].Value.ToString();
            frm.txtb_ReEnterPassword.Text = dgv_User.CurrentRow.Cells[1].Value.ToString();
            frm.cmbb_UserType.Text = dgv_User.CurrentRow.Cells[2].Value.ToString();

            frm.ShowDialog();
            user.UpdateUser(dgv_User.CurrentRow.Cells[0].Value.ToString(), frm.txtb_Username.Text, frm.txtb_ReEnterPassword.Text, frm.cmbb_UserType.Text);
            
            dgv_User.DataSource = user.SearchUser("");
        }

        private void btn_DeleteUser_Click(object sender, EventArgs e)
        {
            DialogResult DR = MessageBox.Show("Are you sure you want to delete ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DR == DialogResult.Yes)
            {
                user.DeleteUser(dgv_User.CurrentRow.Cells[0].Value.ToString());
                MessageBox.Show("Deleted successfully.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgv_User.DataSource = user.SearchUser("");
            }
        }

    }
}
