namespace Sales_Management.PL
{
    partial class frm_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.createDBBackupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restoreDBBackupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.categoriesManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientsManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.addProcessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.productsToolStripMenuItem,
            this.clientsToolStripMenuItem,
            this.usersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(894, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.toolStripSeparator1,
            this.createDBBackupToolStripMenuItem,
            this.restoreDBBackupToolStripMenuItem,
            this.toolStripSeparator2,
            this.logoutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Image = global::Sales_Management.Properties.Resources.Add_File;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Image = global::Sales_Management.Properties.Resources.Key;
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(170, 6);
            // 
            // createDBBackupToolStripMenuItem
            // 
            this.createDBBackupToolStripMenuItem.Image = global::Sales_Management.Properties.Resources.Archive;
            this.createDBBackupToolStripMenuItem.Name = "createDBBackupToolStripMenuItem";
            this.createDBBackupToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.createDBBackupToolStripMenuItem.Text = "Create DB Backup";
            this.createDBBackupToolStripMenuItem.Click += new System.EventHandler(this.createDBBackupToolStripMenuItem_Click);
            // 
            // restoreDBBackupToolStripMenuItem
            // 
            this.restoreDBBackupToolStripMenuItem.Image = global::Sales_Management.Properties.Resources.Add_List;
            this.restoreDBBackupToolStripMenuItem.Name = "restoreDBBackupToolStripMenuItem";
            this.restoreDBBackupToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.restoreDBBackupToolStripMenuItem.Text = "Restore DB Backup";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(170, 6);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Image = global::Sales_Management.Properties.Resources.Lock1;
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::Sales_Management.Properties.Resources.Book;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // productsToolStripMenuItem
            // 
            this.productsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addProductToolStripMenuItem,
            this.productsManagementToolStripMenuItem,
            this.toolStripSeparator3,
            this.categoriesManagementToolStripMenuItem});
            this.productsToolStripMenuItem.Image = global::Sales_Management.Properties.Resources.Business;
            this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            this.productsToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.productsToolStripMenuItem.Text = "Products";
            // 
            // addProductToolStripMenuItem
            // 
            this.addProductToolStripMenuItem.Name = "addProductToolStripMenuItem";
            this.addProductToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.addProductToolStripMenuItem.Text = "Add Product";
            this.addProductToolStripMenuItem.Click += new System.EventHandler(this.addProductToolStripMenuItem_Click);
            // 
            // productsManagementToolStripMenuItem
            // 
            this.productsManagementToolStripMenuItem.Name = "productsManagementToolStripMenuItem";
            this.productsManagementToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.productsManagementToolStripMenuItem.Text = "Products Management";
            this.productsManagementToolStripMenuItem.Click += new System.EventHandler(this.productsManagementToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(201, 6);
            // 
            // categoriesManagementToolStripMenuItem
            // 
            this.categoriesManagementToolStripMenuItem.Name = "categoriesManagementToolStripMenuItem";
            this.categoriesManagementToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.categoriesManagementToolStripMenuItem.Text = "Categories Management";
            this.categoriesManagementToolStripMenuItem.Click += new System.EventHandler(this.categoriesManagementToolStripMenuItem_Click);
            // 
            // clientsToolStripMenuItem
            // 
            this.clientsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientsManagementToolStripMenuItem,
            this.toolStripSeparator4,
            this.addProcessToolStripMenuItem,
            this.processManagementToolStripMenuItem});
            this.clientsToolStripMenuItem.Image = global::Sales_Management.Properties.Resources.Business_Contact;
            this.clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
            this.clientsToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.clientsToolStripMenuItem.Text = "Clients";
            // 
            // clientsManagementToolStripMenuItem
            // 
            this.clientsManagementToolStripMenuItem.Name = "clientsManagementToolStripMenuItem";
            this.clientsManagementToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.clientsManagementToolStripMenuItem.Text = "Clients Management";
            this.clientsManagementToolStripMenuItem.Click += new System.EventHandler(this.clientsManagementToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(181, 6);
            // 
            // addProcessToolStripMenuItem
            // 
            this.addProcessToolStripMenuItem.Name = "addProcessToolStripMenuItem";
            this.addProcessToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.addProcessToolStripMenuItem.Text = "Add Order";
            this.addProcessToolStripMenuItem.Click += new System.EventHandler(this.addProcessToolStripMenuItem_Click);
            // 
            // processManagementToolStripMenuItem
            // 
            this.processManagementToolStripMenuItem.Name = "processManagementToolStripMenuItem";
            this.processManagementToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.processManagementToolStripMenuItem.Text = "Orders Management";
            this.processManagementToolStripMenuItem.Click += new System.EventHandler(this.processManagementToolStripMenuItem_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUserToolStripMenuItem,
            this.usersManagementToolStripMenuItem});
            this.usersToolStripMenuItem.Image = global::Sales_Management.Properties.Resources.Conference_Call;
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.usersToolStripMenuItem.Text = "Users";
            // 
            // addUserToolStripMenuItem
            // 
            this.addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            this.addUserToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.addUserToolStripMenuItem.Text = "Add User";
            this.addUserToolStripMenuItem.Click += new System.EventHandler(this.addUserToolStripMenuItem_Click);
            // 
            // usersManagementToolStripMenuItem
            // 
            this.usersManagementToolStripMenuItem.Name = "usersManagementToolStripMenuItem";
            this.usersManagementToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.usersManagementToolStripMenuItem.Text = "Users Management";
            this.usersManagementToolStripMenuItem.Click += new System.EventHandler(this.usersManagementToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 408);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(894, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(894, 430);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sales Management Program";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem createDBBackupToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem restoreDBBackupToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem addProductToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem productsManagementToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem clientsToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem clientsManagementToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem addProcessToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem processManagementToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem usersManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriesManagementToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}