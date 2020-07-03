using System;
using System.Data;
using Npgsql;

namespace SourceCode.Controlador
{
    public class Connection
    {
        private static string host = "127.0.0.1",
            database = "POOF",
            userId = "postgres",
            password = "00223916";

        private static string sConnection =
            $"Server={host};Port=5432;User Id={userId};Password={password};Database={database};";
        //$sslmode=Require;Trust Server Certificate=true";

        public static DataTable ExecuteQuery(string query)
        {
            NpgsqlConnection connection = new NpgsqlConnection(sConnection);
            DataSet ds = new DataSet();
            
            connection.Open();
            
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query,connection);
            da.Fill(ds);
            
            connection.Close();

            return ds.Tables[0];
        }

        public static void ExecuteNonQuery(string act)
        {
            NpgsqlConnection connection = new NpgsqlConnection(sConnection);
            
            connection.Open();
            
            NpgsqlCommand command = new NpgsqlCommand(act,connection);
            command.ExecuteNonQuery();
            
            connection.Close();
        }

        public static bool ExecuteCheckQuery(string act)
        {
            NpgsqlConnection connection = new NpgsqlConnection(sConnection);
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand(act, connection);
            var n = command.ExecuteScalar();
            connection.Close();
            return (bool) n;
        }

        public static int ExecuteInttQuery(string act)
        {
            NpgsqlConnection connection = new NpgsqlConnection(sConnection);
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand(act, connection);
            var n = command.ExecuteScalar();
            connection.Close();
            return Int32.Parse(n.ToString());
        }
        
        public static string ExecuteStringQuery(string act)
        {
            NpgsqlConnection connection = new NpgsqlConnection(sConnection);
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand(act, connection);
            var n = command.ExecuteScalar();
            connection.Close();
            return n.ToString();
        }
    }
}