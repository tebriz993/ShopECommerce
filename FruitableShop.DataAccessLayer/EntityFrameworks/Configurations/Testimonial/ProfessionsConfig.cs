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
    public class ProfessionsConfig:BaseConfiguration<Professions>
    {
        public override void Configure(EntityTypeBuilder<Professions> builder)
        {
            base.Configure(builder);
            builder.Property(n => n.Name)
                .IsRequired();

            builder.HasMany(n=>n.ClientSays).WithOne(p=>p.Professions).HasForeignKey(p=>p.ProfessionId);
        }
    }
}
