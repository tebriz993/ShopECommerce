
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopECommerce.Entity.Concrete.Common.OurProducts;
using ShopECommerce.Entity.Concrete.Common.Shop;

namespace ShopECommerce.Entity.Concrete.Common
{
    public class Products:BaseEntity
    {
        public string CategoryImage { get; set; } = string.Empty;
        
        public string Title { get; set; } = string.Empty;
        public string Subtitle { get; set; } = string.Empty;
        public string SignOfMoney { get; set; } = string.Empty;
        public double Price { get; set; }
        public string TypeOfWeight { get; set; } = string.Empty;

        

        public int Shop_NamesOfTypesId { get; set; }
        public Shop_NamesOfTypes Shop_NamesOfTypes { get; set; }

        public int Shop_AdditionalId { get; set; }
        public Shop_Additional Shop_Additional { get; set; }

        public int CategoryId { get; set; }
        public Categories Categories { get; set; }






    }
}
