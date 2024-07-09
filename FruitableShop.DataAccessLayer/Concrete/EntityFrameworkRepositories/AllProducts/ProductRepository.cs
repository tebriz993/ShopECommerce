using Microsoft.EntityFrameworkCore;
using ShopECommerce.DataAccessLayer.Abstract.Commons;
using ShopECommerce.DataAccessLayer.Concrete.EntityFrameworkRepositories.Common;
using ShopECommerce.DataAccessLayer.EntityFrameworks.Contexts;
using ShopECommerce.Entity.Concrete.Common;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopECommerce.DataAccessLayer.Concrete.EntityFrameworkRepositories.AllProducts
{
    public class ProductRepository : GenericRepository<Products>, IProductsRepository
    {
        public ProductRepository(ShopECommerceDbContext dbcontext) : base(dbcontext)
        {
        }

        public async Task<IEnumerable<Products>> GetProducts(int? categoryId)
        {
            return await Table.Include(x => x.Categories)
                              .Where(p => categoryId == null || p.CategoryId == categoryId)
                              .ToListAsync();
        }
    }
}
