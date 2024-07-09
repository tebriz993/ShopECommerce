using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopECommerce.Entity.Concrete.Common.Testimonial
{
    public class Professions:BaseEntity
    {
        public string Name { get; set; }
        public ICollection<ClientSays> ClientSays { get; set; }
    }
}
