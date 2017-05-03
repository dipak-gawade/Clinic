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

        public virtual List<Procedure> Procedures { get; set; }

        public DateTime ReportTime { get; set; }

        public int ChargesIncured 
        {
            get
            {
                int charges = 0;
                foreach (Procedure pr in Procedures)
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
                foreach (Procedure pr in Procedures)
                {
                    time += pr.TimePerSession;
                }

                return time;
            }
        }

        public int DiscountedFees { get; set; }

        public string AttendedBy { get; set; }

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
