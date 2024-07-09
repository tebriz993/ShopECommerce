using ShopECommerce.DataAccessLayer.Abstract.Commons;
using ShopECommerce.DataAccessLayer.Concrete.EntityFrameworkRepositories.Common;
using ShopECommerce.DataAccessLayer.EntityFrameworks.Contexts;
using ShopECommerce.Entity.Concrete.Common.Featured_Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopECommerce.DataAccessLayer.Concrete.EntityFrameworkRepositories.AllProducts
{
    public class Featured_ProductsRepository:GenericRepository<Featured_Products>, IFeatured_ProductsRepository
    {
        public Featured_ProductsRepository(ShopECommerceDbContext dbcontext):base(dbcontext)
        {
            
        }
    }
}
