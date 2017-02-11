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
    public partial class AddDoctorForm : Form
    {
        private DoctorsHandler m_DoctorsHandler;

        private Operation m_Operation;

        public AddDoctorForm(DoctorsHandler doctorsHandler, Operation operation)
        {
            InitializeComponent();

            m_DoctorsHandler = doctorsHandler;
            m_Operation = operation;
            HandleOperation();
        }

        private void HandleOperation()
        {
            if (m_Operation == Operation.Edit || m_Operation == Operation.Show)
            {
                txtAdditionalDetails.Text = m_DoctorsHandler.SelectedDoctor.AdditionalDetails;
                txtFirstName.Text = m_DoctorsHandler.SelectedDoctor.FirstName;
                txtLastName.Text = m_DoctorsHandler.SelectedDoctor.LastName;
                txtSpecialistIn.Text = m_DoctorsHandler.SelectedDoctor.SpecialistIn;
                txtAddress.Text = m_DoctorsHandler.SelectedDoctor.Address;
                txtMobileNumber.Text = m_DoctorsHandler.SelectedDoctor.MobileNumber;
            }

            if (m_Operation == Operation.Show)
            {
                txtAddress.ReadOnly = txtAdditionalDetails.ReadOnly = txtFirstName.ReadOnly =
                    txtLastName.ReadOnly = txtMobileNumber.ReadOnly = txtSpecialistIn.ReadOnly = true;

                btnSave.Enabled = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string errorOrigin = string.Empty;
            string errorMessage = string.Empty;

            m_DoctorsHandler.AddOrEditDoctors(m_Operation == Operation.Add ? -1 : m_DoctorsHandler.SelectedDoctor.Id,
                txtFirstName.Text,
                txtLastName.Text,
                txtMobileNumber.Text,
                txtAddress.Text,
                txtSpecialistIn.Text,
                txtAdditionalDetails.Text,
                out errorOrigin,
                out errorMessage);

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }
    }
}
