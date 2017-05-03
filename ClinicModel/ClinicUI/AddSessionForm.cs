using ClinicBusinessLogic;
using ClinicModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClinicUI
{
    public partial class AddSessionForm : Form
    {
        SessionsHandler m_sessionsHandler = null;
        Operation m_operation = Operation.Show;

        public AddSessionForm(SessionsHandler sessionsHandler, Operation operation)
        {
            InitializeComponent();

            m_sessionsHandler = sessionsHandler;
            m_operation = operation;

            PopulateCustomerComboBox();

            SetupGrid();

            if (m_sessionsHandler.SelectedSession != null)
            {
                UpdateTreatmentDataSource();

                txtAttendedBy.Text = m_sessionsHandler.SelectedSession.AttendedBy;
                txtDiscountedFees.Text = m_sessionsHandler.SelectedSession.DiscountedFees.ToString();
                txtTreatmentReason.Text = m_sessionsHandler.SelectedSession.PatientComplaint;
                lblChargesValue.Text = m_sessionsHandler.SelectedSession.ChargesIncured.ToString();
            }
        }

        private void SetupGrid()
        {
            // Customers grid
            dgvTreatments.AutoGenerateColumns = false;
            dgvTreatments.AllowUserToAddRows = true;
            dgvTreatments.AllowUserToDeleteRows = true;
            dgvTreatments.AllowUserToOrderColumns = false;
            dgvTreatments.MultiSelect = false;

            dgvTreatments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTreatments.SelectionChanged += new EventHandler(dgvTreatments_SelectionChanged);
            dgvTreatments.UserDeletedRow += dgvTreatments_UserDeletedRow;

            SetCustomersGridDisplayColumns();
            UpdateTreatmentDataSource();

            dgvTreatments.CurrentCellDirtyStateChanged += dgvTreatments_CurrentCellDirtyStateChanged;
            dgvTreatments.CellValueChanged += dgvTreatments_CellValueChanged;
        }

        void dgvTreatments_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            UpdateValuesAsPerNewChange();
        }

        void dgvTreatments_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            UpdateValuesAsPerNewChange();
        }

        private void UpdateValuesAsPerNewChange()
        {
            List<string> allTreatments = new List<string>();
            foreach (DataGridViewRow row in dgvTreatments.Rows)
            {
                DataGridViewComboBoxCell cell = row.Cells[0] as DataGridViewComboBoxCell;
                if (cell.Value != null)
                {
                    int price, time;
                    m_sessionsHandler.GetTreatmentChargeAndTime(Convert.ToString(cell.Value), out price, out time);
                    row.Cells[1].Value = time;
                    row.Cells[2].Value = price;

                    allTreatments.Add(Convert.ToString(cell.Value));
                }
            }

            lblChargesValue.Text = txtDiscountedFees.Text = Convert.ToString(m_sessionsHandler.GetTreatmentCharges(allTreatments));
        }

        private void UpdateOtherControls()
        {
            lblChargesValue.Text = m_sessionsHandler.SelectedSession.ChargesIncured.ToString();
        }

        private void dgvTreatments_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if(dgvTreatments.IsCurrentCellDirty)
            {
                dgvTreatments.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dgvTreatments_SelectionChanged(object sender, EventArgs e)
        {
            if ((sender as DataGridView).SelectedRows.Count > 0)
            {
                m_sessionsHandler.SelectSession((sender as DataGridView).SelectedRows[0].DataBoundItem as Session);
            }
        }

        private void PopulateCustomerComboBox()
        {
            cbPatientName.Items.AddRange(m_sessionsHandler.GetAllCustomerNames().ToArray());
        }

        private void UpdateTreatmentDataSource()
        {
            if (m_sessionsHandler.SelectedSession != null)
            {
                BindingSource bs = new BindingSource();
                bs.DataSource = m_sessionsHandler.SelectedSession.Procedures;
                dgvTreatments.DataSource = bs;
                dgvTreatments.Refresh();
            }
        }

        private void SetCustomersGridDisplayColumns()
        {
            DataGridViewComboBoxColumn cb = new DataGridViewComboBoxColumn();
            cb.DataSource = m_sessionsHandler.GetProcedureNames();
            dgvTreatments.Columns.Add(cb);
            dgvTreatments.Columns[0].Name = "Treatment";
            dgvTreatments.Columns[0].HeaderText = "Treatment";
            dgvTreatments.Columns[0].DataPropertyName = "Name";
            dgvTreatments.Columns[0].ReadOnly = false;
            dgvTreatments.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvTreatments.ColumnCount = 3;
            dgvTreatments.Columns[1].Name = "TreatmentTime";
            dgvTreatments.Columns[1].HeaderText = "Time";
            dgvTreatments.Columns[1].DataPropertyName = "TimePerSession";
            dgvTreatments.Columns[1].ReadOnly = true;

            dgvTreatments.Columns[2].Name = "TreatmentCost";
            dgvTreatments.Columns[2].HeaderText = "Cost";
            dgvTreatments.Columns[2].DataPropertyName = "PricePerSession";
            dgvTreatments.Columns[2].ReadOnly = true;
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            string errorOrigin = string.Empty;
            string errorMessage = string.Empty;

            m_sessionsHandler.AddOrEditSession(m_operation == Operation.Add ? -1 : m_sessionsHandler.SelectedSession.Id,
                Convert.ToString(cbPatientName.SelectedItem), txtTreatmentReason.Text,
                dtpReportingTime.Value, Convert.ToInt32(txtDiscountedFees.Text), txtAttendedBy.Text,
                out errorOrigin,
                out errorMessage);

            m_sessionsHandler.ClearProcedures();
            int rowIndex = 0;
            foreach(DataGridViewRow row in dgvTreatments.Rows)
            {
                m_sessionsHandler.AddOrEditSessionProceduresToSession(rowIndex, Convert.ToString(row.Cells[0].Value),
                    out errorOrigin, out errorMessage);
                rowIndex++;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
