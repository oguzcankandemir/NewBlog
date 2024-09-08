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
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category
                {
                    Id = Guid.Parse("D2474128-A555-4ADB-9B1C-997BC7D667EE"),
                    Name = "ASP.NET Core",
                    CreatedBy = "Admin Test",
                    CreatedDate = DateTime.Now,
                    IsDeleted = false
                },
                new Category
                {
                    Id = Guid.Parse("30A9CB71-B403-42CB-ADFE-2EA1E278C41C"),
                    Name = "Visual Studio 2022",
                    CreatedBy = "Admin Test",
                    CreatedDate = DateTime.Now,
                    IsDeleted = false
                });
        }
    }
}
