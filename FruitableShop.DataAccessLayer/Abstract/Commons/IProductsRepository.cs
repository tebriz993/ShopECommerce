using ShopECommerce.Entity.Concrete.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopECommerce.DataAccessLayer.Abstract.Commons
{
    public interface IProductsRepository : IGenericRepository<Products>
    {
        Task<IEnumerable<Products>> GetProducts(int? categoryId);
    }
}
