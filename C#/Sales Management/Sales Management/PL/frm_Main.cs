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
    public partial class frm_Main : Form
    {
        //Fields
        #region Static Main Form
        //For Using one Static Form (banning Any object OR instance)
        private static frm_Main MainForm;

        //To Make [MainForm] get the value of the orginal form
        public static frm_Main GetMainForm
        {
            get
            {
                if (MainForm == null)
                    MainForm = new frm_Main();
                return MainForm;
            }
        }
        #endregion
        //Constructor
        public frm_Main()
        {
            //Make Sure [MainForm] is assigned
            //Show it
            if (MainForm == null) { MainForm = this; }
            InitializeComponent();
            DisableMenuStrip();
        }
        //For Disable MenuStrip during outlogging
        public void DisableMenuStrip()
        {
            this.usersToolStripMenuItem.Visible = false;
            this.usersToolStripMenuItem.Enabled = false;
            this.productsToolStripMenuItem.Enabled = false;
            this.clientsToolStripMenuItem.Enabled = false;
            //Disable restore & Create Backups in files list
            this.createDBBackupToolStripMenuItem.Enabled = false;
            this.restoreDBBackupToolStripMenuItem.Enabled = false;
            //Disable howToUse & update in About list

        }
        //For Enable MenuStrip during loginning
        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Login LoginForm = new frm_Login();
            LoginForm.ShowDialog();
        }
        //Form Closing        
        private void frm_Main_Load(object sender, EventArgs e)
        {
            ProgressBar pb = new ProgressBar();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
           DialogResult Dr= MessageBox.Show("Are you about to close the program. Are you sure you want to continue?", "Confirm close", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (Dr==DialogResult.OK)
            {
                Close();
            }
        }
        //Show form for adding new Product
        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_AddProduct frm = new frm_AddProduct();
            frm.ShowDialog();
        }
        //Show form for Management All Products
        private void productsManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Products frm = new frm_Products();
            frm.ShowDialog();
        }

        private void categoriesManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Category frm = new frm_Category();
            frm.ShowDialog();
        }

        private void clientsManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Client frm = new frm_Client();
            frm.ShowDialog();
        }

        private void processManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Orders frm = new frm_Orders();
            frm.ShowDialog();
        }

        private void addProcessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_AddOrder frm = new frm_AddOrder();
            frm.ShowDialog();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisableMenuStrip();
        }

        private void usersManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Users frm = new frm_Users();
            frm.ShowDialog();
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_AddUser frm = new frm_AddUser();
            frm.ShowDialog();
        }

        private void createDBBackupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Backup frm = new frm_Backup();
            frm.ShowDialog();
        }
    }
}
