using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopECommerce.DataAccessLayer.EntityFrameworks.Configurations.Common;
using ShopECommerce.Entity.Concrete.Common.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopECommerce.DataAccessLayer.EntityFrameworks.Configurations.HomeConfigs
{
    public class Home_CompanyRatesConfig : BaseConfiguration<Home_CompanyRates>
    {
        public override void Configure(EntityTypeBuilder<Home_CompanyRates> builder)
        {
            base.Configure(builder);
            builder.Property(t => t.Icon).IsRequired();
            builder.Property(t => t.Title).IsRequired();
            builder.Property(s => s.Sum).IsRequired();

        }
    }
}
