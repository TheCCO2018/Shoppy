using Shoppy.Authentication.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoppy.DataAccess.Abstraction
{
    public interface ICustomerRepository : IRepository<Customer>
    {
        Customer Login(string username, string password);
    }
}
