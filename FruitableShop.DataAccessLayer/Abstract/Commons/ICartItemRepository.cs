using ShopECommerce.Entity.Concrete.Common.Card;
using ShopECommerce.Entity.Concrete.Common.Contact;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopECommerce.DataAccessLayer.Abstract.Commons
{
    public interface ICartItemRepository:IGenericRepository<CartItem>
    {
        public Task<IEnumerable<CartItem>> GetCartItems();
        public Task DeleteAsync(CartItem cartItem);
        public Task UpdateAsync(CartItem existingItem);

    }
}
