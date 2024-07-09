using ShopECommerce.DataAccessLayer.Abstract.Commons;
using ShopECommerce.DataAccessLayer.Concrete.EntityFrameworkRepositories.Common;
using ShopECommerce.DataAccessLayer.EntityFrameworks.Contexts;
using ShopECommerce.Entity.Concrete.Common.Shop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopECommerce.DataAccessLayer.Concrete.EntityFrameworkRepositories.AllProducts
{
    public class Shop_AdditionalRepository:GenericRepository<Shop_Additional>, IShop_AdditionalRepository
    {
        public Shop_AdditionalRepository(ShopECommerceDbContext dbcontext): base(dbcontext)
        {
            
        }
    }
}
