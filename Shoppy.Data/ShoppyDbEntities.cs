namespace Shoppy.Data
{

    using Shoppy.Authentication.Entities;
    using Shoppy.Marketing.Entities;
    using Shoppy.Ordering.Entities;
    using Shoppy.Data.Entity.Mappings;
    using System.Data.Entity;
    using Shoppy.Data.Mappings;
    using Shoppy.Entities.Ordering;

    public class ShoppyDbEntities : DbContext
    {
        // Your context has been configured to use a 'ShoppyDbEntities' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Shoppy.Data.ShoppyDbEntities' database on your LocalDb instance. 
        // bi dk
        // If you wish to target a different database and/or database provider, modify the 'ShoppyDbEntities' 
        // connection string in the application configuration file.
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }

        public ShoppyDbEntities()
            : base("name=ShoppyDbEntities")
        {
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CustomerMap());
            modelBuilder.Configurations.Add(new OrderMap());
            modelBuilder.Configurations.Add(new CommentMap());
            modelBuilder.Configurations.Add(new ProductMap());
            modelBuilder.Configurations.Add(new EmployeeMap());
            modelBuilder.Configurations.Add(new CategoryMap());
            modelBuilder.Configurations.Add(new OrderDetailMap());
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}