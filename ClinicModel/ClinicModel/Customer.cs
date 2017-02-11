using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace ClinicModel
{
    /// <summary>
    /// Customer details
    /// </summary>
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string ReferredBy { get; set; }

        public string ReasonToVisit { get; set; }

        public string EmailAddress { get; set; }

        public string MobileNumber { get; set; }

        public string Address { get; set; }

        public string AdditionalDetails { get; set; }

        public DateTime BirthDate { get; set; }

        public Gender Gender { get; set; }

        public Customer(int id)
        {
            Id = id;
        }

        public Customer()
        {
            Id = 0;
        }
    }

    public enum Gender
    {
        Female,
        Male
    }
}
