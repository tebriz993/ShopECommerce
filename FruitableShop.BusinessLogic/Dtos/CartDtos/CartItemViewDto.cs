using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopECommerce.BusinessLogic.Dtos.CartDtos
{
    public class CartItemViewDto
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductImage { get; set; }
        public double ProductPrice { get; set; }
        public int Quantity { get; set; }
        public double TotalPrice => ProductPrice * Quantity;

        public double Tax { get; set; } = 3.2;
    }
}
