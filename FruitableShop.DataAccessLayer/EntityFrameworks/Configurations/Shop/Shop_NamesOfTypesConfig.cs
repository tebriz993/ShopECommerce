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
    public class Shop_NamesOfTypesConfig:BaseConfiguration<Shop_NamesOfTypes>
    {
        public override void Configure(EntityTypeBuilder<Shop_NamesOfTypes> builder)
        {
            base.Configure(builder);
            builder.Property(t=>t.TypeName)
                .IsRequired();
            builder.HasMany(t=>t.Products).WithOne(x=>x.Shop_NamesOfTypes).HasForeignKey(x=>x.Shop_NamesOfTypesId);
        }
    }
}
