using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopECommerce.BusinessLogic.Dtos.ProductsDtos
{
    public class ProductViewDto
    {
        public int Id { get; set; }
        public string CategoryImage { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string SignOfMoney { get; set; }
        public double Price { get; set; }
        public string TypeOfWeight { get; set; }

        public string CategoryName { get; set; }    
    }
}
