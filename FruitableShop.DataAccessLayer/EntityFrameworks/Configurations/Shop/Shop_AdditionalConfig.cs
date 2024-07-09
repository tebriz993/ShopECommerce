using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.IdentityModel.Tokens;
using ShopECommerce.DataAccessLayer.EntityFrameworks.Configurations.Common;
using ShopECommerce.Entity.Concrete.Common.Shop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopECommerce.DataAccessLayer.EntityFrameworks.Configurations.Shop
{
    public class Shop_AdditionalConfig:BaseConfiguration<Shop_Additional>
    {
        public override void Configure(EntityTypeBuilder<Shop_Additional> builder)
        {
            base.Configure(builder);
            builder.Property(t=>t.Type)
                .IsRequired();
            builder.HasMany(t => t.Products).WithOne(s=>s.Shop_Additional).HasForeignKey(s=>s.Shop_AdditionalId);
        }
    }
}
