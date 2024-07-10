using _21_MVC_RepositorySchool.Models.Context;
using Microsoft.EntityFrameworkCore;

namespace _21_MVC_RepositorySchool.Models.SeedData
{
    public static class SeedData
    {
        //Seed metodu, IApplicationBuilder arayüzünü parametre olarak alır. Bu, ASP.NET Core uygulamasının middleware pipeline'ını yapılandırmak için kullanılır. app nesnesi, uygulamanın başlatılma sürecinde kullanılır ve DI (Dependency Injection) konteynerine erişimi sağlar.
        public static void SeedDatas(IApplicationBuilder app)
        {
            //CreateScope metodu, yeni bir bağımlılık çözümleme kapsamı (scope) oluşturur. Bu, scoped servislerin yaşam döngüsünü yönetmek için kullanılır.
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {

                AppDbContext context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.Migrate();

                if (!context.Schools.Any())
                {
                    context.Schools.AddRange(
                        new School() { SchoolName = "Profilo", PhoneNumber = "123123123", Adress = "Istanbul", Email = "prfoli@gmail.com", FoundedDate = new DateTime(1982, 01, 01) },
                        new School() { SchoolName = "BilgeAdam", PhoneNumber = "12443252", Adress = "Istanbul", Email = "bilge@gmail.com", FoundedDate = new DateTime(1991, 01, 01) },
                        new School() { SchoolName = "Balıkesir", PhoneNumber = "1255556123", Adress = "Balıkesir", Email = "bau@gmail.com", FoundedDate = new DateTime(1999, 01, 01) }
                        );
                }
                context.SaveChanges();

                if (!context.ClassRooms.Any()) { context.ClassRooms.Add(new ClassRoom() { Name = "HS-15"}); }
                context.SaveChanges();

                if (!context.Teachers.Any())
                {

                    context.Teachers.AddRange(
                        new Teacher()
                        {

                            FirstName = "Ali",
                            LastName = "Toplu",
                            BirthDate = new DateTime(1991, 07, 24),
                            Gender="Erkek"
                        },
                        new Teacher()
                        {

                            FirstName = "Buse",
                            LastName = "Deniz",
                            BirthDate = new DateTime(1907, 07, 19),
                            Gender = "Kadin"
                        });
                }
                context.SaveChanges();
                if (!context.Students.Any())
                {

                    context.Students.AddRange(
                       new Student() { FirstName = "İbrahim", LastName = "Deniz", ParentPhoneNumber = "123222251", StudentNo = 1907, BirthDate = new DateTime(1991, 07, 15), StudentAdress = "Istanbul" },
                       new Student() { FirstName = "Harun", LastName = "Selamet", ParentPhoneNumber = "12323251", StudentNo = 1907, BirthDate = new DateTime(1997, 06, 06), StudentAdress = "Istanbul" },
                       new Student() { FirstName = "Hakan", LastName = "Arpacı", ParentPhoneNumber = "12666151", StudentNo = 1907, BirthDate = new DateTime(1994, 04, 03), StudentAdress = "Istanbul" }
                       );
                }
                context.SaveChanges();
              
            }


        }
    }
}

