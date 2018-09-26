using System;
using System.ComponentModel.DataAnnotations;

namespace CloudSpa.Models
{
    public class Customer
    {
        public int? CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
    }
}