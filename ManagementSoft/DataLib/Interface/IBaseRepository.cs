using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataLib.Interface
{
    public interface IBaseRepository<T>
    {
        Task Add(T obj);
        void Delete(T obj);
        Task<List<T>> Get();
        Task<T> GetById(int id);
        Task<List<T>> GetByCondtion(Expression<Func<T, bool>> expression);
        void Update(T obj);
    }
}
