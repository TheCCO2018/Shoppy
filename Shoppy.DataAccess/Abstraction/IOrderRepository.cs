using Shoppy.Ordering.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoppy.DataAccess.Abstraction
{
    public interface IOrderRepository : IRepository<Order>
    {
    }
}
