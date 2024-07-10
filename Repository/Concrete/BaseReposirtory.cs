using _21_MVC_RepositorySchool.Models.Context;

namespace _21_MVC_RepositorySchool.Repository.Concrete
{
    //projede yok deneme için kullaınmıştır.
    public abstract class BaseReposirtory<T> where T : class, new()  //T burada class olma zorunda demek diyoruz. newlemenini zorunlu oldugun söylüyoruz.
    {
        public BaseReposirtory(AppDbContext context)
        {

        }
    }
}
