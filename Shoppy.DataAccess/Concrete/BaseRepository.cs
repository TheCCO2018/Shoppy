using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shoppy.Data;
using System.Data.Entity;

namespace Shoppy.DataAccess
{
    public class BaseRepository<T> : IRepository<T> where T : class
    { 
        private DbContext Context;
        private DbSet<T> table;
        public BaseRepository()
        {
            Context = new ShoppyDbEntities();
            table = Context.Set<T>();
        }

        public bool AddItem(T entity)//İtem Ekleme
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

        public bool Delete(T entity)//Silme
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

        public List<T> GetList()//Listeleme
        {
            return table.ToList();
        }

        public bool Update(T entity)//Güncelleme
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
