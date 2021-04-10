using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Minibus_Hire_System.Interfaces
{
    public interface IDatabaseService
    {
        bool ExecuteStoredProc(string spName, List<SqlParameter> parameters);
    }
}
