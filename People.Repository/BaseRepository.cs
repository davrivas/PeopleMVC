using People.Context.Contexts;
using People.Model.Entities;
using System;
using System.Linq;

namespace People.Repository
{
    public interface IBaseRepository<T>
    {
        bool Create(T entity);
        bool Delete(T entity);
        T Get(int id);
        IQueryable<T> List();
        bool Update(T oldEntity, T newEntity);
    }

    public abstract class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity, IBaseEntity
    {
        protected readonly PeopleContext Context;

        public BaseRepository()
        {
            Context = new PeopleContext();
        }

        public virtual bool Create(T entity)
        {
            throw new NotImplementedException();
        }

        public virtual bool Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public virtual T Get(int id)
        {
            try
            {
                return Context.Set<T>().Find(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                return null;
            }
        }

        public virtual IQueryable<T> List()
        {
            try
            {
                return Context.Set<T>();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                return null;
            }
        }

        public bool Update(T oldEntity, T newEntity)
        {
            throw new NotImplementedException();
        }
    }
}
