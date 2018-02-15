using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreTutorialGit
{
    public partial class InvoicingToolContext : DbContext
    {
        public virtual DbSet<Mail> Mail { get; set; }
        public virtual DbSet<Invoice> Invoice { get; set; }
        public virtual DbSet<InvoiceSchedule> InvoiceSchedule { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=InvoiceDB;Integrated Security=True;");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Invoice>(entity =>
            {
                entity.HasKey(e => e.InvoiceId);

                entity.Property(e => e.StartDate)
                .HasColumnType("Date");

                entity.Property(e => e.EndDate)
               .HasColumnType("Date");

                entity.HasOne<Mail>(s => s.Mail)
                .WithMany(e => e.Invoices)
                .HasForeignKey(s => s.MailId);

                entity.HasOne<InvoiceSchedule>(s => s.InvoiceSchedule)
                .WithMany(e => e.Invoices)
                .HasForeignKey(s => s.InvoiceSchedId)
                .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<InvoiceSchedule>(entity => 
            {
                entity.HasKey(e => e.InvoiceSchedId);

                entity.Property(e => e.SchedStartDate)
                .HasColumnType("Date");

                entity.Property(e => e.SchedEndDate)
                .HasColumnType("Date");
            });

        }
    }
}
