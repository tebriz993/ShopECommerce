using ShopECommerce.Entity.Concrete.Common.Home;
using ShopECommerce.Entity.Concrete.Common.Testimonial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopECommerce.DataAccessLayer.Abstract.Commons
{
    public interface IClientSaysRepository : IGenericRepository<ClientSays>
    {
        Task<IEnumerable<ClientSays>> GetClientSays();
        Task UpdateAsync(ClientSays clientSays);
        Task DeleteAsync(ClientSays clientSays);
    }
}
