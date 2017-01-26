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
    public partial class AddCustomerForm : Form
    {
        private CustomersHandler m_CustomersHandler;
        private Operation m_Operation = Operation.Show;

        public AddCustomerForm(CustomersHandler customersHandler, Operation operation)
        {
            InitializeComponent();
            m_CustomersHandler = customersHandler;
            m_Operation = operation;

            HandleOperation();
        }

        #region Private methods 

        private void HandleOperation()
        {
            if (m_Operation == Operation.Edit || m_Operation == Operation.Show)
            {
                txtFirstName.Text = m_CustomersHandler.SelectedCustomer.FirstName;
                txtLastName.Text = m_CustomersHandler.SelectedCustomer.LastName;
                txtReferredBy.Text = m_CustomersHandler.SelectedCustomer.ReferredBy;
                txtMobileNumber.Text = m_CustomersHandler.SelectedCustomer.MobileNumber;
                txtReasonToVisit.Text = m_CustomersHandler.SelectedCustomer.ReasonToVisit;
                txtAdditionalDetails.Text = m_CustomersHandler.SelectedCustomer.AdditionalDetails;
                txtEmailAddress.Text = m_CustomersHandler.SelectedCustomer.EmailAddress;
                txtAddress.Text = m_CustomersHandler.SelectedCustomer.Address;
                dateTimePickerBirthDate.Value = m_CustomersHandler.SelectedCustomer.BirthDate;
            }

            if (m_Operation == Operation.Show)
            {
                btnSave.Visible = false;
                txtFirstName.ReadOnly = txtLastName.ReadOnly = txtReferredBy.ReadOnly = txtMobileNumber.ReadOnly =
                    txtReasonToVisit.ReadOnly = txtAdditionalDetails.ReadOnly = txtEmailAddress.ReadOnly = txtAddress.ReadOnly = true;

                dateTimePickerBirthDate.Enabled = false;
            }
        }

        #endregion

        #region Event Handlers

        private void btnSave_Click(object sender, EventArgs e)
        {
            string errorOrigin = string.Empty;
            string errorMessage = string.Empty;
            m_CustomersHandler.AddOrEditCustomer(txtMobileNumber.Text,
                txtFirstName.Text,
                txtLastName.Text,
                txtReferredBy.Text,
                txtReasonToVisit.Text,
                txtEmailAddress.Text,
                Convert.ToDateTime(dateTimePickerBirthDate.Value),
                txtAddress.Text,
                txtAdditionalDetails.Text,
                cbGender.Text == "Female"? Gender.Female:Gender.Male,
                out errorOrigin,
                out errorMessage);

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
    }
}
