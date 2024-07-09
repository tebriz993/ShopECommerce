
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopECommerce.Entity.Concrete.Common.Shop
{
    public class Shop_Additional : BaseEntity
    {
        public string Type { get; set; } = string.Empty;
        public ICollection<Products> Products { get; set; }=new HashSet<Products>();
    }
}
