using Shoppy.Marketing.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoppy.Data.Mappings
{
    public class ProductMap : EntityTypeConfiguration<Product>
    {
        public ProductMap()
        {
            this.Property(t => t.CategoryID).IsRequired();
            this.HasKey(t => t.ProductID);
            this.Property(t => t.ProductID).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity).IsRequired();
            this.Property(t => t.Name).IsRequired().HasMaxLength(50);
            this.Property(t => t.Model).IsRequired().HasMaxLength(25);
            this.Property(t => t.TradeMark).IsRequired().HasMaxLength(25);
            this.Property(t => t.Cost).IsRequired();
            this.Property(t => t.SalePrice).IsRequired();
            this.Property(t => t.ProductDescription);
            this.Property(t => t.PicturePath);

            this.ToTable("Products");

            this.Property(t => t.CategoryID).HasColumnName("CategoryID");
            this.Property(t => t.ProductID).HasColumnName("ProductID");
            this.Property(t => t.Model).HasColumnName("Model");
            this.Property(t => t.PicturePath).HasColumnName("Name");
            this.Property(t => t.TradeMark).HasColumnName("TradeMark");
            this.Property(t => t.Cost).HasColumnName("Cost");
            this.Property(t => t.SalePrice).HasColumnName("SalePrice");
            this.Property(t => t.ProductDescription).HasColumnName("Description");
            this.Property(t => t.PicturePath).HasColumnName("PicturePath");

            this.HasRequired(t => t.Category).WithMany(t => t.Products).HasForeignKey(d => d.CategoryID).WillCascadeOnDelete(false);
        }
    }
}
