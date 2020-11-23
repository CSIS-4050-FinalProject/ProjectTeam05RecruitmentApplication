namespace RecruitmentCodeFirstFromDB
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class RecruitmentEntities : DbContext
    {
        public RecruitmentEntities()
            : base("name=RecruitmentConnection")
        {
        }

        public virtual DbSet<Application> Applications { get; set; }
        public virtual DbSet<Candidate> Candidates { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<Interview> Interviews { get; set; }
        public virtual DbSet<Job> Jobs { get; set; }
        public virtual DbSet<Perk> Perks { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Application>()
                .HasMany(e => e.Interviews)
                .WithRequired(e => e.Application)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Candidate>()
                .HasMany(e => e.Applications)
                .WithRequired(e => e.Candidate)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Company>()
                .HasMany(e => e.Jobs)
                .WithRequired(e => e.Company)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Job>()
                .HasMany(e => e.Applications)
                .WithRequired(e => e.Job)
                .WillCascadeOnDelete(false);
        }
    }
}
