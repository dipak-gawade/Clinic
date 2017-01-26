using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClinicBusinessLogic;

namespace ClinicUI
{
    public partial class AddProcedureForm : Form
    {
        ProceduresHandler m_ProceduresHandler = null;
        Operation m_operation = Operation.Show;

        public AddProcedureForm(ProceduresHandler proceduresHandler, Operation operation)
        {
            InitializeComponent();

            m_ProceduresHandler = proceduresHandler;
            m_operation = operation;

            cbMachine.Items.AddRange(m_ProceduresHandler.GetMachineNames().ToArray());

            HandleOperation();
        }

        private void HandleOperation()
        {
            if (m_operation == Operation.Edit || m_operation == Operation.Show)
            {
                txtPricePerSession.Text = m_ProceduresHandler.SelectedProcedure.PricePerSession.ToString();
                txtProcedureName.Text = m_ProceduresHandler.SelectedProcedure.Name;
                txtTimePerSession.Text = m_ProceduresHandler.SelectedProcedure.TimePerSession.ToString();
                cbMachine.SelectedItem = m_ProceduresHandler.SelectedProcedure.Machine.Name;
            }

            if (m_operation == Operation.Show)
            {
                txtTimePerSession.ReadOnly = txtProcedureName.ReadOnly = txtPricePerSession.ReadOnly = true;
                cbMachine.Enabled = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string errorOrigin = string.Empty;
            string errorMessage = string.Empty;

            m_ProceduresHandler.AddOrEditProcedure(m_operation == Operation.Add ? -1 : m_ProceduresHandler.SelectedProcedure.Id,
                txtProcedureName.Text,
                cbMachine.Text,
                Convert.ToInt32(txtPricePerSession.Text),
                Convert.ToInt32(txtTimePerSession.Text),
                out errorOrigin,
                out errorMessage);

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
