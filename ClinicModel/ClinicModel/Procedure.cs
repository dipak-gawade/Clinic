using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClinicModel
{
    public class Procedure
    {
        public Procedure(int id)
        {
            Id = id;
        }

        public int Id { get; private set; }

        public string Name { get; set; }

        public Machine Machine { get; set; }

        public int PricePerSession { get; set; }

        public int TimePerSession { get; set; }
    }
}
