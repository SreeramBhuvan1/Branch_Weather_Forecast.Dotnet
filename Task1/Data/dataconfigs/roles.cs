using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Task1.Data.dataconfigs
{
    public class roles : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Name = "Administraton",
                    NormalizedName = "ADMIN"
                },
                 new IdentityRole
                 {
                     Name = "User",
                     NormalizedName = "USER"
                 }
                );
        }
    }
}
