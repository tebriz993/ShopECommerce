using Microsoft.EntityFrameworkCore;
using ShopECommerce.DataAccessLayer.Abstract.Commons;
using ShopECommerce.DataAccessLayer.Concrete.EntityFrameworkRepositories.Common;
using ShopECommerce.DataAccessLayer.EntityFrameworks.Contexts;
using ShopECommerce.Entity.Concrete.Common.Card;
using ShopECommerce.Entity.Concrete.Common.OurProducts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopECommerce.DataAccessLayer.Concrete.EntityFrameworkRepositories.AllProducts
{
    public class CartItemRepository : GenericRepository<CartItem>, ICartItemRepository
    {
        public CartItemRepository(ShopECommerceDbContext dbcontext) : base(dbcontext)
        {

        }

        public async Task DeleteAsync(CartItem cartItem)
        {
            Table.Remove(cartItem);
            await SaveChanges();
        }

        public async Task<IEnumerable<CartItem>> GetCartItems()
        {
            return await Table.ToListAsync();
        }

        public async Task UpdateAsync(CartItem existingItem)
        {
            Table.Update(existingItem);
            await SaveChanges();
        }
    }
}
