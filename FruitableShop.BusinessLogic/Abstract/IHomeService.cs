using ShopECommerce.BusinessLogic.Dtos.HomeDtos;
using ShopECommerce.Entity.Concrete.Common.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopECommerce.BusinessLogic.Abstract
{
    public interface IHomeService
    {
        //Home_Carousel operations
        public Task<IEnumerable<Home_CarouselViewDto>> GetAllHomeCarousels();
        public Task<Home_CarouselViewDto> GetHomeCarouselById(int id);
        public Task CreateHomeCarousel(Home_CarouselViewDto homeCarouselViewDto);
        public Task UpdateHomeCarousel(Home_CarouselViewDto homeCarouselViewDto);
        public Task DeleteHomeCarousel(int id);


        //Home_CompanyRates operations
        public Task<IEnumerable<Home_CompanyRatesViewDto>> GetAllHomeCompanyRates();
        public Task<Home_CompanyRatesViewDto> GetHomeCompanyRatesById(int id);
        public Task CreateHomeCompanyRates(Home_CompanyRatesViewDto home_CompanyRatesViewDto);
        public Task UpdateHomeCompanyRates(Home_CompanyRatesViewDto home_CompanyRatesViewDto);
        public Task DeleteHomeCompanyRates(int id);


        //Home_Services operations
        public Task<IEnumerable<Home_ServicesViewDto>> GetAllHomeServices();
        public Task<Home_ServicesViewDto> GetHomeServicesById(int id);
        public Task CreateHomeServices(Home_ServicesViewDto home_ServicesViewDto);
        public Task UpdateHomeServices(Home_ServicesViewDto home_ServicesViewDto);
        public Task DeleteHomeServices(int id);

    }
}
