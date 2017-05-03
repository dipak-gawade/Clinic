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

        public bool AddOrEditProcedure(string name, string machineName, int pricePerSession, int timePerSession,
            out string errorOrigin, out string errorMessage)
        {
            errorOrigin = string.Empty;
            errorMessage = string.Empty;

            Procedure newProcedure = m_Procedures.Find(x => x.Name.Equals(name));
            bool isNewEntry = false;

            if (newProcedure == null)
            {
                isNewEntry = true;
                newProcedure = new Procedure();
                m_Procedures.Add(newProcedure);
            }

            //newProcedure.Machine = m_MachinesHandler.GetMachineByName(machineName);
            newProcedure.Name = name;
            newProcedure.PricePerSession = pricePerSession;
            newProcedure.TimePerSession = timePerSession;

            m_SelectedProcedure = newProcedure;
            

            using (var db = new ClinicModelContext())
            {
                string serNumber = m_MachinesHandler.GetMachineByName(machineName).SerialNumber;
                Machine connectedDatabaseMachine = db.Machines.Single(x => x.SerialNumber.Equals(serNumber));
                //db.Machines.Attach(connectedDatabaseMachine);
                newProcedure.Machine = connectedDatabaseMachine;

                if (isNewEntry)
                {
                    db.Procedures.Add(newProcedure);
                }
                else
                {
                    var existing = db.Procedures.Single(x => x.Name.Equals(name));
                    existing = newProcedure;
                    db.Entry(existing).State = System.Data.Entity.EntityState.Modified;
                }

                db.SaveChanges();
            }

            RaiseProceduresUpdatedEvent();

            return true;
        }

        public List<string> GetMachineNames()
        {
            return m_MachinesHandler.GetMachineNames();
        }

        public void RemoveProcedure()
        {
            m_Procedures.Remove(m_SelectedProcedure);
            using (var db = new ClinicModelContext())
            {
                var existing = db.Procedures.Single(x => x.Name.Equals(m_SelectedProcedure.Name));
                existing = m_SelectedProcedure;
                db.Entry(existing).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
            }
            RaiseProceduresUpdatedEvent();
        }

        public Procedure GetProcedureByName(string procedureName)
        {
            return m_Procedures.Find(x => x.Name == procedureName);
        }

        public List<string> GetProcedureNames()
        {
            return m_Procedures.Select(x => x.Name).ToList();
        }

        private void RaiseProceduresUpdatedEvent()
        {
            if (ProceduresUpdated != null)
            {
                ProceduresUpdated(this, null);
            }
        }
    }
}
