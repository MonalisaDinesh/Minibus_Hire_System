using Microsoft.Extensions.Options;
using Minibus_Hire_System.Interfaces;
using Minibus_Hire_System.Object;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Minibus_Hire_System.Services
{
    public class UserService : IUserService
    {
        private readonly IDatabaseService databaseService;
        /// <summary>
        /// Constructor
        /// </summary>
        public UserService(IDatabaseService _databaseService)
        {
            databaseService = _databaseService;
        }

        public bool AddUser(UserObject user)
        {
            List<SqlParameter> parameters = new List<SqlParameter> {
                new SqlParameter { ParameterName = "@User_ID", Value = Guid.NewGuid() },
                new SqlParameter { ParameterName = "@First_Name", Value = user.FirstName },
                new SqlParameter { ParameterName = "@Last_Name", Value = user.LastName },
                new SqlParameter { ParameterName = "@Address1", Value = user.Address1 },
                new SqlParameter { ParameterName = "@Address2", Value = user.Address2 },
                new SqlParameter { ParameterName = "@Address3", Value = user.Address3 },
                new SqlParameter { ParameterName = "@City", Value = user.City },
                new SqlParameter { ParameterName = "@County", Value = user.County },
                new SqlParameter { ParameterName = "@Country", Value = user.Country },
                new SqlParameter { ParameterName = "@Email_Address", Value = user.Email },
                new SqlParameter { ParameterName = "@Mobile_NO", Value = user.PhoneNumber }
            };

            return databaseService.ExecuteStoredProc("AddNewUser", parameters);
        }

        public UserObject GetUserByID(Guid UserID)
        {
            //TODO:: Need to Write logic
            return new UserObject();
        }

    }
}
