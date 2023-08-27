using System;
using Core.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Interface
{
    public interface IGenericRepo<T> where T : BaseEntity
    {
        /*
        Task<T> GetByIdAsync(int id);
        Task<IEnumerable<T>>GetAllAsync();
        IEnumerable<T> Find(Expression<Func<T, bool>> expression);
        
        void Add (T entity);
        void AddRange;
        Remove (T entity);
        void RemoveRanger (IEnumerable<T> entities);
        void update (T entity);
        */
    }
}