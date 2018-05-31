using Shoppy.Data;
using Shoppy.DataAccess.Abstraction;
using Shoppy.Ordering.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoppy.DataAccess.Concrete
{
    public class OrderDataAccess : IOrderRepository
    {
        private DbContext Context;
        private DbSet<Order> table;

        public OrderDataAccess()
        {
            Context = new ShoppyDbEntities();
            table = Context.Set<Order>();
        }
        public bool AddItem(Order entity)//İtem Ekleme
        {
            table.Add(entity);
            try
            {

                return Context.SaveChanges() > 0;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Delete(Order entity)//Silme
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

        public List<Order> GetList()//Listeleme
        {
            return table.ToList();
        }

        public bool Update(Order entity)//Güncelleme
        {
            try
            {
                return Context.SaveChanges() > 0;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
