using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ZhoraBot.Models
{
    public partial class ZhoraDBContext : DbContext
    {
        public ZhoraDBContext()
        {
        }

        public ZhoraDBContext(DbContextOptions<ZhoraDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Content> Content { get; set; }
        public virtual DbSet<Contest> Contest { get; set; }
        public virtual DbSet<Course> Course { get; set; }
        public virtual DbSet<Homework> Homework { get; set; }
        public virtual DbSet<Mentor> Mentor { get; set; }
        public virtual DbSet<Methodist> Methodist { get; set; }
        public virtual DbSet<Quiz> Quiz { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<Schedule> Schedule { get; set; }
        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<Subject> Subject { get; set; }
        public virtual DbSet<Teacher> Teacher { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=ZhoraDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Content>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.Content)
                    .HasForeignKey<Content>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Content_Subject");
            });

            modelBuilder.Entity<Contest>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.SubjectId).HasColumnName("Subject_Id");

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.Contest)
                    .HasForeignKey<Contest>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Contest_Content");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.Contest)
                    .HasForeignKey(d => d.SubjectId)
                    .HasConstraintName("FK_Contest_Subject");
            });

            modelBuilder.Entity<Course>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Homework>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.MethodistId).HasColumnName("Methodist_Id");

                entity.Property(e => e.SubjectId).HasColumnName("Subject_Id");

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.Homework)
                    .HasForeignKey<Homework>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Homework_Content");

                entity.HasOne(d => d.Methodist)
                    .WithMany(p => p.Homework)
                    .HasForeignKey(d => d.MethodistId)
                    .HasConstraintName("FK_Homework_Methodist");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.Homework)
                    .HasForeignKey(d => d.SubjectId)
                    .HasConstraintName("FK_Homework_Subject");
            });

            modelBuilder.Entity<Mentor>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.EndWork).HasColumnType("datetime");

                entity.Property(e => e.StartWork).HasColumnType("datetime");
            });

            modelBuilder.Entity<Methodist>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Quiz>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.SubjectId).HasColumnName("Subject_Id");

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.Quiz)
                    .HasForeignKey<Quiz>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Quiz_Content");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.Quiz)
                    .HasForeignKey(d => d.SubjectId)
                    .HasConstraintName("FK_Quiz_Subject");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Schedule>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Time).HasColumnType("datetime");

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.Schedule)
                    .HasForeignKey<Schedule>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Schedule_Student");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.RoleId).HasColumnName("Role_Id");

                entity.Property(e => e.SubjectId).HasColumnName("Subject_Id");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Student)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_Student_Role");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.Student)
                    .HasForeignKey(d => d.SubjectId)
                    .HasConstraintName("FK_Student_Subject");
            });

            modelBuilder.Entity<Subject>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.SubjectId).HasColumnName("Subject_Id");
            });

            modelBuilder.Entity<Teacher>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.EndWork).HasColumnType("datetime");

                entity.Property(e => e.RoleId).HasColumnName("Role_Id");

                entity.Property(e => e.StartWork).HasColumnType("datetime");

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.Teacher)
                    .HasForeignKey<Teacher>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Teacher_Subject");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Teacher)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_Teacher_Role");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
