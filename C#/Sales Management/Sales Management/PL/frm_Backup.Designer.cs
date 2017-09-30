namespace Sales_Management.PL
{
    partial class frm_Backup
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
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Create = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtb_FilePath = new System.Windows.Forms.TextBox();
            this.btn_browse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Note :  Disconnect The Database During The Operation";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(341, 148);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(160, 30);
            this.btn_Cancel.TabIndex = 4;
            this.btn_Cancel.Text = "Close";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Create
            // 
            this.btn_Create.Location = new System.Drawing.Point(341, 104);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(160, 30);
            this.btn_Create.TabIndex = 3;
            this.btn_Create.Text = "Create Backup";
            this.btn_Create.UseVisualStyleBackColor = true;
            this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Select Path For Backup file :";
            // 
            // txtb_FilePath
            // 
            this.txtb_FilePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtb_FilePath.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_FilePath.Location = new System.Drawing.Point(33, 61);
            this.txtb_FilePath.Name = "txtb_FilePath";
            this.txtb_FilePath.ReadOnly = true;
            this.txtb_FilePath.Size = new System.Drawing.Size(402, 23);
            this.txtb_FilePath.TabIndex = 7;
            // 
            // btn_browse
            // 
            this.btn_browse.Location = new System.Drawing.Point(439, 61);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(62, 23);
            this.btn_browse.TabIndex = 8;
            this.btn_browse.Text = "....";
            this.btn_browse.UseVisualStyleBackColor = true;
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // frm_Backup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 218);
            this.Controls.Add(this.btn_browse);
            this.Controls.Add(this.txtb_FilePath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Create);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frm_Backup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Backup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Create;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtb_FilePath;
        private System.Windows.Forms.Button btn_browse;
    }
}