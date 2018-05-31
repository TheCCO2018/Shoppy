using Shoppy.Authentication.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoppy.Data.Mappings
{
    public class EmployeeMap : EntityTypeConfiguration<Employee>
    {
        public EmployeeMap()
        {
            this.HasKey(t => t.EmployeeID);

            this.Property(t => t.EmployeeID).IsRequired();
            this.Property(t => t.FirstName).HasMaxLength(25);
            this.Property(t => t.LastName).HasMaxLength(50);
            this.Property(t => t.EMail).IsRequired().HasMaxLength(100);
            this.Property(t => t.UserName).IsRequired().HasMaxLength(35);
            this.Property(t => t.Password).IsRequired().HasMaxLength(100);
            this.Property(t => t.HiredDate).IsRequired();
            this.Property(t => t.Adress);
            this.Property(t => t.PicturePath);

            this.ToTable("Employees");

            this.Property(t => t.EmployeeID).HasColumnName("EmployeeID");
            this.Property(t => t.FirstName).HasColumnName("FirstName");
            this.Property(t => t.LastName).HasColumnName("LastName");
            this.Property(t => t.EMail).HasColumnName("EMail");
            this.Property(t => t.UserName).HasColumnName("UserName");
            this.Property(t => t.Password).HasColumnName("Password");
            this.Property(t => t.Adress).HasColumnName("Adress");
            this.Property(t => t.PicturePath).HasColumnName("PicturePath");
            this.Property(t => t.HiredDate).HasColumnName("RegisterDate");
        }
    }
}
