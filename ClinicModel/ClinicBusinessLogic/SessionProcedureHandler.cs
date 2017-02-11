﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClinicModel;

namespace ClinicBusinessLogic
{
    public class SessionProcedureHandler
    {
        private List<SessionProcedure> m_proceduresInTheSession = null;

        private ProceduresHandler m_ProceduresHandler = null;

        private DoctorsHandler m_DoctorsHandler = null;

        public List<SessionProcedure> ProceduresInTheSession { get; set; }

        public event EventHandler ProceduresInSessionUpdated;

        public SessionProcedureHandler(ProceduresHandler proceduresHandler, DoctorsHandler doctorsHandler)
        {
            m_ProceduresHandler = proceduresHandler;
            m_DoctorsHandler = doctorsHandler;
            m_proceduresInTheSession = new List<SessionProcedure>();
        }

        public bool AddOrEditSessionProcedure(string procedureName, DateTime startTime, int sittingNumber,
            SessionProcedureResult result, string resultPath, string medicinesSuggested, int doctorSuggested,
            string additionalComments, out string errorOrigin, out string errorMessage)
        {
            errorOrigin = string.Empty;
            errorMessage = string.Empty;

            SessionProcedure newSessionProcedure = m_proceduresInTheSession.Find(x => x.Procedure.Name.Equals(procedureName));
            if (newSessionProcedure == null)
            {
                newSessionProcedure = new SessionProcedure();
                newSessionProcedure.Procedure = m_ProceduresHandler.GetProcedureByName(procedureName);
            }

            newSessionProcedure.StartTime = startTime;
            newSessionProcedure.SittingNumber = sittingNumber;
            newSessionProcedure.Result = result;
            newSessionProcedure.ResultPath = resultPath;
            newSessionProcedure.MedicinesSuggested = medicinesSuggested;
            newSessionProcedure.DoctorSuggested = m_DoctorsHandler.Doctors.Find(x => x.Id == doctorSuggested);
            newSessionProcedure.AdditionalComments = additionalComments;


            return true;
        }
    }
}