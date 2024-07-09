using ShopECommerce.Entity.Concrete.Common.Home;
using ShopECommerce.Entity.Concrete.Common.Testimonial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopECommerce.DataAccessLayer.Abstract.Commons
{
    public interface IHome_CompanyRatesRepository:IGenericRepository<Home_CompanyRates>
    {
        Task<IEnumerable<Home_CompanyRates>> GatCompanyRates();
        Task UpdateAsync(Home_CompanyRates home_CompanyRates);
        Task DeleteAsync(Home_CompanyRates home_CompanyRates);
    }
}
