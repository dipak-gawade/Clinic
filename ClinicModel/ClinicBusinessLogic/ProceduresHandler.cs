using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClinicModel;

namespace ClinicBusinessLogic
{
    public class ProceduresHandler
    {
        private List<Procedure> m_Procedures = new List<Procedure>();

        private MachinesHandler m_MachinesHandler = new MachinesHandler();

        private Procedure m_SelectedProcedure = null;

        public List<Procedure> Procedures { get { return m_Procedures; } }

        public event EventHandler ProceduresUpdated;

        public Procedure SelectedProcedure { get { return m_SelectedProcedure; } }

        public ProceduresHandler(MachinesHandler machineHandler)
        {
            m_MachinesHandler = machineHandler;
            using (var db = new ClinicModelContext())
            {
                m_Procedures = db.Procedures.ToList<Procedure>(); 
            }
        }

        public void SelectProcedure(Procedure procedure)
        {
            m_SelectedProcedure = procedure;
        }

        public bool AddOrEditProcedure(int id, string name, string machineName, int pricePerSession, int timePerSession,
            out string errorOrigin, out string errorMessage)
        {
            errorOrigin = string.Empty;
            errorMessage = string.Empty;

            Procedure newProcedure = GetProcedureFromId(id);

            if (id == -1)
            {
                if (m_Procedures.Count > 0)
                {
                    newProcedure = new Procedure(m_Procedures[m_Procedures.Count - 1].Id + 1);
                }
                else
                {
                    newProcedure = new Procedure(1);
                }

                m_Procedures.Add(newProcedure);
            }

            newProcedure.Machine = m_MachinesHandler.GetMachineByName(machineName);
            newProcedure.Name = name;
            newProcedure.PricePerSession = pricePerSession;
            newProcedure.TimePerSession = timePerSession;

            m_SelectedProcedure = newProcedure;
            RaiseProceduresUpdatedEvent();

            using (var db = new ClinicModelContext())
            {
                if (id == -1)
                {
                    db.Procedures.Add(newProcedure);
                }
                else
                {
                    var existing = db.Procedures.Find(id);
                    existing = newProcedure;
                    db.Entry(existing).State = System.Data.Entity.EntityState.Modified;
                }

                db.SaveChanges();
            }

            return true;
        }

        public List<string> GetMachineNames()
        {
            return m_MachinesHandler.GetMachineNames();
        }

        public void RemoveProcedure()
        {
            m_Procedures.Remove(m_SelectedProcedure);
            RaiseProceduresUpdatedEvent();
        }

        public Procedure GetProcedureByName(string procedureName)
        {
            return m_Procedures.Find(x => x.Name == procedureName);
        }

        private void RaiseProceduresUpdatedEvent()
        {
            if (ProceduresUpdated != null)
            {
                ProceduresUpdated(this, null);
            }
        }

        private Procedure GetProcedureFromId(int id)
        {
            return m_Procedures.Find(x => x.Id == id);
        }
    }
}
