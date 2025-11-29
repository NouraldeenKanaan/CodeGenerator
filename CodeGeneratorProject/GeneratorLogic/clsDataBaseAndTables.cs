using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace GeneratorLogic
{
    public static class clsDataAccessSettings
    {
        public static string MSQLServerConnection = ConfigurationManager.ConnectionStrings["MSQLServer"].ConnectionString;
    }
    public class clsDataBaseAndTables
    {
        public static DataTable GetAllMSQLServerDatabases()
        {
            DataTable dtMSQLServerDatabases = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.MSQLServerConnection))
                {
                    connection.Open();

                    string query = @"SELECT name FROM sys.databases WHERE database_id > 4;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                                dtMSQLServerDatabases.Load(reader);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return dtMSQLServerDatabases;
        }
        public static DataTable GetDatabaseTables(string ConnectionString)
        {
            DataTable dtDatabaseTables = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    string query = @"SELECT  TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE';";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                                dtDatabaseTables.Load(reader);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return dtDatabaseTables;
        }
    }
}
