using Microsoft.EntityFrameworkCore;
using ShopECommerce.DataAccessLayer.Abstract.Commons;
using ShopECommerce.DataAccessLayer.Concrete.EntityFrameworkRepositories.Common;
using ShopECommerce.DataAccessLayer.EntityFrameworks.Contexts;
using ShopECommerce.Entity.Concrete.Common.OurProducts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopECommerce.DataAccessLayer.Concrete.EntityFrameworkRepositories.AllProducts
{
    public class CategoriesRepository:GenericRepository<Categories>, ICategoriesRepository
    {
        public CategoriesRepository(ShopECommerceDbContext dbcontext):base(dbcontext)
        {
            
        }

        public async Task<IEnumerable<Categories>> GetCategories()
        {
            return await Table.Include(p=>p.Products).ToListAsync();
        }
    }
}
