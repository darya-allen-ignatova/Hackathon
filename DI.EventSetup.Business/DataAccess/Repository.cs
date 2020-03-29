using System.Data.Entity;
using System.Linq;
using DI.EventSetup.Business.DataAccess.Configuration;

namespace DI.EventSetup.Business.DataAccess
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity);

        T GetById(int id);

        IQueryable<T> GetAll();

        void Remove(T entity);

        void Update(T entity);
    }

    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly DbContext _context;
        private readonly DbSet<T> _dbSet;

        public Repository()
        {
            _context = new DataContext();
            _dbSet = _context.Set<T>();
        }

        public void Add(T entity)
        {
            _dbSet.Add(entity);
            _context.SaveChanges();
        }

        public IQueryable<T> GetAll()
        {
            var result = _dbSet.AsNoTracking();
            return result;
        }

        public T GetById(int id)
        {
            var entity =_dbSet.Find(id);
            return entity;
        }

        public void Remove(T entity)
        {
            _context.Entry(entity).State = EntityState.Deleted;
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
