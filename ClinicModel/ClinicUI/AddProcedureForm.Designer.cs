namespace ClinicUI
{
    partial class AddProcedureForm
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
            this.gbSessionDetails = new System.Windows.Forms.GroupBox();
            this.lblProcedureName = new System.Windows.Forms.Label();
            this.txtProcedureName = new System.Windows.Forms.TextBox();
            this.lblMachine = new System.Windows.Forms.Label();
            this.cbMachine = new System.Windows.Forms.ComboBox();
            this.lblPricePerSession = new System.Windows.Forms.Label();
            this.txtPricePerSession = new System.Windows.Forms.TextBox();
            this.lblTimePerSession = new System.Windows.Forms.Label();
            this.txtTimePerSession = new System.Windows.Forms.TextBox();
            this.lblMinutes = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbBasicDetails.SuspendLayout();
            this.gbSessionDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbBasicDetails
            // 
            this.gbBasicDetails.Controls.Add(this.cbMachine);
            this.gbBasicDetails.Controls.Add(this.lblMachine);
            this.gbBasicDetails.Controls.Add(this.txtProcedureName);
            this.gbBasicDetails.Controls.Add(this.lblProcedureName);
            this.gbBasicDetails.Location = new System.Drawing.Point(12, 12);
            this.gbBasicDetails.Name = "gbBasicDetails";
            this.gbBasicDetails.Size = new System.Drawing.Size(319, 100);
            this.gbBasicDetails.TabIndex = 0;
            this.gbBasicDetails.TabStop = false;
            this.gbBasicDetails.Text = "Basic details";
            // 
            // gbSessionDetails
            // 
            this.gbSessionDetails.Controls.Add(this.lblMinutes);
            this.gbSessionDetails.Controls.Add(this.lblPricePerSession);
            this.gbSessionDetails.Controls.Add(this.txtPricePerSession);
            this.gbSessionDetails.Controls.Add(this.lblTimePerSession);
            this.gbSessionDetails.Controls.Add(this.txtTimePerSession);
            this.gbSessionDetails.Location = new System.Drawing.Point(337, 12);
            this.gbSessionDetails.Name = "gbSessionDetails";
            this.gbSessionDetails.Size = new System.Drawing.Size(284, 100);
            this.gbSessionDetails.TabIndex = 1;
            this.gbSessionDetails.TabStop = false;
            this.gbSessionDetails.Text = "Session details";
            // 
            // lblProcedureName
            // 
            this.lblProcedureName.AutoSize = true;
            this.lblProcedureName.Location = new System.Drawing.Point(6, 26);
            this.lblProcedureName.Name = "lblProcedureName";
            this.lblProcedureName.Size = new System.Drawing.Size(85, 13);
            this.lblProcedureName.TabIndex = 0;
            this.lblProcedureName.Text = "Procedure name";
            // 
            // txtProcedureName
            // 
            this.txtProcedureName.Location = new System.Drawing.Point(122, 26);
            this.txtProcedureName.Name = "txtProcedureName";
            this.txtProcedureName.Size = new System.Drawing.Size(182, 20);
            this.txtProcedureName.TabIndex = 1;
            // 
            // lblMachine
            // 
            this.lblMachine.AutoSize = true;
            this.lblMachine.Location = new System.Drawing.Point(9, 59);
            this.lblMachine.Name = "lblMachine";
            this.lblMachine.Size = new System.Drawing.Size(48, 13);
            this.lblMachine.TabIndex = 2;
            this.lblMachine.Text = "Machine";
            // 
            // cbMachine
            // 
            this.cbMachine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMachine.FormattingEnabled = true;
            this.cbMachine.Location = new System.Drawing.Point(122, 59);
            this.cbMachine.Name = "cbMachine";
            this.cbMachine.Size = new System.Drawing.Size(182, 21);
            this.cbMachine.TabIndex = 3;
            // 
            // lblPricePerSession
            // 
            this.lblPricePerSession.AutoSize = true;
            this.lblPricePerSession.Location = new System.Drawing.Point(6, 59);
            this.lblPricePerSession.Name = "lblPricePerSession";
            this.lblPricePerSession.Size = new System.Drawing.Size(87, 13);
            this.lblPricePerSession.TabIndex = 9;
            this.lblPricePerSession.Text = "Price per session";
            // 
            // txtPricePerSession
            // 
            this.txtPricePerSession.Location = new System.Drawing.Point(127, 60);
            this.txtPricePerSession.Name = "txtPricePerSession";
            this.txtPricePerSession.Size = new System.Drawing.Size(97, 20);
            this.txtPricePerSession.TabIndex = 10;
            // 
            // lblTimePerSession
            // 
            this.lblTimePerSession.AutoSize = true;
            this.lblTimePerSession.Location = new System.Drawing.Point(6, 26);
            this.lblTimePerSession.Name = "lblTimePerSession";
            this.lblTimePerSession.Size = new System.Drawing.Size(86, 13);
            this.lblTimePerSession.TabIndex = 7;
            this.lblTimePerSession.Text = "Time per session";
            // 
            // txtTimePerSession
            // 
            this.txtTimePerSession.Location = new System.Drawing.Point(127, 26);
            this.txtTimePerSession.Name = "txtTimePerSession";
            this.txtTimePerSession.Size = new System.Drawing.Size(97, 20);
            this.txtTimePerSession.TabIndex = 8;
            // 
            // lblMinutes
            // 
            this.lblMinutes.AutoSize = true;
            this.lblMinutes.Location = new System.Drawing.Point(230, 29);
            this.lblMinutes.Name = "lblMinutes";
            this.lblMinutes.Size = new System.Drawing.Size(44, 13);
            this.lblMinutes.TabIndex = 11;
            this.lblMinutes.Text = "Minutes";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(221, 119);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(95, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(346, 119);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(95, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AddProcedureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 154);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbSessionDetails);
            this.Controls.Add(this.gbBasicDetails);
            this.Name = "AddProcedureForm";
            this.Text = "Add procedure";
            this.gbBasicDetails.ResumeLayout(false);
            this.gbBasicDetails.PerformLayout();
            this.gbSessionDetails.ResumeLayout(false);
            this.gbSessionDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbBasicDetails;
        private System.Windows.Forms.ComboBox cbMachine;
        private System.Windows.Forms.Label lblMachine;
        private System.Windows.Forms.TextBox txtProcedureName;
        private System.Windows.Forms.Label lblProcedureName;
        private System.Windows.Forms.GroupBox gbSessionDetails;
        private System.Windows.Forms.Label lblMinutes;
        private System.Windows.Forms.Label lblPricePerSession;
        private System.Windows.Forms.TextBox txtPricePerSession;
        private System.Windows.Forms.Label lblTimePerSession;
        private System.Windows.Forms.TextBox txtTimePerSession;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}