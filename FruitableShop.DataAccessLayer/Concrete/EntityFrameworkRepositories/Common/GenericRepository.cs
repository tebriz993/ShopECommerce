using Microsoft.EntityFrameworkCore;
using ShopECommerce.DataAccessLayer.Abstract;
using ShopECommerce.DataAccessLayer.EntityFrameworks.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ShopECommerce.DataAccessLayer.Concrete.EntityFrameworkRepositories.Common
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class, new()
    {

        private readonly ShopECommerceDbContext _dbContext;
        protected DbSet<T> Table => _dbContext.Set<T>();

        public GenericRepository(ShopECommerceDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<bool> AddAsync(T entity)
        {
            var addedState = await Table.AddAsync(entity);
            return addedState.State == EntityState.Added;
        }

        public async Task<IEnumerable<T>> GetAllAsync(bool tracking = true)
        {
            if (tracking is false)
            {
                return await Table.AsNoTracking().ToListAsync();
            }

            return await Table.ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id) => await Table.FindAsync(id);

        public async Task<IEnumerable<T>> GetWhereAsync(Expression<Func<T, bool>> expression)
              => await Table.Where(expression).ToListAsync();


        public bool Remove(T entity)
        {
            var removed = Table.Remove(entity);
            return removed.State == EntityState.Deleted;
        }

        public async Task SaveChanges()
        {
            await _dbContext.SaveChangesAsync();
        }

        public bool Update(T entity)
        {
            var updated = Table.Update(entity);
            return updated.State == EntityState.Modified;
        }
    }
}
