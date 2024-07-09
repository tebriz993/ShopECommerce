using ShopECommerce.Entity.Concrete.Common.OurProducts;
using ShopECommerce.Entity.Concrete.Common.Testimonial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopECommerce.DataAccessLayer.Abstract.Commons
{
    public interface ICategoriesRepository:IGenericRepository<Categories>
    {
        Task<IEnumerable<Categories>> GetCategories();
    }

}
