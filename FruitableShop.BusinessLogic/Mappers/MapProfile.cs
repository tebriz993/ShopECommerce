using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopECommerce.Entity.Concrete;
using ShopECommerce.Entity.Concrete.Common;
using ShopECommerce.BusinessLogic.Dtos.ProductsDtos;
using ShopECommerce.Entity.Concrete.Common.Testimonial;
using ShopECommerce.BusinessLogic.Dtos.TestimonialDtos;
using ShopECommerce.Entity.Concrete.Common.Home;
using ShopECommerce.BusinessLogic.Dtos.HomeDtos;
using ShopECommerce.Entity.Concrete.Common.OurProducts;
using ShopECommerce.BusinessLogic.Dtos.Categories;
using ShopECommerce.Entity.Concrete.Common.Card;
using ShopECommerce.BusinessLogic.Dtos.CartDtos;
using ShopECommerce.Entity.Concrete.Common.Contact;
using ShopECommerce.BusinessLogic.Dtos.ContactDtos;
using ShopECommerce.BusinessLogic.Dtos.MessagesDtos;
using ShopECommerce.Entity.Concrete.Common.Message;

namespace ShopECommerce.BusinessLogic.Mappers
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            CreateMap<Products, ProductViewDto>().ForMember(c => c.CategoryName, y => y.MapFrom(x=>x.Categories.Name));
            CreateMap<Categories, CategoriesViewDto>();
            CreateMap<ClientSays, TestimonialViewDto>().ForMember(s => s.ProfessionName, y => y.MapFrom(x => x.Professions.Name));
            CreateMap<TestimonialViewDto, ClientSays>();

            CreateMap<ProfessionsViewDto, Professions>();
            CreateMap<Professions, ProfessionsViewDto>();

            CreateMap<Home_Carousel, Home_CarouselViewDto>();
            CreateMap<Home_CarouselViewDto, Home_Carousel>();
            
            CreateMap<Home_CompanyRates, Home_CompanyRatesViewDto>();
            CreateMap<Home_CompanyRatesViewDto, Home_CompanyRates>();

            CreateMap<Home_Services, Home_ServicesViewDto>();
            CreateMap<Home_ServicesViewDto, Home_Services>();

            CreateMap<Contacts, ContactViewDto>();
            CreateMap<ContactViewDto, Contacts>();

            CreateMap<CartItem, CartItemViewDto>();
            CreateMap<CartItemViewDto, CartItem>();

            CreateMap<MessageViewDto, Messages>();
            CreateMap<Messages, MessageViewDto>();



        }
    }
}
