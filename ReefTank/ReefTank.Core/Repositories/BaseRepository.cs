using System.Collections.Generic;
using Castle.ActiveRecord;
using NHibernate.Criterion;
using ReefTank.Core.Domain;

namespace ReefTank.Core.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class, IAggregateRoot
    {
        public T FindBy(object id)
        {
            var entity = ActiveRecordMediator<T>.FindByPrimaryKey(id, false);
            if (entity == null)
            {
                throw new NotFoundException($"Couldn't find {typeof(T)} with Id {id}.");
            }
            return entity;
        }

        public IEnumerable<T> FindBy(DetachedCriteria query)
        {
            return ActiveRecordMediator<T>.FindAll(query);
        }

        public IEnumerable<T> FindAll()
        {
            return ActiveRecordMediator<T>.FindAll();
        }

        public T FindOne()
        {
            return ActiveRecordMediator<T>.FindOne();
        }

        public T FindFirst(DetachedCriteria query)
        {
            return ActiveRecordMediator<T>.FindFirst(query);
        }

        public int Count(DetachedCriteria query)
        {
            return ActiveRecordMediator<T>.Count(query);
        }

        public void Save(T entity)
        {
            ActiveRecordMediator<T>.Save(entity);
        }

        public void Add(T entity)
        {
            ActiveRecordMediator<T>.Create(entity);
        }

        public void Remove(T entity)
        {
            ActiveRecordMediator<T>.Delete(entity);
        }

        public void SaveAndFlush(T model)
        {
            ActiveRecordMediator.SaveAndFlush(model);
        }
    }
}
