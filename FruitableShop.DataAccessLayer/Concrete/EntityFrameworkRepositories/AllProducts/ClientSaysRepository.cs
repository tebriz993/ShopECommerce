using Microsoft.EntityFrameworkCore;
using ShopECommerce.DataAccessLayer.Abstract.Commons;
using ShopECommerce.DataAccessLayer.Concrete.EntityFrameworkRepositories.Common;
using ShopECommerce.DataAccessLayer.EntityFrameworks.Contexts;
using ShopECommerce.Entity.Concrete.Common.Testimonial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopECommerce.DataAccessLayer.Concrete.EntityFrameworkRepositories.AllProducts
{
    public class ClientSaysRepository:GenericRepository<ClientSays>, IClientSaysRepository
    {
        public ClientSaysRepository(ShopECommerceDbContext dbcontext):base(dbcontext)
        {
            
        }

        public async Task DeleteAsync(ClientSays clientSays)
        {
            Table.Remove(clientSays);
            await SaveChanges();
        }

        public async Task<IEnumerable<ClientSays>> GetClientSays()
        {
            var data = await Table.Include(x => x.Professions).ToListAsync();
            return data;
        }

        public async Task UpdateAsync(ClientSays clientSays)
        {
            
            Table.Update(clientSays);
            await SaveChanges();
        }
    }
}
