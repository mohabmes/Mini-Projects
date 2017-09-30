namespace Sales_Management.PL
{
    partial class frm_AddUser
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
            this.cmbb_UserType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtb_ReEnterPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtb_EnterPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtb_Username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtb_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbb_UserType);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtb_ReEnterPassword);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtb_EnterPassword);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtb_Username);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtb_ID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 236);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New User";
            // 
            // cmbb_UserType
            // 
            this.cmbb_UserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbb_UserType.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbb_UserType.FormattingEnabled = true;
            this.cmbb_UserType.Items.AddRange(new object[] {
            "Admin",
            "Normal"});
            this.cmbb_UserType.Location = new System.Drawing.Point(160, 184);
            this.cmbb_UserType.Name = "cmbb_UserType";
            this.cmbb_UserType.Size = new System.Drawing.Size(268, 24);
            this.cmbb_UserType.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 38;
            this.label5.Text = "User Type  :";
            // 
            // txtb_ReEnterPassword
            // 
            this.txtb_ReEnterPassword.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_ReEnterPassword.Location = new System.Drawing.Point(160, 143);
            this.txtb_ReEnterPassword.Name = "txtb_ReEnterPassword";
            this.txtb_ReEnterPassword.PasswordChar = '*';
            this.txtb_ReEnterPassword.Size = new System.Drawing.Size(268, 23);
            this.txtb_ReEnterPassword.TabIndex = 3;
            this.txtb_ReEnterPassword.Validated += new System.EventHandler(this.txtb_ReEnterPassword_Validated);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 16);
            this.label4.TabIndex = 36;
            this.label4.Text = "Re-enter Password  :";
            // 
            // txtb_EnterPassword
            // 
            this.txtb_EnterPassword.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_EnterPassword.Location = new System.Drawing.Point(160, 108);
            this.txtb_EnterPassword.Name = "txtb_EnterPassword";
            this.txtb_EnterPassword.PasswordChar = '*';
            this.txtb_EnterPassword.Size = new System.Drawing.Size(268, 23);
            this.txtb_EnterPassword.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 16);
            this.label3.TabIndex = 34;
            this.label3.Text = "Enter Password  :";
            // 
            // txtb_Username
            // 
            this.txtb_Username.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_Username.Location = new System.Drawing.Point(160, 64);
            this.txtb_Username.Name = "txtb_Username";
            this.txtb_Username.Size = new System.Drawing.Size(268, 23);
            this.txtb_Username.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 32;
            this.label2.Text = "Username  :";
            // 
            // txtb_ID
            // 
            this.txtb_ID.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_ID.Location = new System.Drawing.Point(160, 28);
            this.txtb_ID.Name = "txtb_ID";
            this.txtb_ID.Size = new System.Drawing.Size(268, 23);
            this.txtb_ID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 30;
            this.label1.Text = "ID  :";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Location = new System.Drawing.Point(313, 278);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(129, 27);
            this.btn_cancel.TabIndex = 2;
            this.btn_cancel.Text = "Close";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(43, 278);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(129, 27);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(178, 278);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(129, 27);
            this.btn_clear.TabIndex = 1;
            this.btn_clear.Text = "New";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // frm_AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 343);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_add);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_AddUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add User";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cmbb_UserType;
        public System.Windows.Forms.TextBox txtb_ReEnterPassword;
        public System.Windows.Forms.TextBox txtb_EnterPassword;
        public System.Windows.Forms.TextBox txtb_Username;
        public System.Windows.Forms.TextBox txtb_ID;
        public System.Windows.Forms.Button btn_cancel;
        public System.Windows.Forms.Button btn_add;
        public System.Windows.Forms.Button btn_clear;

    }
}