
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
    public class Home_CompanyRatesRepository : GenericRepository<Home_CompanyRates>, IHome_CompanyRatesRepository
    {
        public Home_CompanyRatesRepository(ShopECommerceDbContext dbContext) : base(dbContext)
        {

        }

        public async Task<IEnumerable<Home_CompanyRates>> GatCompanyRates()
        {
            return await Table.ToListAsync();
        }
        public async Task UpdateAsync(Home_CompanyRates home_CompanyRates)
        {
            Table.Update(home_CompanyRates);
            await SaveChanges();
        }

        public async Task DeleteAsync(Home_CompanyRates home_CompanyRates)
        {
            Table.Remove(home_CompanyRates);
            await SaveChanges();
        }
    }
}
