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
        private SessionProcedureHandler m_procedureResultHandler = null;
        private DoctorsHandler m_doctorsHandler = null;
        private Session m_SelectedSession;

        public Session SelectedSession { get { return m_SelectedSession; } }

        public SessionsHandler(CustomersHandler customersHandler, ProceduresHandler proceduresHandler, 
            DoctorsHandler doctorsHandler)
        {
            m_ProceduresHandler = proceduresHandler;
            m_CustomersHandler = customersHandler;
            m_doctorsHandler = doctorsHandler;
            using (var db = new ClinicModelContext())
            {
                m_Sessions = db.Sessions.ToList<Session>(); 
            }
        }

        public List<Session> Sessions { get { return m_Sessions; } }

        public bool AddOrEditSession(int id, int customerId, string patientComplaint,
            DateTime reportTime, int discountedFees, List<SessionProcedure> sessionProcedures, out string errorOrigin, out string errorMessage)
        {
            errorMessage = string.Empty;
            errorOrigin = string.Empty;

            Session newSession = GetSessionById(id);
            if (id == -1)
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

            newSession.Patient = m_CustomersHandler.GetCustomersById(customerId);
            newSession.PatientComplaint = patientComplaint;
            newSession.ReportTime = reportTime;
            newSession.DiscountedFees = discountedFees;

            newSession.Procedures = sessionProcedures;

            using (var db = new ClinicModelContext())
            {
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

            return true;
        }

        public void SelectSession(Session session)
        {
            m_SelectedSession = session;
        }

        public void RemoveSession()
        {
            m_Sessions.Remove(m_SelectedSession);
        }

        public void AddSessionProceduresToSession(List<SessionProcedure> sessionProcedures)
        {
            m_SelectedSession.Procedures = sessionProcedures;
        }

        private Session GetSessionById(int id)
        {
            return Sessions.Find(x => x.Id == id);
        }
    }
}
