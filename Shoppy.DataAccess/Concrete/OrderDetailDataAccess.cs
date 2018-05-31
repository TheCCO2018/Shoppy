using Shoppy.Data;
using Shoppy.DataAccess.Abstraction;
using Shoppy.Entities.Ordering;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoppy.DataAccess.Concrete
{
    public class OrderDetailDataAccess: IOrderDetailsRepository
    {
        private DbContext Context;
        private DbSet<OrderDetail> table;

        public OrderDetailDataAccess()
        {
            Context = new ShoppyDbEntities();
            table = Context.Set<OrderDetail>();
        }
        public bool AddItem(OrderDetail entity)
        {
            table.Add(entity);
            try
            {

                return Context.SaveChanges() > 0;
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
                return false;
            }
        }

        public bool Delete(OrderDetail entity)
        {
            var orderDetail = table.Find(entity.OrderDetailID);
            try
            {
                table.Attach(orderDetail);
                Context.Entry(orderDetail).State = EntityState.Deleted;
                return Context.SaveChanges() > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<OrderDetail> GetList()
        {
            return table.ToList();
        }

        public bool Update(OrderDetail entity)
        {
            var orderDetail = table.Find(entity.OrderDetailID);
            try
            {
                table.Attach(orderDetail);
                Context.Entry(orderDetail).CurrentValues.SetValues(entity);
                return Context.SaveChanges() > 0;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
