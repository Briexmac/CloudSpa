using System;
using System.ComponentModel.DataAnnotations;

namespace CloudSpa.Models
{
    public class ServiceProvider
    {
       public int? ServiceProviderId { get; set; }
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