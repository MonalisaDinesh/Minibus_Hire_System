using Microsoft.Extensions.Options;
using Minibus_Hire_System.Interfaces;
using Minibus_Hire_System.Object;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Minibus_Hire_System.Services
{
    public class DatabaseService : IDatabaseService
    {
        private readonly DatabaseConnectionStringObject databaseConnection;
        private readonly IDbConnection dbConnection;
        /// <summary>
        /// Constructor
        /// </summary>
        public DatabaseService(IOptions<DbConfigurationObject> _databaseConnection)
        {
            var _configObject = _databaseConnection.Value;
            databaseConnection = new DatabaseConnectionStringObject
            {
                ConnectionStringBuilder = new SqlConnectionStringBuilder
                {
                    DataSource = _configObject.DataSource,
                    UserID = _configObject.UserID,
                    Password = _configObject.Password,
                    InitialCatalog = _configObject.InitialCatalog
                }
            };
            dbConnection = new SqlConnection(databaseConnection.ConnectionStringBuilder.ConnectionString);
        }

        public bool ExecuteStoredProc(string spName, List<SqlParameter> parameters)
        {
            try
            {
                using (SqlConnection _con = new SqlConnection(databaseConnection.ConnectionStringBuilder.ConnectionString))
                using (SqlCommand _cmd = new SqlCommand(spName, _con))
                {
                    _cmd.CommandType = CommandType.StoredProcedure;
                    if (parameters != null)
                        _cmd.Parameters.AddRange(parameters.ToArray());
                    _con.Open();
                    _cmd.ExecuteNonQuery();
                    _con.Close();
                }
                return true;
            }
            catch
            {
                return false;
            }

        }
    }
}
