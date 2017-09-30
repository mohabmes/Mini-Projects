namespace Sales_Management.PL
{
    partial class frm_ViewOrderDetails
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
            this.groupB_Product = new System.Windows.Forms.GroupBox();
            this.txt_Total = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupB_OrderData = new System.Windows.Forms.GroupBox();
            this.dateTime_OrderDate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtB_OrderNo = new System.Windows.Forms.TextBox();
            this.txtB_OrderDescription = new System.Windows.Forms.TextBox();
            this.txtB_Username = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupB_ClientData = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtB_SName = new System.Windows.Forms.TextBox();
            this.txtb_Email = new System.Windows.Forms.TextBox();
            this.txtB_ID = new System.Windows.Forms.TextBox();
            this.txtb_FName = new System.Windows.Forms.TextBox();
            this.txtb_PhoneNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureB_ClientImage = new System.Windows.Forms.PictureBox();
            this.btn_Print = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.dgv_products = new System.Windows.Forms.DataGridView();
            this.groupB_Product.SuspendLayout();
            this.groupB_OrderData.SuspendLayout();
            this.groupB_ClientData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureB_ClientImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_products)).BeginInit();
            this.SuspendLayout();
            // 
            // groupB_Product
            // 
            this.groupB_Product.Controls.Add(this.dgv_products);
            this.groupB_Product.Controls.Add(this.txt_Total);
            this.groupB_Product.Controls.Add(this.label10);
            this.groupB_Product.Location = new System.Drawing.Point(12, 203);
            this.groupB_Product.Name = "groupB_Product";
            this.groupB_Product.Size = new System.Drawing.Size(949, 223);
            this.groupB_Product.TabIndex = 4;
            this.groupB_Product.TabStop = false;
            this.groupB_Product.Text = "Products";
            // 
            // txt_Total
            // 
            this.txt_Total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Total.Location = new System.Drawing.Point(755, 197);
            this.txt_Total.Name = "txt_Total";
            this.txt_Total.ReadOnly = true;
            this.txt_Total.Size = new System.Drawing.Size(188, 20);
            this.txt_Total.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(708, 200);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 93;
            this.label10.Text = "Total  :";
            // 
            // groupB_OrderData
            // 
            this.groupB_OrderData.Controls.Add(this.dateTime_OrderDate);
            this.groupB_OrderData.Controls.Add(this.label1);
            this.groupB_OrderData.Controls.Add(this.label7);
            this.groupB_OrderData.Controls.Add(this.label8);
            this.groupB_OrderData.Controls.Add(this.txtB_OrderNo);
            this.groupB_OrderData.Controls.Add(this.txtB_OrderDescription);
            this.groupB_OrderData.Controls.Add(this.txtB_Username);
            this.groupB_OrderData.Controls.Add(this.label9);
            this.groupB_OrderData.Location = new System.Drawing.Point(12, 12);
            this.groupB_OrderData.Name = "groupB_OrderData";
            this.groupB_OrderData.Size = new System.Drawing.Size(470, 185);
            this.groupB_OrderData.TabIndex = 2;
            this.groupB_OrderData.TabStop = false;
            this.groupB_OrderData.Text = "Order Data";
            // 
            // dateTime_OrderDate
            // 
            this.dateTime_OrderDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dateTime_OrderDate.Location = new System.Drawing.Point(111, 109);
            this.dateTime_OrderDate.Name = "dateTime_OrderDate";
            this.dateTime_OrderDate.ReadOnly = true;
            this.dateTime_OrderDate.Size = new System.Drawing.Size(341, 20);
            this.dateTime_OrderDate.TabIndex = 94;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 92;
            this.label1.Text = "Order No.  :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 90;
            this.label7.Text = "Date  :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 91;
            this.label8.Text = "Username  :";
            // 
            // txtB_OrderNo
            // 
            this.txtB_OrderNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtB_OrderNo.Location = new System.Drawing.Point(111, 25);
            this.txtB_OrderNo.Name = "txtB_OrderNo";
            this.txtB_OrderNo.ReadOnly = true;
            this.txtB_OrderNo.Size = new System.Drawing.Size(288, 20);
            this.txtB_OrderNo.TabIndex = 0;
            // 
            // txtB_OrderDescription
            // 
            this.txtB_OrderDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtB_OrderDescription.Location = new System.Drawing.Point(111, 52);
            this.txtB_OrderDescription.Multiline = true;
            this.txtB_OrderDescription.Name = "txtB_OrderDescription";
            this.txtB_OrderDescription.ReadOnly = true;
            this.txtB_OrderDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtB_OrderDescription.Size = new System.Drawing.Size(341, 44);
            this.txtB_OrderDescription.TabIndex = 1;
            // 
            // txtB_Username
            // 
            this.txtB_Username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtB_Username.Location = new System.Drawing.Point(111, 138);
            this.txtB_Username.Name = "txtB_Username";
            this.txtB_Username.ReadOnly = true;
            this.txtB_Username.Size = new System.Drawing.Size(341, 20);
            this.txtB_Username.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(25, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 89;
            this.label9.Text = "Description  :";
            // 
            // groupB_ClientData
            // 
            this.groupB_ClientData.Controls.Add(this.label5);
            this.groupB_ClientData.Controls.Add(this.label4);
            this.groupB_ClientData.Controls.Add(this.label3);
            this.groupB_ClientData.Controls.Add(this.txtB_SName);
            this.groupB_ClientData.Controls.Add(this.txtb_Email);
            this.groupB_ClientData.Controls.Add(this.txtB_ID);
            this.groupB_ClientData.Controls.Add(this.txtb_FName);
            this.groupB_ClientData.Controls.Add(this.txtb_PhoneNo);
            this.groupB_ClientData.Controls.Add(this.label6);
            this.groupB_ClientData.Controls.Add(this.label2);
            this.groupB_ClientData.Controls.Add(this.pictureB_ClientImage);
            this.groupB_ClientData.Location = new System.Drawing.Point(491, 12);
            this.groupB_ClientData.Name = "groupB_ClientData";
            this.groupB_ClientData.Size = new System.Drawing.Size(470, 185);
            this.groupB_ClientData.TabIndex = 3;
            this.groupB_ClientData.TabStop = false;
            this.groupB_ClientData.Text = "Client Data";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 84;
            this.label5.Text = "ID  :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 81;
            this.label4.Text = "Second Name  :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 82;
            this.label3.Text = "Phone No.  :";
            // 
            // txtB_SName
            // 
            this.txtB_SName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtB_SName.Location = new System.Drawing.Point(103, 80);
            this.txtB_SName.Name = "txtB_SName";
            this.txtB_SName.ReadOnly = true;
            this.txtB_SName.Size = new System.Drawing.Size(201, 20);
            this.txtB_SName.TabIndex = 2;
            // 
            // txtb_Email
            // 
            this.txtb_Email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtb_Email.Location = new System.Drawing.Point(103, 140);
            this.txtb_Email.Name = "txtb_Email";
            this.txtb_Email.ReadOnly = true;
            this.txtb_Email.Size = new System.Drawing.Size(201, 20);
            this.txtb_Email.TabIndex = 4;
            // 
            // txtB_ID
            // 
            this.txtB_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtB_ID.Location = new System.Drawing.Point(103, 25);
            this.txtB_ID.Name = "txtB_ID";
            this.txtB_ID.ReadOnly = true;
            this.txtB_ID.Size = new System.Drawing.Size(201, 20);
            this.txtB_ID.TabIndex = 0;
            // 
            // txtb_FName
            // 
            this.txtb_FName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtb_FName.Location = new System.Drawing.Point(103, 52);
            this.txtb_FName.Name = "txtb_FName";
            this.txtb_FName.ReadOnly = true;
            this.txtb_FName.Size = new System.Drawing.Size(201, 20);
            this.txtb_FName.TabIndex = 1;
            // 
            // txtb_PhoneNo
            // 
            this.txtb_PhoneNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtb_PhoneNo.Location = new System.Drawing.Point(103, 109);
            this.txtb_PhoneNo.Name = "txtb_PhoneNo";
            this.txtb_PhoneNo.ReadOnly = true;
            this.txtb_PhoneNo.Size = new System.Drawing.Size(201, 20);
            this.txtb_PhoneNo.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 83;
            this.label6.Text = "E-Mail  :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(17, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 80;
            this.label2.Text = "First Name  :";
            // 
            // pictureB_ClientImage
            // 
            this.pictureB_ClientImage.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pictureB_ClientImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureB_ClientImage.Image = global::Sales_Management.Properties.Resources.Contacts;
            this.pictureB_ClientImage.InitialImage = global::Sales_Management.Properties.Resources.Contacts;
            this.pictureB_ClientImage.Location = new System.Drawing.Point(310, 25);
            this.pictureB_ClientImage.Name = "pictureB_ClientImage";
            this.pictureB_ClientImage.Size = new System.Drawing.Size(128, 135);
            this.pictureB_ClientImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureB_ClientImage.TabIndex = 85;
            this.pictureB_ClientImage.TabStop = false;
            // 
            // btn_Print
            // 
            this.btn_Print.Location = new System.Drawing.Point(375, 445);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(107, 23);
            this.btn_Print.TabIndex = 0;
            this.btn_Print.Text = "Print";
            this.btn_Print.UseVisualStyleBackColor = true;
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(488, 445);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(107, 23);
            this.btn_Cancel.TabIndex = 1;
            this.btn_Cancel.Text = "Close";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // dgv_products
            // 
            this.dgv_products.AllowUserToAddRows = false;
            this.dgv_products.AllowUserToDeleteRows = false;
            this.dgv_products.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_products.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_products.Location = new System.Drawing.Point(6, 29);
            this.dgv_products.MultiSelect = false;
            this.dgv_products.Name = "dgv_products";
            this.dgv_products.ReadOnly = true;
            this.dgv_products.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_products.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_products.Size = new System.Drawing.Size(937, 162);
            this.dgv_products.TabIndex = 94;
            // 
            // frm_ViewOrderDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 480);
            this.Controls.Add(this.btn_Print);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.groupB_Product);
            this.Controls.Add(this.groupB_OrderData);
            this.Controls.Add(this.groupB_ClientData);
            this.Name = "frm_ViewOrderDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order Details";
            this.groupB_Product.ResumeLayout(false);
            this.groupB_Product.PerformLayout();
            this.groupB_OrderData.ResumeLayout(false);
            this.groupB_OrderData.PerformLayout();
            this.groupB_ClientData.ResumeLayout(false);
            this.groupB_ClientData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureB_ClientImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_products)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupB_Product;
        public System.Windows.Forms.TextBox txt_Total;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupB_OrderData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txtB_OrderNo;
        public System.Windows.Forms.TextBox txtB_OrderDescription;
        public System.Windows.Forms.TextBox txtB_Username;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupB_ClientData;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtB_SName;
        public System.Windows.Forms.TextBox txtb_Email;
        public System.Windows.Forms.TextBox txtB_ID;
        public System.Windows.Forms.TextBox txtb_FName;
        public System.Windows.Forms.TextBox txtb_PhoneNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.PictureBox pictureB_ClientImage;
        private System.Windows.Forms.Button btn_Print;
        private System.Windows.Forms.Button btn_Cancel;
        public System.Windows.Forms.TextBox dateTime_OrderDate;
        public System.Windows.Forms.DataGridView dgv_products;
    }
}