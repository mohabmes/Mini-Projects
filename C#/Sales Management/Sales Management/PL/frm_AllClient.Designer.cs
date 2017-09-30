namespace Sales_Management.PL
{
    partial class frm_AllClient
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
            this.txtB_ClientSearch = new System.Windows.Forms.TextBox();
            this.dataGridView_Clients = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Clients)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(484, 16);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(71, 26);
            this.btn_Search.TabIndex = 67;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 66;
            this.label1.Text = "Search For :";
            // 
            // txtB_ClientSearch
            // 
            this.txtB_ClientSearch.Location = new System.Drawing.Point(194, 20);
            this.txtB_ClientSearch.Name = "txtB_ClientSearch";
            this.txtB_ClientSearch.Size = new System.Drawing.Size(272, 20);
            this.txtB_ClientSearch.TabIndex = 65;
            // 
            // dataGridView_Clients
            // 
            this.dataGridView_Clients.AllowUserToAddRows = false;
            this.dataGridView_Clients.AllowUserToDeleteRows = false;
            this.dataGridView_Clients.AllowUserToResizeRows = false;
            this.dataGridView_Clients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Clients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Clients.Location = new System.Drawing.Point(0, 70);
            this.dataGridView_Clients.MultiSelect = false;
            this.dataGridView_Clients.Name = "dataGridView_Clients";
            this.dataGridView_Clients.ReadOnly = true;
            this.dataGridView_Clients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Clients.Size = new System.Drawing.Size(638, 282);
            this.dataGridView_Clients.TabIndex = 64;
            this.dataGridView_Clients.DoubleClick += new System.EventHandler(this.dataGridView_Clients_DoubleClick);
            // 
            // frm_AllClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 353);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtB_ClientSearch);
            this.Controls.Add(this.dataGridView_Clients);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_AllClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Clients";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Clients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtB_ClientSearch;
        public System.Windows.Forms.DataGridView dataGridView_Clients;
    }
}