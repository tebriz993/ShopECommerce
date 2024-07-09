using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ShopECommerce.BusinessLogic.Abstract;
using ShopECommerce.BusinessLogic.Dtos.HomeDtos;
using ShopECommerce.DataAccessLayer.Abstract.Commons;
using ShopECommerce.Entity.Concrete.Common.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopECommerce.BusinessLogic.Concrete
{
    public class HomeService : IHomeService
    {
        private readonly IHome_CarouselRepository _homeCarouselRepository;
        private readonly IHome_CompanyRatesRepository _homeCompanyRatesRepository;
        private readonly IHomeServicesRepository _homeServicesRepository;
        private readonly IMapper _mapper;

        public HomeService(IHome_CarouselRepository homeCarouselRepository,
                           IHome_CompanyRatesRepository homeCompanyRatesRepository,
                           IHomeServicesRepository homeServicesRepository,
                           IMapper mapper)
        {
            _homeCarouselRepository = homeCarouselRepository;
            _homeCompanyRatesRepository = homeCompanyRatesRepository;
            _homeServicesRepository = homeServicesRepository;
            _mapper = mapper;
        }
        
        //Home_Craousel Methods
        public async Task<IEnumerable<Home_CarouselViewDto>> GetAllHomeCarousels()
        {
            var carouselList = await _homeCarouselRepository.GetCarousels();
            var carouselViewDtos = _mapper.Map<IEnumerable<Home_CarouselViewDto>>(carouselList);
            return carouselViewDtos;
        }

        public async Task<Home_CarouselViewDto> GetHomeCarouselById(int id)
        {
            var carousel = await _homeCarouselRepository.GetByIdAsync(id);
            return _mapper.Map<Home_CarouselViewDto>(carousel);
        }
        public async Task CreateHomeCarousel(Home_CarouselViewDto homeCarouselViewDto)
        {
            var homeCarousel = _mapper.Map<Home_Carousel>(homeCarouselViewDto);
            await _homeCarouselRepository.AddAsync(homeCarousel);
            await _homeCarouselRepository.SaveChanges();
        }

        public async Task UpdateHomeCarousel(Home_CarouselViewDto homeCarouselViewDto)
        {
            var homeCarousel = await _homeCarouselRepository.GetByIdAsync(homeCarouselViewDto.Id);
            if (homeCarousel != null)
            {
                _mapper.Map(homeCarouselViewDto, homeCarousel);
                await _homeCarouselRepository.UpdateAsync(homeCarousel);
            }

        }
        public async Task DeleteHomeCarousel(int id)
        {
            var homeCarousel = await _homeCarouselRepository.GetByIdAsync(id);
            if (homeCarousel != null)
            {
                await _homeCarouselRepository.DeleteAsync(homeCarousel);
            }
        }




        //Home_CompanyRates Methods
        public async Task<IEnumerable<Home_CompanyRatesViewDto>> GetAllHomeCompanyRates()
        {
            var companyRatesList = await _homeCompanyRatesRepository.GatCompanyRates();
            var companyRatesViewDtos = _mapper.Map<IEnumerable<Home_CompanyRatesViewDto>>(companyRatesList);
            return companyRatesViewDtos;
        }
        public async Task<Home_CompanyRatesViewDto> GetHomeCompanyRatesById(int id)
        {
            var companyRates = await _homeCompanyRatesRepository.GetByIdAsync(id);
            return _mapper.Map<Home_CompanyRatesViewDto>(companyRates);
        }

        public async Task CreateHomeCompanyRates(Home_CompanyRatesViewDto home_CompanyRatesViewDto)
        {
            var homeCompanyRates = _mapper.Map<Home_CompanyRates>(home_CompanyRatesViewDto);
            await _homeCompanyRatesRepository.AddAsync(homeCompanyRates);
            await _homeCompanyRatesRepository.SaveChanges();
        }

        public async Task UpdateHomeCompanyRates(Home_CompanyRatesViewDto home_CompanyRatesViewDto)
        {
           var homeCompanyRates=await _homeCompanyRatesRepository.GetByIdAsync(home_CompanyRatesViewDto.Id);
            if (homeCompanyRates != null)
            {
                _mapper.Map(home_CompanyRatesViewDto, homeCompanyRates);
                await _homeCompanyRatesRepository.UpdateAsync(homeCompanyRates);
            }
        }

        public async Task DeleteHomeCompanyRates(int id)
        {
            var homeCompanyRates = await _homeCompanyRatesRepository.GetByIdAsync(id);
            if(homeCompanyRates != null)
            {
                await _homeCompanyRatesRepository.DeleteAsync(homeCompanyRates);
            }
        }



        //Home_Services Methods
        public async Task<IEnumerable<Home_ServicesViewDto>> GetAllHomeServices()
        {
            var servicesList = await _homeServicesRepository.GetServices();
            var servicesViewDtos = _mapper.Map<IEnumerable<Home_ServicesViewDto>>(servicesList);
            return servicesViewDtos;
        }

        public async Task<Home_ServicesViewDto> GetHomeServicesById(int id)
        {
            var services = await _homeServicesRepository.GetByIdAsync(id);
            return _mapper.Map<Home_ServicesViewDto>(services);
        }

        public async Task CreateHomeServices(Home_ServicesViewDto home_ServicesViewDto)
        {
            var services = _mapper.Map<Home_Services>(home_ServicesViewDto);
            await _homeServicesRepository.AddAsync(services);
            await _homeServicesRepository.SaveChanges();
        }

        public async Task UpdateHomeServices(Home_ServicesViewDto home_ServicesViewDto)
        {
            var homeServices = await _homeServicesRepository.GetByIdAsync(home_ServicesViewDto.Id);
            if (homeServices != null)
            {
                _mapper.Map(home_ServicesViewDto, homeServices);
                await _homeServicesRepository.UpdateAsync(homeServices);
            }
        }

        public async Task DeleteHomeServices(int id)
        {
            var homeServices = await _homeServicesRepository.GetByIdAsync(id);
            if (homeServices != null)
            {
                await _homeServicesRepository.DeleteAsync(homeServices);
            }
        }
    }
}
