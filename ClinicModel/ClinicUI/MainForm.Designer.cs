namespace ClinicUI
{
    partial class MainForm
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
            this.tabControlWHole = new System.Windows.Forms.TabControl();
            this.tabCustomers = new System.Windows.Forms.TabPage();
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.rbListAll = new System.Windows.Forms.RadioButton();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtMobileNumber = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.rbMobileNumber = new System.Windows.Forms.RadioButton();
            this.rbLastName = new System.Windows.Forms.RadioButton();
            this.rbFirstName = new System.Windows.Forms.RadioButton();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridViewCustomers = new System.Windows.Forms.DataGridView();
            this.tabPageMachines = new System.Windows.Forms.TabPage();
            this.btnAddMachine = new System.Windows.Forms.Button();
            this.dataGridViewMachines = new System.Windows.Forms.DataGridView();
            this.tabProcedures = new System.Windows.Forms.TabPage();
            this.dataGridViewProcedures = new System.Windows.Forms.DataGridView();
            this.btnAddProcedure = new System.Windows.Forms.Button();
            this.tabControlWHole.SuspendLayout();
            this.tabCustomers.SuspendLayout();
            this.gbSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).BeginInit();
            this.tabPageMachines.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMachines)).BeginInit();
            this.tabProcedures.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProcedures)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlWHole
            // 
            this.tabControlWHole.Controls.Add(this.tabCustomers);
            this.tabControlWHole.Controls.Add(this.tabPageMachines);
            this.tabControlWHole.Controls.Add(this.tabProcedures);
            this.tabControlWHole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlWHole.Location = new System.Drawing.Point(0, 0);
            this.tabControlWHole.Name = "tabControlWHole";
            this.tabControlWHole.SelectedIndex = 0;
            this.tabControlWHole.Size = new System.Drawing.Size(699, 392);
            this.tabControlWHole.TabIndex = 0;
            // 
            // tabCustomers
            // 
            this.tabCustomers.Controls.Add(this.gbSearch);
            this.tabCustomers.Controls.Add(this.btnAdd);
            this.tabCustomers.Controls.Add(this.dataGridViewCustomers);
            this.tabCustomers.Location = new System.Drawing.Point(4, 22);
            this.tabCustomers.Name = "tabCustomers";
            this.tabCustomers.Padding = new System.Windows.Forms.Padding(3);
            this.tabCustomers.Size = new System.Drawing.Size(691, 366);
            this.tabCustomers.TabIndex = 1;
            this.tabCustomers.Text = "Customers";
            this.tabCustomers.UseVisualStyleBackColor = true;
            // 
            // gbSearch
            // 
            this.gbSearch.Controls.Add(this.rbListAll);
            this.gbSearch.Controls.Add(this.btnSearch);
            this.gbSearch.Controls.Add(this.txtMobileNumber);
            this.gbSearch.Controls.Add(this.txtLastName);
            this.gbSearch.Controls.Add(this.txtFirstName);
            this.gbSearch.Controls.Add(this.rbMobileNumber);
            this.gbSearch.Controls.Add(this.rbLastName);
            this.gbSearch.Controls.Add(this.rbFirstName);
            this.gbSearch.Location = new System.Drawing.Point(8, 6);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(675, 78);
            this.gbSearch.TabIndex = 3;
            this.gbSearch.TabStop = false;
            this.gbSearch.Text = "Search";
            // 
            // rbListAll
            // 
            this.rbListAll.AutoSize = true;
            this.rbListAll.Checked = true;
            this.rbListAll.Location = new System.Drawing.Point(6, 19);
            this.rbListAll.Name = "rbListAll";
            this.rbListAll.Size = new System.Drawing.Size(54, 17);
            this.rbListAll.TabIndex = 7;
            this.rbListAll.TabStop = true;
            this.rbListAll.Text = "List all";
            this.rbListAll.UseVisualStyleBackColor = true;
            this.rbListAll.CheckedChanged += new System.EventHandler(this.rbListAll_CheckedChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(579, 39);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtMobileNumber
            // 
            this.txtMobileNumber.Enabled = false;
            this.txtMobileNumber.Location = new System.Drawing.Point(456, 42);
            this.txtMobileNumber.Name = "txtMobileNumber";
            this.txtMobileNumber.Size = new System.Drawing.Size(111, 20);
            this.txtMobileNumber.TabIndex = 5;
            // 
            // txtLastName
            // 
            this.txtLastName.Enabled = false;
            this.txtLastName.Location = new System.Drawing.Point(301, 42);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(111, 20);
            this.txtLastName.TabIndex = 4;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Enabled = false;
            this.txtFirstName.Location = new System.Drawing.Point(139, 42);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(111, 20);
            this.txtFirstName.TabIndex = 3;
            // 
            // rbMobileNumber
            // 
            this.rbMobileNumber.AutoSize = true;
            this.rbMobileNumber.Location = new System.Drawing.Point(437, 19);
            this.rbMobileNumber.Name = "rbMobileNumber";
            this.rbMobileNumber.Size = new System.Drawing.Size(108, 17);
            this.rbMobileNumber.TabIndex = 2;
            this.rbMobileNumber.Text = "By mobile number";
            this.rbMobileNumber.UseVisualStyleBackColor = true;
            this.rbMobileNumber.CheckedChanged += new System.EventHandler(this.rbMobileNumber_CheckedChanged);
            // 
            // rbLastName
            // 
            this.rbLastName.AutoSize = true;
            this.rbLastName.Location = new System.Drawing.Point(281, 19);
            this.rbLastName.Name = "rbLastName";
            this.rbLastName.Size = new System.Drawing.Size(85, 17);
            this.rbLastName.TabIndex = 1;
            this.rbLastName.Text = "By last name";
            this.rbLastName.UseVisualStyleBackColor = true;
            this.rbLastName.CheckedChanged += new System.EventHandler(this.rbLastName_CheckedChanged);
            // 
            // rbFirstName
            // 
            this.rbFirstName.AutoSize = true;
            this.rbFirstName.Location = new System.Drawing.Point(120, 19);
            this.rbFirstName.Name = "rbFirstName";
            this.rbFirstName.Size = new System.Drawing.Size(85, 17);
            this.rbFirstName.TabIndex = 0;
            this.rbFirstName.Text = "By first name";
            this.rbFirstName.UseVisualStyleBackColor = true;
            this.rbFirstName.CheckedChanged += new System.EventHandler(this.rbFirstName_CheckedChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(246, 325);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(198, 32);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add Customer";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // dataGridViewCustomers
            // 
            this.dataGridViewCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomers.Location = new System.Drawing.Point(8, 90);
            this.dataGridViewCustomers.Name = "dataGridViewCustomers";
            this.dataGridViewCustomers.Size = new System.Drawing.Size(675, 221);
            this.dataGridViewCustomers.TabIndex = 1;
            // 
            // tabPageMachines
            // 
            this.tabPageMachines.Controls.Add(this.btnAddMachine);
            this.tabPageMachines.Controls.Add(this.dataGridViewMachines);
            this.tabPageMachines.Location = new System.Drawing.Point(4, 22);
            this.tabPageMachines.Name = "tabPageMachines";
            this.tabPageMachines.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMachines.Size = new System.Drawing.Size(691, 366);
            this.tabPageMachines.TabIndex = 0;
            this.tabPageMachines.Text = "Machines";
            this.tabPageMachines.UseVisualStyleBackColor = true;
            // 
            // btnAddMachine
            // 
            this.btnAddMachine.Location = new System.Drawing.Point(255, 315);
            this.btnAddMachine.Name = "btnAddMachine";
            this.btnAddMachine.Size = new System.Drawing.Size(198, 32);
            this.btnAddMachine.TabIndex = 1;
            this.btnAddMachine.Text = "Add Machine";
            this.btnAddMachine.UseVisualStyleBackColor = true;
            this.btnAddMachine.Click += new System.EventHandler(this.btnAddMachine_Click);
            // 
            // dataGridViewMachines
            // 
            this.dataGridViewMachines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMachines.Location = new System.Drawing.Point(8, 6);
            this.dataGridViewMachines.Name = "dataGridViewMachines";
            this.dataGridViewMachines.Size = new System.Drawing.Size(675, 303);
            this.dataGridViewMachines.TabIndex = 0;
            // 
            // tabProcedures
            // 
            this.tabProcedures.Controls.Add(this.btnAddProcedure);
            this.tabProcedures.Controls.Add(this.dataGridViewProcedures);
            this.tabProcedures.Location = new System.Drawing.Point(4, 22);
            this.tabProcedures.Name = "tabProcedures";
            this.tabProcedures.Size = new System.Drawing.Size(691, 366);
            this.tabProcedures.TabIndex = 2;
            this.tabProcedures.Text = "Procedures";
            this.tabProcedures.UseVisualStyleBackColor = true;
            // 
            // dataGridViewProcedures
            // 
            this.dataGridViewProcedures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProcedures.Location = new System.Drawing.Point(8, 8);
            this.dataGridViewProcedures.Name = "dataGridViewProcedures";
            this.dataGridViewProcedures.Size = new System.Drawing.Size(675, 303);
            this.dataGridViewProcedures.TabIndex = 1;
            // 
            // btnAddProcedure
            // 
            this.btnAddProcedure.Location = new System.Drawing.Point(246, 322);
            this.btnAddProcedure.Name = "btnAddProcedure";
            this.btnAddProcedure.Size = new System.Drawing.Size(198, 32);
            this.btnAddProcedure.TabIndex = 2;
            this.btnAddProcedure.Text = "Add Procedure";
            this.btnAddProcedure.UseVisualStyleBackColor = true;
            this.btnAddProcedure.Click += new System.EventHandler(this.btnAddProcedure_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 392);
            this.Controls.Add(this.tabControlWHole);
            this.Name = "MainForm";
            this.Text = "Clinic";
            this.tabControlWHole.ResumeLayout(false);
            this.tabCustomers.ResumeLayout(false);
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).EndInit();
            this.tabPageMachines.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMachines)).EndInit();
            this.tabProcedures.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProcedures)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlWHole;
        private System.Windows.Forms.TabPage tabPageMachines;
        private System.Windows.Forms.TabPage tabCustomers;
        private System.Windows.Forms.Button btnAddMachine;
        private System.Windows.Forms.DataGridView dataGridViewMachines;
        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dataGridViewCustomers;
        private System.Windows.Forms.TextBox txtMobileNumber;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.RadioButton rbMobileNumber;
        private System.Windows.Forms.RadioButton rbLastName;
        private System.Windows.Forms.RadioButton rbFirstName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.RadioButton rbListAll;
        private System.Windows.Forms.TabPage tabProcedures;
        private System.Windows.Forms.Button btnAddProcedure;
        private System.Windows.Forms.DataGridView dataGridViewProcedures;
    }
}

