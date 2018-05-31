using Shoppy.Authentication.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoppy.Data.Entity.Mappings
{
    public class CustomerMap : EntityTypeConfiguration<Customer>
    {
        public CustomerMap()
        {
            this.HasKey(t => t.CustomerID);

            this.Property(t => t.CustomerID).IsRequired();
            this.Property(t => t.FirstName).HasMaxLength(25);
            this.Property(t => t.LastName).HasMaxLength(50);
            this.Property(t => t.EMail).IsRequired().HasMaxLength(100);
            this.Property(t => t.UserName).IsRequired().HasMaxLength(35);
            this.Property(t => t.password).IsRequired().HasMaxLength(100);
            this.Property(t => t.RegisterDate).IsRequired();
            this.Property(t => t.Adress);
            this.Property(t => t.PicturePath);
            this.ToTable("Customers");

            this.Property(t => t.CustomerID).HasColumnName("CustomerID");
            this.Property(t => t.FirstName).HasColumnName("FirstName");
            this.Property(t => t.LastName).HasColumnName("LastName");
            this.Property(t => t.EMail).HasColumnName("EMail");
            this.Property(t => t.UserName).HasColumnName("UserName");
            this.Property(t => t.password).HasColumnName("Password");
            this.Property(t => t.Adress).HasColumnName("Adress");
            this.Property(t => t.RegisterDate).HasColumnName("RegisterDate");
            this.Property(t => t.PicturePath).HasColumnName("PicturePath");

        }
    }
}
