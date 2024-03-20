using System.Linq.Expressions;
using Jobdoon.DataAccess.IRepositories;
using Jobdoon.Database;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Jobdoon.DataAccess.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly IdentityDbContext Context;
        private DbSet<T> set;

        public Repository(IdentityDbContext context)
        {
            Context = context;
            set = context.Set<T>();
        }

        public void Add(T entity)
        {
            set.Add(entity);
        }

        public void AddRange(IEnumerable<T> entities)
        {
            set.AddRange(entities);
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
        {
            return set.Where(predicate);
        }

        public T Get(int id)
        {
            return set.Find(id);
        }

        public IEnumerable<T> GetAll()
        {
            return set.ToList();
        }

        public void Remove(T entity)
        {
            set.Remove(entity);
        }

        public void Remove(int id)
        {
            set.Remove(Get(id));
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            set.RemoveRange(entities);
        }
    }
}
