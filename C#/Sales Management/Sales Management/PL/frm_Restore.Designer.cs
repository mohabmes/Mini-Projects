namespace Sales_Management.PL
{
    partial class frm_Restore
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
            this.btn_browse = new System.Windows.Forms.Button();
            this.txtb_FilePath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Restore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_browse
            // 
            this.btn_browse.Location = new System.Drawing.Point(439, 58);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(62, 23);
            this.btn_browse.TabIndex = 13;
            this.btn_browse.Text = "....";
            this.btn_browse.UseVisualStyleBackColor = true;
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // txtb_FilePath
            // 
            this.txtb_FilePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtb_FilePath.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_FilePath.Location = new System.Drawing.Point(33, 58);
            this.txtb_FilePath.Name = "txtb_FilePath";
            this.txtb_FilePath.ReadOnly = true;
            this.txtb_FilePath.Size = new System.Drawing.Size(402, 23);
            this.txtb_FilePath.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Select Path For Backup file :";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(341, 159);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(160, 30);
            this.btn_Cancel.TabIndex = 10;
            this.btn_Cancel.Text = "Close";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Restore
            // 
            this.btn_Restore.Location = new System.Drawing.Point(341, 115);
            this.btn_Restore.Name = "btn_Restore";
            this.btn_Restore.Size = new System.Drawing.Size(160, 30);
            this.btn_Restore.TabIndex = 9;
            this.btn_Restore.Text = "Restore Backup";
            this.btn_Restore.UseVisualStyleBackColor = true;
            this.btn_Restore.Click += new System.EventHandler(this.btn_Restore_Click);
            // 
            // frm_Restore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 218);
            this.Controls.Add(this.btn_browse);
            this.Controls.Add(this.txtb_FilePath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Restore);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Restore";
            this.Opacity = 0.8D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restore";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_browse;
        private System.Windows.Forms.TextBox txtb_FilePath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Restore;
    }
}