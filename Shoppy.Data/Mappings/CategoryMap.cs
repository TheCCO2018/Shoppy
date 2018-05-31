using Shoppy.Marketing.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoppy.Data.Mappings
{
    public class CategoryMap : EntityTypeConfiguration<Category>
    {
        public CategoryMap()
        {
            this.HasKey(t => t.CategoryID);
            this.Property(t => t.CategoryID).IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            this.Property(t => t.CategoryDescription).IsRequired().HasMaxLength(300);
            this.Property(t => t.Name).IsRequired().HasMaxLength(50);
            this.Property(t => t.PicturePath).IsOptional();

            this.ToTable("Categories");

            this.Property(t => t.CategoryID).HasColumnName("CategoryID");
            this.Property(t => t.CategoryDescription).HasColumnName("CategoryDescription");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.PicturePath).HasColumnName("PicturePath");

        }
    }
}
