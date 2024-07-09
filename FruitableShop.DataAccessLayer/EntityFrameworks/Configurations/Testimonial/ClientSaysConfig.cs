using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.IdentityModel.Tokens;
using ShopECommerce.DataAccessLayer.EntityFrameworks.Configurations.Common;
using ShopECommerce.Entity.Concrete.Common.Testimonial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopECommerce.DataAccessLayer.EntityFrameworks.Configurations.Testimonial
{
    public class ClientSaysConfig:BaseConfiguration<ClientSays>
    {
        public override void Configure(EntityTypeBuilder<ClientSays> builder)
        {
            base.Configure(builder);
            builder.Property(i => i.Subtitle)
                .IsRequired();
            builder.Property(i => i.Image)
                .IsRequired();
            builder.Property(i => i.Name)
                .IsRequired();
            
        }
    }
}
