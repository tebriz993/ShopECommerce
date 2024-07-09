using ShopECommerce.BusinessLogic.Dtos.CartDtos;
using ShopECommerce.BusinessLogic.Dtos.ContactDtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopECommerce.BusinessLogic.Abstract
{
    public interface ICartService
    {
        Task AddToCartAsync(CartItemViewDto cartItemViewDto);
        Task ClearCartAsync();
        Task<IEnumerable<CartItemViewDto>> GetAllCartItems();
        Task RemoveFromCartAsync(int productId);
        Task<CartItemViewDto> GetCartItemsById(int id);
    }
}
