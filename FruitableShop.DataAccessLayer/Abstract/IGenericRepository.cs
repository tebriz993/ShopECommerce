using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ShopECommerce.DataAccessLayer.Abstract
{
    public interface IGenericRepository<T> where T : class, new()
    {
        Task<IEnumerable<T>> GetAllAsync(bool trackimg=true);
        Task<T> GetByIdAsync(int id);
        Task<IEnumerable<T>> GetWhereAsync(Expression<Func<T, bool>> expression);
        Task<bool> AddAsync(T entity);
        Task SaveChanges();
        bool Update(T entity);
        bool Remove(T entity);
    }
}
