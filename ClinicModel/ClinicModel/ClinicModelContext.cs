using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace ClinicModel
{
    public class ClinicModelContext:DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        public DbSet<Doctor> Doctors { get; set; }

        public DbSet<Machine> Machines { get; set; }

        public DbSet<Procedure> Procedures { get; set; }

        public DbSet<Session> Sessions { get; set; }
    }
}
