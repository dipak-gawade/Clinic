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

        public CustomersHandler()
        {
            using (var db = new ClinicModelContext())
            {
                m_Customers = db.Customers.ToList<Customer>(); 
            }
        }

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

        public bool AddOrEditCustomer(int id, string mobileNumber, string firstName,
            string lastName, string referredBy, string reasonToVisit, string emailAddress,
            DateTime birthDate, string address, string additionalDetails, Gender gender, out string errorOrigin, out string errorMessage)
        {
            errorMessage = null;
            errorOrigin = null;

            var newCustomer = (id == -1) ? new Customer(GetIdForNewCustomer()) : m_SelectedCustomer;
            if (id == -1)
            {
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


            using (var db = new ClinicModelContext())
            {
                if (id == -1)
                {
                    m_Customers.Add(newCustomer);
                    db.Customers.Add(newCustomer);
                }
                else
                {
                    var existing = db.Customers.Find(id);
                    existing = newCustomer;
                    db.Entry(existing).State = System.Data.Entity.EntityState.Modified;
                }

                db.SaveChanges();
            }

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

        public Customer GetCustomersById(int id)
        {
            return m_Customers.Find(x => x.Id == id);
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

        private int GetIdForNewCustomer()
        {
            int id = 1; 
            if (m_Customers.Count > 0)
            {
                id = m_Customers[m_Customers.Count - 1].Id + 1;
            }

            return id;
        }

        #endregion
    }
}
