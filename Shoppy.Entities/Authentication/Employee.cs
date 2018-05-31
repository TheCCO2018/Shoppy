using System;
using System.Collections.Generic;
using System.Text;

namespace Shoppy.Authentication.Entities
{
    public class Employee : IUser
    {
        public int EmployeeID { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Adress { get; set; }
        public DateTime HiredDate { get; set; }
        
        private string eMail;
        public string EMail { get { return eMail; } set { eMail = value; } }
        private string userName;
        public string UserName { get { return userName; } set { userName = value; } }
        public string Password { get; set; }
        public string PicturePath { get; set; }

        public Employee()
        {
            HiredDate = DateTime.Now;
        }

    }
}
