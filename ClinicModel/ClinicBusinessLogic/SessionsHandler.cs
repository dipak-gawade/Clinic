using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClinicModel;

namespace ClinicBusinessLogic
{
    public class SessionsHandler
    {
        private List<Session> m_Sessions = new List<Session>();
        private CustomersHandler m_CustomersHandler = null;
        private ProceduresHandler m_ProceduresHandler = null;
        private DoctorsHandler m_doctorsHandler = null;
        private Session m_SelectedSession;

        public Session SelectedSession { get { return m_SelectedSession; } }

        public event EventHandler SessionUpdated;

        public SessionsHandler(CustomersHandler customersHandler, ProceduresHandler proceduresHandler, 
            DoctorsHandler doctorsHandler)
        {
            m_ProceduresHandler = proceduresHandler;
            m_CustomersHandler = customersHandler;
            m_doctorsHandler = doctorsHandler;
            using (var db = new ClinicModelContext())
            {
                m_Sessions = db.Sessions.ToList(); 
            }
        }

        public List<Session> Sessions { get { return m_Sessions; } }

        public bool AddOrEditSession(long id, string customerName, string patientComplaint,
            DateTime reportTime, int discountedFees, string attendedBy, out string errorOrigin, out string errorMessage)
        {
            errorMessage = string.Empty;
            errorOrigin = string.Empty;

            Session newSession = GetSessionById(id);
            if (newSession == null)
            {
                if (Sessions.Count > 0)
                {
                    newSession = new Session(Sessions[Sessions.Count - 1].Id + 1);
                }
                else
                {
                    newSession = new Session(1);
                }

                Sessions.Add(newSession);
            }

            // newSession.Patient = m_CustomersHandler.GetCustomersByFullName(customerName);
            newSession.PatientComplaint = patientComplaint;
            newSession.ReportTime = reportTime;
            newSession.DiscountedFees = discountedFees;
            newSession.AttendedBy = attendedBy;

            m_SelectedSession = newSession;

            using (var db = new ClinicModelContext())
            {
                Customer connectedDatabaseCustomer = db.Customers.Find
                    (m_CustomersHandler.GetCustomersByFullName(customerName).Id);
                //db.Machines.Attach(connectedDatabaseMachine);
                newSession.Patient = connectedDatabaseCustomer;
                if (id == -1)
                {
                    db.Sessions.Add(newSession);
                }
                else
                {
                    var existing = db.Sessions.Find(id);
                    existing = newSession;
                    db.Entry(existing).State = System.Data.Entity.EntityState.Modified;
                }

                db.SaveChanges();
            }

            RaiseSessionUpdatedEvent();

            return true;
        }

        private void RaiseSessionUpdatedEvent()
        {
            if(SessionUpdated != null)
            {
                SessionUpdated(this, null);
            }
        }

        public List<string> GetProcedureNames()
        {
            return m_ProceduresHandler.GetProcedureNames();
        }

        public void SelectSession(Session session)
        {
            m_SelectedSession = session;
        }

        public void RemoveSession()
        {
            m_Sessions.Remove(m_SelectedSession);
            using (var db = new ClinicModelContext())
            {
                var existing = db.Sessions.Find(m_SelectedSession.Id);
                db.Entry(existing).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
            }

            RaiseSessionUpdatedEvent();
        }

        public void ClearProcedures()
        {
            m_SelectedSession.ClearProcedures();
        }

        public void AddOrEditSessionProceduresToSession(int rowIndex, string procedureName, out string errorOrigin, out string errorMessage)
        {
            errorOrigin = string.Empty;
            errorMessage = string.Empty;

            Procedure newSessionProcedure = new Procedure();
            newSessionProcedure = m_ProceduresHandler.GetProcedureByName(procedureName);
            using (var db = new ClinicModelContext())
            {
            if (rowIndex >= m_SelectedSession.GetProcedureCount())
            {
                m_SelectedSession.AddProcedure(newSessionProcedure);
            }
            else
            {
                m_SelectedSession.Procedures[rowIndex] = newSessionProcedure;
            }

            
                var existing = db.Sessions.Find(m_SelectedSession.Id);
                db.Entry(existing).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void GetTreatmentChargeAndTime(string treatmentName, out int treatmentPrice, out int treatmentTime)
        {
            Procedure pro = m_ProceduresHandler.GetProcedureByName(treatmentName);
            treatmentPrice = pro.PricePerSession;
            treatmentTime = pro.TimePerSession;
        }

        public int GetTreatmentCharges(List<string> treatmentNames)
        {
            Session dummySession = new Session();
            foreach(string str in treatmentNames)
            {
                dummySession.Procedures.Add(m_ProceduresHandler.GetProcedureByName(str));
            }

            return dummySession.ChargesIncured;
        }

        public List<string> GetAllCustomerNames()
        {
            return m_CustomersHandler.GetAllCustomerNames();
        }

        private Session GetSessionById(long id)
        {
            return Sessions.Find(x => x.Id == id);
        }
    }
}
