using Sample.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Linq.Expressions;
using Sample.Models.Mocks;

namespace Sample.Models.Concrete
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly SampleDbContext dbContext;

        public Repository(SampleDbContext context)
        {
            dbContext = context;
        }

        public Repository()
        {

        }


        public void Add(TEntity entity)
        {
            dbContext.Set<TEntity>().Add(entity);


        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            dbContext.Set<TEntity>().AddRange(entities);
           
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return dbContext.Set<TEntity>().Where(predicate);
        }

        public TEntity Get(int id)
        {
            return dbContext.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
           return dbContext.Set<TEntity>().ToList();
        }
        public IEnumerable<Student> GetAllStudents()
        {
            return new MockStudentRepository().GetAll();
        }


        public void Remove(TEntity entity)
        {
            dbContext.Set<TEntity>().Remove(entity);
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            dbContext.Set<TEntity>().RemoveRange(entities);
        }
    }
}