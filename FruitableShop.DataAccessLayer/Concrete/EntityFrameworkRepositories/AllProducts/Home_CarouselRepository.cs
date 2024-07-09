using Microsoft.EntityFrameworkCore;
using ShopECommerce.DataAccessLayer.Abstract.Commons;
using ShopECommerce.DataAccessLayer.Concrete.EntityFrameworkRepositories.Common;
using ShopECommerce.DataAccessLayer.EntityFrameworks.Contexts;
using ShopECommerce.Entity.Concrete.Common.Home;
using ShopECommerce.Entity.Concrete.Common.Testimonial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopECommerce.DataAccessLayer.Concrete.EntityFrameworkRepositories.AllProducts
{
    public class Home_CarouselRepository:GenericRepository<Home_Carousel>, IHome_CarouselRepository
    {
        public Home_CarouselRepository(ShopECommerceDbContext dbContext) : base(dbContext)
        {

        }

      
        public async Task<IEnumerable<Home_Carousel>> GetCarousels()
        {
            return await Table.ToListAsync();
        }
        
        public async Task UpdateAsync(Home_Carousel homeCarousel)
        {
            Table.Update(homeCarousel);
            await SaveChanges();
        }

        public async Task DeleteAsync(Home_Carousel homeCarousel)
        {
            Table.Remove(homeCarousel);
            await SaveChanges();
        }

    }
}
