namespace Sales_Management.PL
{
    partial class frm_Client
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_Position = new System.Windows.Forms.Label();
            this.btn_ImageBrowse = new System.Windows.Forms.Button();
            this.txtB_SName = new System.Windows.Forms.TextBox();
            this.txtB_ID = new System.Windows.Forms.TextBox();
            this.txtb_PhoneNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureB_ClientImage = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtb_FName = new System.Windows.Forms.TextBox();
            this.txtb_Email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_New = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.groupB_ClientList = new System.Windows.Forms.GroupBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtB_ClientSearch = new System.Windows.Forms.TextBox();
            this.dataGridView_Clients = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureB_ClientImage)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupB_ClientList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Clients)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_Position);
            this.groupBox1.Controls.Add(this.btn_ImageBrowse);
            this.groupBox1.Controls.Add(this.txtB_SName);
            this.groupBox1.Controls.Add(this.txtB_ID);
            this.groupBox1.Controls.Add(this.txtb_PhoneNo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.pictureB_ClientImage);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtb_FName);
            this.groupBox1.Controls.Add(this.txtb_Email);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 270);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Client Data";
            // 
            // lbl_Position
            // 
            this.lbl_Position.AutoSize = true;
            this.lbl_Position.Location = new System.Drawing.Point(230, 236);
            this.lbl_Position.Name = "lbl_Position";
            this.lbl_Position.Size = new System.Drawing.Size(24, 13);
            this.lbl_Position.TabIndex = 72;
            this.lbl_Position.Text = "Pos";
            // 
            // btn_ImageBrowse
            // 
            this.btn_ImageBrowse.Location = new System.Drawing.Point(451, 226);
            this.btn_ImageBrowse.Name = "btn_ImageBrowse";
            this.btn_ImageBrowse.Size = new System.Drawing.Size(38, 23);
            this.btn_ImageBrowse.TabIndex = 74;
            this.btn_ImageBrowse.Text = "..";
            this.btn_ImageBrowse.UseVisualStyleBackColor = true;
            this.btn_ImageBrowse.Click += new System.EventHandler(this.btn_ImageBrowse_Click);
            // 
            // txtB_SName
            // 
            this.txtB_SName.Location = new System.Drawing.Point(108, 112);
            this.txtB_SName.Name = "txtB_SName";
            this.txtB_SName.Size = new System.Drawing.Size(263, 20);
            this.txtB_SName.TabIndex = 3;
            // 
            // txtB_ID
            // 
            this.txtB_ID.Location = new System.Drawing.Point(108, 36);
            this.txtB_ID.Name = "txtB_ID";
            this.txtB_ID.ReadOnly = true;
            this.txtB_ID.Size = new System.Drawing.Size(263, 20);
            this.txtB_ID.TabIndex = 1;
            // 
            // txtb_PhoneNo
            // 
            this.txtb_PhoneNo.Location = new System.Drawing.Point(108, 158);
            this.txtb_PhoneNo.Name = "txtb_PhoneNo";
            this.txtb_PhoneNo.Size = new System.Drawing.Size(263, 20);
            this.txtb_PhoneNo.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(13, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 49;
            this.label2.Text = "First Name  :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 57;
            this.label5.Text = "ID  :";
            // 
            // pictureB_ClientImage
            // 
            this.pictureB_ClientImage.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pictureB_ClientImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureB_ClientImage.Image = global::Sales_Management.Properties.Resources.Contacts;
            this.pictureB_ClientImage.InitialImage = global::Sales_Management.Properties.Resources.Contacts;
            this.pictureB_ClientImage.Location = new System.Drawing.Point(396, 36);
            this.pictureB_ClientImage.Name = "pictureB_ClientImage";
            this.pictureB_ClientImage.Size = new System.Drawing.Size(144, 173);
            this.pictureB_ClientImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureB_ClientImage.TabIndex = 59;
            this.pictureB_ClientImage.TabStop = false;
            this.pictureB_ClientImage.Click += new System.EventHandler(this.pictureB_ClientImage_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 55;
            this.label6.Text = "E-Mail  :";
            // 
            // txtb_FName
            // 
            this.txtb_FName.Location = new System.Drawing.Point(108, 84);
            this.txtb_FName.Name = "txtb_FName";
            this.txtb_FName.Size = new System.Drawing.Size(263, 20);
            this.txtb_FName.TabIndex = 2;
            // 
            // txtb_Email
            // 
            this.txtb_Email.Location = new System.Drawing.Point(108, 189);
            this.txtb_Email.Name = "txtb_Email";
            this.txtb_Email.Size = new System.Drawing.Size(263, 20);
            this.txtb_Email.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 53;
            this.label3.Text = "Phone No.  :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 51;
            this.label4.Text = "Second Name  :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Cancel);
            this.groupBox2.Controls.Add(this.btn_New);
            this.groupBox2.Controls.Add(this.btn_Update);
            this.groupBox2.Controls.Add(this.btn_Add);
            this.groupBox2.Controls.Add(this.btn_Delete);
            this.groupBox2.Location = new System.Drawing.Point(12, 273);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(549, 34);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Cancel.Location = new System.Drawing.Point(442, 9);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(103, 23);
            this.btn_Cancel.TabIndex = 15;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_New
            // 
            this.btn_New.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_New.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_New.Location = new System.Drawing.Point(6, 9);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(103, 23);
            this.btn_New.TabIndex = 10;
            this.btn_New.Text = "New";
            this.btn_New.UseVisualStyleBackColor = true;
            this.btn_New.Click += new System.EventHandler(this.btn_New_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Update.Location = new System.Drawing.Point(224, 9);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(103, 23);
            this.btn_Update.TabIndex = 13;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Add.Location = new System.Drawing.Point(115, 9);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(103, 23);
            this.btn_Add.TabIndex = 11;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Delete.Location = new System.Drawing.Point(333, 9);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(103, 23);
            this.btn_Delete.TabIndex = 14;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // groupB_ClientList
            // 
            this.groupB_ClientList.Controls.Add(this.btn_Search);
            this.groupB_ClientList.Controls.Add(this.label1);
            this.groupB_ClientList.Controls.Add(this.txtB_ClientSearch);
            this.groupB_ClientList.Controls.Add(this.dataGridView_Clients);
            this.groupB_ClientList.Location = new System.Drawing.Point(569, 3);
            this.groupB_ClientList.Name = "groupB_ClientList";
            this.groupB_ClientList.Size = new System.Drawing.Size(423, 310);
            this.groupB_ClientList.TabIndex = 2;
            this.groupB_ClientList.TabStop = false;
            this.groupB_ClientList.Text = "Clients List";
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(330, 19);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(38, 23);
            this.btn_Search.TabIndex = 63;
            this.btn_Search.Text = "Go";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 62;
            this.label1.Text = "Search For :";
            // 
            // txtB_ClientSearch
            // 
            this.txtB_ClientSearch.Location = new System.Drawing.Point(89, 19);
            this.txtB_ClientSearch.Name = "txtB_ClientSearch";
            this.txtB_ClientSearch.Size = new System.Drawing.Size(226, 20);
            this.txtB_ClientSearch.TabIndex = 9;
            this.txtB_ClientSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtB_ClientSearch_KeyDown);
            // 
            // dataGridView_Clients
            // 
            this.dataGridView_Clients.AllowUserToAddRows = false;
            this.dataGridView_Clients.AllowUserToDeleteRows = false;
            this.dataGridView_Clients.AllowUserToResizeRows = false;
            this.dataGridView_Clients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Clients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Clients.Location = new System.Drawing.Point(6, 53);
            this.dataGridView_Clients.MultiSelect = false;
            this.dataGridView_Clients.Name = "dataGridView_Clients";
            this.dataGridView_Clients.ReadOnly = true;
            this.dataGridView_Clients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Clients.Size = new System.Drawing.Size(411, 251);
            this.dataGridView_Clients.TabIndex = 3;
            this.dataGridView_Clients.Click += new System.EventHandler(this.dataGridView_Clients_Click);
            // 
            // frm_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 323);
            this.Controls.Add(this.groupB_ClientList);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Client";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clients";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureB_ClientImage)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupB_ClientList.ResumeLayout(false);
            this.groupB_ClientList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Clients)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox txtB_SName;
        public System.Windows.Forms.TextBox txtB_ID;
        public System.Windows.Forms.TextBox txtb_PhoneNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.PictureBox pictureB_ClientImage;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtb_FName;
        public System.Windows.Forms.TextBox txtb_Email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_New;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.GroupBox groupB_ClientList;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtB_ClientSearch;
        private System.Windows.Forms.DataGridView dataGridView_Clients;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_ImageBrowse;
        private System.Windows.Forms.Label lbl_Position;
    }
}