using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicModel
{
    public class Procedure
    {
        [Key]
        public string Name { get; set; }

        public Machine Machine { get; set; }

        public int PricePerSession { get; set; }

        public int TimePerSession { get; set; }

        [ForeignKey("Id")]
        public virtual List<Session> Sessions { get; set; }
    }
}
