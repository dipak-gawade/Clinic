using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClinicBusinessLogic;
using ClinicModel;

namespace ClinicUI
{
    public partial class MainForm : Form
    {
        private MachinesHandler m_MachinesHandler;
        private CustomersHandler m_CustomersHandler;
        private ProceduresHandler m_ProcedureHandler;

        public MainForm()
        {
            InitializeComponent();
            m_MachinesHandler = new MachinesHandler();

            m_CustomersHandler = new CustomersHandler();

            m_ProcedureHandler = new ProceduresHandler(m_MachinesHandler);

            InitializeGrid();

            SetMachinesGridDisplayColumns();
            SetCustomersGridDisplayColumns();
            SetProceduresGridDisplayColumns();

            UpdateMachineDataSource();
            UpdateCustomerDataSource();
            UpdateProcedureDataSource();

            dataGridViewProcedures.CellFormatting += new DataGridViewCellFormattingEventHandler(dataGridViewProcedures_CellFormatting);
        }

        #region Private methods

        private System.Windows.Forms.ContextMenu GetContextMenuForMachinesGrid()
        {
            ContextMenu contextMenu = new System.Windows.Forms.ContextMenu();
            MenuItem editToolStrip = new MenuItem();
            editToolStrip.Text = "Edit machine details";
            editToolStrip.Click += new EventHandler(editToolStripForMachine_Click);
            contextMenu.MenuItems.Add(editToolStrip);

            MenuItem showToolStrip = new MenuItem();
            showToolStrip.Text = "Show all details";
            showToolStrip.Click += new EventHandler(showToolStripForMachine_Click);
            contextMenu.MenuItems.Add(showToolStrip);

            MenuItem deleteToolStrip = new MenuItem();
            deleteToolStrip.Text = "Remove machine";
            deleteToolStrip.Click += new EventHandler(deleteToolStripForMachine_Click);
            contextMenu.MenuItems.Add(deleteToolStrip);

            return contextMenu;
        }

        private System.Windows.Forms.ContextMenu GetContextMenuForCustomersGrid()
        {
            ContextMenu contextMenu = new System.Windows.Forms.ContextMenu();
            MenuItem editToolStrip = new MenuItem();
            editToolStrip.Text = "Edit customer details";
            editToolStrip.Click += new EventHandler(editToolStripForCustomer_Click);
            contextMenu.MenuItems.Add(editToolStrip);

            MenuItem showToolStrip = new MenuItem();
            showToolStrip.Text = "Show all details";
            showToolStrip.Click += new EventHandler(showToolStripForCustomer_Click);
            contextMenu.MenuItems.Add(showToolStrip);

            MenuItem deleteToolStrip = new MenuItem();
            deleteToolStrip.Text = "Remove customer";
            deleteToolStrip.Click += new EventHandler(deleteToolStripForCustomer_Click);
            contextMenu.MenuItems.Add(deleteToolStrip);

            return contextMenu;
        }

        private System.Windows.Forms.ContextMenu GetContextMenuFoProcedureGrid()
        {
            ContextMenu contextMenu = new System.Windows.Forms.ContextMenu();
            MenuItem editToolStrip = new MenuItem();
            editToolStrip.Text = "Edit procedure details";
            editToolStrip.Click += new EventHandler(editToolStripForProcedure_Click);
            contextMenu.MenuItems.Add(editToolStrip);

            MenuItem showToolStrip = new MenuItem();
            showToolStrip.Text = "Show all details";
            showToolStrip.Click += new EventHandler(showToolStripForProcedure_Click);
            contextMenu.MenuItems.Add(showToolStrip);

            MenuItem deleteToolStrip = new MenuItem();
            deleteToolStrip.Text = "Remove procedure";
            deleteToolStrip.Click += new EventHandler(deleteToolStripForProcedure_Click);
            contextMenu.MenuItems.Add(deleteToolStrip);

            return contextMenu;
        }

