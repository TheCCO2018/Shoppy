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
    public class CategoryDataAccess : ICategoryRepository
    {
        private DbContext Context;
        private DbSet<Category> table;

        public CategoryDataAccess()
        {
            Context = new ShoppyDbEntities();
            table = Context.Set<Category>();
        }
        public bool AddItem(Category entity)//İtem Ekleme
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

        public bool Delete(Category entity)//Silme
        {
            var category = table.Find(entity.CategoryID);
            ProductDataAccess pda = new ProductDataAccess();
            var products = pda.GetList().Where(c => c.CategoryID == category.CategoryID).ToList();
            foreach (var product in products)
            {
                pda.Delete(product);
            }
            try
            {
                table.Attach(category);
                Context.Entry(category).State = EntityState.Deleted;
                return Context.SaveChanges() > 0;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public List<Category> GetList()//Listeleme
        {
             return table.ToList();
        }

        public bool Update(Category entity)//Güncelleme
        {
            var category = table.Find(entity.CategoryID);
            try
            {
                table.Attach(category);
                Context.Entry(category).CurrentValues.SetValues(entity);
                return Context.SaveChanges() > 0;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
