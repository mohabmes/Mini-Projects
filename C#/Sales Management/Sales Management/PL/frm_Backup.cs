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
    public partial class frm_Backup : Form
    {
        SqlConnection SQLConn = new SqlConnection("server=.\\SQLEXPRESS; database=master; integrated security=true");
        SqlCommand cmd;
        public frm_Backup()
        {
            InitializeComponent();
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (txtb_FilePath.Text =="")
            {
                MessageBox.Show("Error : Incomplete Data, Please fill all missing data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                cmd = new SqlCommand("Backup Database Product_DB to Disk = '" + txtb_FilePath.Text + "' ", SQLConn);
                SQLConn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Backup successfully Created !!\nFile Path " + txtb_FilePath.Text, "Backup Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
            finally
            {
                SQLConn.Close();
            } Cursor.Current = Cursors.Default;
        }

        private void btn_browse_Click(object sender, EventArgs e)
        {
            SaveFileDialog SF = new SaveFileDialog();
            SF.Filter = "Backup files (*.bak)|*.bak | All files (*.*)|*.* ";
            if (SF.ShowDialog() == DialogResult.OK)
            {
                txtb_FilePath.Text = SF.FileName;
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
