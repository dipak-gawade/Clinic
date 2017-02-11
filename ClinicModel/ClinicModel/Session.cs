using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

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
        }

        public Session()
        {
            Id = 0;
        }

        [Key]
        public int Id { get; set; }

        public Customer Patient { get; set; }

        public string PatientComplaint { get; set; }

        public List<SessionProcedure> Procedures { get; set; }

        public DateTime ReportTime { get; set; }

        public int ChargesIncured 
        {
            get
            {
                int charges = 0;
                foreach (SessionProcedure pr in Procedures)
                {
                    charges += pr.Procedure.PricePerSession;
                }

                return charges;
            }
        }

        public int DiscountedFees { get; set; }

        public string AttendedBy { get; set; }
    }
}
