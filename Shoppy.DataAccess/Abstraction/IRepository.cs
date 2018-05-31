using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoppy.DataAccess
{
    public interface IRepository<T> where T : class
    {
        List<T> GetList();
        bool AddItem(T entity);
        bool Update(T entity);
        bool Delete(T entity);

    }
}
