using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClinicModel;

namespace ClinicBusinessLogic
{
    public class MachinesHandler
    {
        #region Private variables

        private List<Machine> m_Machines = new List<Machine>();

        private Machine m_SelectedMachine = null;

        #endregion

        #region Properties

        public List<Machine> Machines { get { return m_Machines; } }

        public event EventHandler MachinesUpdated;

        public Machine SelectedMachine { get { return m_SelectedMachine; } }

        #endregion

        #region Public methods

        public void SelectMachine(Machine machineSelected)
        {
            m_SelectedMachine = machineSelected;
        }

        public bool AddOrEditMachine(string serialNumber, string shortName,
            string name, string make, string purpose, string comments,
            int price, DateTime purchaseDate, string imagePath, bool isActive,
            out string errorOrigin, out string errorMessage)
        {
            errorMessage = null;
            errorOrigin = null;

            Machine newMachine = GetMachineBySerialNumber(serialNumber);
            if (newMachine == null)
            {
                newMachine = new Machine();
                newMachine.SerialNumber = serialNumber;
                m_Machines.Add(newMachine);
            }

            newMachine.ShortName = shortName;
            newMachine.Name = name;
            newMachine.Make = make;
            newMachine.Purpose = purpose;
            newMachine.Comments = comments;
            newMachine.Price = price;
            newMachine.PurchaseDate = purchaseDate;
            newMachine.ImagePath = imagePath;
            newMachine.IsActive = isActive;

            RaiseMachinesUpdatedEvent();

            return true;
        }

        public List<string> GetMachineNames()
        {
            return m_Machines.Select(s => s.Name).ToList();
        }

        public void RemoveMachine()
        {
            m_Machines.Remove(m_SelectedMachine);
            RaiseMachinesUpdatedEvent();
        }

        public Machine GetMachineByName(string name)
        {
            return m_Machines.Find(x => x.Name == name);
        }

        #endregion

        #region Private methods

        private void RaiseMachinesUpdatedEvent()
        {
            if (MachinesUpdated != null)
            {
                MachinesUpdated(this, null);
            }
        }

        private Machine GetMachineBySerialNumber(string serialNumber)
        {
            Machine existingMachine = m_Machines.Find(x => x.SerialNumber == serialNumber);
            return existingMachine;
        }

        #endregion
    }
}
