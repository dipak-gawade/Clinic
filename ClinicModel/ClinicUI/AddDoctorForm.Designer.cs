namespace ClinicUI
{
    partial class AddDoctorForm
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
            this.gbBasicDetails = new System.Windows.Forms.GroupBox();
            this.gbContactDetails = new System.Windows.Forms.GroupBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtMobileNumber = new System.Windows.Forms.TextBox();
            this.lblMobileNumber = new System.Windows.Forms.Label();
            this.gbExpertiseDetails = new System.Windows.Forms.GroupBox();
            this.txtAdditionalDetails = new System.Windows.Forms.TextBox();
            this.lblSpecialistIn = new System.Windows.Forms.Label();
            this.lblAdditionalDetails = new System.Windows.Forms.Label();
            this.txtSpecialistIn = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbBasicDetails.SuspendLayout();
            this.gbContactDetails.SuspendLayout();
            this.gbExpertiseDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbBasicDetails
            // 
            this.gbBasicDetails.Controls.Add(this.txtLastName);
            this.gbBasicDetails.Controls.Add(this.lblLastName);
            this.gbBasicDetails.Controls.Add(this.txtFirstName);
            this.gbBasicDetails.Controls.Add(this.lblFirstName);
            this.gbBasicDetails.Location = new System.Drawing.Point(12, 12);
            this.gbBasicDetails.Name = "gbBasicDetails";
            this.gbBasicDetails.Size = new System.Drawing.Size(268, 80);
            this.gbBasicDetails.TabIndex = 0;
            this.gbBasicDetails.TabStop = false;
            this.gbBasicDetails.Text = "Basic details";
            // 
            // gbContactDetails
            // 
            this.gbContactDetails.Controls.Add(this.txtAddress);
            this.gbContactDetails.Controls.Add(this.lblMobileNumber);
            this.gbContactDetails.Controls.Add(this.lblAddress);
            this.gbContactDetails.Controls.Add(this.txtMobileNumber);
            this.gbContactDetails.Location = new System.Drawing.Point(12, 98);
            this.gbContactDetails.Name = "gbContactDetails";
            this.gbContactDetails.Size = new System.Drawing.Size(268, 118);
            this.gbContactDetails.TabIndex = 1;
            this.gbContactDetails.TabStop = false;
            this.gbContactDetails.Text = "Contact details";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(6, 26);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(55, 13);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(127, 23);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(123, 20);
            this.txtFirstName.TabIndex = 1;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(127, 49);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(123, 20);
            this.txtLastName.TabIndex = 3;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(6, 52);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(56, 13);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Last name";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(127, 48);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(123, 60);
            this.txtAddress.TabIndex = 7;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(6, 51);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(45, 13);
            this.lblAddress.TabIndex = 6;
            this.lblAddress.Text = "Address";
            // 
            // txtMobileNumber
            // 
            this.txtMobileNumber.Location = new System.Drawing.Point(127, 22);
            this.txtMobileNumber.Name = "txtMobileNumber";
            this.txtMobileNumber.Size = new System.Drawing.Size(123, 20);
            this.txtMobileNumber.TabIndex = 5;
            // 
            // lblMobileNumber
            // 
            this.lblMobileNumber.AutoSize = true;
            this.lblMobileNumber.Location = new System.Drawing.Point(6, 25);
            this.lblMobileNumber.Name = "lblMobileNumber";
            this.lblMobileNumber.Size = new System.Drawing.Size(76, 13);
            this.lblMobileNumber.TabIndex = 4;
            this.lblMobileNumber.Text = "Mobile number";
            // 
            // gbExpertiseDetails
            // 
            this.gbExpertiseDetails.Controls.Add(this.txtAdditionalDetails);
            this.gbExpertiseDetails.Controls.Add(this.lblSpecialistIn);
            this.gbExpertiseDetails.Controls.Add(this.lblAdditionalDetails);
            this.gbExpertiseDetails.Controls.Add(this.txtSpecialistIn);
            this.gbExpertiseDetails.Location = new System.Drawing.Point(290, 12);
            this.gbExpertiseDetails.Name = "gbExpertiseDetails";
            this.gbExpertiseDetails.Size = new System.Drawing.Size(261, 158);
            this.gbExpertiseDetails.TabIndex = 8;
            this.gbExpertiseDetails.TabStop = false;
            this.gbExpertiseDetails.Text = "Expertise details";
            // 
            // txtAdditionalDetails
            // 
            this.txtAdditionalDetails.Location = new System.Drawing.Point(127, 83);
            this.txtAdditionalDetails.Multiline = true;
            this.txtAdditionalDetails.Name = "txtAdditionalDetails";
            this.txtAdditionalDetails.Size = new System.Drawing.Size(123, 60);
            this.txtAdditionalDetails.TabIndex = 7;
            // 
            // lblSpecialistIn
            // 
            this.lblSpecialistIn.AutoSize = true;
            this.lblSpecialistIn.Location = new System.Drawing.Point(6, 25);
            this.lblSpecialistIn.Name = "lblSpecialistIn";
            this.lblSpecialistIn.Size = new System.Drawing.Size(61, 13);
            this.lblSpecialistIn.TabIndex = 4;
            this.lblSpecialistIn.Text = "Speciaist in";
            // 
            // lblAdditionalDetails
            // 
            this.lblAdditionalDetails.AutoSize = true;
            this.lblAdditionalDetails.Location = new System.Drawing.Point(6, 86);
            this.lblAdditionalDetails.Name = "lblAdditionalDetails";
            this.lblAdditionalDetails.Size = new System.Drawing.Size(86, 13);
            this.lblAdditionalDetails.TabIndex = 6;
            this.lblAdditionalDetails.Text = "Additional details";
            // 
            // txtSpecialistIn
            // 
            this.txtSpecialistIn.Location = new System.Drawing.Point(127, 22);
            this.txtSpecialistIn.Multiline = true;
            this.txtSpecialistIn.Name = "txtSpecialistIn";
            this.txtSpecialistIn.Size = new System.Drawing.Size(123, 55);
            this.txtSpecialistIn.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(326, 181);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(91, 30);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(449, 180);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 30);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AddDoctorForm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(562, 222);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbExpertiseDetails);
            this.Controls.Add(this.gbContactDetails);
            this.Controls.Add(this.gbBasicDetails);
            this.Name = "AddDoctorForm";
            this.Text = "Add Doctor";
            this.gbBasicDetails.ResumeLayout(false);
            this.gbBasicDetails.PerformLayout();
            this.gbContactDetails.ResumeLayout(false);
            this.gbContactDetails.PerformLayout();
            this.gbExpertiseDetails.ResumeLayout(false);
            this.gbExpertiseDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbBasicDetails;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.GroupBox gbContactDetails;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblMobileNumber;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtMobileNumber;
        private System.Windows.Forms.GroupBox gbExpertiseDetails;
        private System.Windows.Forms.TextBox txtAdditionalDetails;
        private System.Windows.Forms.Label lblSpecialistIn;
        private System.Windows.Forms.Label lblAdditionalDetails;
        private System.Windows.Forms.TextBox txtSpecialistIn;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}