using Shoppy.Entities.Ordering;
using System.Data.Entity.ModelConfiguration;

namespace Shoppy.Data.Mappings
{
    public class OrderDetailMap : EntityTypeConfiguration<OrderDetail>
    {
        public OrderDetailMap()
        {
            this.HasKey(t => t.OrderDetailID);
            this.Property(t => t.OrderID).IsRequired();
            this.Property(t => t.OrderDetailID).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            this.Property(t => t.Profit);
            this.Property(t => t.Loss);

            this.Property(t => t.OrderDetailID).HasColumnName("OrderDetailID");
            this.Property(t => t.OrderID).HasColumnName("OrderID");
            this.Property(t => t.Profit).HasColumnName("Profit");
            this.Property(t => t.Loss).HasColumnName("Loss");

        }
    }
}
