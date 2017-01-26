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
        public MainForm()
        {
            InitializeComponent();
            m_MachinesHandler = new MachinesHandler();
            m_MachinesHandler.MachinesUpdated += new EventHandler(m_MachinesHandler_MachinesUpdated);
            

            InitializeGrid();

            SetMachinesGridDisplayColumns();
            UpdateDataSource();
        }

        #region Private methods

        private void InitializeGrid()
        {
            dataGridViewMachines.AutoGenerateColumns = false;
            dataGridViewMachines.AllowUserToAddRows = false;
            dataGridViewMachines.AllowUserToDeleteRows = false;
            dataGridViewMachines.AllowUserToOrderColumns = false; 
            dataGridViewMachines.MultiSelect = false;
            dataGridViewMachines.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dataGridViewMachines.SelectionChanged += new EventHandler(dataGridViewMachines_SelectionChanged);
            dataGridViewMachines.CellMouseDown += new DataGridViewCellMouseEventHandler(dataGridViewMachines_CellMouseDown);
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

        }

        private void UpdateDataSource()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = m_MachinesHandler.Machines;
            dataGridViewMachines.DataSource = bs;
            dataGridViewMachines.Refresh();
        }

        #endregion

        #region Event Handlers

        private void dataGridViewMachines_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                if (e.ColumnIndex > -1 && e.RowIndex > -1)
                {
                    dataGridViewMachines.CurrentCell = dataGridViewMachines.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    ContextMenu contextMenu = new System.Windows.Forms.ContextMenu();
                    MenuItem editToolStrip = new MenuItem();
                    editToolStrip.Text = "Edit machine details";
                    editToolStrip.Click += new EventHandler(editToolStrip_Click);
                    contextMenu.MenuItems.Add(editToolStrip);

                    MenuItem showToolStrip = new MenuItem();
                    showToolStrip.Text = "Show all details";
                    showToolStrip.Click += new EventHandler(showToolStrip_Click);
                    contextMenu.MenuItems.Add(showToolStrip);

                    MenuItem deleteToolStrip = new MenuItem();
                    deleteToolStrip.Text = "Remove machine";
                    deleteToolStrip.Click += new EventHandler(deleteToolStrip_Click);
                    contextMenu.MenuItems.Add(deleteToolStrip);

                    contextMenu.Show(dataGridViewMachines, new Point(e.RowIndex, e.ColumnIndex));
                }
            }
        }

        private void deleteToolStrip_Click(object sender, EventArgs e)
        {
            DialogResult dlgResult = MessageBox.Show("Do you want to remove the selected machine?", "Remove machine",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (dlgResult == System.Windows.Forms.DialogResult.OK)
            {
                m_MachinesHandler.RemoveMachine();
                dataGridViewMachines.ClearSelection();
            }
        }

        private void showToolStrip_Click(object sender, EventArgs e)
        {
            AddMachineForm addForm = new AddMachineForm(m_MachinesHandler, Operation.Show);
            addForm.ShowDialog();
        }

        private void dataGridViewMachines_SelectionChanged(object sender, EventArgs e)
        {
            if ((sender as DataGridView).SelectedRows.Count > 0)
            {
                m_MachinesHandler.SelectMachine((sender as DataGridView).SelectedRows[0].DataBoundItem as Machine);
            }
        }

        private void editToolStrip_Click(object sender, EventArgs e)
        {
            AddMachineForm addForm = new AddMachineForm(m_MachinesHandler, Operation.Edit);
            addForm.ShowDialog();
        }

        private void m_MachinesHandler_MachinesUpdated(object sender, EventArgs e)
        {
            UpdateDataSource();
        }

        private void btnAddMachine_Click(object sender, EventArgs e)
        {
            AddMachineForm addForm = new AddMachineForm(m_MachinesHandler, Operation.Add);
            addForm.ShowDialog();
        }

        #endregion
    }
}
