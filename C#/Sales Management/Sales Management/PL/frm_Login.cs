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
    using Sales_Management.BL;

    public partial class frm_Login : Form
    {
        //fields
        LoginCheck log = new LoginCheck();
        int logCounter = 0;
        public frm_Login()
        {
            InitializeComponent();
            txtb_ID.Focus();
            
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            //logCounter++;
            //if (logCounter == 3)
            //{
            //    MessageBox.Show("Your Login terminated ", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    btn_Login.Enabled = false;
            //    this.Enabled = false;
            //    return;
            //}
            DataTable Dt = new DataTable();
            Dt = log.Login(txtb_ID.Text, txtb_Pwd.Text);
            frm_Main MainForm = new frm_Main();
            if (Dt.Rows.Count > 0)
            {
                //EnableMenuStrip();
                if (Dt.Rows[0][2].ToString() == "admin" || Dt.Rows[0][2].ToString() == "Admin")
                {
                    frm_Main.GetMainForm.usersToolStripMenuItem.Visible = true;
                    frm_Main.GetMainForm.usersToolStripMenuItem.Enabled = true;
                    frm_Main.GetMainForm.clientsToolStripMenuItem.Enabled = true;
                    frm_Main.GetMainForm.productsToolStripMenuItem.Enabled = true;
                    frm_Main.GetMainForm.createDBBackupToolStripMenuItem.Enabled = true;
                    frm_Main.GetMainForm.restoreDBBackupToolStripMenuItem.Enabled = true; 
                }
                else if (Dt.Rows[0][2].ToString() == "Normal" || Dt.Rows[0][2].ToString() == "normal")
                {
                    frm_Main.GetMainForm.usersToolStripMenuItem.Visible = false;
                    frm_Main.GetMainForm.usersToolStripMenuItem.Enabled = false;
                    frm_Main.GetMainForm.clientsToolStripMenuItem.Enabled = true;
                    frm_Main.GetMainForm.productsToolStripMenuItem.Enabled = true;
                    frm_Main.GetMainForm.createDBBackupToolStripMenuItem.Enabled = true;
                    frm_Main.GetMainForm.restoreDBBackupToolStripMenuItem.Enabled = false;
                }
                Program.Username = Dt.Rows[0][3].ToString();
                this.Close();
            }
            else 
            { 
                MessageBox.Show("Invalid ID or Password. Please try again! ","Login failed",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txtb_Pwd.Focus();
                txtb_Pwd.SelectionStart = 0;
                txtb_Pwd.SelectionLength = txtb_Pwd.TextLength;
            }

        }

        private void txtb_ID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtb_Pwd.Focus();
        }

        private void txtb_Pwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btn_Login.Focus();
        }


    }
}
