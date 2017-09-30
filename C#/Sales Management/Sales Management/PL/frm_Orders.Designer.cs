namespace Sales_Management.PL
{
    partial class frm_Orders
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
            this.dgv_Orders = new System.Windows.Forms.DataGridView();
            this.txtb_search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_PrintOrder = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_AddOrder = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Orders)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_Orders);
            this.groupBox1.Location = new System.Drawing.Point(18, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(874, 404);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Orders";
            // 
            // dgv_Orders
            // 
            this.dgv_Orders.AllowUserToAddRows = false;
            this.dgv_Orders.AllowUserToDeleteRows = false;
            this.dgv_Orders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Orders.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_Orders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Orders.Location = new System.Drawing.Point(7, 19);
            this.dgv_Orders.MultiSelect = false;
            this.dgv_Orders.Name = "dgv_Orders";
            this.dgv_Orders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Orders.Size = new System.Drawing.Size(861, 370);
            this.dgv_Orders.TabIndex = 0;
            // 
            // txtb_search
            // 
            this.txtb_search.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_search.Location = new System.Drawing.Point(316, 22);
            this.txtb_search.Name = "txtb_search";
            this.txtb_search.Size = new System.Drawing.Size(335, 26);
            this.txtb_search.TabIndex = 5;
            this.txtb_search.TextChanged += new System.EventHandler(this.txtb_search_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(217, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Search For : ";
            // 
            // btn_PrintOrder
            // 
            this.btn_PrintOrder.Location = new System.Drawing.Point(316, 478);
            this.btn_PrintOrder.Name = "btn_PrintOrder";
            this.btn_PrintOrder.Size = new System.Drawing.Size(143, 23);
            this.btn_PrintOrder.TabIndex = 13;
            this.btn_PrintOrder.Text = "Report";
            this.btn_PrintOrder.UseVisualStyleBackColor = true;
            this.btn_PrintOrder.Click += new System.EventHandler(this.btn_PrintOrder_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(614, 477);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(143, 23);
            this.btn_Cancel.TabIndex = 12;
            this.btn_Cancel.Text = "Close";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_AddOrder
            // 
            this.btn_AddOrder.Location = new System.Drawing.Point(167, 478);
            this.btn_AddOrder.Name = "btn_AddOrder";
            this.btn_AddOrder.Size = new System.Drawing.Size(143, 23);
            this.btn_AddOrder.TabIndex = 11;
            this.btn_AddOrder.Text = "Add Order";
            this.btn_AddOrder.UseVisualStyleBackColor = true;
            this.btn_AddOrder.Click += new System.EventHandler(this.btn_AddOrder_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(788, 22);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(107, 26);
            this.btn_refresh.TabIndex = 14;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(465, 477);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "View Details";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 513);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_PrintOrder);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_AddOrder);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtb_search);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "frm_Orders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orders Management";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Orders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.DataGridView dgv_Orders;
        private System.Windows.Forms.TextBox txtb_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_PrintOrder;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_AddOrder;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button button1;
    }
}