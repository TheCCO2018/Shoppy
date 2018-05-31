using System;
using System.Collections.Generic;
using System.Text;

namespace Shoppy.Authentication.Entities
{
    public enum UserType
    {
        Customer,
        Employee,
    }

    public interface IUser
    {
        string EMail { get; set; }
        string UserName { get; set; }

    }
}
