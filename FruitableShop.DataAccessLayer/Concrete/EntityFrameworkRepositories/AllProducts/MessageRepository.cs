using ShopECommerce.DataAccessLayer.Abstract;
using ShopECommerce.DataAccessLayer.Abstract.Commons;
using ShopECommerce.DataAccessLayer.Concrete.EntityFrameworkRepositories.Common;
using ShopECommerce.DataAccessLayer.EntityFrameworks.Contexts;
using ShopECommerce.Entity.Concrete.Common.Contact;
using ShopECommerce.Entity.Concrete.Common.Message;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopECommerce.DataAccessLayer.Concrete.EntityFrameworkRepositories.AllProducts
{
    public class MessageRepository:GenericRepository<Messages>, IMessageRepository
    {
        public MessageRepository(ShopECommerceDbContext dbContext) : base(dbContext)
        {

        }

        public async Task DeleteAsync(Messages messages)
        {
            Table.Remove(messages);
            await SaveChanges();
        }
    }
}
