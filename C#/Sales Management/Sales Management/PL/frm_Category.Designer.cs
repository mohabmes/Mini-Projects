namespace Sales_Management.PL
{
    partial class frm_Category
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
            this.components = new System.ComponentModel.Container();
            this.dataGridV_Category = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbl_Position = new System.Windows.Forms.Label();
            this.btn_Last = new System.Windows.Forms.Button();
            this.btn_Next = new System.Windows.Forms.Button();
            this.btn_Previous = new System.Windows.Forms.Button();
            this.btn_First = new System.Windows.Forms.Button();
            this.txtb_Description = new System.Windows.Forms.TextBox();
            this.txtb_IDCategory = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btn_AllCategoriesReport = new System.Windows.Forms.Button();
            this.btn_New = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_CategoryReport = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridV_Category)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridV_Category
            // 
            this.dataGridV_Category.AllowUserToAddRows = false;
            this.dataGridV_Category.AllowUserToDeleteRows = false;
            this.dataGridV_Category.AllowUserToResizeRows = false;
            this.dataGridV_Category.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridV_Category.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridV_Category.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridV_Category.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridV_Category.Location = new System.Drawing.Point(350, 19);
            this.dataGridV_Category.Name = "dataGridV_Category";
            this.dataGridV_Category.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridV_Category.Size = new System.Drawing.Size(406, 200);
            this.dataGridV_Category.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridV_Category);
            this.groupBox4.Controls.Add(this.lbl_Position);
            this.groupBox4.Controls.Add(this.btn_Last);
            this.groupBox4.Controls.Add(this.btn_Next);
            this.groupBox4.Controls.Add(this.btn_Previous);
            this.groupBox4.Controls.Add(this.btn_First);
            this.groupBox4.Controls.Add(this.txtb_Description);
            this.groupBox4.Controls.Add(this.txtb_IDCategory);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(13, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(769, 225);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Category";
            // 
            // lbl_Position
            // 
            this.lbl_Position.AutoSize = true;
            this.lbl_Position.Location = new System.Drawing.Point(162, 141);
            this.lbl_Position.Name = "lbl_Position";
            this.lbl_Position.Size = new System.Drawing.Size(24, 13);
            this.lbl_Position.TabIndex = 8;
            this.lbl_Position.Text = "Pos";
            // 
            // btn_Last
            // 
            this.btn_Last.Location = new System.Drawing.Point(260, 136);
            this.btn_Last.Name = "btn_Last";
            this.btn_Last.Size = new System.Drawing.Size(62, 23);
            this.btn_Last.TabIndex = 7;
            this.btn_Last.Text = ">>||";
            this.btn_Last.UseVisualStyleBackColor = true;
            this.btn_Last.Click += new System.EventHandler(this.btn_Last_Click);
            // 
            // btn_Next
            // 
            this.btn_Next.Location = new System.Drawing.Point(192, 136);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(62, 23);
            this.btn_Next.TabIndex = 6;
            this.btn_Next.Text = ">>";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // btn_Previous
            // 
            this.btn_Previous.Location = new System.Drawing.Point(94, 136);
            this.btn_Previous.Name = "btn_Previous";
            this.btn_Previous.Size = new System.Drawing.Size(62, 23);
            this.btn_Previous.TabIndex = 5;
            this.btn_Previous.Text = "<<";
            this.btn_Previous.UseVisualStyleBackColor = true;
            this.btn_Previous.Click += new System.EventHandler(this.btn_Previous_Click);
            // 
            // btn_First
            // 
            this.btn_First.Location = new System.Drawing.Point(21, 136);
            this.btn_First.Name = "btn_First";
            this.btn_First.Size = new System.Drawing.Size(62, 23);
            this.btn_First.TabIndex = 4;
            this.btn_First.Text = "||<<";
            this.btn_First.UseVisualStyleBackColor = true;
            this.btn_First.Click += new System.EventHandler(this.btn_First_Click);
            // 
            // txtb_Description
            // 
            this.txtb_Description.Location = new System.Drawing.Point(93, 92);
            this.txtb_Description.Name = "txtb_Description";
            this.txtb_Description.Size = new System.Drawing.Size(229, 20);
            this.txtb_Description.TabIndex = 3;
            // 
            // txtb_IDCategory
            // 
            this.txtb_IDCategory.Location = new System.Drawing.Point(93, 57);
            this.txtb_IDCategory.Name = "txtb_IDCategory";
            this.txtb_IDCategory.ReadOnly = true;
            this.txtb_IDCategory.Size = new System.Drawing.Size(229, 20);
            this.txtb_IDCategory.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description  : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID  : ";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btn_AllCategoriesReport);
            this.groupBox5.Controls.Add(this.btn_New);
            this.groupBox5.Controls.Add(this.btn_Cancel);
            this.groupBox5.Controls.Add(this.btn_CategoryReport);
            this.groupBox5.Controls.Add(this.btn_Add);
            this.groupBox5.Controls.Add(this.btn_Update);
            this.groupBox5.Controls.Add(this.btn_Delete);
            this.groupBox5.Location = new System.Drawing.Point(13, 244);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(769, 86);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Operation";
            // 
            // btn_AllCategoriesReport
            // 
            this.btn_AllCategoriesReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_AllCategoriesReport.Location = new System.Drawing.Point(308, 48);
            this.btn_AllCategoriesReport.Name = "btn_AllCategoriesReport";
            this.btn_AllCategoriesReport.Size = new System.Drawing.Size(179, 23);
            this.btn_AllCategoriesReport.TabIndex = 8;
            this.btn_AllCategoriesReport.Text = "All Categories Report";
            this.btn_AllCategoriesReport.UseVisualStyleBackColor = true;
            this.btn_AllCategoriesReport.Click += new System.EventHandler(this.btn_AllCategoriesReport_Click);
            // 
            // btn_New
            // 
            this.btn_New.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_New.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_New.Location = new System.Drawing.Point(21, 19);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(179, 23);
            this.btn_New.TabIndex = 4;
            this.btn_New.Text = "New";
            this.btn_New.UseVisualStyleBackColor = true;
            this.btn_New.Click += new System.EventHandler(this.btn_New_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Cancel.Location = new System.Drawing.Point(493, 48);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(179, 23);
            this.btn_Cancel.TabIndex = 8;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_CategoryReport
            // 
            this.btn_CategoryReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_CategoryReport.Location = new System.Drawing.Point(123, 48);
            this.btn_CategoryReport.Name = "btn_CategoryReport";
            this.btn_CategoryReport.Size = new System.Drawing.Size(179, 23);
            this.btn_CategoryReport.TabIndex = 9;
            this.btn_CategoryReport.Text = "Category Report";
            this.btn_CategoryReport.UseVisualStyleBackColor = true;
            this.btn_CategoryReport.Click += new System.EventHandler(this.btn_CategoryReport_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Add.Location = new System.Drawing.Point(206, 19);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(179, 23);
            this.btn_Add.TabIndex = 0;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Update.Location = new System.Drawing.Point(391, 19);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(179, 23);
            this.btn_Update.TabIndex = 3;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Delete.Location = new System.Drawing.Point(576, 19);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(179, 23);
            this.btn_Delete.TabIndex = 1;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // frm_Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 340);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Category";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Categories";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridV_Category)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridV_Category;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lbl_Position;
        private System.Windows.Forms.Button btn_Last;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.Button btn_Previous;
        private System.Windows.Forms.Button btn_First;
        private System.Windows.Forms.TextBox txtb_Description;
        private System.Windows.Forms.TextBox txtb_IDCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btn_AllCategoriesReport;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_CategoryReport;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_New;
        private System.Windows.Forms.ImageList imageList1;
    }
}