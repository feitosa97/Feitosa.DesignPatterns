using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Feitosa.DesignPatterns2.Factories
{
    public class ConnectionFactory
    {
        public IDbConnection GetConnection()
        {
            var connection = new SqlConnection();
            connection.ConnectionString = "User Id=sa;Password=Senha123;Server=localhost;Database=master;";
            connection.Open();
            return connection;
        }
    }
}
