using Blog.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data.Mappings
{
    public class ImageMap : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder.HasData(new Image
            {
                
                    Id = Guid.Parse("92621080-1900-4E50-BD65-0C7CFBDBE1CE"),
                    FileName = "images/testImage",
                    FileType = "jpg",
                    CreatedBy = "Admin Test",
                    CreatedDate = DateTime.Now,
                    IsDeleted = false,
                
            },

            new Image
            {
                
                    Id = Guid.Parse("{00D19DE1-B11F-46B7-9B18-867FD52C6289}"),
                    FileName = "images/vsTests",
                    FileType = "png",
                    CreatedBy = "Admin Test",
                    CreatedDate = DateTime.Now,
                    IsDeleted = false,
                
            });
        }

    }
}
