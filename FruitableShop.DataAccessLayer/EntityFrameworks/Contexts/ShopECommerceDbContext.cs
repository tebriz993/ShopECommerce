using Microsoft.EntityFrameworkCore;
using ShopECommerce.Entity.Concrete.Common;
using ShopECommerce.Entity.Concrete.Common.Card;
using ShopECommerce.Entity.Concrete.Common.Contact;
using ShopECommerce.Entity.Concrete.Common.Featured_Products;
using ShopECommerce.Entity.Concrete.Common.Home;
using ShopECommerce.Entity.Concrete.Common.Message;
using ShopECommerce.Entity.Concrete.Common.OurProducts;
using ShopECommerce.Entity.Concrete.Common.Shop;
using ShopECommerce.Entity.Concrete.Common.Testimonial;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ShopECommerce.DataAccessLayer.EntityFrameworks.Contexts
{
    public class ShopECommerceDbContext:DbContext
    {
        public ShopECommerceDbContext(DbContextOptions<ShopECommerceDbContext> options):base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.LogTo(x=> Debug.Write(x));
        }
        public DbSet<Featured_Products> Featured_Products { get; set; }
        public DbSet<Home_Carousel> Home_Carousels { get; set; }
        public DbSet<Home_CompanyRates> Home_CompanyRates { get; set; }
        public DbSet<Home_Services> Home_Services { get; set; }
        public DbSet<Shop_Additional> Shop_Additionals { get; set; }
        public DbSet<Shop_NamesOfTypes> Shop_NamesOfTypes { get; set; }
        public DbSet<ClientSays> ClientSays { get; set; }
        public DbSet<Professions> Professions { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Contacts> Contacts { get; set; }
        public DbSet<Messages> Messages { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly
                  (Assembly.GetExecutingAssembly());

            //Istesen SQLde yox burda yaza bilersen
            //modelBuilder.Entity<Home_CompanyRates>()
            //   .HasData(
            //    new Home_CompanyRates
            //    {
            //        //Datas
            //    }
            //    );

          
        }  
    }
}
