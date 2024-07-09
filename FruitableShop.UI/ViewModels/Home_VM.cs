using ShopECommerce.BusinessLogic.Dtos.HomeDtos;
using ShopECommerce.BusinessLogic.Dtos.ProductsDtos;
using ShopECommerce.Entity.Concrete.Common.Home;

namespace ShopECommerce.UI.ViewModels
{
    public class Home_VM
    {
        public IEnumerable<Home_CarouselViewDto> HomeCarousels { get; set; }
        public IEnumerable<Home_CompanyRatesViewDto> HomeCompanyRates { get; set; }
        public IEnumerable<Home_ServicesViewDto> HomeServices { get; set; }
    }
}
