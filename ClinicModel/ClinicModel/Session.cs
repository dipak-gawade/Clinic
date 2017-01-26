using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClinicModel
{
    /// <summary>
    /// Session details
    /// </summary>
    public class Session
    {
        public Customer Patient { get; set; }

        public string PatientComplaint { get; set; }

        public List<MachineSessionResult> Machines { get; set; }

        public DateTime ReportTime { get; set; }

        public int ChargesIncured { get; set; }
    }
}
