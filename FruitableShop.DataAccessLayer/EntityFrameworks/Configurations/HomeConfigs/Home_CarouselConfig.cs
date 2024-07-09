using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.IdentityModel.Tokens;
using ShopECommerce.DataAccessLayer.EntityFrameworks.Configurations.Common;
using ShopECommerce.Entity.Concrete.Common.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopECommerce.DataAccessLayer.EntityFrameworks.Configurations.HomeConfigs
{
    public class Home_CarouselConfig : BaseConfiguration<Home_Carousel>
    {
        public override void Configure(EntityTypeBuilder<Home_Carousel> builder)
        {
            base.Configure(builder);
            builder.Property(i => i.Image)
                .IsRequired();

            builder.Property(t => t.Title)
                .IsRequired();

        }
    }
}
