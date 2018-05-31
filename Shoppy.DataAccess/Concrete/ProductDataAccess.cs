using Shoppy.Data;
using Shoppy.DataAccess.Abstraction;
using Shoppy.Marketing.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoppy.DataAccess.Concrete
{
    public class ProductDataAccess : IProductRepository
    {
        private DbContext Context;
        private DbSet<Product> table;

        public ProductDataAccess()
        {
            Context = new ShoppyDbEntities();
            table = Context.Set<Product>();
        }
        public bool AddItem(Product entity)//İtem Ekleme
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

        public bool Delete(Product entity)//Silme
        {
            var product = table.Find(entity.ProductID);
            CommentDataAccess cda = new CommentDataAccess();
            var comments = cda.GetList().Where(c => c.ProductID == product.ProductID).ToList();
            foreach (var comment in comments)
            {
                cda.Delete(comment);
            }
            try
            {
                table.Attach(product);
                Context.Entry(product).State = EntityState.Deleted;
                return Context.SaveChanges() > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<Product> GetList()//Listeleme
        {
            return table.ToList();
        }

        public bool Update(Product entity)//Güncelleme
        {
            var product = table.Find(entity.ProductID);
            try
            {
                table.Attach(product);
                Context.Entry(product).CurrentValues.SetValues(entity);
                return Context.SaveChanges() > 0;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public List<Product> GetByCategoryName(int CategoryID)
        {
            if(table.Where(x => x.CategoryID == CategoryID).ToList().Count != 0)
            {
                return table.Where(x => x.CategoryID == CategoryID).ToList();
            }
            else
            {
                return null;
            }
        }
    }
}
