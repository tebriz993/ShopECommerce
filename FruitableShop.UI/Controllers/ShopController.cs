using System.Linq;
using Microsoft.AspNetCore.Mvc;

using ShopECommerce.Entity.Concrete.Common.Home;
using ShopECommerce.Service;
using Microsoft.EntityFrameworkCore;
using ShopECommerce.DataAccessLayer.EntityFrameworks.Contexts;

public class ShopController : Controller
{
    private readonly ShopECommerceDbContext _context;

    public ShopController(ShopECommerceDbContext context)
    {
        _context = context;
    }

    public IActionResult Index(int? shopNamesOfTypesId)
    {
       

        //Shop_VM shop = new Shop_VM
        //{
        //    Products = _context.Products.Where(p=>p.Shop_NamesOfTypesId==shopNamesOfTypesId).ToList(),
        //    Shop_NamesOfTypes = _context.Shop_NamesOfTypes.Include(p=>p.Products).ToList(),
        //    //Shop_Additionals = _context.Shop_Additionals.ToList(),
        //    Featured_Products= _context.Featured_Products.ToList()
        //};


        //var model = new Shop_VM
        //{
        //    Shop_NamesOfTypes = _productService.GetNamesOfTypes(),
        //    Shop_Additionals = _productService.GetAdditionals(),
        //    Products = _productService.GetProducts(shop_NamesOfTypesId, shop_AdditionalId),
        //    Featured_Products = _productService.GetFeatured_Products()
        //};

        //if (shop_NamesOfTypesId.HasValue)
        //{
        //    shop.Products = shop.Products.Where(p => p.Shop_NamesOfTypesId == shop_NamesOfTypesId.Value).ToList();
        //}

        //if (shop_AdditionalId.HasValue)
        //{
        //    shop.Products = shop.Products.Where(p => p.Shop_AdditionalId == shop_AdditionalId.Value).ToList();
        //}

        return View();
    }
}
