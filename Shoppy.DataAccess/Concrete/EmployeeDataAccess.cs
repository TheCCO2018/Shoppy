using Shoppy.Authentication.Entities;
using Shoppy.Data;
using Shoppy.DataAccess.Abstraction;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoppy.DataAccess.Concrete
{
    public class EmployeeDataAccess : IEmployeeRepository
    {
        private DbContext Context;
        private DbSet<Employee> table;

        public EmployeeDataAccess()
        {
            Context = new ShoppyDbEntities();
            table = Context.Set<Employee>();
        }
        public bool AddItem(Employee entity)//İtem Ekleme
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

        public bool Delete(Employee entity)//Silme
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

        public List<Employee> GetList()//Listeleme
        {
            return table.ToList();
        }

        public bool Update(Employee entity)//Güncelleme
        {
            var employee = table.Find(entity.EmployeeID);
            try
            {
                table.Attach(employee);
                Context.Entry(employee).CurrentValues.SetValues(entity);
                return Context.SaveChanges() > 0;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public Employee Login(string username, string password)
        {
            var employee = new Employee();
            if (!String.IsNullOrWhiteSpace(username))
            {
                if (username.Contains("@"))
                {
                    employee = table.Where(b => b.EMail == username).Where(c => c.Password == password).FirstOrDefault();
                }
                else
                {
                    employee = table.Where(b => b.UserName == username).Where(c => c.Password == password).FirstOrDefault();
                }
                return employee;
            }
            return null;
        }
    }
}