        private void InitializeGrid()
        {
            // Machines grid
            dataGridViewMachines.AutoGenerateColumns = false;
            dataGridViewMachines.AllowUserToAddRows = false;
            dataGridViewMachines.AllowUserToDeleteRows = false;
            dataGridViewMachines.AllowUserToOrderColumns = false; 
            dataGridViewMachines.MultiSelect = false;
            dataGridViewMachines.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dataGridViewMachines.SelectionChanged += new EventHandler(dataGridViewMachines_SelectionChanged);
            dataGridViewMachines.CellMouseDown += new DataGridViewCellMouseEventHandler(dataGridViewMachines_CellMouseDown);
            m_MachinesHandler.MachinesUpdated += new EventHandler(m_MachinesHandler_MachinesUpdated);

            // Customers grid
            dataGridViewCustomers.AutoGenerateColumns = false;
            dataGridViewCustomers.AllowUserToAddRows = false;
            dataGridViewCustomers.AllowUserToDeleteRows = false;
            dataGridViewCustomers.AllowUserToOrderColumns = false;
            dataGridViewCustomers.MultiSelect = false;

            dataGridViewCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCustomers.SelectionChanged += new EventHandler(dataGridViewCustomers_SelectionChanged);
            m_CustomersHandler.CustomersUpdated += new EventHandler(m_CustomersHandler_CustomersUpdated);
            dataGridViewCustomers.CellMouseDown += new DataGridViewCellMouseEventHandler(dataGridViewCustomers_CellMouseDown);

            // Procedure grid
            dataGridViewProcedures.AutoGenerateColumns = false;
            dataGridViewProcedures.AllowUserToAddRows = false;
            dataGridViewProcedures.AllowUserToDeleteRows = false;
            dataGridViewProcedures.AllowUserToOrderColumns = false;
            dataGridViewProcedures.MultiSelect = false;
            dataGridViewProcedures.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dataGridViewProcedures.SelectionChanged += new EventHandler(dataGridViewProcedures_SelectionChanged);
            dataGridViewProcedures.CellMouseDown += new DataGridViewCellMouseEventHandler(dataGridViewProcedures_CellMouseDown);
            m_ProcedureHandler.ProceduresUpdated += new EventHandler(m_ProcedureHandler_ProceduresUpdated);

        }

        private void SetMachinesGridDisplayColumns()
        {
            dataGridViewMachines.ColumnCount = 5;

            dataGridViewMachines.Columns[0].Name = "Name";
            dataGridViewMachines.Columns[0].HeaderText = "Name";
            dataGridViewMachines.Columns[0].DataPropertyName = "Name";
            dataGridViewMachines.Columns[0].ReadOnly = true;

            dataGridViewMachines.Columns[1].Name = "SerialNumber";
            dataGridViewMachines.Columns[1].HeaderText = "Serial number";
            dataGridViewMachines.Columns[1].DataPropertyName = "SerialNumber";
            dataGridViewMachines.Columns[1].ReadOnly = true;

            dataGridViewMachines.Columns[2].Name = "Purpose";
            dataGridViewMachines.Columns[2].HeaderText = "Purpose";
            dataGridViewMachines.Columns[2].DataPropertyName = "Purpose";
            dataGridViewMachines.Columns[2].ReadOnly = true;
            dataGridViewMachines.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridViewMachines.Columns[3].Name = "TimePerSession";
            dataGridViewMachines.Columns[3].HeaderText = "Time per session";
            dataGridViewMachines.Columns[3].DataPropertyName = "TimePerSessionInMinutes";
            dataGridViewMachines.Columns[3].ReadOnly = true;

            dataGridViewMachines.Columns[4].Name = "PricePerSession";
            dataGridViewMachines.Columns[4].HeaderText = "Price per session";
            dataGridViewMachines.Columns[4].DataPropertyName = "PerSessionPrice";
            dataGridViewMachines.Columns[4].ReadOnly = true;

            dataGridViewMachines.Columns.Add(new DataGridViewCheckBoxColumn());
            dataGridViewMachines.Columns[5].Name = "IsActive";
            dataGridViewMachines.Columns[5].HeaderText = "Active";
            dataGridViewMachines.Columns[5].DataPropertyName = "IsActive";
            dataGridViewMachines.Columns[5].ReadOnly = true;
        }

