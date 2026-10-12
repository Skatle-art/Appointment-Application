using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Appointment_Application.Models;

public partial class AppointmentDatabaseSystemGpContext : DbContext
{
    public AppointmentDatabaseSystemGpContext()
    {
    }

    public AppointmentDatabaseSystemGpContext(DbContextOptions<AppointmentDatabaseSystemGpContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Appointment> Appointments { get; set; }

    public virtual DbSet<GeneralPractitioner> GeneralPractitioners { get; set; }

    public virtual DbSet<Patient> Patients { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=AppointmentDatabaseSystemGP;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Appointment>(entity =>
        {
            entity.HasKey(e => e.AppointmentId).HasName("PK__Appointm__8ECDFCA2DB438B30");

            entity.ToTable("Appointment");

            entity.Property(e => e.AppointmentId).HasColumnName("AppointmentID");
            entity.Property(e => e.Gpid).HasColumnName("GPID");
            entity.Property(e => e.PatientId).HasColumnName("PatientID");
            entity.Property(e => e.VisitReason)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasOne(d => d.Gp).WithMany(p => p.Appointments)
                .HasForeignKey(d => d.Gpid)
                .HasConstraintName("FK__Appointmen__GPID__4F7CD00D");

            entity.HasOne(d => d.Patient).WithMany(p => p.Appointments)
                .HasForeignKey(d => d.PatientId)
                .HasConstraintName("FK__Appointme__Patie__4E88ABD4");
        });

        modelBuilder.Entity<GeneralPractitioner>(entity =>
        {
            entity.HasKey(e => e.Gpid).HasName("PK__GeneralP__5E7D7DD44B24715F");

            entity.ToTable("GeneralPractitioner");

            entity.Property(e => e.Gpid).HasColumnName("GPID");
            entity.Property(e => e.AddressNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CityTown)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Specialties)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Patient>(entity =>
        {
            entity.HasKey(e => e.PatientId).HasName("PK__Patient__970EC346B323DF60");

            entity.ToTable("Patient");

            entity.Property(e => e.PatientId).HasColumnName("PatientID");
            entity.Property(e => e.CityTown)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PatientEmail).HasMaxLength(50);
            entity.Property(e => e.PatientName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PatientSurname)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
