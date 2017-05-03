namespace ClinicUI
{
    partial class AddSessionForm
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
            this.lblSessionNumber = new System.Windows.Forms.Label();
            this.lblSessionNumberValue = new System.Windows.Forms.Label();
            this.cbPatientName = new System.Windows.Forms.ComboBox();
            this.lblPatientName = new System.Windows.Forms.Label();
            this.dgvTreatments = new System.Windows.Forms.DataGridView();
            this.lblTreatment = new System.Windows.Forms.Label();
            this.lblTreatmentFor = new System.Windows.Forms.Label();
            this.txtTreatmentReason = new System.Windows.Forms.TextBox();
            this.lblCharges = new System.Windows.Forms.Label();
            this.lblDiscountedFees = new System.Windows.Forms.Label();
            this.lblChargesValue = new System.Windows.Forms.Label();
            this.txtDiscountedFees = new System.Windows.Forms.TextBox();
            this.lblRs = new System.Windows.Forms.Label();
            this.txtAttendedBy = new System.Windows.Forms.TextBox();
            this.lblAttendedBy = new System.Windows.Forms.Label();
            this.dtpReportingTime = new System.Windows.Forms.DateTimePicker();
            this.lblReportingTime = new System.Windows.Forms.Label();
            this.btnBook = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTreatments)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSessionNumber
            // 
            this.lblSessionNumber.AutoSize = true;
            this.lblSessionNumber.Location = new System.Drawing.Point(13, 13);
            this.lblSessionNumber.Name = "lblSessionNumber";
            this.lblSessionNumber.Size = new System.Drawing.Size(85, 13);
            this.lblSessionNumber.TabIndex = 0;
            this.lblSessionNumber.Text = "Session number:";
            // 
            // lblSessionNumberValue
            // 
            this.lblSessionNumberValue.AutoSize = true;
            this.lblSessionNumberValue.Location = new System.Drawing.Point(104, 13);
            this.lblSessionNumberValue.Name = "lblSessionNumberValue";
            this.lblSessionNumberValue.Size = new System.Drawing.Size(85, 13);
            this.lblSessionNumberValue.TabIndex = 1;
            this.lblSessionNumberValue.Text = "Session number:";
            // 
            // cbPatientName
            // 
            this.cbPatientName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPatientName.FormattingEnabled = true;
            this.cbPatientName.Location = new System.Drawing.Point(107, 37);
            this.cbPatientName.Name = "cbPatientName";
            this.cbPatientName.Size = new System.Drawing.Size(162, 21);
            this.cbPatientName.TabIndex = 2;
            // 
            // lblPatientName
            // 
            this.lblPatientName.AutoSize = true;
            this.lblPatientName.Location = new System.Drawing.Point(13, 40);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.Size = new System.Drawing.Size(72, 13);
            this.lblPatientName.TabIndex = 3;
            this.lblPatientName.Text = "Patient name:";
            // 
            // dgvTreatments
            // 
            this.dgvTreatments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTreatments.Location = new System.Drawing.Point(16, 129);
            this.dgvTreatments.Name = "dgvTreatments";
            this.dgvTreatments.Size = new System.Drawing.Size(465, 130);
            this.dgvTreatments.TabIndex = 4;
            // 
            // lblTreatment
            // 
            this.lblTreatment.AutoSize = true;
            this.lblTreatment.Location = new System.Drawing.Point(13, 103);
            this.lblTreatment.Name = "lblTreatment";
            this.lblTreatment.Size = new System.Drawing.Size(60, 13);
            this.lblTreatment.TabIndex = 5;
            this.lblTreatment.Text = "Treatments";
            // 
            // lblTreatmentFor
            // 
            this.lblTreatmentFor.AutoSize = true;
            this.lblTreatmentFor.Location = new System.Drawing.Point(13, 70);
            this.lblTreatmentFor.Name = "lblTreatmentFor";
            this.lblTreatmentFor.Size = new System.Drawing.Size(93, 13);
            this.lblTreatmentFor.TabIndex = 6;
            this.lblTreatmentFor.Text = "Treatment reason:";
            // 
            // txtTreatmentReason
            // 
            this.txtTreatmentReason.Location = new System.Drawing.Point(107, 67);
            this.txtTreatmentReason.Multiline = true;
            this.txtTreatmentReason.Name = "txtTreatmentReason";
            this.txtTreatmentReason.Size = new System.Drawing.Size(162, 33);
            this.txtTreatmentReason.TabIndex = 7;
            // 
            // lblCharges
            // 
            this.lblCharges.AutoSize = true;
            this.lblCharges.Location = new System.Drawing.Point(13, 273);
            this.lblCharges.Name = "lblCharges";
            this.lblCharges.Size = new System.Drawing.Size(49, 13);
            this.lblCharges.TabIndex = 8;
            this.lblCharges.Text = "Charges:";
            // 
            // lblDiscountedFees
            // 
            this.lblDiscountedFees.AutoSize = true;
            this.lblDiscountedFees.Location = new System.Drawing.Point(13, 303);
            this.lblDiscountedFees.Name = "lblDiscountedFees";
            this.lblDiscountedFees.Size = new System.Drawing.Size(87, 13);
            this.lblDiscountedFees.TabIndex = 9;
            this.lblDiscountedFees.Text = "Discounted fees:";
            // 
            // lblChargesValue
            // 
            this.lblChargesValue.AutoSize = true;
            this.lblChargesValue.Location = new System.Drawing.Point(104, 273);
            this.lblChargesValue.Name = "lblChargesValue";
            this.lblChargesValue.Size = new System.Drawing.Size(13, 13);
            this.lblChargesValue.TabIndex = 10;
            this.lblChargesValue.Text = "0";
            // 
            // txtDiscountedFees
            // 
            this.txtDiscountedFees.Location = new System.Drawing.Point(107, 300);
            this.txtDiscountedFees.Name = "txtDiscountedFees";
            this.txtDiscountedFees.Size = new System.Drawing.Size(100, 20);
            this.txtDiscountedFees.TabIndex = 11;
            // 
            // lblRs
            // 
            this.lblRs.AutoSize = true;
            this.lblRs.Location = new System.Drawing.Point(213, 303);
            this.lblRs.Name = "lblRs";
            this.lblRs.Size = new System.Drawing.Size(20, 13);
            this.lblRs.TabIndex = 12;
            this.lblRs.Text = "Rs";
            // 
            // txtAttendedBy
            // 
            this.txtAttendedBy.Location = new System.Drawing.Point(381, 270);
            this.txtAttendedBy.Name = "txtAttendedBy";
            this.txtAttendedBy.Size = new System.Drawing.Size(100, 20);
            this.txtAttendedBy.TabIndex = 14;
            // 
            // lblAttendedBy
            // 
            this.lblAttendedBy.AutoSize = true;
            this.lblAttendedBy.Location = new System.Drawing.Point(287, 273);
            this.lblAttendedBy.Name = "lblAttendedBy";
            this.lblAttendedBy.Size = new System.Drawing.Size(67, 13);
            this.lblAttendedBy.TabIndex = 13;
            this.lblAttendedBy.Text = "Attended by:";
            // 
            // dtpReportingTime
            // 
            this.dtpReportingTime.Location = new System.Drawing.Point(281, 67);
            this.dtpReportingTime.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtpReportingTime.MinDate = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            this.dtpReportingTime.Name = "dtpReportingTime";
            this.dtpReportingTime.Size = new System.Drawing.Size(200, 20);
            this.dtpReportingTime.TabIndex = 15;
            // 
            // lblReportingTime
            // 
            this.lblReportingTime.AutoSize = true;
            this.lblReportingTime.Location = new System.Drawing.Point(278, 40);
            this.lblReportingTime.Name = "lblReportingTime";
            this.lblReportingTime.Size = new System.Drawing.Size(78, 13);
            this.lblReportingTime.TabIndex = 16;
            this.lblReportingTime.Text = "Reporting time:";
            // 
            // btnBook
            // 
            this.btnBook.Location = new System.Drawing.Point(125, 334);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(120, 23);
            this.btnBook.TabIndex = 17;
            this.btnBook.Text = "Book";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(251, 334);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 23);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AddSessionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 364);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.lblReportingTime);
            this.Controls.Add(this.dtpReportingTime);
            this.Controls.Add(this.txtAttendedBy);
            this.Controls.Add(this.lblAttendedBy);
            this.Controls.Add(this.lblRs);
            this.Controls.Add(this.txtDiscountedFees);
            this.Controls.Add(this.lblChargesValue);
            this.Controls.Add(this.lblDiscountedFees);
            this.Controls.Add(this.lblCharges);
            this.Controls.Add(this.txtTreatmentReason);
            this.Controls.Add(this.lblTreatmentFor);
            this.Controls.Add(this.lblTreatment);
            this.Controls.Add(this.dgvTreatments);
            this.Controls.Add(this.lblPatientName);
            this.Controls.Add(this.cbPatientName);
            this.Controls.Add(this.lblSessionNumberValue);
            this.Controls.Add(this.lblSessionNumber);
            this.Name = "AddSessionForm";
            this.Text = "AddSessionForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTreatments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSessionNumber;
        private System.Windows.Forms.Label lblSessionNumberValue;
        private System.Windows.Forms.ComboBox cbPatientName;
        private System.Windows.Forms.Label lblPatientName;
        private System.Windows.Forms.DataGridView dgvTreatments;
        private System.Windows.Forms.Label lblTreatment;
        private System.Windows.Forms.Label lblTreatmentFor;
        private System.Windows.Forms.TextBox txtTreatmentReason;
        private System.Windows.Forms.Label lblCharges;
        private System.Windows.Forms.Label lblDiscountedFees;
        private System.Windows.Forms.Label lblChargesValue;
        private System.Windows.Forms.TextBox txtDiscountedFees;
        private System.Windows.Forms.Label lblRs;
        private System.Windows.Forms.TextBox txtAttendedBy;
        private System.Windows.Forms.Label lblAttendedBy;
        private System.Windows.Forms.DateTimePicker dtpReportingTime;
        private System.Windows.Forms.Label lblReportingTime;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Button btnCancel;
    }
}