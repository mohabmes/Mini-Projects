namespace Sales_Management.PL
{
    partial class frm_AddOrder
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
            this.groupB_ClientData = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_SelectClient = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtB_SName = new System.Windows.Forms.TextBox();
            this.txtb_Email = new System.Windows.Forms.TextBox();
            this.txtB_ID = new System.Windows.Forms.TextBox();
            this.txtb_FName = new System.Windows.Forms.TextBox();
            this.txtb_PhoneNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureB_ClientImage = new System.Windows.Forms.PictureBox();
            this.groupB_OrderData = new System.Windows.Forms.GroupBox();
            this.dateTime_OrderDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtB_OrderNo = new System.Windows.Forms.TextBox();
            this.txtB_OrderDescription = new System.Windows.Forms.TextBox();
            this.txtB_Username = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupB_Product = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtb_ProductTotal = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtb_ProductDiscount = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtb_ProductAmount = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtb_ProductQuantity = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtb_ProductPrice = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtb_ProductName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtb_ProductID = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_Total = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_SelectProduct = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Print = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_New = new System.Windows.Forms.Button();
            this.groupB_ClientData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureB_ClientImage)).BeginInit();
            this.groupB_OrderData.SuspendLayout();
            this.groupB_Product.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupB_ClientData
            // 
            this.groupB_ClientData.Controls.Add(this.label5);
            this.groupB_ClientData.Controls.Add(this.btn_SelectClient);
            this.groupB_ClientData.Controls.Add(this.label4);
            this.groupB_ClientData.Controls.Add(this.label3);
            this.groupB_ClientData.Controls.Add(this.txtB_SName);
            this.groupB_ClientData.Controls.Add(this.txtb_Email);
            this.groupB_ClientData.Controls.Add(this.txtB_ID);
            this.groupB_ClientData.Controls.Add(this.txtb_FName);
            this.groupB_ClientData.Controls.Add(this.txtb_PhoneNo);
            this.groupB_ClientData.Controls.Add(this.label6);
            this.groupB_ClientData.Controls.Add(this.label2);
            this.groupB_ClientData.Controls.Add(this.pictureB_ClientImage);
            this.groupB_ClientData.Location = new System.Drawing.Point(492, 12);
            this.groupB_ClientData.Name = "groupB_ClientData";
            this.groupB_ClientData.Size = new System.Drawing.Size(470, 185);
            this.groupB_ClientData.TabIndex = 1;
            this.groupB_ClientData.TabStop = false;
            this.groupB_ClientData.Text = "Client Data";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 84;
            this.label5.Text = "ID  :";
            // 
            // btn_SelectClient
            // 
            this.btn_SelectClient.Location = new System.Drawing.Point(257, 23);
            this.btn_SelectClient.Name = "btn_SelectClient";
            this.btn_SelectClient.Size = new System.Drawing.Size(48, 23);
            this.btn_SelectClient.TabIndex = 0;
            this.btn_SelectClient.Text = "...";
            this.btn_SelectClient.UseVisualStyleBackColor = true;
            this.btn_SelectClient.Click += new System.EventHandler(this.btn_SelectClient_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 81;
            this.label4.Text = "Second Name  :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 82;
            this.label3.Text = "Phone No.  :";
            // 
            // txtB_SName
            // 
            this.txtB_SName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtB_SName.Location = new System.Drawing.Point(103, 80);
            this.txtB_SName.Name = "txtB_SName";
            this.txtB_SName.ReadOnly = true;
            this.txtB_SName.Size = new System.Drawing.Size(201, 20);
            this.txtB_SName.TabIndex = 3;
            // 
            // txtb_Email
            // 
            this.txtb_Email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtb_Email.Location = new System.Drawing.Point(103, 140);
            this.txtb_Email.Name = "txtb_Email";
            this.txtb_Email.ReadOnly = true;
            this.txtb_Email.Size = new System.Drawing.Size(201, 20);
            this.txtb_Email.TabIndex = 5;
            // 
            // txtB_ID
            // 
            this.txtB_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtB_ID.Location = new System.Drawing.Point(103, 25);
            this.txtB_ID.Name = "txtB_ID";
            this.txtB_ID.ReadOnly = true;
            this.txtB_ID.Size = new System.Drawing.Size(148, 20);
            this.txtB_ID.TabIndex = 1;
            // 
            // txtb_FName
            // 
            this.txtb_FName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtb_FName.Location = new System.Drawing.Point(103, 52);
            this.txtb_FName.Name = "txtb_FName";
            this.txtb_FName.ReadOnly = true;
            this.txtb_FName.Size = new System.Drawing.Size(201, 20);
            this.txtb_FName.TabIndex = 2;
            // 
            // txtb_PhoneNo
            // 
            this.txtb_PhoneNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtb_PhoneNo.Location = new System.Drawing.Point(103, 109);
            this.txtb_PhoneNo.Name = "txtb_PhoneNo";
            this.txtb_PhoneNo.ReadOnly = true;
            this.txtb_PhoneNo.Size = new System.Drawing.Size(201, 20);
            this.txtb_PhoneNo.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 83;
            this.label6.Text = "E-Mail  :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(17, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 80;
            this.label2.Text = "First Name  :";
            // 
            // pictureB_ClientImage
            // 
            this.pictureB_ClientImage.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pictureB_ClientImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureB_ClientImage.Image = global::Sales_Management.Properties.Resources.Contacts;
            this.pictureB_ClientImage.InitialImage = global::Sales_Management.Properties.Resources.Contacts;
            this.pictureB_ClientImage.Location = new System.Drawing.Point(310, 25);
            this.pictureB_ClientImage.Name = "pictureB_ClientImage";
            this.pictureB_ClientImage.Size = new System.Drawing.Size(128, 135);
            this.pictureB_ClientImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureB_ClientImage.TabIndex = 85;
            this.pictureB_ClientImage.TabStop = false;
            // 
            // groupB_OrderData
            // 
            this.groupB_OrderData.Controls.Add(this.dateTime_OrderDate);
            this.groupB_OrderData.Controls.Add(this.label1);
            this.groupB_OrderData.Controls.Add(this.label7);
            this.groupB_OrderData.Controls.Add(this.label8);
            this.groupB_OrderData.Controls.Add(this.txtB_OrderNo);
            this.groupB_OrderData.Controls.Add(this.txtB_OrderDescription);
            this.groupB_OrderData.Controls.Add(this.txtB_Username);
            this.groupB_OrderData.Controls.Add(this.label9);
            this.groupB_OrderData.Location = new System.Drawing.Point(13, 12);
            this.groupB_OrderData.Name = "groupB_OrderData";
            this.groupB_OrderData.Size = new System.Drawing.Size(470, 185);
            this.groupB_OrderData.TabIndex = 0;
            this.groupB_OrderData.TabStop = false;
            this.groupB_OrderData.Text = "Order Data";
            // 
            // dateTime_OrderDate
            // 
            this.dateTime_OrderDate.Location = new System.Drawing.Point(112, 109);
            this.dateTime_OrderDate.Name = "dateTime_OrderDate";
            this.dateTime_OrderDate.Size = new System.Drawing.Size(340, 20);
            this.dateTime_OrderDate.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 92;
            this.label1.Text = "Order No.  :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 90;
            this.label7.Text = "Date  :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 91;
            this.label8.Text = "Username  :";
            // 
            // txtB_OrderNo
            // 
            this.txtB_OrderNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtB_OrderNo.Location = new System.Drawing.Point(111, 25);
            this.txtB_OrderNo.Name = "txtB_OrderNo";
            this.txtB_OrderNo.ReadOnly = true;
            this.txtB_OrderNo.Size = new System.Drawing.Size(288, 20);
            this.txtB_OrderNo.TabIndex = 2;
            // 
            // txtB_OrderDescription
            // 
            this.txtB_OrderDescription.Location = new System.Drawing.Point(111, 52);
            this.txtB_OrderDescription.Multiline = true;
            this.txtB_OrderDescription.Name = "txtB_OrderDescription";
            this.txtB_OrderDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtB_OrderDescription.Size = new System.Drawing.Size(341, 44);
            this.txtB_OrderDescription.TabIndex = 0;
            // 
            // txtB_Username
            // 
            this.txtB_Username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtB_Username.Location = new System.Drawing.Point(111, 138);
            this.txtB_Username.Name = "txtB_Username";
            this.txtB_Username.ReadOnly = true;
            this.txtB_Username.Size = new System.Drawing.Size(341, 20);
            this.txtB_Username.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(25, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 89;
            this.label9.Text = "Description  :";
            // 
            // groupB_Product
            // 
            this.groupB_Product.Controls.Add(this.label18);
            this.groupB_Product.Controls.Add(this.txtb_ProductTotal);
            this.groupB_Product.Controls.Add(this.label17);
            this.groupB_Product.Controls.Add(this.txtb_ProductDiscount);
            this.groupB_Product.Controls.Add(this.label16);
            this.groupB_Product.Controls.Add(this.txtb_ProductAmount);
            this.groupB_Product.Controls.Add(this.label15);
            this.groupB_Product.Controls.Add(this.txtb_ProductQuantity);
            this.groupB_Product.Controls.Add(this.label14);
            this.groupB_Product.Controls.Add(this.txtb_ProductPrice);
            this.groupB_Product.Controls.Add(this.label13);
            this.groupB_Product.Controls.Add(this.txtb_ProductName);
            this.groupB_Product.Controls.Add(this.label12);
            this.groupB_Product.Controls.Add(this.txtb_ProductID);
            this.groupB_Product.Controls.Add(this.label11);
            this.groupB_Product.Controls.Add(this.txt_Total);
            this.groupB_Product.Controls.Add(this.label10);
            this.groupB_Product.Controls.Add(this.button1);
            this.groupB_Product.Controls.Add(this.dataGridView1);
            this.groupB_Product.Controls.Add(this.btn_SelectProduct);
            this.groupB_Product.Location = new System.Drawing.Point(13, 203);
            this.groupB_Product.Name = "groupB_Product";
            this.groupB_Product.Size = new System.Drawing.Size(949, 264);
            this.groupB_Product.TabIndex = 2;
            this.groupB_Product.TabStop = false;
            this.groupB_Product.Text = "Products";
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label18.Location = new System.Drawing.Point(14, 26);
            this.label18.Name = "label18";
            this.label18.Padding = new System.Windows.Forms.Padding(7, 4, 4, 4);
            this.label18.Size = new System.Drawing.Size(82, 23);
            this.label18.TabIndex = 109;
            this.label18.Text = "Select Prod";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtb_ProductTotal
            // 
            this.txtb_ProductTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtb_ProductTotal.Location = new System.Drawing.Point(836, 48);
            this.txtb_ProductTotal.MaxLength = 7;
            this.txtb_ProductTotal.Name = "txtb_ProductTotal";
            this.txtb_ProductTotal.ReadOnly = true;
            this.txtb_ProductTotal.Size = new System.Drawing.Size(105, 20);
            this.txtb_ProductTotal.TabIndex = 7;
            this.txtb_ProductTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtb_ProductTotal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtb_ProductTotal_KeyDown);
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label17.Location = new System.Drawing.Point(836, 26);
            this.label17.Name = "label17";
            this.label17.Padding = new System.Windows.Forms.Padding(7, 4, 4, 4);
            this.label17.Size = new System.Drawing.Size(105, 23);
            this.label17.TabIndex = 107;
            this.label17.Text = "Total Amount";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtb_ProductDiscount
            // 
            this.txtb_ProductDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtb_ProductDiscount.Location = new System.Drawing.Point(734, 48);
            this.txtb_ProductDiscount.MaxLength = 7;
            this.txtb_ProductDiscount.Name = "txtb_ProductDiscount";
            this.txtb_ProductDiscount.Size = new System.Drawing.Size(105, 20);
            this.txtb_ProductDiscount.TabIndex = 6;
            this.txtb_ProductDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtb_ProductDiscount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtb_ProductDiscount_KeyDown);
            this.txtb_ProductDiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtb_ProductDiscount_KeyPress);
            this.txtb_ProductDiscount.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtb_ProductDiscount_KeyUp);
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label16.Location = new System.Drawing.Point(734, 26);
            this.label16.Name = "label16";
            this.label16.Padding = new System.Windows.Forms.Padding(7, 4, 4, 4);
            this.label16.Size = new System.Drawing.Size(105, 23);
            this.label16.TabIndex = 105;
            this.label16.Text = "Discount (%)";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtb_ProductAmount
            // 
            this.txtb_ProductAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtb_ProductAmount.Location = new System.Drawing.Point(633, 48);
            this.txtb_ProductAmount.MaxLength = 7;
            this.txtb_ProductAmount.Name = "txtb_ProductAmount";
            this.txtb_ProductAmount.ReadOnly = true;
            this.txtb_ProductAmount.Size = new System.Drawing.Size(105, 20);
            this.txtb_ProductAmount.TabIndex = 5;
            this.txtb_ProductAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label15.Location = new System.Drawing.Point(633, 26);
            this.label15.Name = "label15";
            this.label15.Padding = new System.Windows.Forms.Padding(7, 4, 4, 4);
            this.label15.Size = new System.Drawing.Size(105, 23);
            this.label15.TabIndex = 103;
            this.label15.Text = "Amount";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtb_ProductQuantity
            // 
            this.txtb_ProductQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtb_ProductQuantity.Location = new System.Drawing.Point(532, 48);
            this.txtb_ProductQuantity.MaxLength = 7;
            this.txtb_ProductQuantity.Name = "txtb_ProductQuantity";
            this.txtb_ProductQuantity.Size = new System.Drawing.Size(105, 20);
            this.txtb_ProductQuantity.TabIndex = 4;
            this.txtb_ProductQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtb_ProductQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtb_ProductQuantity_KeyPress);
            this.txtb_ProductQuantity.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtb_ProductQuantity_KeyUp);
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label14.Location = new System.Drawing.Point(532, 26);
            this.label14.Name = "label14";
            this.label14.Padding = new System.Windows.Forms.Padding(7, 4, 4, 4);
            this.label14.Size = new System.Drawing.Size(105, 23);
            this.label14.TabIndex = 101;
            this.label14.Text = "Quantity";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtb_ProductPrice
            // 
            this.txtb_ProductPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtb_ProductPrice.Location = new System.Drawing.Point(430, 48);
            this.txtb_ProductPrice.MaxLength = 7;
            this.txtb_ProductPrice.Name = "txtb_ProductPrice";
            this.txtb_ProductPrice.Size = new System.Drawing.Size(105, 20);
            this.txtb_ProductPrice.TabIndex = 3;
            this.txtb_ProductPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtb_ProductPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtb_ProductPrice_KeyPress);
            this.txtb_ProductPrice.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtb_ProductPrice_KeyUp);
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Location = new System.Drawing.Point(430, 26);
            this.label13.Name = "label13";
            this.label13.Padding = new System.Windows.Forms.Padding(7, 4, 4, 4);
            this.label13.Size = new System.Drawing.Size(105, 23);
            this.label13.TabIndex = 99;
            this.label13.Text = "Price";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtb_ProductName
            // 
            this.txtb_ProductName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtb_ProductName.Location = new System.Drawing.Point(199, 48);
            this.txtb_ProductName.Name = "txtb_ProductName";
            this.txtb_ProductName.ReadOnly = true;
            this.txtb_ProductName.Size = new System.Drawing.Size(232, 20);
            this.txtb_ProductName.TabIndex = 2;
            this.txtb_ProductName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Location = new System.Drawing.Point(199, 26);
            this.label12.Name = "label12";
            this.label12.Padding = new System.Windows.Forms.Padding(7, 4, 4, 4);
            this.label12.Size = new System.Drawing.Size(232, 23);
            this.label12.TabIndex = 97;
            this.label12.Text = "Name";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtb_ProductID
            // 
            this.txtb_ProductID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtb_ProductID.Location = new System.Drawing.Point(95, 48);
            this.txtb_ProductID.Name = "txtb_ProductID";
            this.txtb_ProductID.ReadOnly = true;
            this.txtb_ProductID.Size = new System.Drawing.Size(105, 20);
            this.txtb_ProductID.TabIndex = 1;
            this.txtb_ProductID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Location = new System.Drawing.Point(95, 26);
            this.label11.Name = "label11";
            this.label11.Padding = new System.Windows.Forms.Padding(7, 4, 4, 4);
            this.label11.Size = new System.Drawing.Size(105, 23);
            this.label11.TabIndex = 95;
            this.label11.Text = "Product ID";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_Total
            // 
            this.txt_Total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Total.Location = new System.Drawing.Point(755, 238);
            this.txt_Total.Name = "txt_Total";
            this.txt_Total.ReadOnly = true;
            this.txt_Total.Size = new System.Drawing.Size(188, 20);
            this.txt_Total.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(708, 241);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 93;
            this.label10.Text = "Total  :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Location = new System.Drawing.Point(14, 74);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(929, 156);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.ColumnRemoved += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dataGridView1_ColumnRemoved);
            this.dataGridView1.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridView1_RowsRemoved);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // btn_SelectProduct
            // 
            this.btn_SelectProduct.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_SelectProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_SelectProduct.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_SelectProduct.Location = new System.Drawing.Point(14, 48);
            this.btn_SelectProduct.Name = "btn_SelectProduct";
            this.btn_SelectProduct.Size = new System.Drawing.Size(82, 20);
            this.btn_SelectProduct.TabIndex = 0;
            this.btn_SelectProduct.Text = "...";
            this.btn_SelectProduct.UseVisualStyleBackColor = false;
            this.btn_SelectProduct.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(605, 473);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(107, 23);
            this.btn_Cancel.TabIndex = 15;
            this.btn_Cancel.Text = "Close";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Print
            // 
            this.btn_Print.Location = new System.Drawing.Point(492, 473);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(107, 23);
            this.btn_Print.TabIndex = 13;
            this.btn_Print.Text = "Print";
            this.btn_Print.UseVisualStyleBackColor = true;
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(379, 473);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(107, 23);
            this.btn_Save.TabIndex = 12;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_New
            // 
            this.btn_New.Location = new System.Drawing.Point(266, 473);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(107, 23);
            this.btn_New.TabIndex = 5;
            this.btn_New.Text = "New Order";
            this.btn_New.UseVisualStyleBackColor = true;
            this.btn_New.Click += new System.EventHandler(this.btn_New_Click);
            // 
            // frm_AddOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 508);
            this.Controls.Add(this.btn_New);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Print);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.groupB_Product);
            this.Controls.Add(this.groupB_OrderData);
            this.Controls.Add(this.groupB_ClientData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_AddOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orders";
            this.groupB_ClientData.ResumeLayout(false);
            this.groupB_ClientData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureB_ClientImage)).EndInit();
            this.groupB_OrderData.ResumeLayout(false);
            this.groupB_OrderData.PerformLayout();
            this.groupB_Product.ResumeLayout(false);
            this.groupB_Product.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupB_ClientData;
        private System.Windows.Forms.Button btn_SelectClient;
        public System.Windows.Forms.TextBox txtB_SName;
        public System.Windows.Forms.TextBox txtB_ID;
        public System.Windows.Forms.TextBox txtb_PhoneNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.PictureBox pictureB_ClientImage;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtb_FName;
        public System.Windows.Forms.TextBox txtb_Email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupB_OrderData;
        private System.Windows.Forms.DateTimePicker dateTime_OrderDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txtB_OrderNo;
        public System.Windows.Forms.TextBox txtB_OrderDescription;
        public System.Windows.Forms.TextBox txtB_Username;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupB_Product;
        public System.Windows.Forms.TextBox txt_Total;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Print;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_New;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtb_ProductTotal;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtb_ProductDiscount;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtb_ProductAmount;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtb_ProductQuantity;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtb_ProductPrice;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtb_ProductName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtb_ProductID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_SelectProduct;
    }
}