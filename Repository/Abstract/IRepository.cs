namespace _21_MVC_RepositorySchool.Repository.Abstract
{
    public interface IRepository<T> where T : class
    {

        T GetById(int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

        
        /*
         * Sorgulama yapabilmek için
         * 
         * public List<TEntity> GetDefault(Expression<Func<TEntity, bool>> exp)
            (Expression<Func<TEntity, bool>> exp) // koşul belirtme.
        {
            return _context.Where(exp).ToList();
        
        }
         */
    }
}
