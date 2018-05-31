
using Shoppy.Authentication.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shoppy.DataAccess.Abstraction;
using System.Data.Entity;
using Shoppy.Data;

namespace Shoppy.DataAccess
{
    public class CustomerDataAccess : ICustomerRepository
    {
        //   using (var dataContext = new Data.ShoppyDbEntities())
        //        {
        //            var customer = dataContext.Customers.Add(entity);
        //dataContext.SaveChanges();
        //            return customer is null; 
        //        }
        private DbContext Context;
        private DbSet<Customer> table;
        public CustomerDataAccess()
        {
            Context = new ShoppyDbEntities();
            table = Context.Set<Customer>();
        }

        public bool AddItem(Customer entity)//İtem Ekleme
        {

                var customer = table.Add(entity);
                try
                {

                    return Context.SaveChanges() > 0;
                }
                catch (Exception)
                {
                    return false;
                }      
        }

        public bool Delete(Customer entity)//Silme
        {
            table.Remove(entity);

            try
            {
                return Context.SaveChanges() > 0;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public List<Customer> GetList()//Listeleme
        {
            return table.ToList();
        }

        public bool Update(Customer entity)//Güncelleme
        {
            var customer = table.Find(entity.CustomerID);
            try
            {
                table.Attach(customer);
                Context.Entry(customer).CurrentValues.SetValues(entity);
                return Context.SaveChanges() > 0;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public Customer GetCustomer(int customerID)
        {
            return table.Where(c => c.CustomerID == customerID).FirstOrDefault();
        }

        public Customer Login(string username, string password)
        {
            Customer customer;
            if(!String.IsNullOrWhiteSpace(username))
            {
                if(username.Contains("@"))
                {
                    customer = table.Where(b => b.EMail == username).Where(c=>c.password == password).FirstOrDefault();
                }
                else
                {
                    customer = table.Where(b => b.UserName == username).Where(c => c.password == password).FirstOrDefault();
                }
                return customer;
            }
            return null;
        }
    }
}
