using Microsoft.EntityFrameworkCore;

namespace _21_MVC_RepositorySchool.Models.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public virtual DbSet<School> Schools { get; set; }

        public virtual DbSet<Student> Students { get; set; }

        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<ClassRoom> ClassRooms { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            //bir okulun bir çok sınıfı vardır.
            modelBuilder.Entity<ClassRoom>()
                .HasOne(s => s.School)
                .WithMany(s => s.ClassRooms)
                .HasForeignKey(s => s.SchoolId);

            //bir öğretmeninin bir sınıfı vardır. Ogretmen Id Hem primary key hemde classroomun foreign keyi

            modelBuilder.Entity<ClassRoom>()
                .HasOne(s => s.Teacher)
                .WithOne(s => s.ClassRoom)
                .HasForeignKey<Teacher>(s => s.ID);

            //bir öğrencinin bir sınıfı vardır. sınıfın bir çok öğrencisi vardır. Öğrenci ıd primary key hemde classın foregin keyidir.
            modelBuilder.Entity<Student>()
                .HasOne(s => s.ClassRoom)
                .WithMany(s => s.Students)
                .HasForeignKey(x => x.ID);

            modelBuilder.Entity<Student>()
                .HasIndex(s=>s.StudentNo).IsUnique();

            modelBuilder.Entity<ClassRoom>()
                .HasIndex(s=>s.Name).IsUnique();


            base.OnModelCreating(modelBuilder);
        }
    }

}
