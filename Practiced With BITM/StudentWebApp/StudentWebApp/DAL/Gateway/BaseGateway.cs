using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace StudentWebApp.DAL.Gateway
{
    public class BaseGateway
    {
        public SqlConnection connection;
        public SqlCommand command;
        public SqlDataReader reader;
        public BaseGateway()
        {
            string connectionString =
                WebConfigurationManager.ConnectionStrings["UniveristyDBConString"].ConnectionString;

            connection = new SqlConnection(connectionString);


        }
    }
}