using Shoppy.Ordering.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoppy.Data.Entity.Mappings
{
    public class OrderMap : EntityTypeConfiguration<Order>
    {
        public OrderMap()
        {
            this.Property(t => t.CustomerID).IsRequired();
            this.HasKey(t => t.OrderID);
            this.Property(t => t.OrderID).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            this.Property(t => t.OrderState).IsRequired();
            this.Property(t => t.OrderDate).IsRequired();

            this.ToTable("Orders");

            this.Property(t => t.CustomerID).HasColumnName("CustomerID");
            this.Property(t => t.OrderID).HasColumnName("OrderID");
            this.Property(t => t.OrderState).HasColumnName("OrderState");
            this.Property(t => t.OrderDate).HasColumnName("OrderDate");

            this.HasRequired(t => t.Customer).
                WithMany(t => t.Orders).
                HasForeignKey(d => d.CustomerID).WillCascadeOnDelete(false);
        }
    }
}
