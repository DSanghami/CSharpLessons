using MvcEFApp.Models;
using System;
using Microsoft.EntityFrameworkCore;

namespace MvcEFApp.Models
{
    public class HospitalDbContext : DbContext
    {
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            String conString = @"server=200411LTP2823\SQLEXPRESS ; database= HospitalDB; integrated security = true; Encrypt = false;";
            options.UseSqlServer(conString);
        }
    }
}
