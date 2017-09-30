namespace Sales_Management.PL
{
    partial class frm_AllProducts
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
            this.btn_Search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtB_ProductSearch = new System.Windows.Forms.TextBox();
            this.dataGridView_Products = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Products)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(477, 12);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(71, 26);
            this.btn_Search.TabIndex = 1;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 70;
            this.label1.Text = "Search For :";
            // 
            // txtB_ProductSearch
            // 
            this.txtB_ProductSearch.Location = new System.Drawing.Point(187, 16);
            this.txtB_ProductSearch.Name = "txtB_ProductSearch";
            this.txtB_ProductSearch.Size = new System.Drawing.Size(272, 20);
            this.txtB_ProductSearch.TabIndex = 0;
            // 
            // dataGridView_Products
            // 
            this.dataGridView_Products.AllowUserToAddRows = false;
            this.dataGridView_Products.AllowUserToDeleteRows = false;
            this.dataGridView_Products.AllowUserToResizeRows = false;
            this.dataGridView_Products.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Products.Location = new System.Drawing.Point(-4, 49);
            this.dataGridView_Products.MultiSelect = false;
            this.dataGridView_Products.Name = "dataGridView_Products";
            this.dataGridView_Products.ReadOnly = true;
            this.dataGridView_Products.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Products.Size = new System.Drawing.Size(647, 307);
            this.dataGridView_Products.TabIndex = 2;
            this.dataGridView_Products.DoubleClick += new System.EventHandler(this.dataGridView_Products_DoubleClick);
            // 
            // frm_AllProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 353);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtB_ProductSearch);
            this.Controls.Add(this.dataGridView_Products);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_AllProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Products";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Products)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtB_ProductSearch;
        public System.Windows.Forms.DataGridView dataGridView_Products;
    }
}