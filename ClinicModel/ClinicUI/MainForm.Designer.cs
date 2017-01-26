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
            this.tabPageMachines = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridViewMachines = new System.Windows.Forms.DataGridView();
            this.btnAddMachine = new System.Windows.Forms.Button();
            this.tabControlWHole.SuspendLayout();
            this.tabPageMachines.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMachines)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlWHole
            // 
            this.tabControlWHole.Controls.Add(this.tabPageMachines);
            this.tabControlWHole.Controls.Add(this.tabPage2);
            this.tabControlWHole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlWHole.Location = new System.Drawing.Point(0, 0);
            this.tabControlWHole.Name = "tabControlWHole";
            this.tabControlWHole.SelectedIndex = 0;
            this.tabControlWHole.Size = new System.Drawing.Size(699, 392);
            this.tabControlWHole.TabIndex = 0;
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
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(691, 366);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewMachines
            // 
            this.dataGridViewMachines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMachines.Location = new System.Drawing.Point(8, 6);
            this.dataGridViewMachines.Name = "dataGridViewMachines";
            this.dataGridViewMachines.Size = new System.Drawing.Size(675, 303);
            this.dataGridViewMachines.TabIndex = 0;
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 392);
            this.Controls.Add(this.tabControlWHole);
            this.Name = "MainForm";
            this.Text = "Clinic";
            this.tabControlWHole.ResumeLayout(false);
            this.tabPageMachines.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMachines)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlWHole;
        private System.Windows.Forms.TabPage tabPageMachines;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnAddMachine;
        private System.Windows.Forms.DataGridView dataGridViewMachines;
    }
}

