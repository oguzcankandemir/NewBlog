using Blog.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data.Mappings
{
    public class UserRoleMap : IEntityTypeConfiguration<AppUserRole>
    {
        public void Configure(EntityTypeBuilder<AppUserRole> builder)
        {
            // Primary key
            builder.HasKey(r => new { r.UserId, r.RoleId });

            // Maps to the AspNetUserRoles table
            builder.ToTable("AspNetUserRoles");

            builder.HasData(new AppUserRole
            {
                UserId = Guid.Parse("40C85A0D-35AC-4960-BA59-6A3C3B4B54F5"),
                RoleId = Guid.Parse("6C187EC3-8775-411E-89EE-08E56DFDE184"),
            },
            new AppUserRole
            {
                UserId = Guid.Parse("6670818B-B8F4-4CA6-BF22-2C738E49C549"),
                RoleId = Guid.Parse("219065EA-1101-4A3A-94CC-0E84C1213262")
            });
        }
    }
}
