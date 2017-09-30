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
using System.IO;

namespace Sales_Management.PL
{
    public partial class frm_Client : Form
    {
        //Fields
        int CurrentRowIndex;
        BL.Clients Clnt = new BL.Clients();
        DataTable DT = new DataTable();
        //Constructor
        public frm_Client()
        {
            InitializeComponent();
            
            RefreshDataGridView();
            lbl_Position.Text = "0 / " + (dataGridView_Clients.Rows.Count);
            btn_Add.Enabled = false;
            btn_Delete.Enabled = false;
            btn_Update.Enabled = false;
        }

        public void RefreshDataGridView()
        {
            //Fill DataGridView_Client With initial Data
            DT = Clnt.GetAllClients();
            dataGridView_Clients.DataSource = DT;
            lbl_Position.Text = CurrentRowIndex + 1 + " / " + (dataGridView_Clients.Rows.Count);
            //hide Client Image Column
            dataGridView_Clients.Columns[5].Visible = false;
        }
        private void pictureB_ClientImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Filter = "Image Files | *.jpg; *,png; *,gif";
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                pictureB_ClientImage.Image = Image.FromFile(OFD.FileName);
            }
        }

        private void btn_ImageBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Filter = "Image Files | *.jpg; *,png; *,gif";
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                pictureB_ClientImage.Image = Image.FromFile(OFD.FileName);
            }
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            txtB_ID.Clear();
            txtb_FName.Clear();
            txtB_SName.Clear();
            txtb_PhoneNo.Clear();
            txtb_Email.Clear();
            pictureB_ClientImage.Image = Sales_Management.Properties.Resources.Contacts;
            groupB_ClientList.Enabled = false;
            //groupB_Controller.Enabled = false;
            btn_Add.Enabled = true;
            txtB_ID.ReadOnly = false;
            btn_New.Enabled = false;
            btn_Delete.Enabled = false;
            btn_Update.Enabled = false;
            lbl_Position.Text = (dataGridView_Clients.Rows.Count+1)+ " / " + (dataGridView_Clients.Rows.Count+1);
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (txtb_FName.Text == string.Empty || txtB_SName.Text == string.Empty|| txtb_PhoneNo.Text == string.Empty || txtb_Email.Text == string.Empty)
            {
                MessageBox.Show("Error : Incomplete Data, Please fill all missing data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                MemoryStream MS = new MemoryStream();
                pictureB_ClientImage.Image.Save(MS, pictureB_ClientImage.Image.RawFormat);
                byte[] pic = MS.ToArray();
                Clnt.AddClient(Convert.ToInt32(txtB_ID.Text), txtb_FName.Text, txtB_SName.Text, Convert.ToInt32(txtb_PhoneNo.Text), txtb_Email.Text, pic);
                MessageBox.Show("Added Successfully", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
                groupB_ClientList.Enabled = true;
                //groupB_Controller.Enabled = true;
                txtB_ID.ReadOnly = false;
                btn_New.Enabled = true;
                btn_Delete.Enabled = true;
                btn_Update.Enabled = true;
                btn_Add.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); 
            }
            finally
            {
                DT = Clnt.GetAllClients();
                dataGridView_Clients.DataSource = DT;
                lbl_Position.Text = CurrentRowIndex + 1 + " / " + (dataGridView_Clients.Rows.Count);
                //hide Client Image Column
                dataGridView_Clients.Columns[5].Visible = false;
            }   
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (txtb_FName.Text == string.Empty || txtB_SName.Text == string.Empty || txtb_PhoneNo.Text == string.Empty || txtb_Email.Text == string.Empty)
            {
                MessageBox.Show("Error : Incomplete Data, Please fill all missing data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                MemoryStream MS = new MemoryStream();
                pictureB_ClientImage.Image.Save(MS, pictureB_ClientImage.Image.RawFormat);
                byte[] pic = MS.ToArray();
                Clnt.UpdateClient(Convert.ToInt32(txtB_ID.Text), txtb_FName.Text, txtB_SName.Text, Convert.ToInt32(txtb_PhoneNo.Text), txtb_Email.Text, pic);
                MessageBox.Show("Updated Successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                DT = Clnt.GetAllClients();
                dataGridView_Clients.DataSource = DT;
                lbl_Position.Text = CurrentRowIndex + 1 + " / " + (dataGridView_Clients.Rows.Count);
                //hide Client Image Column
                dataGridView_Clients.Columns[5].Visible = false;
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (txtb_FName.Text == string.Empty || txtB_SName.Text == string.Empty || txtb_PhoneNo.Text == string.Empty || txtb_Email.Text == string.Empty)
            {
                MessageBox.Show("Error : Incomplete Data, Please fill all missing data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                if (MessageBox.Show("Are you sure you want to delete ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Clnt.DeleteClient(Convert.ToInt32(txtB_ID.Text));
                    MessageBox.Show("Deleted Successfully. \n\nNote : Refresh The Page After Updating !!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FillClientDetailsWithController(0);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            DT = Clnt.GetAllClients();
            dataGridView_Clients.DataSource = DT;
            lbl_Position.Text = CurrentRowIndex + 1 + " / " + (dataGridView_Clients.Rows.Count);
            //hide Client Image Column
            dataGridView_Clients.Columns[5].Visible = false;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        // For Searching
        private void btn_Search_Click(object sender, EventArgs e)
        {
            dataGridView_Clients.DataSource = Clnt.SearchClients(txtB_ClientSearch.Text);  
        }
        private void txtB_ClientSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btn_Search_Click(sender, e);
        }
        //Filling textBoxes with data from dataGridView_Clients
        private void dataGridView_Clients_Click(object sender, EventArgs e)
        {
            btn_Delete.Enabled = true;
            btn_Update.Enabled = true;
            try
            {
                CurrentRowIndex = dataGridView_Clients.CurrentRow.Index;
                txtB_ID.Text = dataGridView_Clients.CurrentRow.Cells[0].Value.ToString();
                txtb_FName.Text = dataGridView_Clients.CurrentRow.Cells[1].Value.ToString();
                txtB_SName.Text = dataGridView_Clients.CurrentRow.Cells[2].Value.ToString();
                txtb_PhoneNo.Text = dataGridView_Clients.CurrentRow.Cells[3].Value.ToString();
                txtb_Email.Text = dataGridView_Clients.CurrentRow.Cells[4].Value.ToString();
                byte[] Pic = (byte[])dataGridView_Clients.CurrentRow.Cells[5].Value;
                MemoryStream MS = new MemoryStream(Pic);
                pictureB_ClientImage.Image = Image.FromStream(MS);
          }
            catch 
            {
                //If any Exception occured reFill Image
                byte[] Pic = (byte[])DT.Rows[CurrentRowIndex][5];
                MemoryStream MS = new MemoryStream(Pic);
                pictureB_ClientImage.Image = Image.FromStream(MS);
                //Edit lbl_Position
                lbl_Position.Text = CurrentRowIndex + 1 + " / " + (dataGridView_Clients.Rows.Count);
                return;
            }
            //Edit lbl_Position
            lbl_Position.Text = CurrentRowIndex + 1 + " / " + (dataGridView_Clients.Rows.Count);
        }
        public void FillClientDetailsWithController(int RowIndex)
        {
            lbl_Position.Text = RowIndex + 1 + " / " + (dataGridView_Clients.Rows.Count);
            try
            {
                txtB_ID.Text = dataGridView_Clients.Rows[RowIndex].Cells[0].Value.ToString();
                txtb_FName.Text = dataGridView_Clients.Rows[RowIndex].Cells[1].Value.ToString();
                txtB_SName.Text = dataGridView_Clients.Rows[RowIndex].Cells[2].Value.ToString();
                txtb_PhoneNo.Text = dataGridView_Clients.Rows[RowIndex].Cells[3].Value.ToString();
                txtb_Email.Text = dataGridView_Clients.Rows[RowIndex].Cells[4].Value.ToString();

                byte[] Pic = (byte[])dataGridView_Clients.Rows[RowIndex].Cells[5].Value;
                MemoryStream MS = new MemoryStream(Pic);
                pictureB_ClientImage.Image = Image.FromStream(MS);
                //Edit lbl_Position text
                lbl_Position.Text = RowIndex + 1 + " / " + (dataGridView_Clients.Rows.Count);
            }
            catch
            {
                //If any Exception occured reFill Image
                byte[] Pic = (byte[])DT.Rows[CurrentRowIndex][5];
                MemoryStream MS = new MemoryStream(Pic);
                pictureB_ClientImage.Image = Image.FromStream(MS);
                //Edit lbl_Position text
                lbl_Position.Text = RowIndex + 1 + " / " + (dataGridView_Clients.Rows.Count);
            }
        }
    }
}