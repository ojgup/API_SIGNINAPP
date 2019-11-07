using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace API_SIGNINAPP
{
    public static class DB
    {
        public static SqlConnection GetConnection()
        {
            string ConnString = "Server=sign-in-app.database.windows.net;Database=sign-in-database;User Id=milan; Password = Swinburne1;";
            return new SqlConnection(ConnString);
        }

    }
}
