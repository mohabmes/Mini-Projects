namespace Sales_Management.PL
{
    partial class frm_ImagePreview
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
            this.PictureB_ProductImage2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureB_ProductImage2)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureB_ProductImage2
            // 
            this.PictureB_ProductImage2.Location = new System.Drawing.Point(13, 13);
            this.PictureB_ProductImage2.Name = "PictureB_ProductImage2";
            this.PictureB_ProductImage2.Size = new System.Drawing.Size(565, 417);
            this.PictureB_ProductImage2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureB_ProductImage2.TabIndex = 0;
            this.PictureB_ProductImage2.TabStop = false;
            // 
            // frm_ImagePreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 442);
            this.Controls.Add(this.PictureB_ProductImage2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_ImagePreview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Image";
            ((System.ComponentModel.ISupportInitialize)(this.PictureB_ProductImage2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox PictureB_ProductImage2;

    }
}