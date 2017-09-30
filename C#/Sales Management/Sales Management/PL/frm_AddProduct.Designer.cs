namespace Sales_Management.PL
{
    partial class frm_AddProduct
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
            this.txtb_Quantity = new System.Windows.Forms.TextBox();
            this.cmbb_CategoryID = new System.Windows.Forms.ComboBox();
            this.btn_SelectImage = new System.Windows.Forms.Button();
            this.pictureB_ProductImage = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtb_Price = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtb_Label = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtb_ProductID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_OK = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureB_ProductImage)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.txtb_Quantity);
            this.groupBox1.Controls.Add(this.cmbb_CategoryID);
            this.groupBox1.Controls.Add(this.btn_SelectImage);
            this.groupBox1.Controls.Add(this.pictureB_ProductImage);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtb_Price);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtb_Label);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtb_ProductID);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(531, 434);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product Details";
            // 
            // txtb_Quantity
            // 
            this.txtb_Quantity.Location = new System.Drawing.Point(134, 211);
            this.txtb_Quantity.Name = "txtb_Quantity";
            this.txtb_Quantity.Size = new System.Drawing.Size(337, 20);
            this.txtb_Quantity.TabIndex = 32;
            // 
            // cmbb_CategoryID
            // 
            this.cmbb_CategoryID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbb_CategoryID.FormattingEnabled = true;
            this.cmbb_CategoryID.Location = new System.Drawing.Point(134, 45);
            this.cmbb_CategoryID.Name = "cmbb_CategoryID";
            this.cmbb_CategoryID.Size = new System.Drawing.Size(337, 21);
            this.cmbb_CategoryID.TabIndex = 26;
            // 
            // btn_SelectImage
            // 
            this.btn_SelectImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SelectImage.Location = new System.Drawing.Point(406, 385);
            this.btn_SelectImage.Name = "btn_SelectImage";
            this.btn_SelectImage.Size = new System.Drawing.Size(65, 23);
            this.btn_SelectImage.TabIndex = 36;
            this.btn_SelectImage.Text = "...";
            this.btn_SelectImage.UseVisualStyleBackColor = true;
            this.btn_SelectImage.Click += new System.EventHandler(this.btn_SelectImage_Click);
            // 
            // pictureB_ProductImage
            // 
            this.pictureB_ProductImage.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureB_ProductImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureB_ProductImage.Image = global::Sales_Management.Properties.Resources.Add_File;
            this.pictureB_ProductImage.InitialImage = global::Sales_Management.Properties.Resources.Add_File;
            this.pictureB_ProductImage.Location = new System.Drawing.Point(134, 295);
            this.pictureB_ProductImage.Name = "pictureB_ProductImage";
            this.pictureB_ProductImage.Size = new System.Drawing.Size(250, 113);
            this.pictureB_ProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureB_ProductImage.TabIndex = 37;
            this.pictureB_ProductImage.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Category ID  :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Product ID  :";
            // 
            // txtb_Price
            // 
            this.txtb_Price.Location = new System.Drawing.Point(134, 248);
            this.txtb_Price.Name = "txtb_Price";
            this.txtb_Price.Size = new System.Drawing.Size(337, 20);
            this.txtb_Price.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Label  :";
            // 
            // txtb_Label
            // 
            this.txtb_Label.Location = new System.Drawing.Point(134, 122);
            this.txtb_Label.Multiline = true;
            this.txtb_Label.Name = "txtb_Label";
            this.txtb_Label.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtb_Label.Size = new System.Drawing.Size(337, 76);
            this.txtb_Label.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Quantity  :";
            // 
            // txtb_ProductID
            // 
            this.txtb_ProductID.Location = new System.Drawing.Point(134, 84);
            this.txtb_ProductID.Name = "txtb_ProductID";
            this.txtb_ProductID.Size = new System.Drawing.Size(337, 20);
            this.txtb_ProductID.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Price  :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Image  :";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Cancel.ImageIndex = 0;
            this.btn_Cancel.Location = new System.Drawing.Point(332, 462);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(100, 39);
            this.btn_Cancel.TabIndex = 8;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_OK
            // 
            this.btn_OK.CausesValidation = false;
            this.btn_OK.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OK.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_OK.ImageIndex = 6;
            this.btn_OK.Location = new System.Drawing.Point(438, 462);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(100, 39);
            this.btn_OK.TabIndex = 7;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = false;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // frm_AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 514);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_AddProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Product";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureB_ProductImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Cancel;
        public System.Windows.Forms.Button btn_OK;
        public System.Windows.Forms.TextBox txtb_Quantity;
        public System.Windows.Forms.ComboBox cmbb_CategoryID;
        private System.Windows.Forms.Button btn_SelectImage;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.PictureBox pictureB_ProductImage;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtb_Price;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtb_Label;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtb_ProductID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}