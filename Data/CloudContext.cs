using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using CloudSpa.Models;

namespace CloudSpa.Models
{
    public class CloudContext : DbContext
    {
        public CloudContext(DbContextOptions<CloudContext> options) : base(options)
        { }
        public DbSet<Appointment> Appointment { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<ServiceProvider> ServiceProvider { get; set; }
        
    }

}
