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
    public class ProfessionsRepository:GenericRepository<Professions>, IProfessionsRepository
    {
        public ProfessionsRepository(ShopECommerceDbContext dbcontext):base(dbcontext)
        {
            
        }

        public async Task<IEnumerable<Professions>> GetProfessions()
        {
            var data = await Table.Include(x => x.ClientSays).ToListAsync();
            return data;
        }
    }
}
