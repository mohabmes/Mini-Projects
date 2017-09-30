namespace Sales_Management.PL
{
    partial class frm_Users
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
            this.btn_DeleteUser = new System.Windows.Forms.Button();
            this.btn_PrintOrder = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_AddOrder = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_User = new System.Windows.Forms.DataGridView();
            this.txtb_search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_User)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_DeleteUser
            // 
            this.btn_DeleteUser.Location = new System.Drawing.Point(436, 403);
            this.btn_DeleteUser.Name = "btn_DeleteUser";
            this.btn_DeleteUser.Size = new System.Drawing.Size(143, 23);
            this.btn_DeleteUser.TabIndex = 23;
            this.btn_DeleteUser.Text = "Delete";
            this.btn_DeleteUser.UseVisualStyleBackColor = true;
            this.btn_DeleteUser.Click += new System.EventHandler(this.btn_DeleteUser_Click);
            // 
            // btn_PrintOrder
            // 
            this.btn_PrintOrder.Location = new System.Drawing.Point(287, 403);
            this.btn_PrintOrder.Name = "btn_PrintOrder";
            this.btn_PrintOrder.Size = new System.Drawing.Size(143, 23);
            this.btn_PrintOrder.TabIndex = 21;
            this.btn_PrintOrder.Text = "Edit";
            this.btn_PrintOrder.UseVisualStyleBackColor = true;
            this.btn_PrintOrder.Click += new System.EventHandler(this.btn_PrintOrder_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(585, 403);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(143, 23);
            this.btn_Cancel.TabIndex = 20;
            this.btn_Cancel.Text = "Close";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_AddOrder
            // 
            this.btn_AddOrder.Location = new System.Drawing.Point(138, 403);
            this.btn_AddOrder.Name = "btn_AddOrder";
            this.btn_AddOrder.Size = new System.Drawing.Size(143, 23);
            this.btn_AddOrder.TabIndex = 19;
            this.btn_AddOrder.Text = "Add User";
            this.btn_AddOrder.UseVisualStyleBackColor = true;
            this.btn_AddOrder.Click += new System.EventHandler(this.btn_AddOrder_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_User);
            this.groupBox1.Location = new System.Drawing.Point(14, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(839, 345);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Orders";
            // 
            // dgv_User
            // 
            this.dgv_User.AllowUserToAddRows = false;
            this.dgv_User.AllowUserToDeleteRows = false;
            this.dgv_User.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_User.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_User.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_User.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_User.Location = new System.Drawing.Point(7, 19);
            this.dgv_User.MultiSelect = false;
            this.dgv_User.Name = "dgv_User";
            this.dgv_User.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_User.Size = new System.Drawing.Size(827, 320);
            this.dgv_User.TabIndex = 0;
            // 
            // txtb_search
            // 
            this.txtb_search.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_search.Location = new System.Drawing.Point(287, 12);
            this.txtb_search.Name = "txtb_search";
            this.txtb_search.Size = new System.Drawing.Size(335, 26);
            this.txtb_search.TabIndex = 16;
            this.txtb_search.TextChanged += new System.EventHandler(this.txtb_search_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(188, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 18);
            this.label1.TabIndex = 17;
            this.label1.Text = "Search For : ";
            // 
            // frm_Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 438);
            this.Controls.Add(this.btn_DeleteUser);
            this.Controls.Add(this.btn_PrintOrder);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_AddOrder);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtb_search);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Users";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Users";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_User)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_DeleteUser;
        private System.Windows.Forms.Button btn_PrintOrder;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_AddOrder;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.DataGridView dgv_User;
        private System.Windows.Forms.TextBox txtb_search;
        private System.Windows.Forms.Label label1;
    }
}