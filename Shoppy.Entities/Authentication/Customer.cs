using System;
using System.Collections.Generic;
using System.Text;
using Shoppy.Ordering.Entities;

namespace Shoppy.Authentication.Entities
{
    public class Customer : IUser
    {
        public int CustomerID { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Adress { get; set; }
        public DateTime RegisterDate { get; set; }
        public string PicturePath { get; set; }
        private string eMail;
        public string EMail { get { return eMail; } set { eMail = value; } }
        private string userName;
        public string UserName { get { return userName; } set { userName = value; } }
        public string password { get; set; }

        public List<Order> Orders { get; set; }

        public Customer()
        {
            RegisterDate = DateTime.Now;
            Orders = new List<Order>();
        }
    }
}
