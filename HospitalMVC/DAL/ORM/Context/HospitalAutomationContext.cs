using DAL.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ORM.Context
{
    public class HospitalAutomationContext : DbContext
    {
        public HospitalAutomationContext() : base("HospitalAutomationContext")
        {
        }

        public DbSet<Appoinment> Appoinments { get; set; }
        public DbSet<City> Citys { get; set; }
        public DbSet<Hospital> Hospitals { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<PatientHistory> PatientHistories { get; set; }
        public DbSet<Policlinic> Policlinics { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Title> Titles { get; set; }
        public DbSet<Town> Towns { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }
    }
}
