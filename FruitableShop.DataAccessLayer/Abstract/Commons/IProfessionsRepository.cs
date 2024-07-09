using ShopECommerce.Entity.Concrete.Common.Testimonial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopECommerce.DataAccessLayer.Abstract.Commons
{
    public interface IProfessionsRepository:IGenericRepository<Professions>
    {
        Task<IEnumerable<Professions>> GetProfessions();
    }
}
