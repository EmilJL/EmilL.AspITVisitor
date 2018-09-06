namespace EmilL.AspITVisitor.DAL.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class AspITVisitorModel : DbContext
    {
        public AspITVisitorModel()
            : base("name=AspITVisitorModelConString")
        {
        }

        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<AspITVisitDay> AspITVisitDays { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<FreeAnswerQuestion> FreeAnswerQuestions { get; set; }
        public virtual DbSet<FreeAnswer> FreeAnswers { get; set; }
        public virtual DbSet<Guest> Guests { get; set; }
        public virtual DbSet<Inquiry> Inquiries { get; set; }
        public virtual DbSet<MultipleChoiseAnswer> MultipleChoiseAnswers { get; set; }
        public virtual DbSet<MultipleChoiseQuestion> MultipleChoiseQuestions { get; set; }
        public virtual DbSet<PossibleAnswer> PossibleAnswers { get; set; }
        public virtual DbSet<Questionnaire> Questionnaires { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admin>()
                .HasMany(e => e.AspITVisitDays)
                .WithRequired(e => e.Admin)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Admin>()
                .HasMany(e => e.Questionnaires)
                .WithRequired(e => e.Admin)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AspITVisitDay>()
                .HasMany(e => e.Departments)
                .WithRequired(e => e.AspITVisitDay)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AspITVisitDay>()
                .HasMany(e => e.Guests)
                .WithRequired(e => e.AspITVisitDay)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FreeAnswerQuestion>()
                .HasMany(e => e.FreeAnswers)
                .WithRequired(e => e.FreeAnswerQuestion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Guest>()
                .HasMany(e => e.FreeAnswers)
                .WithRequired(e => e.Guest)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Guest>()
                .HasMany(e => e.MultipleChoiseAnswers)
                .WithRequired(e => e.Guest)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Inquiry>()
                .HasMany(e => e.Departments)
                .WithRequired(e => e.Inquiry)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Inquiry>()
                .HasMany(e => e.Guests)
                .WithRequired(e => e.Inquiry)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MultipleChoiseQuestion>()
                .HasMany(e => e.PossibleAnswers)
                .WithRequired(e => e.MultipleChoiseQuestion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PossibleAnswer>()
                .HasMany(e => e.MultipleChoiseAnswers)
                .WithRequired(e => e.PossibleAnswer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Questionnaire>()
                .HasMany(e => e.FreeAnswerQuestions)
                .WithRequired(e => e.Questionnaire)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Questionnaire>()
                .HasMany(e => e.Guests)
                .WithRequired(e => e.Questionnaire)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Questionnaire>()
                .HasMany(e => e.MultipleChoiseQuestions)
                .WithRequired(e => e.Questionnaire)
                .WillCascadeOnDelete(false);
        }
    }
}
