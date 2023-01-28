using DataAccesLayer.Abstract;
using DataAccesLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        Context data = new Context();

        public void Insert(T entity)
        {
            data.Add(entity);
            data.SaveChanges();
        }

        public void Delete(T entity)
        {
            data.Remove(entity);
            data.SaveChanges();
        }

        public void Update(T entity)
        {
            data.Update(entity);
            data.SaveChanges();
        }

        public T GetByID(int ID)
        {
            return data.Set<T>().Find(ID);
        }

        public ICollection<T> GetAll()
        {
            return data.Set<T>().ToList();
        }

        public ICollection<T> GetAll(Expression<Func<T, bool>> predicate)
        {
            return data.Set<T>().Where(predicate).ToList();
        }

        public T Get(Expression<Func<T, bool>> predicate)
        { 
            return data.Set<T>().FirstOrDefault(predicate);
        }
    }
}
