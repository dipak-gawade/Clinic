using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClinicModel
{
    /// <summary>
    /// Session result for every machine
    /// </summary>
    public class SessionProcedure
    {
        public Procedure Procedure { get; set; }

        public DateTime StartTime { get; set; }

        public int SittingNumber { get; set; }

        public SessionProcedureResult Result { get; set; }

        public string ResultPath { get; set; }

        public string MedicinesSuggested { get; set; }

        public Doctor DoctorSuggested { get; set; }

        public string AdditionalComments { get; set; }
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
