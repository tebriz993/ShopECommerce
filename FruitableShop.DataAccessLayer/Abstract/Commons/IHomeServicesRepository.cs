using ShopECommerce.Entity.Concrete.Common.Home;
using ShopECommerce.Entity.Concrete.Common.Testimonial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopECommerce.DataAccessLayer.Abstract.Commons
{
    public interface IHomeServicesRepository:IGenericRepository<Home_Services>
    {
        Task<IEnumerable<Home_Services>> GetServices();
        Task UpdateAsync(Home_Services homeServices);
        Task DeleteAsync(Home_Services homeServices);
    }
}
