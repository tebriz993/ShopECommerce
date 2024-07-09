using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.IdentityModel.Tokens;
using ShopECommerce.DataAccessLayer.EntityFrameworks.Configurations.Common;
using ShopECommerce.Entity.Concrete.Common.OurProducts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopECommerce.DataAccessLayer.EntityFrameworks.Configurations.OurProductsConfigs
{
    public class CategoriesConfig:BaseConfiguration<Categories>
    {
        public override void Configure(EntityTypeBuilder<Categories> builder)
        {
            base.Configure(builder);
            builder.Property(n => n.Name)
                .IsRequired();
            builder.HasMany(t => t.Products).WithOne(s => s.Categories).HasForeignKey(s => s.CategoryId);



        }
    }
}
