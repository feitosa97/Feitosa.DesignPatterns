using Feitosa.DesignPatterns2.Factories;
using Microsoft.Data.SqlClient;
using System;
using System.Data;

namespace Feitosa.DesignPatterns2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IDbConnection connection = new ConnectionFactory().GetConnection();

            IDbCommand command = connection.CreateCommand();
            command.CommandText = "Select * From Sys.Tables";
            command.CommandType = CommandType.Text;
            command.ExecuteNonQuery();


        }
    }
}
