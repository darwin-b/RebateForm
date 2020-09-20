namespace RebateForm
{
	partial class Form1
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
			this.addressLine1 = new System.Windows.Forms.TextBox();
			this.addressLine2 = new System.Windows.Forms.TextBox();
			this.city = new System.Windows.Forms.TextBox();
			this.state = new System.Windows.Forms.TextBox();
			this.lblZipCode = new System.Windows.Forms.Label();
			this.zipCode = new System.Windows.Forms.TextBox();
			this.textBox8 = new System.Windows.Forms.TextBox();
			this.lblEmailId = new System.Windows.Forms.Label();
			this.emailId = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.textBox10 = new System.Windows.Forms.TextBox();
			this.lblPhoneNo = new System.Windows.Forms.Label();
			this.phoneNo = new System.Windows.Forms.MaskedTextBox();
			this.lblProofAttached = new System.Windows.Forms.Label();
			this.cboProofAttached = new System.Windows.Forms.ComboBox();
			this.lblDateReceived = new System.Windows.Forms.Label();
			this.dateReceived = new System.Windows.Forms.DateTimePicker();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.lstViewNamePhone = new System.Windows.Forms.ListView();
			this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SuspendLayout();
			// 
			// elementHost1
			// 
			this.elementHost1.Location = new System.Drawing.Point(12, 12);
			this.elementHost1.Name = "elementHost1";
			this.elementHost1.Size = new System.Drawing.Size(1140, 740);
			this.elementHost1.TabIndex = 0;
			this.elementHost1.Text = "elementHost1";
			this.elementHost1.ChildChanged += new System.EventHandler<System.Windows.Forms.Integration.ChildChangedEventArgs>(this.elementHost1_ChildChanged);
			this.elementHost1.Child = null;
			// 
			// lblFirstName
			// 
			this.lblFirstName.AutoSize = true;
			this.lblFirstName.Location = new System.Drawing.Point(83, 73);
			this.lblFirstName.Name = "lblFirstName";
			this.lblFirstName.Size = new System.Drawing.Size(116, 25);
			this.lblFirstName.TabIndex = 1;
			this.lblFirstName.Text = "First Name";
			this.lblFirstName.Click += new System.EventHandler(this.Label1_Click);
			// 
			// lastName
			// 
			this.lastName.AccessibleName = "";
			this.lastName.AutoSize = true;
			this.lastName.Location = new System.Drawing.Point(475, 73);
			this.lastName.Name = "lastName";
			this.lastName.Size = new System.Drawing.Size(132, 25);
			this.lastName.TabIndex = 3;
			this.lastName.Text = "Middle Initial";
			// 
			// lblLastName
			// 
			this.lblLastName.AutoSize = true;
			this.lblLastName.Location = new System.Drawing.Point(83, 124);
			this.lblLastName.Name = "lblLastName";
			this.lblLastName.Size = new System.Drawing.Size(115, 25);
			this.lblLastName.TabIndex = 5;
			this.lblLastName.Text = "Last Name";
			// 
			// txtFirstName
			// 
			this.txtFirstName.Location = new System.Drawing.Point(205, 70);
			this.txtFirstName.Name = "txtFirstName";
			this.txtFirstName.Size = new System.Drawing.Size(249, 31);
			this.txtFirstName.TabIndex = 2;
			this.txtFirstName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// txtLastName
			// 
			this.txtLastName.Location = new System.Drawing.Point(204, 121);
			this.txtLastName.Name = "txtLastName";
			this.txtLastName.Size = new System.Drawing.Size(249, 31);
			this.txtLastName.TabIndex = 6;
			// 
			// lblAddress
			// 
			this.lblAddress.AutoSize = true;
			this.lblAddress.Location = new System.Drawing.Point(83, 280);
			this.lblAddress.Name = "lblAddress";
			this.lblAddress.Size = new System.Drawing.Size(97, 25);
			this.lblAddress.TabIndex = 13;
			this.lblAddress.Text = "Address ";
			this.lblAddress.Click += new System.EventHandler(this.label2_Click);
			// 
			// lblAddressLine1
			// 
			this.lblAddressLine1.AutoSize = true;
			this.lblAddressLine1.Location = new System.Drawing.Point(127, 325);
			this.lblAddressLine1.Name = "lblAddressLine1";
			this.lblAddressLine1.Size = new System.Drawing.Size(71, 25);
			this.lblAddressLine1.TabIndex = 14;
			this.lblAddressLine1.Text = "Line 1";
			this.lblAddressLine1.Click += new System.EventHandler(this.label4_Click);
			// 
			// lblAddressLine2
			// 
			this.lblAddressLine2.AutoSize = true;
			this.lblAddressLine2.Location = new System.Drawing.Point(127, 365);
			this.lblAddressLine2.Name = "lblAddressLine2";
			this.lblAddressLine2.Size = new System.Drawing.Size(71, 25);
			this.lblAddressLine2.TabIndex = 16;
			this.lblAddressLine2.Text = "Line 2";
			this.lblAddressLine2.Click += new System.EventHandler(this.label5_Click);
			// 
			// lblState
			// 
			this.lblState.AutoSize = true;
			this.lblState.Location = new System.Drawing.Point(127, 443);
			this.lblState.Name = "lblState";
			this.lblState.Size = new System.Drawing.Size(62, 25);
			this.lblState.TabIndex = 20;
			this.lblState.Text = "State";
			this.lblState.Click += new System.EventHandler(this.label6_Click);
			// 
			// lblCity
			// 
			this.lblCity.AutoSize = true;
			this.lblCity.Location = new System.Drawing.Point(127, 403);
			this.lblCity.Name = "lblCity";
			this.lblCity.Size = new System.Drawing.Size(49, 25);
			this.lblCity.TabIndex = 18;
			this.lblCity.Text = "City";
			this.lblCity.Click += new System.EventHandler(this.label7_Click);
			// 
			// addressLine1
			// 
			this.addressLine1.Location = new System.Drawing.Point(204, 322);
			this.addressLine1.Name = "addressLine1";
			this.addressLine1.Size = new System.Drawing.Size(445, 31);
			this.addressLine1.TabIndex = 15;
			this.addressLine1.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
			// 
			// addressLine2
			// 
			this.addressLine2.Location = new System.Drawing.Point(204, 362);
			this.addressLine2.Name = "addressLine2";
			this.addressLine2.Size = new System.Drawing.Size(445, 31);
			this.addressLine2.TabIndex = 17;
			this.addressLine2.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
			// 
			// city
			// 
			this.city.Location = new System.Drawing.Point(204, 400);
			this.city.Name = "city";
			this.city.Size = new System.Drawing.Size(311, 31);
			this.city.TabIndex = 19;
			this.city.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
			// 
			// state
			// 
			this.state.Location = new System.Drawing.Point(204, 440);
			this.state.Name = "state";
			this.state.Size = new System.Drawing.Size(53, 31);
			this.state.TabIndex = 21;
			this.state.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
			// 
			// lblZipCode
			// 
			this.lblZipCode.AutoSize = true;
			this.lblZipCode.Location = new System.Drawing.Point(288, 443);
			this.lblZipCode.Name = "lblZipCode";
			this.lblZipCode.Size = new System.Drawing.Size(99, 25);
			this.lblZipCode.TabIndex = 22;
			this.lblZipCode.Text = "Zip Code";
			this.lblZipCode.Click += new System.EventHandler(this.label8_Click);
			// 
			// zipCode
			// 
			this.zipCode.Location = new System.Drawing.Point(393, 440);
			this.zipCode.Name = "zipCode";
			this.zipCode.Size = new System.Drawing.Size(122, 31);
			this.zipCode.TabIndex = 23;
			this.zipCode.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
			// 
			// textBox8
			// 
			this.textBox8.Location = new System.Drawing.Point(613, 70);
			this.textBox8.Name = "textBox8";
			this.textBox8.Size = new System.Drawing.Size(37, 31);
			this.textBox8.TabIndex = 4;
			this.textBox8.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
			// 
			// lblEmailId
			// 
			this.lblEmailId.AutoSize = true;
			this.lblEmailId.Location = new System.Drawing.Point(83, 226);
			this.lblEmailId.Name = "lblEmailId";
			this.lblEmailId.Size = new System.Drawing.Size(97, 25);
			this.lblEmailId.TabIndex = 11;
			this.lblEmailId.Text = "Email ID ";
			this.lblEmailId.Click += new System.EventHandler(this.label9_Click);
			// 
			// emailId
			// 
			this.emailId.Location = new System.Drawing.Point(204, 223);
			this.emailId.Name = "emailId";
			this.emailId.Size = new System.Drawing.Size(445, 31);
			this.emailId.TabIndex = 12;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(524, 124);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(83, 25);
			this.label10.TabIndex = 7;
			this.label10.Text = "Gender";
			// 
			// textBox10
			// 
			this.textBox10.Location = new System.Drawing.Point(613, 121);
			this.textBox10.Name = "textBox10";
			this.textBox10.Size = new System.Drawing.Size(37, 31);
			this.textBox10.TabIndex = 8;
			// 
			// lblPhoneNo
			// 
			this.lblPhoneNo.AutoSize = true;
			this.lblPhoneNo.Location = new System.Drawing.Point(83, 177);
			this.lblPhoneNo.Name = "lblPhoneNo";
			this.lblPhoneNo.Size = new System.Drawing.Size(107, 25);
			this.lblPhoneNo.TabIndex = 9;
			this.lblPhoneNo.Text = "Phone No";
			// 
			// phoneNo
			// 
			this.phoneNo.Location = new System.Drawing.Point(205, 174);
			this.phoneNo.Mask = "(999) 000-0000";
			this.phoneNo.Name = "phoneNo";
			this.phoneNo.Size = new System.Drawing.Size(249, 31);
			this.phoneNo.TabIndex = 10;
			// 
			// lblProofAttached
			// 
			this.lblProofAttached.AutoSize = true;
			this.lblProofAttached.Location = new System.Drawing.Point(83, 519);
			this.lblProofAttached.Name = "lblProofAttached";
			this.lblProofAttached.Size = new System.Drawing.Size(275, 25);
			this.lblProofAttached.TabIndex = 24;
			this.lblProofAttached.Text = "Proof of Purchase Attached";
			// 
			// cboProofAttached
			// 
			this.cboProofAttached.AllowDrop = true;
			this.cboProofAttached.FormattingEnabled = true;
			this.cboProofAttached.Items.AddRange(new object[] {
            "Yes",
            "No"});
			this.cboProofAttached.Location = new System.Drawing.Point(393, 510);
			this.cboProofAttached.Name = "cboProofAttached";
			this.cboProofAttached.Size = new System.Drawing.Size(122, 33);
			this.cboProofAttached.TabIndex = 25;
			// 
			// lblDateReceived
			// 
			this.lblDateReceived.AutoSize = true;
			this.lblDateReceived.Location = new System.Drawing.Point(205, 563);
			this.lblDateReceived.Name = "lblDateReceived";
			this.lblDateReceived.Size = new System.Drawing.Size(153, 25);
			this.lblDateReceived.TabIndex = 26;
			this.lblDateReceived.Text = "Date Received";
			// 
			// dateReceived
			// 
			this.dateReceived.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateReceived.Location = new System.Drawing.Point(393, 556);
			this.dateReceived.Name = "dateReceived";
			this.dateReceived.Size = new System.Drawing.Size(171, 31);
			this.dateReceived.TabIndex = 27;
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(205, 670);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(129, 50);
			this.btnSave.TabIndex = 28;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			// 
			// btnClear
			// 
			this.btnClear.Location = new System.Drawing.Point(364, 670);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(129, 50);
			this.btnClear.TabIndex = 29;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(521, 670);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(129, 50);
			this.btnDelete.TabIndex = 30;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			// 
			// lstViewNamePhone
			// 
			this.lstViewNamePhone.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colPhone});
			this.lstViewNamePhone.HideSelection = false;
			this.lstViewNamePhone.Location = new System.Drawing.Point(793, 70);
			this.lstViewNamePhone.Name = "lstViewNamePhone";
			this.lstViewNamePhone.Size = new System.Drawing.Size(304, 517);
			this.lstViewNamePhone.TabIndex = 31;
			this.lstViewNamePhone.UseCompatibleStateImageBehavior = false;
			this.lstViewNamePhone.View = System.Windows.Forms.View.Details;
			// 
			// colName
			// 
			this.colName.Text = "Name";
			this.colName.Width = 150;
			// 
			// colPhone
			// 
			this.colPhone.Text = "Phone";
			this.colPhone.Width = 150;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1168, 762);
			this.Controls.Add(this.lstViewNamePhone);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.dateReceived);
			this.Controls.Add(this.lblDateReceived);
			this.Controls.Add(this.cboProofAttached);
			this.Controls.Add(this.lblProofAttached);
			this.Controls.Add(this.phoneNo);
			this.Controls.Add(this.lblPhoneNo);
			this.Controls.Add(this.textBox10);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.emailId);
			this.Controls.Add(this.lblEmailId);
			this.Controls.Add(this.textBox8);
			this.Controls.Add(this.zipCode);
			this.Controls.Add(this.lblZipCode);
			this.Controls.Add(this.state);
			this.Controls.Add(this.city);
			this.Controls.Add(this.addressLine2);
			this.Controls.Add(this.addressLine1);
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
			this.Name = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Integration.ElementHost elementHost1;
		private System.Windows.Forms.Label lblFirstName;
		private System.Windows.Forms.Label lastName;
		private System.Windows.Forms.Label lblLastName;
		private System.Windows.Forms.TextBox txtFirstName;
		private System.Windows.Forms.TextBox txtLastName;
		private System.Windows.Forms.Label lblAddress;
		private System.Windows.Forms.Label lblAddressLine1;
		private System.Windows.Forms.Label lblAddressLine2;
		private System.Windows.Forms.Label lblState;
		private System.Windows.Forms.Label lblCity;
		private System.Windows.Forms.TextBox addressLine1;
		private System.Windows.Forms.TextBox addressLine2;
		private System.Windows.Forms.TextBox city;
		private System.Windows.Forms.TextBox state;
		private System.Windows.Forms.Label lblZipCode;
		private System.Windows.Forms.TextBox zipCode;
		private System.Windows.Forms.TextBox textBox8;
		private System.Windows.Forms.Label lblEmailId;
		private System.Windows.Forms.TextBox emailId;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox textBox10;
		private System.Windows.Forms.Label lblPhoneNo;
		private System.Windows.Forms.MaskedTextBox phoneNo;
		private System.Windows.Forms.Label lblProofAttached;
		private System.Windows.Forms.ComboBox cboProofAttached;
		private System.Windows.Forms.Label lblDateReceived;
		private System.Windows.Forms.DateTimePicker dateReceived;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.ListView lstViewNamePhone;
		private System.Windows.Forms.ColumnHeader colName;
		private System.Windows.Forms.ColumnHeader colPhone;
	}
}

