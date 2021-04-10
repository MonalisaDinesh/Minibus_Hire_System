using Minibus_Hire_System.Object;
using System;
using System.Collections.Generic;
using System.Text;

namespace Minibus_Hire_System.Interfaces
{
    public interface IUserService
    {
        bool AddUser(UserObject user);
        UserObject GetUserByID(Guid UserID);
    }
}
