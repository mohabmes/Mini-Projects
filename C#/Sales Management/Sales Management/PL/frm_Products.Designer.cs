namespace Sales_Management.PL
{
    partial class frm_Products
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtb_search = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridV_Product = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_PrintAllProducts = new System.Windows.Forms.Button();
            this.btn_PrintProduct = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_EditDetails = new System.Windows.Forms.Button();
            this.btn_ViewImage = new System.Windows.Forms.Button();
            this.btn_DeleteProduct = new System.Windows.Forms.Button();
            this.btn_AddProduct = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridV_Product)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(193, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search For : ";
            // 
            // txtb_search
            // 
            this.txtb_search.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_search.Location = new System.Drawing.Point(292, 12);
            this.txtb_search.Name = "txtb_search";
            this.txtb_search.Size = new System.Drawing.Size(335, 26);
            this.txtb_search.TabIndex = 0;
            this.txtb_search.TextChanged += new System.EventHandler(this.txtb_search_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridV_Product);
            this.groupBox1.Location = new System.Drawing.Point(11, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(874, 351);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data";
            // 
            // dataGridV_Product
            // 
            this.dataGridV_Product.AllowUserToAddRows = false;
            this.dataGridV_Product.AllowUserToDeleteRows = false;
            this.dataGridV_Product.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridV_Product.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridV_Product.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridV_Product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridV_Product.Location = new System.Drawing.Point(7, 19);
            this.dataGridV_Product.Name = "dataGridV_Product";
            this.dataGridV_Product.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridV_Product.Size = new System.Drawing.Size(861, 316);
            this.dataGridV_Product.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_PrintAllProducts);
            this.groupBox2.Controls.Add(this.btn_PrintProduct);
            this.groupBox2.Controls.Add(this.btn_Cancel);
            this.groupBox2.Controls.Add(this.btn_EditDetails);
            this.groupBox2.Controls.Add(this.btn_ViewImage);
            this.groupBox2.Controls.Add(this.btn_DeleteProduct);
            this.groupBox2.Controls.Add(this.btn_AddProduct);
            this.groupBox2.Location = new System.Drawing.Point(11, 404);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(874, 88);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Control";
            // 
            // btn_PrintAllProducts
            // 
            this.btn_PrintAllProducts.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_PrintAllProducts.Location = new System.Drawing.Point(334, 57);
            this.btn_PrintAllProducts.Name = "btn_PrintAllProducts";
            this.btn_PrintAllProducts.Size = new System.Drawing.Size(255, 23);
            this.btn_PrintAllProducts.TabIndex = 9;
            this.btn_PrintAllProducts.Text = "All Products Report";
            this.btn_PrintAllProducts.UseVisualStyleBackColor = true;
            this.btn_PrintAllProducts.Click += new System.EventHandler(this.btn_PrintAllProducts_Click);
            // 
            // btn_PrintProduct
            // 
            this.btn_PrintProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_PrintProduct.Location = new System.Drawing.Point(73, 57);
            this.btn_PrintProduct.Name = "btn_PrintProduct";
            this.btn_PrintProduct.Size = new System.Drawing.Size(255, 23);
            this.btn_PrintProduct.TabIndex = 10;
            this.btn_PrintProduct.Text = "Product Report";
            this.btn_PrintProduct.UseVisualStyleBackColor = true;
            this.btn_PrintProduct.Click += new System.EventHandler(this.btn_PrintProduct_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Cancel.Location = new System.Drawing.Point(595, 57);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(207, 23);
            this.btn_Cancel.TabIndex = 8;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_EditDetails
            // 
            this.btn_EditDetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_EditDetails.Location = new System.Drawing.Point(442, 28);
            this.btn_EditDetails.Name = "btn_EditDetails";
            this.btn_EditDetails.Size = new System.Drawing.Size(207, 23);
            this.btn_EditDetails.TabIndex = 3;
            this.btn_EditDetails.Text = "Edit Details";
            this.btn_EditDetails.UseVisualStyleBackColor = true;
            this.btn_EditDetails.Click += new System.EventHandler(this.btn_EditDetails_Click);
            // 
            // btn_ViewImage
            // 
            this.btn_ViewImage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ViewImage.Location = new System.Drawing.Point(655, 28);
            this.btn_ViewImage.Name = "btn_ViewImage";
            this.btn_ViewImage.Size = new System.Drawing.Size(207, 23);
            this.btn_ViewImage.TabIndex = 2;
            this.btn_ViewImage.Text = "View Image";
            this.btn_ViewImage.UseVisualStyleBackColor = true;
            this.btn_ViewImage.Click += new System.EventHandler(this.btn_ViewImage_Click);
            // 
            // btn_DeleteProduct
            // 
            this.btn_DeleteProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_DeleteProduct.Location = new System.Drawing.Point(229, 28);
            this.btn_DeleteProduct.Name = "btn_DeleteProduct";
            this.btn_DeleteProduct.Size = new System.Drawing.Size(207, 23);
            this.btn_DeleteProduct.TabIndex = 1;
            this.btn_DeleteProduct.Text = "Delete Product";
            this.btn_DeleteProduct.UseVisualStyleBackColor = true;
            this.btn_DeleteProduct.Click += new System.EventHandler(this.btn_DeleteProduct_Click);
            // 
            // btn_AddProduct
            // 
            this.btn_AddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_AddProduct.Location = new System.Drawing.Point(16, 28);
            this.btn_AddProduct.Name = "btn_AddProduct";
            this.btn_AddProduct.Size = new System.Drawing.Size(207, 23);
            this.btn_AddProduct.TabIndex = 0;
            this.btn_AddProduct.Text = "Add Product";
            this.btn_AddProduct.UseVisualStyleBackColor = true;
            this.btn_AddProduct.Click += new System.EventHandler(this.btn_AddProduct_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Location = new System.Drawing.Point(774, 12);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(111, 26);
            this.btn_Refresh.TabIndex = 4;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // frm_Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 500);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtb_search);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frm_Products";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Products";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridV_Product)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtb_search;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_EditDetails;
        private System.Windows.Forms.Button btn_ViewImage;
        private System.Windows.Forms.Button btn_DeleteProduct;
        private System.Windows.Forms.Button btn_AddProduct;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Refresh;
        public System.Windows.Forms.DataGridView dataGridV_Product;
        private System.Windows.Forms.Button btn_PrintAllProducts;
        private System.Windows.Forms.Button btn_PrintProduct;
    }
}