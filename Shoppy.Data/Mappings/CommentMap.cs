using Shoppy.Marketing.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoppy.Data.Mappings
{
    public class CommentMap : EntityTypeConfiguration<Comment>
    {
        public CommentMap()
        {
            this.Property(t => t.ProductID).IsRequired();
            this.HasKey(t => t.CommentID);
            this.Property(t => t.CommentID).IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            this.Property(t => t.CustomerID).IsRequired();
            this.Property(t => t.createdAt).IsRequired();
            this.Property(t => t.CommentDescription).IsRequired().HasMaxLength(500);
            this.Property(t => t.Star).IsRequired();

            this.ToTable("Comments");

            this.Property(t => t.CommentID).HasColumnName("CommentID");
            this.Property(t => t.ProductID).HasColumnName("ProductID");
            this.Property(t => t.CustomerID).HasColumnName("CustomerID");
            this.Property(t => t.createdAt).HasColumnName("createdAt");
            this.Property(t => t.CommentDescription).HasColumnName("CommentDescription");
            this.Property(t => t.Star).HasColumnName("Star");

            this.HasRequired(t => t.Product).WithMany(t => t.Comments).HasForeignKey(d => d.ProductID).WillCascadeOnDelete(false);

        }
    }
}
