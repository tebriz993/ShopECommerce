using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopECommerce.Entity.Concrete.Common.Featured_Products
{
    public class Featured_Products:BaseEntity
    {
        public string Image { get; set; }
        public string ProductName { get; set; }
        public int Stars { get; set; }
        public double NewPrice { get; set; }
        public double BeforePrice { get; set; }
    }
}
