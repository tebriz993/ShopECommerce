using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.IdentityModel.Tokens;
using ShopECommerce.DataAccessLayer.EntityFrameworks.Configurations.Common;
using ShopECommerce.Entity.Concrete.Common.Featured_Products;
using ShopECommerce.Entity.Concrete.Common.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopECommerce.DataAccessLayer.EntityFrameworks.Configurations.Featured_ProductsConfigs
{
    public class Featured_ProductsConfig:BaseConfiguration<Featured_Products>
    {
        public override void Configure(EntityTypeBuilder<Featured_Products> builder)
        {
            base.Configure(builder);
            builder.Property(i => i.Image)
                .IsRequired();
            builder.Property(p => p.ProductName)
                .IsRequired();
            builder.Property(s=>s.Stars)
                .IsRequired();
            builder.Property(n=>n.NewPrice)
                .IsRequired();
            builder.Property(b=>b.BeforePrice)
                .IsRequired();

        }
    }
}
