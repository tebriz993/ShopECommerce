using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopECommerce.Entity.Concrete.Common;

namespace ShopECommerce.Entity.Concrete.Common.OurProducts
{
    public class Categories : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public ICollection<Products> Products { get; set; } = new HashSet<Products>();
    }
}
