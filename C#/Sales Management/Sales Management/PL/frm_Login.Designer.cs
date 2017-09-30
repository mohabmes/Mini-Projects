namespace Sales_Management.PL
{
    partial class frm_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Login));
            this.btn_Login = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtb_ID = new System.Windows.Forms.TextBox();
            this.txtb_Pwd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Login
            // 
            this.btn_Login.CausesValidation = false;
            this.btn_Login.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Login.ImageIndex = 6;
            this.btn_Login.ImageList = this.imageList1;
            this.btn_Login.Location = new System.Drawing.Point(368, 109);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(100, 39);
            this.btn_Login.TabIndex = 2;
            this.btn_Login.Text = "Login";
            this.btn_Login.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Cancel.png");
            this.imageList1.Images.SetKeyName(1, "Checked.png");
            this.imageList1.Images.SetKeyName(2, "Checkmark.png");
            this.imageList1.Images.SetKeyName(3, "About.png");
            this.imageList1.Images.SetKeyName(4, "Attention.png");
            this.imageList1.Images.SetKeyName(5, "Cancel 2.png");
            this.imageList1.Images.SetKeyName(6, "Checked 2.png");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID  :";
            // 
            // txtb_ID
            // 
            this.txtb_ID.Location = new System.Drawing.Point(110, 32);
            this.txtb_ID.Name = "txtb_ID";
            this.txtb_ID.Size = new System.Drawing.Size(358, 20);
            this.txtb_ID.TabIndex = 0;
            this.txtb_ID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtb_ID_KeyDown);
            // 
            // txtb_Pwd
            // 
            this.txtb_Pwd.Location = new System.Drawing.Point(110, 67);
            this.txtb_Pwd.Name = "txtb_Pwd";
            this.txtb_Pwd.PasswordChar = '*';
            this.txtb_Pwd.Size = new System.Drawing.Size(358, 20);
            this.txtb_Pwd.TabIndex = 1;
            this.txtb_Pwd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtb_Pwd_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password   :";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Cancel.ImageIndex = 0;
            this.btn_Cancel.ImageList = this.imageList1;
            this.btn_Cancel.Location = new System.Drawing.Point(262, 109);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(100, 39);
            this.btn_Cancel.TabIndex = 3;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 176);
            this.ControlBox = false;
            this.Controls.Add(this.txtb_Pwd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.txtb_ID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtb_ID;
        private System.Windows.Forms.TextBox txtb_Pwd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.ImageList imageList1;
    }
}