        private void SetCustomersGridDisplayColumns()
        {
            dataGridViewCustomers.ColumnCount = 5;

            dataGridViewCustomers.Columns[0].Name = "FirstName";
            dataGridViewCustomers.Columns[0].HeaderText = "First name";
            dataGridViewCustomers.Columns[0].DataPropertyName = "FirstName";
            dataGridViewCustomers.Columns[0].ReadOnly = true;

            dataGridViewCustomers.Columns[1].Name = "LastName";
            dataGridViewCustomers.Columns[1].HeaderText = "Last name";
            dataGridViewCustomers.Columns[1].DataPropertyName = "LastName";
            dataGridViewCustomers.Columns[1].ReadOnly = true;

            dataGridViewCustomers.Columns[2].Name = "MobileNumber";
            dataGridViewCustomers.Columns[2].HeaderText = "Mobile number";
            dataGridViewCustomers.Columns[2].DataPropertyName = "MobileNumber";
            dataGridViewCustomers.Columns[2].ReadOnly = true;

            dataGridViewCustomers.Columns[3].Name = "Gender";
            dataGridViewCustomers.Columns[3].HeaderText = "Gender";
            dataGridViewCustomers.Columns[3].DataPropertyName = "Gender";
            dataGridViewCustomers.Columns[3].ReadOnly = true;

            dataGridViewCustomers.Columns[4].Name = "ReasonToVisit";
            dataGridViewCustomers.Columns[4].HeaderText = "Initial reason to visit";
            dataGridViewCustomers.Columns[4].DataPropertyName = "ReasonToVisit";
            dataGridViewCustomers.Columns[4].ReadOnly = true;
            dataGridViewCustomers.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void SetProceduresGridDisplayColumns()
        {
            dataGridViewProcedures.ColumnCount = 4;

            dataGridViewProcedures.Columns[0].Name = "Name";
            dataGridViewProcedures.Columns[0].HeaderText = "Name";
            dataGridViewProcedures.Columns[0].DataPropertyName = "Name";
            dataGridViewProcedures.Columns[0].ReadOnly = true;
            dataGridViewProcedures.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridViewProcedures.Columns[1].Name = "MachineName";
            dataGridViewProcedures.Columns[1].HeaderText = "Machine";
            dataGridViewProcedures.Columns[1].DataPropertyName = "Machine";
            dataGridViewProcedures.Columns[1].ReadOnly = true;

            dataGridViewProcedures.Columns[2].Name = "PricePerSession";
            dataGridViewProcedures.Columns[2].HeaderText = "Price per session";
            dataGridViewProcedures.Columns[2].DataPropertyName = "PricePerSession";
            dataGridViewProcedures.Columns[2].ReadOnly = true;

            dataGridViewProcedures.Columns[3].Name = "TimePerSession";
            dataGridViewProcedures.Columns[3].HeaderText = "Time per session";
            dataGridViewProcedures.Columns[3].DataPropertyName = "TimePerSession";
            dataGridViewProcedures.Columns[3].ReadOnly = true;
        }

        private void UpdateMachineDataSource()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = m_MachinesHandler.Machines;
            dataGridViewMachines.DataSource = bs;
            dataGridViewMachines.Refresh();
        }

        private void UpdateCustomerDataSource()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = m_CustomersHandler.Customers;
            dataGridViewCustomers.DataSource = bs;
            dataGridViewCustomers.Refresh();
        }

