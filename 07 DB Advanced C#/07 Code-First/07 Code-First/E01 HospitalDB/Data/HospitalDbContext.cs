using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E01HospitalDB.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace E01HospitalDB.Data
{
    public class HospitalDbContext : DbContext
    {
        public HospitalDbContext()
        {

        }

        public HospitalDbContext(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<Patient> Patients { get; set; }

        public DbSet<Diagnose> Diagnoses { get; set; }

        public DbSet<Medicament> Medicaments { get; set; }

        public DbSet<PatientMedicament> PatientMedicaments { get; set; }

        public DbSet<Visitation> Visitations { get; set; }

        public DbSet<Doctor> Doctors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Configuration.ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Patient>(entity =>
            {
                entity.HasKey(e => e.PatientId);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .IsUnicode()
                    .IsRequired();

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode()
                    .IsRequired();

                entity.Property(e => e.Address)
                    .HasMaxLength(250)
                    .IsRequired()
                    .IsUnicode();

                entity.Property(e => e.Email)
                    .HasMaxLength(80)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.HasInsurance)
                    .HasDefaultValue(true)
                    .IsRequired();
            });

            modelBuilder.Entity<Visitation>(entity =>
            {
                entity.HasKey(e => e.VisitationId);

                entity.Property(e => e.Date)
                    .HasColumnType("DATETIME")
                    .IsRequired();

                entity.Property(e => e.Comments)
                    .HasMaxLength(250)
                    .IsRequired(false)
                    .IsUnicode();

                entity.HasOne(e => e.Patient)
                    .WithMany(p => p.Visitations)
                    .HasForeignKey(e => e.PatientId);

                entity.HasOne(e => e.Doctor)
                    .WithMany(d => d.Visitations)
                    .HasForeignKey(e => e.DoctorId);
            });

            modelBuilder.Entity<Diagnose>(entity =>
            {
                entity.HasKey(e => e.DiagnoseId);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode()
                    .IsRequired();

                entity.Property(e => e.Comments)
                    .HasMaxLength(250)
                    .IsUnicode()
                    .IsRequired(false);

                entity.HasOne(e => e.Patient)
                    .WithMany(p => p.Diagnoses)
                    .HasForeignKey(e => e.PatientId);

            });

            modelBuilder.Entity<PatientMedicament>(entity =>
            {
                entity.HasKey(e => new { e.MedicamentId, e.PatientId });

                entity.HasOne(e => e.Patient)
                    .WithMany(p => p.Prescriptions)
                    .HasForeignKey(e => e.MedicamentId);

                entity.HasOne(e => e.Medicament)
                    .WithMany(m => m.Prescriptions)
                    .HasForeignKey(e => e.MedicamentId);
            });

            modelBuilder.Entity<Medicament>(entity =>
            {
                entity.HasKey(e => e.MedicamentId);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .IsUnicode()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Doctor>(entity =>
            {
                entity.HasKey(e => e.DoctorId);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .IsUnicode()
                    .HasMaxLength(100);

                entity.Property(e => e.Specialty)
                    .IsRequired()
                    .IsUnicode()
                    .HasMaxLength(100);
            });
        }
    }
}
