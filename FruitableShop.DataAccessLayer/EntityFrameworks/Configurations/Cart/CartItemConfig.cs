using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopECommerce.DataAccessLayer.EntityFrameworks.Configurations.Common;
using ShopECommerce.Entity.Concrete.Common;
using ShopECommerce.Entity.Concrete.Common.Card;
using ShopECommerce.Entity.Concrete.Common.OurProducts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopECommerce.DataAccessLayer.EntityFrameworks.Configurations.Cart
{
    public class CartItemConfig : BaseConfiguration<CartItem>
    {
        public override void Configure(EntityTypeBuilder<CartItem> builder)
        {
            base.Configure(builder);
            builder.Property(n => n.ProductName)
                .IsRequired();
            builder.Property(t => t.ProductImage)
                .IsRequired();
            builder.Property(t => t.ProductPrice)
                .IsRequired();
            builder.Property(t => t.Quantity)
                .IsRequired();
            builder.Property(t => t.TotalPrice)
                .IsRequired();


        }
    }
}
