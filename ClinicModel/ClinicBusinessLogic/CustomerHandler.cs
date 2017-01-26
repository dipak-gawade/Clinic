using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClinicModel;

namespace ClinicBusinessLogic
{
    public class CustomersHandler
    {
        #region Private variables

        private List<Customer> m_Customers = new List<Customer>();

        private Customer m_SelectedCustomer = null;

        #endregion

        #region Properties

        public List<Customer> Customers { get { return m_Customers; } }

        public event EventHandler CustomersUpdated;

        public Customer SelectedCustomer { get { return m_SelectedCustomer; } }

        #endregion

        #region Public methods

        public void SelectCustomer(Customer customerSelected)
        {
            m_SelectedCustomer = customerSelected;
        }

        public bool AddOrEditCustomer(string mobileNumber, string firstName,
            string lastName, string referredBy, string reasonToVisit, string emailAddress,
            DateTime birthDate, string address, string additionalDetails, Gender gender, out string errorOrigin, out string errorMessage)
        {
            errorMessage = null;
            errorOrigin = null;

            Customer newCustomer = GetCustomerByUniqueNameAndNumber(mobileNumber, firstName, lastName);
            if (newCustomer == null)
            {
                newCustomer = new Customer();
                m_Customers.Add(newCustomer);
            }

            newCustomer.MobileNumber = mobileNumber;
            newCustomer.FirstName = firstName;
            newCustomer.LastName = lastName;
            newCustomer.ReferredBy = referredBy;
            newCustomer.ReasonToVisit = reasonToVisit;
            newCustomer.EmailAddress = emailAddress;
            newCustomer.BirthDate = birthDate;
            newCustomer.Address = address;
            newCustomer.AdditionalDetails = additionalDetails;
            newCustomer.Gender = gender;

            this.m_SelectedCustomer = newCustomer;
            RaiseCustomersUpdatedEvent();

            return true;
        }

        public void RemoveCustomer()
        {
            m_Customers.Remove(m_SelectedCustomer);
            RaiseCustomersUpdatedEvent();
        }

        public List<Customer> GetCustomersByPhoneNumber(string mobileNumber)
        {
            return m_Customers.FindAll(x => x.MobileNumber == mobileNumber);
        }

        public List<Customer> GetCustomersByFirstName(string firstName)
        {
            return m_Customers.FindAll(x => x.FirstName == firstName);
        }

        public List<Customer> GetCustomersByLastName(string lastName)
        {
            return m_Customers.FindAll(x => x.LastName == lastName);
        }

        #endregion

        #region Private methods

        private void RaiseCustomersUpdatedEvent()
        {
            if (CustomersUpdated != null)
            {
                CustomersUpdated(this, null);
            }
        }

        private Customer GetCustomerByUniqueNameAndNumber(string mobileNumber, string firstName, string lastName)
        {
            Customer existingMachine = m_Customers.Find(x => (x.MobileNumber == mobileNumber)
                && (x.FirstName == firstName) && (x.LastName == lastName));
            return existingMachine;
        }

        #endregion
    }
}
