using ShopECommerce.Entity.Concrete.Common.Contact;
using ShopECommerce.Entity.Concrete.Common.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopECommerce.DataAccessLayer.Abstract.Commons
{
    public interface IContactRepository:IGenericRepository<Contacts>
    {
        Task<IEnumerable<Contacts>> GetContacts();
        Task UpdateAsync(Contacts contacts);
        Task DeleteAsync(Contacts contacts);
    }
}
