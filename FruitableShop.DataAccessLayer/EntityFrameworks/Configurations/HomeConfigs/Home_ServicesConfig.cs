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
    public class Home_ServicesConfig : BaseConfiguration<Home_Services>
    {
        public override void Configure(EntityTypeBuilder<Home_Services> builder)
        {
            base.Configure(builder);
            builder.Property(t => t.Icon).IsRequired();
            builder.Property(t => t.Title).IsRequired();
            builder.Property(s => s.Subtitle).IsRequired();
        }
    }
}
