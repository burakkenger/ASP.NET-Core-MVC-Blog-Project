using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Abstract
{
    public interface IGenericDal<T> where T : class
    {
        void Insert(T entity);
        void Delete(T entity);
        void Update(T entity);
        ICollection<T> GetAll();
        T GetByID(int ID);
        ICollection<T> GetAll(Expression<Func<T, bool>> predicate);
    }
}
