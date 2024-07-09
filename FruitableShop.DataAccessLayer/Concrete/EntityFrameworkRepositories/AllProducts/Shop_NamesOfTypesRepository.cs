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
    public class Shop_NamesOfTypesRepository:GenericRepository<Shop_NamesOfTypes>, IShop_NamesOfTypesRepository
    {
        public Shop_NamesOfTypesRepository(ShopECommerceDbContext dbcontext):base(dbcontext)
        {
            
        }
    }
}
