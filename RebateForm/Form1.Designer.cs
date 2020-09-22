namespace RebateForm
{
	partial class RebateForm
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
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("test1");
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblAddressLine1 = new System.Windows.Forms.Label();
            this.lblAddressLine2 = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtAddressLine1 = new System.Windows.Forms.TextBox();
            this.txtAddressLine2 = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.lblZipCode = new System.Windows.Forms.Label();
            this.txtZipCode = new System.Windows.Forms.TextBox();
            this.txtMiddleInitial = new System.Windows.Forms.TextBox();
            this.lblEmailId = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.lblPhoneNo = new System.Windows.Forms.Label();
            this.txtPhoneNo = new System.Windows.Forms.MaskedTextBox();
            this.cboProofAttached = new System.Windows.Forms.ComboBox();
            this.lblDateReceived = new System.Windows.Forms.Label();
            this.dateReceived = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lstViewNamePhone = new System.Windows.Forms.ListView();
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.btnNew = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // elementHost1
            // 
            this.elementHost1.Location = new System.Drawing.Point(41, 11);
            this.elementHost1.Margin = new System.Windows.Forms.Padding(2);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(652, 622);
            this.elementHost1.TabIndex = 0;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.ChildChanged += new System.EventHandler<System.Windows.Forms.Integration.ChildChangedEventArgs>(this.elementHost1_ChildChanged);
            this.elementHost1.Child = null;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(90, 90);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "First Name";
            // 
            // lastName
            // 
            this.lastName.AccessibleName = "";
            this.lastName.AutoSize = true;
            this.lastName.Location = new System.Drawing.Point(285, 90);
            this.lastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(65, 13);
            this.lastName.TabIndex = 3;
            this.lastName.Text = "Middle Initial";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(90, 115);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 5;
            this.lblLastName.Text = "Last Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(149, 87);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(2);
            this.txtFirstName.MaxLength = 20;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(126, 20);
            this.txtFirstName.TabIndex = 2;
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(149, 111);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(2);
            this.txtLastName.MaxLength = 20;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(126, 20);
            this.txtLastName.TabIndex = 6;
            this.txtLastName.TextChanged += new System.EventHandler(this.txtLastName_TextChanged);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(89, 213);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(48, 13);
            this.lblAddress.TabIndex = 13;
            this.lblAddress.Text = "Address ";
            // 
            // lblAddressLine1
            // 
            this.lblAddressLine1.AutoSize = true;
            this.lblAddressLine1.Location = new System.Drawing.Point(111, 235);
            this.lblAddressLine1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddressLine1.Name = "lblAddressLine1";
            this.lblAddressLine1.Size = new System.Drawing.Size(36, 13);
            this.lblAddressLine1.TabIndex = 14;
            this.lblAddressLine1.Text = "Line 1";
            // 
            // lblAddressLine2
            // 
            this.lblAddressLine2.AutoSize = true;
            this.lblAddressLine2.Location = new System.Drawing.Point(111, 259);
            this.lblAddressLine2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddressLine2.Name = "lblAddressLine2";
            this.lblAddressLine2.Size = new System.Drawing.Size(36, 13);
            this.lblAddressLine2.TabIndex = 16;
            this.lblAddressLine2.Text = "Line 2";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(111, 307);
            this.lblState.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(32, 13);
            this.lblState.TabIndex = 20;
            this.lblState.Text = "State";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(111, 283);
            this.lblCity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(24, 13);
            this.lblCity.TabIndex = 18;
            this.lblCity.Text = "City";
            // 
            // txtAddressLine1
            // 
            this.txtAddressLine1.Location = new System.Drawing.Point(149, 232);
            this.txtAddressLine1.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddressLine1.MaxLength = 35;
            this.txtAddressLine1.Name = "txtAddressLine1";
            this.txtAddressLine1.Size = new System.Drawing.Size(223, 20);
            this.txtAddressLine1.TabIndex = 15;
            this.txtAddressLine1.TextChanged += new System.EventHandler(this.txtAddressLine1_TextChanged);
            // 
            // txtAddressLine2
            // 
            this.txtAddressLine2.Location = new System.Drawing.Point(149, 256);
            this.txtAddressLine2.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddressLine2.MaxLength = 35;
            this.txtAddressLine2.Name = "txtAddressLine2";
            this.txtAddressLine2.Size = new System.Drawing.Size(223, 20);
            this.txtAddressLine2.TabIndex = 17;
            this.txtAddressLine2.TextChanged += new System.EventHandler(this.txtAddressLine2_TextChanged);
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(149, 280);
            this.txtCity.Margin = new System.Windows.Forms.Padding(2);
            this.txtCity.MaxLength = 25;
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(126, 20);
            this.txtCity.TabIndex = 19;
            this.txtCity.TextChanged += new System.EventHandler(this.txtCity_TextChanged);
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(149, 304);
            this.txtState.Margin = new System.Windows.Forms.Padding(2);
            this.txtState.MaxLength = 2;
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(26, 20);
            this.txtState.TabIndex = 21;
            this.txtState.TextChanged += new System.EventHandler(this.txtState_TextChanged);
            // 
            // lblZipCode
            // 
            this.lblZipCode.AutoSize = true;
            this.lblZipCode.Location = new System.Drawing.Point(234, 307);
            this.lblZipCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblZipCode.Name = "lblZipCode";
            this.lblZipCode.Size = new System.Drawing.Size(50, 13);
            this.lblZipCode.TabIndex = 22;
            this.lblZipCode.Text = "Zip Code";
            // 
            // txtZipCode
            // 
            this.txtZipCode.Location = new System.Drawing.Point(288, 304);
            this.txtZipCode.Margin = new System.Windows.Forms.Padding(2);
            this.txtZipCode.MaxLength = 9;
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.Size = new System.Drawing.Size(84, 20);
            this.txtZipCode.TabIndex = 23;
            this.txtZipCode.TextChanged += new System.EventHandler(this.txtZipCode_TextChanged);
            // 
            // txtMiddleInitial
            // 
            this.txtMiddleInitial.Location = new System.Drawing.Point(352, 87);
            this.txtMiddleInitial.Margin = new System.Windows.Forms.Padding(2);
            this.txtMiddleInitial.MaxLength = 1;
            this.txtMiddleInitial.Name = "txtMiddleInitial";
            this.txtMiddleInitial.Size = new System.Drawing.Size(20, 20);
            this.txtMiddleInitial.TabIndex = 4;
            this.txtMiddleInitial.TextChanged += new System.EventHandler(this.txtMiddleInitial_TextChanged);
            // 
            // lblEmailId
            // 
            this.lblEmailId.AutoSize = true;
            this.lblEmailId.Location = new System.Drawing.Point(90, 162);
            this.lblEmailId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmailId.Name = "lblEmailId";
            this.lblEmailId.Size = new System.Drawing.Size(49, 13);
            this.lblEmailId.TabIndex = 11;
            this.lblEmailId.Text = "Email ID ";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(149, 159);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.MaxLength = 60;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(223, 20);
            this.txtEmail.TabIndex = 12;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(306, 115);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Gender";
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(352, 111);
            this.txtGender.Margin = new System.Windows.Forms.Padding(2);
            this.txtGender.MaxLength = 1;
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(20, 20);
            this.txtGender.TabIndex = 8;
            this.txtGender.TextChanged += new System.EventHandler(this.txtGender_TextChanged);
            // 
            // lblPhoneNo
            // 
            this.lblPhoneNo.AutoSize = true;
            this.lblPhoneNo.Location = new System.Drawing.Point(90, 138);
            this.lblPhoneNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhoneNo.Name = "lblPhoneNo";
            this.lblPhoneNo.Size = new System.Drawing.Size(55, 13);
            this.lblPhoneNo.TabIndex = 9;
            this.lblPhoneNo.Text = "Phone No";
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.Location = new System.Drawing.Point(149, 135);
            this.txtPhoneNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtPhoneNo.Mask = "(999) 000-0000";
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.Size = new System.Drawing.Size(126, 20);
            this.txtPhoneNo.TabIndex = 10;
            this.txtPhoneNo.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtPhoneNo_MaskInputRejected);
            // 
            // cboProofAttached
            // 
            this.cboProofAttached.AllowDrop = true;
            this.cboProofAttached.FormattingEnabled = true;
            this.cboProofAttached.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cboProofAttached.Location = new System.Drawing.Point(229, 366);
            this.cboProofAttached.Margin = new System.Windows.Forms.Padding(2);
            this.cboProofAttached.Name = "cboProofAttached";
            this.cboProofAttached.Size = new System.Drawing.Size(46, 21);
            this.cboProofAttached.TabIndex = 25;
            this.cboProofAttached.SelectedIndexChanged += new System.EventHandler(this.cboProofAttached_SelectedIndexChanged);
            // 
            // lblDateReceived
            // 
            this.lblDateReceived.AutoSize = true;
            this.lblDateReceived.Location = new System.Drawing.Point(146, 397);
            this.lblDateReceived.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDateReceived.Name = "lblDateReceived";
            this.lblDateReceived.Size = new System.Drawing.Size(79, 13);
            this.lblDateReceived.TabIndex = 26;
            this.lblDateReceived.Text = "Date Received";
            // 
            // dateReceived
            // 
            this.dateReceived.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateReceived.Location = new System.Drawing.Point(229, 391);
            this.dateReceived.Margin = new System.Windows.Forms.Padding(2);
            this.dateReceived.Name = "dateReceived";
            this.dateReceived.Size = new System.Drawing.Size(97, 20);
            this.dateReceived.TabIndex = 27;
            this.dateReceived.ValueChanged += new System.EventHandler(this.dateReceived_ValueChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(93, 509);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(83, 40);
            this.btnSave.TabIndex = 28;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(210, 509);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(65, 40);
            this.btnClear.TabIndex = 29;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(309, 509);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(63, 40);
            this.btnDelete.TabIndex = 30;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lstViewNamePhone
            // 
            this.lstViewNamePhone.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colPhone});
            this.lstViewNamePhone.FullRowSelect = true;
            this.lstViewNamePhone.HideSelection = false;
            this.lstViewNamePhone.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.lstViewNamePhone.Location = new System.Drawing.Point(421, 89);
            this.lstViewNamePhone.Margin = new System.Windows.Forms.Padding(2);
            this.lstViewNamePhone.MultiSelect = false;
            this.lstViewNamePhone.Name = "lstViewNamePhone";
            this.lstViewNamePhone.Size = new System.Drawing.Size(262, 460);
            this.lstViewNamePhone.TabIndex = 31;
            this.lstViewNamePhone.UseCompatibleStateImageBehavior = false;
            this.lstViewNamePhone.View = System.Windows.Forms.View.Details;
            this.lstViewNamePhone.SelectedIndexChanged += new System.EventHandler(this.lstViewNamePhone_SelectedIndexChanged);
            // 
            // colName
            // 
            this.colName.Text = "Name";
            this.colName.Width = 120;
            // 
            // colPhone
            // 
            this.colPhone.Text = "Phone";
            this.colPhone.Width = 120;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 369);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Proof of Purchase Attached";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 639);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(734, 22);
            this.statusStrip1.TabIndex = 32;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(421, 115);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(262, 23);
            this.btnNew.TabIndex = 33;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // RebateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 661);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lstViewNamePhone);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dateReceived);
            this.Controls.Add(this.lblDateReceived);
            this.Controls.Add(this.cboProofAttached);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPhoneNo);
            this.Controls.Add(this.lblPhoneNo);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmailId);
            this.Controls.Add(this.txtMiddleInitial);
            this.Controls.Add(this.txtZipCode);
            this.Controls.Add(this.lblZipCode);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtAddressLine2);
            this.Controls.Add(this.txtAddressLine1);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.lblAddressLine2);
            this.Controls.Add(this.lblAddressLine1);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.elementHost1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RebateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rebate Form";
            this.Load += new System.EventHandler(this.RebateForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Integration.ElementHost elementHost1;
		private System.Windows.Forms.Label lblFirstName;
		private System.Windows.Forms.Label lastName;
		private System.Windows.Forms.Label lblLastName;
		private System.Windows.Forms.TextBox txtLastName;
		private System.Windows.Forms.Label lblAddress;
		private System.Windows.Forms.Label lblAddressLine1;
		private System.Windows.Forms.Label lblAddressLine2;
		private System.Windows.Forms.Label lblState;
		private System.Windows.Forms.Label lblCity;
		private System.Windows.Forms.TextBox txtAddressLine1;
		private System.Windows.Forms.TextBox txtAddressLine2;
		private System.Windows.Forms.TextBox txtCity;
		private System.Windows.Forms.TextBox txtState;
		private System.Windows.Forms.Label lblZipCode;
		private System.Windows.Forms.TextBox txtZipCode;
		private System.Windows.Forms.TextBox txtMiddleInitial;
		private System.Windows.Forms.Label lblEmailId;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txtGender;
		private System.Windows.Forms.Label lblPhoneNo;
		private System.Windows.Forms.MaskedTextBox txtPhoneNo;
		private System.Windows.Forms.Label lblDateReceived;
		private System.Windows.Forms.DateTimePicker dateReceived;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.ListView lstViewNamePhone;
		private System.Windows.Forms.ColumnHeader colName;
		private System.Windows.Forms.ColumnHeader colPhone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.ComboBox cboProofAttached;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.Button btnNew;
    }
}

