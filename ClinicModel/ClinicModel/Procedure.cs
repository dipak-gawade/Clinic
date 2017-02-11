using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace ClinicModel
{
    public class Procedure
    {
        public Procedure(int id)
        {
            Id = id;
        }

        public Procedure()
        {
            Id = 0;
        }

        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public Machine Machine { get; set; }

        public int PricePerSession { get; set; }

        public int TimePerSession { get; set; }
    }
}
