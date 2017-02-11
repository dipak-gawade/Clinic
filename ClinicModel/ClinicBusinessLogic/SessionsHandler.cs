﻿using System;
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

        public Session SelectedSession { get; }

        public SessionsHandler(CustomersHandler customersHandler, ProceduresHandler proceduresHandler, 
            DoctorsHandler doctorsHandler)
        {
            m_ProceduresHandler = proceduresHandler;
            m_CustomersHandler = customersHandler;
            m_doctorsHandler = doctorsHandler;
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