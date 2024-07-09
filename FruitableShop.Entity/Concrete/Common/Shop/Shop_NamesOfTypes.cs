using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopECommerce.Entity.Concrete.Common.Shop
{
    public class Shop_NamesOfTypes : BaseEntity
    {
        public string TypeName { get; set; } = string.Empty;
        public ICollection<Products> Products { get; set; }
    }
}