        private void UpdateProcedureDataSource()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = m_ProcedureHandler.Procedures;
            dataGridViewProcedures.DataSource = bs;
            dataGridViewProcedures.Refresh();
        }

        private void BindToSelectedCustomer()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = m_CustomersHandler.SelectedCustomer;
            dataGridViewCustomers.DataSource = bs;
            dataGridViewCustomers.Refresh();
        }

        #endregion

        #region Event Handlers

        #region Machines Grid

        private void dataGridViewMachines_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                if (e.ColumnIndex > -1 && e.RowIndex > -1)
                {
                    dataGridViewMachines.CurrentCell = dataGridViewMachines.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    ContextMenu contextMenu = GetContextMenuForMachinesGrid();
                    contextMenu.Show(dataGridViewMachines, new Point(e.RowIndex, e.ColumnIndex));
                }
            }
        }

        private void deleteToolStripForMachine_Click(object sender, EventArgs e)
        {
            DialogResult dlgResult = MessageBox.Show("Do you want to remove the selected machine?", "Remove machine",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (dlgResult == System.Windows.Forms.DialogResult.OK)
            {
                dataGridViewMachines.ClearSelection();
                m_MachinesHandler.RemoveMachine();
            }
        }

        private void showToolStripForMachine_Click(object sender, EventArgs e)
        {
            AddMachineForm addForm = new AddMachineForm(m_MachinesHandler, Operation.Show);
            addForm.ShowDialog();
        }

        private void editToolStripForMachine_Click(object sender, EventArgs e)
        {
            AddMachineForm addForm = new AddMachineForm(m_MachinesHandler, Operation.Edit);
            addForm.ShowDialog();
        }

        private void m_MachinesHandler_MachinesUpdated(object sender, EventArgs e)
        {
            UpdateMachineDataSource();
        }

        private void btnAddMachine_Click(object sender, EventArgs e)
        {
            AddMachineForm addForm = new AddMachineForm(m_MachinesHandler, Operation.Add);
            addForm.ShowDialog();
        }

        private void dataGridViewMachines_SelectionChanged(object sender, EventArgs e)
        {
            if ((sender as DataGridView).SelectedRows.Count > 0)
            {
                m_MachinesHandler.SelectMachine((sender as DataGridView).SelectedRows[0].DataBoundItem as Machine);
            }
        }

        #endregion

        #region Customers Grid

        private void dataGridViewCustomers_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                if (e.ColumnIndex > -1 && e.RowIndex > -1)
                {
                    dataGridViewCustomers.CurrentCell = dataGridViewCustomers.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    ContextMenu contextMenu = GetContextMenuForCustomersGrid();
                    contextMenu.Show(dataGridViewCustomers, new Point(e.RowIndex, e.ColumnIndex));
                }
            }
        }

        private void deleteToolStripForCustomer_Click(object sender, EventArgs e)
        {
            DialogResult dlgResult = MessageBox.Show("Do you want to remove the selected customer?", "Remove customer",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (dlgResult == System.Windows.Forms.DialogResult.OK)
            {
                dataGridViewCustomers.ClearSelection();
                m_CustomersHandler.RemoveCustomer();
            }
        }

        private void showToolStripForCustomer_Click(object sender, EventArgs e)
        {
            AddCustomerForm addForm = new AddCustomerForm(m_CustomersHandler, Operation.Show);
            addForm.ShowDialog();
        }

        private void editToolStripForCustomer_Click(object sender, EventArgs e)
        {
            AddCustomerForm addForm = new AddCustomerForm(m_CustomersHandler, Operation.Edit);
            addForm.ShowDialog();
        }

        private void m_CustomersHandler_CustomersUpdated(object sender, EventArgs e)
        {
            UpdateCustomerDataSource();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            AddCustomerForm addForm = new AddCustomerForm(m_CustomersHandler, Operation.Add);
            if (addForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                UpdateCustomerDataSource();
            }
        }

        private void dataGridViewCustomers_SelectionChanged(object sender, EventArgs e)
        {
            if ((sender as DataGridView).SelectedRows.Count > 0)
            {
                m_CustomersHandler.SelectCustomer((sender as DataGridView).SelectedRows[0].DataBoundItem as Customer);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<Customer> customers = null;
            if (rbFirstName.Checked)
            {
                customers = m_CustomersHandler.GetCustomersByFirstName(txtFirstName.Text);
            }
            else if (rbLastName.Checked)
            {
                customers = m_CustomersHandler.GetCustomersByLastName(txtLastName.Text);
            }
            else
            {
                customers = m_CustomersHandler.GetCustomersByPhoneNumber(txtMobileNumber.Text);
            }

            if (customers != null && customers.Count > 0)
            {
                BindingSource bs = new BindingSource();
                bs.DataSource = customers;
                dataGridViewCustomers.DataSource = bs;
                dataGridViewCustomers.Refresh();
            }
            else
            {
                DialogResult dlgResult = MessageBox.Show("No records found!!", "Search operation",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rbFirstName_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFirstName.Checked)
            {
                rbLastName.Checked = false;
                rbListAll.Checked = false;
                rbMobileNumber.Checked = false;

                txtFirstName.Enabled = true;
            }
            else
            {
                txtFirstName.Enabled = false;
                txtFirstName.Clear();
            }
        }

        private void rbLastName_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLastName.Checked)
            {
                rbFirstName.Checked = false;
                rbListAll.Checked = false;
                rbMobileNumber.Checked = false;

                txtLastName.Enabled = true;
            }
            else
            {
                txtLastName.Enabled = false;
                txtLastName.Clear();
            }
        }

        private void rbMobileNumber_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMobileNumber.Checked)
            {
                rbLastName.Checked = false;
                rbListAll.Checked = false;
                rbFirstName.Checked = false;

                txtMobileNumber.Enabled = true;
            }
            else
            {
                txtMobileNumber.Enabled = false;
                txtMobileNumber.Clear();
            }
        }

        private void rbListAll_CheckedChanged(object sender, EventArgs e)
        {
            if (rbListAll.Checked)
            {
                rbLastName.Checked = false;
                rbMobileNumber.Checked = false;
                rbFirstName.Checked = false;

                UpdateCustomerDataSource();
            }
        }

        #endregion

        #region Procedure grid 

        private void btnAddProcedure_Click(object sender, EventArgs e)
        {
            AddProcedureForm procedureForm = new AddProcedureForm(m_ProcedureHandler, Operation.Add);
            procedureForm.ShowDialog();
        }

        private void deleteToolStripForProcedure_Click(object sender, EventArgs e)
        {
            DialogResult dlgResult = MessageBox.Show("Do you want to remove the selected procedure?", "Remove procedure",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (dlgResult == System.Windows.Forms.DialogResult.OK)
            {
                dataGridViewProcedures.ClearSelection();
                m_ProcedureHandler.RemoveProcedure();
            }
        }

        private void showToolStripForProcedure_Click(object sender, EventArgs e)
        {
            AddProcedureForm addForm = new AddProcedureForm(m_ProcedureHandler, Operation.Show);
            addForm.ShowDialog();
        }

        private void editToolStripForProcedure_Click(object sender, EventArgs e)
        {
            AddProcedureForm addForm = new AddProcedureForm(m_ProcedureHandler, Operation.Edit);
            addForm.ShowDialog();
        }

        private void m_ProcedureHandler_ProceduresUpdated(object sender, EventArgs e)
        {
            UpdateProcedureDataSource();
        }

        private void dataGridViewProcedures_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                if (e.ColumnIndex > -1 && e.RowIndex > -1)
                {
                    dataGridViewProcedures.CurrentCell = dataGridViewProcedures.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    ContextMenu contextMenu = GetContextMenuFoProcedureGrid();
                    contextMenu.Show(dataGridViewProcedures, new Point(e.RowIndex, e.ColumnIndex));
                }
            }
        }

        private void dataGridViewProcedures_SelectionChanged(object sender, EventArgs e)
        {
            if ((sender as DataGridView).SelectedRows.Count > 0)
            {
                m_ProcedureHandler.SelectProcedure((sender as DataGridView).SelectedRows[0].DataBoundItem as Procedure);
            }
        }

        private void dataGridViewProcedures_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridViewProcedures.Rows[e.RowIndex].DataBoundItem != null
                && dataGridViewProcedures.Columns[e.ColumnIndex].DataPropertyName.Equals("Machine"))
            {
                e.Value = (dataGridViewProcedures.Rows[e.RowIndex].DataBoundItem as Procedure).Machine.Name;
            }
        }

        #endregion

        #endregion
    }
}
