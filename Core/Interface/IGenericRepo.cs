using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Interface;

public interface IGenericRepo<T> where T : BaseEntity
{
    //Palabra reservada para representar la asincronía
    
    Task<T> GetByIdAsync(int id);
    Task<IEnumerable<T>>GetAllAsync();
    
    //IEnumerable<T> Find(Expression<Func<T, bool>> expression);

    void Add (T entity);
    void AddRange(T entity);
    void Remove (T entity);
    void RemoveRanger (IEnumerable<T> entities);
    void Update (T entity);
    
}
