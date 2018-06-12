using Sample.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Linq.Expressions;

namespace Sample.Models.Mocks
{
    public class MockRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected IEnumerable<TEntity> _collection;

        public MockRepository(IEnumerable<TEntity> collection)
        {
            _collection = collection;
        }

        public MockRepository()
        {

        }


        public void Add(TEntity entity)
        {
            _collection.ToList().Add(entity);
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            _collection.ToList().AddRange(entities);
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return _collection.AsQueryable().Where(predicate);
        }

        public TEntity Get(int id)
        {
            return _collection.ToList()[id-1];
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _collection.ToList();
        }
        public IEnumerable<Student> GetAllStudents()
        {
            return new MockStudentRepository().GetAll();
        }


        public void Remove(TEntity entity)
        {
            _collection.ToList().Remove(entity);
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            _collection.ToList().RemoveRange(0, entities.Count());
        }

       
    }
}