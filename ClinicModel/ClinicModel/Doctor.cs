using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClinicModel
{
    /// <summary>
    /// Doctor details
    /// </summary>
    public class Doctor
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string SpecialistIn { get; set; }

        public string MobileNumber { get; set; }

        public string Address { get; set; }

        public string AdditionalDetails { get; set; }
    }
}
