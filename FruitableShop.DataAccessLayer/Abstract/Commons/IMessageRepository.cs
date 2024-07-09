using ShopECommerce.Entity.Concrete.Common.Contact;
using ShopECommerce.Entity.Concrete.Common.Message;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopECommerce.DataAccessLayer.Abstract.Commons
{
    public interface IMessageRepository:IGenericRepository<Messages>
    {
        Task DeleteAsync(Messages messages);
    }
}
