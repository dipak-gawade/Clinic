using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClinicModel;

namespace ClinicBusinessLogic
{
    public class DoctorsHandler
    {
        private List<Doctor> m_Doctors = new List<Doctor>();
        private Doctor m_selectedDoctor = null;

        public Doctor SelectedDoctor { get { return m_selectedDoctor; } }
        public event EventHandler DoctorsUpdated;
        public List<Doctor> Doctors
        {
            get
            {
                return m_Doctors;
            }
        }

        public bool AddOrEditDoctors(int id, string firstName, string lastName, string mobileNumber,
            string address, string specialistIn, string additionalDetails, out string errorOrigin, out string errorMessage)
        {
            errorOrigin = string.Empty;
            errorMessage = string.Empty;

            Doctor newDoctor = GetDoctorById(id);
            if (id == -1)
            {
                if (m_Doctors.Count > 0)
                {
                    newDoctor = new Doctor(m_Doctors[m_Doctors.Count - 1].Id + 1);
                }
                else
                {
                    newDoctor = new Doctor(1);
                }

                m_Doctors.Add(newDoctor);
            }

            newDoctor.FirstName = firstName;
            newDoctor.LastName = lastName;
            newDoctor.MobileNumber = mobileNumber;
            newDoctor.SpecialistIn = specialistIn;
            newDoctor.Address = address;
            newDoctor.AdditionalDetails = additionalDetails;

            m_selectedDoctor = newDoctor;
            RaiseDoctorsUpdatedEvent();
            return true;
        }

        public void SelectDoctor(Doctor doctor)
        {
            m_selectedDoctor = doctor;
        }

        public void RemoveDoctor()
        {
            m_Doctors.Remove(m_selectedDoctor);
            RaiseDoctorsUpdatedEvent();
        }

        private void RaiseDoctorsUpdatedEvent()
        {
            if (DoctorsUpdated != null)
            {
                DoctorsUpdated(this, null);
            }
        }

        private Doctor GetDoctorById(int id)
        {
            return m_Doctors.Find(x => x.Id == id);
        }
    }
}
