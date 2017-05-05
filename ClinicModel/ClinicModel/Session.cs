using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicModel
{
    /// <summary>
    /// Session details
    /// </summary>
    public class Session
    {
        private List<Procedure> m_procedures;
        public Session(int id)
        {
            Id = id;
            Procedures = new List<Procedure>();
        }

        public Session():this(0)
        {
        }

        [Key]
        public int Id { get; set; }

        public Customer Patient { get; set; }

        public string PatientComplaint { get; set; }

        public virtual List<Procedure> Procedures
        {
            get { return m_procedures; }
            set { m_procedures = value; }
        }

        public DateTime ReportTime { get; set; }

        public int ChargesIncured 
        {
            get
            {
                int charges = 0;
                foreach (Procedure pr in m_procedures)
                {
                    charges += pr.PricePerSession;
                }

                return charges;
            }
        }

        public int TotalTime
        {
            get
            {
                int time = 0;
                foreach (Procedure pr in m_procedures)
                {
                    time += pr.TimePerSession;
                }

                return time;
            }
        }

        public int DiscountedFees { get; set; }

        public string AttendedBy { get; set; }

        [NotMapped]
        public string AllProcedureNames
        {
            get
            {
                StringBuilder allProcedureNames = new StringBuilder();

                foreach(Procedure proc in m_procedures)
                {
                    if(allProcedureNames.Length > 0)
                    {
                        allProcedureNames.Append(",");
                    }

                    allProcedureNames.Append(proc.Name);
                }

                return allProcedureNames.ToString();
            }
        }

        [NotMapped]
        public string FullName
        {
            get { return Patient != null ? Patient.FullName : string.Empty; }
        }

        public void ClearProcedures()
        {
            m_procedures.Clear();
        }

        public int GetProcedureCount()
        {
            return m_procedures.Count;
        }

        public void AddProcedure(Procedure newProcedure)
        {
            m_procedures.Add(newProcedure);
        }

        //public SessionProcedureResult Result { get; set; }

        //public string AdditionalComments { get; set; }
    }

    public enum SessionProcedureResult
    {
        Successful,
        Pending,
        CustomerFailedToVisit,
        MachineBroken,
        Cancelled
    }
}
