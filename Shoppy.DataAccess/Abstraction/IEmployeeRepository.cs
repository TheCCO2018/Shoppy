using Shoppy.Authentication.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoppy.DataAccess.Abstraction
{
    public interface IEmployeeRepository : IRepository<Employee>
    {
        Employee Login(string username, string password);
    }
}
