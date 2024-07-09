using Microsoft.EntityFrameworkCore;
using ShopECommerce.DataAccessLayer.Abstract.Commons;
using ShopECommerce.DataAccessLayer.Concrete.EntityFrameworkRepositories.Common;
using ShopECommerce.DataAccessLayer.EntityFrameworks.Contexts;
using ShopECommerce.Entity.Concrete.Common.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopECommerce.DataAccessLayer.Concrete.EntityFrameworkRepositories.AllProducts
{
    public class Home_ServicesRepository:GenericRepository<Home_Services>, IHomeServicesRepository
    {
        public Home_ServicesRepository(ShopECommerceDbContext dbContext) : base(dbContext)
        {

        }

        public async Task DeleteAsync(Home_Services homeServices)
        {
            Table.Remove(homeServices);
            await SaveChanges();
        }

        public async Task<IEnumerable<Home_Services>> GetServices()
        {
            return await Table.ToListAsync();
        }

        public async Task UpdateAsync(Home_Services homeServices)
        {
            Table.Update(homeServices);
            await SaveChanges();
        }
    }
}
