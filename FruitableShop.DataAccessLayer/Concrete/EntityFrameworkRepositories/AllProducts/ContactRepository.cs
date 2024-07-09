using Microsoft.EntityFrameworkCore;
using ShopECommerce.DataAccessLayer.Abstract.Commons;
using ShopECommerce.DataAccessLayer.Concrete.EntityFrameworkRepositories.Common;
using ShopECommerce.DataAccessLayer.EntityFrameworks.Contexts;
using ShopECommerce.Entity.Concrete.Common.Contact;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopECommerce.DataAccessLayer.Concrete.EntityFrameworkRepositories.AllProducts
{
    public class ContactRepository:GenericRepository<Contacts>, IContactRepository
    {
        public ContactRepository(ShopECommerceDbContext dbContext) : base(dbContext)
        {

        }

        public async Task DeleteAsync(Contacts contacts)
        {
            Table.Remove(contacts);
            await SaveChanges();
        }

        public async Task<IEnumerable<Contacts>> GetContacts()
        {
            return await Table.ToListAsync();
        }

        public async Task UpdateAsync(Contacts contacts)
        {
            Table.Update(contacts);
            await SaveChanges();
        }
    }
}
