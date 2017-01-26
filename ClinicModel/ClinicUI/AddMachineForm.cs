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
    public partial class AddMachineForm : Form
    {
        private MachinesHandler m_MachinesHandler;
        private Operation m_Operation = Operation.Show;

        public AddMachineForm(MachinesHandler machinesHandler, Operation operation)
        {
            InitializeComponent();
            m_MachinesHandler = machinesHandler;
            m_Operation = operation;

            HandleOperation();
        }

        #region Private methods 

        private void HandleOperation()
        {
            if (m_Operation == Operation.Edit || m_Operation == Operation.Show)
            {
                txtSerialNumber.Text = m_MachinesHandler.SelectedMachine.SerialNumber;
                txtShortName.Text = m_MachinesHandler.SelectedMachine.ShortName;
                txtName.Text = m_MachinesHandler.SelectedMachine.Name;
                txtMake.Text = m_MachinesHandler.SelectedMachine.Make;
                txtPurpose.Text = m_MachinesHandler.SelectedMachine.Purpose;
                txtAdditionalDetails.Text = m_MachinesHandler.SelectedMachine.Comments;
                txtPrice.Text = m_MachinesHandler.SelectedMachine.Price.ToString();
                dateTimePickerPurchaseDate.Value = m_MachinesHandler.SelectedMachine.PurchaseDate;
                txtImagePath.Text = m_MachinesHandler.SelectedMachine.ImagePath;
                cbActive.Checked = m_MachinesHandler.SelectedMachine.IsActive;
            }

            if (m_Operation == Operation.Show)
            {
                btnSave.Visible = false;
                txtSerialNumber.ReadOnly = txtShortName.ReadOnly = txtName.ReadOnly = txtMake.ReadOnly =
                    txtPurpose.ReadOnly = txtAdditionalDetails.ReadOnly = txtPrice.ReadOnly = txtImagePath.ReadOnly = true;

                dateTimePickerPurchaseDate.Enabled = false;
                cbActive.Enabled = false;
            }
        }

        #endregion

        #region Event Handlers

        private void btnSave_Click(object sender, EventArgs e)
        {
            string errorOrigin = string.Empty;
            string errorMessage = string.Empty;
            m_MachinesHandler.AddOrEditMachine(txtSerialNumber.Text,
                txtShortName.Text,
                txtName.Text,
                txtMake.Text,
                txtPurpose.Text,
                txtAdditionalDetails.Text,
                Convert.ToInt32(txtPrice.Text),
                Convert.ToDateTime(dateTimePickerPurchaseDate.Value),
                txtImagePath.Text,
                cbActive.Checked,
                out errorOrigin,
                out errorMessage);

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDlg = new OpenFileDialog();
            openFileDlg.Multiselect = false;
            DialogResult result = openFileDlg.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                string filePath = openFileDlg.FileName;
                txtImagePath.Text = filePath;
            }
        }

        #endregion
    }

    /// <summary>
    /// Enumeration states that which operation is selected
    /// Add - To add new machine
    /// Show - Readonly display of all information
    /// Edit - Editable display of information
    /// </summary>
    public enum Operation
    {
        Show = 0,
        Add,
        Edit
    }
}
