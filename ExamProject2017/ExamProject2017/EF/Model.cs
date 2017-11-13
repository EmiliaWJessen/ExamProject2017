namespace ExamProject2017.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model : DbContext
    {
        public Model()
            : base("name=ModelConnectionSettings")
        {
        }

        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Event> Event { get; set; }
        public virtual DbSet<Judge> Judge { get; set; }
        public virtual DbSet<JudgesGroup> JudgesGroup { get; set; }
        public virtual DbSet<Question> Question { get; set; }
        public virtual DbSet<Ranking> Ranking { get; set; }
        public virtual DbSet<Result> Result { get; set; }
        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<StudentGroup> StudentGroup { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .Property(e => e.category_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Category>()
                .HasMany(e => e.StudentGroup)
                .WithRequired(e => e.Category)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Event>()
                .HasMany(e => e.Ranking)
                .WithRequired(e => e.Event)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Judge>()
                .Property(e => e.judge_Name)
                .IsUnicode(false);

            modelBuilder.Entity<JudgesGroup>()
                .Property(e => e.jGroup_Name)
                .IsUnicode(false);

            modelBuilder.Entity<JudgesGroup>()
                .HasMany(e => e.Judge)
                .WithRequired(e => e.JudgesGroup)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<JudgesGroup>()
                .HasMany(e => e.Ranking)
                .WithRequired(e => e.JudgesGroup)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Question>()
                .Property(e => e.question_Text)
                .IsUnicode(false);

            modelBuilder.Entity<Question>()
                .HasMany(e => e.Result)
                .WithRequired(e => e.Question)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Ranking>()
                .HasMany(e => e.Result)
                .WithRequired(e => e.Ranking)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.student_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.student_School)
                .IsUnicode(false);

            modelBuilder.Entity<StudentGroup>()
                .Property(e => e.sGroup_Name)
                .IsUnicode(false);

            modelBuilder.Entity<StudentGroup>()
                .HasMany(e => e.Ranking)
                .WithRequired(e => e.StudentGroup)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<StudentGroup>()
                .HasMany(e => e.Student)
                .WithRequired(e => e.StudentGroup)
                .WillCascadeOnDelete(false);
        }
    }
}
