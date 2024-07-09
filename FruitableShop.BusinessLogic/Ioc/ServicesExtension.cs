using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ShopECommerce.BusinessLogic.Abstract;
using ShopECommerce.BusinessLogic.Concrete;
using ShopECommerce.DataAccessLayer.Abstract.Commons;
using ShopECommerce.DataAccessLayer.Concrete.EntityFrameworkRepositories.AllProducts;
using ShopECommerce.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace ShopECommerce.BusinessLogic.Ioc
{
    public static class ServicesExtension
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddScoped<IProductsRepository, ProductRepository>();
            services.AddScoped<ICategoriesRepository, CategoriesRepository>();
            services.AddScoped<IProductService, ProductService>();

            services.AddScoped<IHome_CarouselRepository, Home_CarouselRepository>();
            services.AddScoped<IHome_CompanyRatesRepository, Home_CompanyRatesRepository>();
            services.AddScoped<IHomeServicesRepository, Home_ServicesRepository>();
            services.AddScoped<IHomeService, HomeService>();

            services.AddScoped<IClientSaysRepository, ClientSaysRepository>();
            services.AddScoped<IProfessionsRepository, ProfessionsRepository>();
            services.AddScoped<ITestimonialServicecs, TestimonialService>();

            services.AddScoped<ICartService, CartService>();
            services.AddScoped<ICartItemRepository, CartItemRepository>();

            
            services.AddScoped<IContactRepository, ContactRepository>();
            services.AddScoped<IMessageRepository, MessageRepository>();
            services.AddScoped<IContactService, ContactService>();

            

            services.AddAutoMapper(Assembly.GetExecutingAssembly());
        }
    }
}


