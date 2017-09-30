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
    public partial class frm_AddUser : Form
    {
        BL.LoginCheck log = new BL.LoginCheck();
        public frm_AddUser()
        {
            InitializeComponent();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txtb_EnterPassword.Clear();
            txtb_Username.Clear();
            txtb_ReEnterPassword.Clear();
            txtb_ID.Clear();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            //While Adding
            if (btn_add.Text == "Add")
            {
                if (txtb_ID.Text == string.Empty || txtb_Username.Text == string.Empty || txtb_EnterPassword.Text == string.Empty || txtb_ReEnterPassword.Text == string.Empty)
                {
                    MessageBox.Show("Error : Incomplete Data, Please fill all missing data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (txtb_EnterPassword.Text != txtb_ReEnterPassword.Text)
                {
                    MessageBox.Show("Please Re-enter your password correctly.", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                try
                {
                    log.AddUser(txtb_ID.Text, txtb_Username.Text, txtb_EnterPassword.Text, cmbb_UserType.Text);
                    MessageBox.Show("New user added Successfully.", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            } 
            
            //While Updating
            else if (btn_add.Text != "Add")
            {
                if (txtb_ID.Text == string.Empty || txtb_Username.Text == string.Empty || txtb_EnterPassword.Text == string.Empty || txtb_ReEnterPassword.Text == string.Empty)
                {
                    MessageBox.Show("Error : Incomplete Data, Please fill all missing data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (txtb_EnterPassword.Text != txtb_ReEnterPassword.Text)
                {
                    MessageBox.Show("Please Re-enter your password correctly.", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                MessageBox.Show("Updated Successfully.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtb_ReEnterPassword_Validated(object sender, EventArgs e)
        {
            if (txtb_EnterPassword.Text != txtb_ReEnterPassword.Text)
            {
                MessageBox.Show("Please Re-enter your password correctly.", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            }
        }
    }
}