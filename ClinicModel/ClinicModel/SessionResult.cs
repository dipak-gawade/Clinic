using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClinicModel
{
    /// <summary>
    /// Session result for every machine
    /// </summary>
    public class MachineSessionResult
    {
        public Machine Machine { get; set; }

        public int SittingNumber { get; set; }

        public string ResultPath { get; set; }

        public bool IsSessionCompleted { get; set; }

        public bool NeedFollowupSession { get; set; }

        public ModeOfResult ResultFormat { get; set; }

        public List<string> MedicinesSuggested { get; set; }

        public Doctor DoctorSuggested { get; set; }

        public string AttendedBy { get; set; }

        public DateTime StartTime { get; set; }

        public string AdditionalComments { get; set; }

        public string CustomerReview { get; set; }
    }

    public enum ModeOfResult
    {
        None,
        Print,
        Mail
    }
}
