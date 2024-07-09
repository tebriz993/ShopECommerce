using AutoMapper;
using ShopECommerce.BusinessLogic.Abstract;
using ShopECommerce.BusinessLogic.Dtos.CartDtos;
using ShopECommerce.BusinessLogic.Dtos.ContactDtos;
using ShopECommerce.DataAccessLayer.Abstract.Commons;
using ShopECommerce.DataAccessLayer.Concrete.EntityFrameworkRepositories.AllProducts;
using ShopECommerce.Entity.Concrete.Common.Card;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopECommerce.BusinessLogic.Concrete
{
    public class CartService : ICartService
    {
        private readonly ICartItemRepository _cartItemRepository;
        private readonly IMapper _mapper;

        public CartService(ICartItemRepository cartItemRepository, IMapper mapper)
        {
            _cartItemRepository = cartItemRepository;
            _mapper = mapper;
        }

        public async Task AddToCartAsync(CartItemViewDto cartItemViewDto)
        {
            var cartItem = _mapper.Map<CartItem>(cartItemViewDto);
            var existingItem = await _cartItemRepository.GetByIdAsync(cartItemViewDto.ProductId);

            if (existingItem == null)
            {
                await _cartItemRepository.AddAsync(cartItem);
            }
            else
            {
                existingItem.Quantity++;
                await _cartItemRepository.UpdateAsync(existingItem);
            }

            await _cartItemRepository.SaveChanges();
        }

        public async Task ClearCartAsync()
        {
            var allItems = await _cartItemRepository.GetCartItems();
            foreach (var item in allItems)
            {
                await _cartItemRepository.DeleteAsync(item);
                //await _cartItemRepository.UpdateAsync(item);
            }

            await _cartItemRepository.SaveChanges();
        }

        public async Task<IEnumerable<CartItemViewDto>> GetAllCartItems()
        {
            var cartList = await _cartItemRepository.GetCartItems();
            return _mapper.Map<IEnumerable<CartItemViewDto>>(cartList);
        }

        public async Task<CartItemViewDto> GetCartItemsById(int id)
        {
            var carts = await _cartItemRepository.GetByIdAsync(id);
            return _mapper.Map<CartItemViewDto>(carts);
        }

        public async Task RemoveFromCartAsync(int productId)
        {
            var cartItem = await _cartItemRepository.GetByIdAsync(productId);
            if (cartItem != null)
            {
                await _cartItemRepository.DeleteAsync(cartItem);
                //await _cartItemRepository.UpdateAsync(cartItem);
                await _cartItemRepository.SaveChanges();
            }
        }
    }
}
