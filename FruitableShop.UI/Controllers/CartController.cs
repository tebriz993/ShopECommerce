using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ShopECommerce.BusinessLogic.Abstract;
using ShopECommerce.BusinessLogic.Concrete;
using ShopECommerce.BusinessLogic.Dtos.CartDtos;

namespace ShopECommerce.UI.Controllers
{
    public class CartController : Controller
    {
        private readonly ICartService _cartService;
        private readonly IMapper _mapper;

        public CartController(ICartService cartService, IMapper mapper)
        {
            _cartService = cartService;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<CartItemViewDto> carts = await _cartService.GetAllCartItems();
            return View(carts);
        }

        [HttpPost]
        public async Task<IActionResult> AddToCart(int productId, string productName, string productImage, double productPrice)
        {
            var cartItem = new CartItemViewDto
            {
                ProductId = productId,
                ProductName = productName,
                ProductImage = productImage,
                ProductPrice = productPrice,
                Quantity = 1
            };

            await  _cartService.AddToCartAsync(cartItem);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> RemoveFromCart(int productId)
        {
            if (productId == null || productId < 1)
            {
                return BadRequest();
            }

            var carts = await _cartService.GetCartItemsById(productId);
            if (carts == null)
            {
                return NotFound();
            }
            await _cartService.RemoveFromCartAsync(productId);
            return RedirectToAction(nameof(Index));
        }


        [HttpPost]
        public async Task<IActionResult> ClearCart()
        {
            await _cartService.ClearCartAsync();
            return PartialView("_CartItemsPartial", await _cartService.GetAllCartItems());
        }

    }
}
