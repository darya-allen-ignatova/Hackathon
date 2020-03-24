using DI.EventSetup.Business.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DI.EventSetup.Business.Services
{
    public interface IServiceBase<T>
    {
        void Add(T entity);

        T GetById(int id);

        List<T> GetAll();

        List<T> GetByPredicate(Func<T, bool> predicate);

        void Remove(T entity);

        void Update(T entity);

        bool IsExists(Func<T, bool> predicate);
    }

    public class ServiceBase<T> : IServiceBase<T> where T : class
    {
        public ServiceBase(IRepository<T> repository)
        {
            Repository = repository;
        }

        protected IRepository<T> Repository { get; }

        public void Add(T entity)
        {
            Repository.Add(entity);
        }

        public List<T> GetAll()
        {
            var result = Repository.GetAll().ToList();
            return result;
        }

        public T GetById(int id)
        {
            var entity = Repository.GetById(id);
            return entity;
        }

        public List<T> GetByPredicate(Func<T, bool> predicate)
        {
            var result = Repository.GetAll().Where(predicate).ToList();
            return result;
        }

        public bool IsExists(Func<T, bool> predicate)
        {
            var result = Repository.GetAll().Any(predicate);
            return result;
        }

        public void Remove(T entity)
        {
            Repository.Remove(entity);
        }

        public void Update(T entity)
        {
            Repository.Update(entity);
        }
    }
}
