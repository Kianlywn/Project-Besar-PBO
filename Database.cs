using Npgsql;
using System.Data;
using System.Collections.Generic;

namespace PBO_BESAR.DataAccess
{
    public static class Database
    {
        private static string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=bun;Database=Database_PBO_Besar";

        public static NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(connectionString);
        }

        // Basic query execution (tanpa parameter)
        public static DataTable ExecuteQuery(string query)
        {
            return ExecuteQuery(query, null);
        }

        // Overloaded method dengan parameter
        public static DataTable ExecuteQuery(string query, Dictionary<string, object> parameters)
        {
            DataTable dt = new DataTable();
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    // Tambahkan parameter jika ada
                    if (parameters != null)
                    {
                        foreach (var param in parameters)
                        {
                            cmd.Parameters.AddWithValue(param.Key, param.Value);
                        }
                    }

                    using (var adapter = new NpgsqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            return dt;
        }

        // Untuk INSERT/UPDATE/DELETE dengan parameter
        public static int ExecuteNonQuery(string query, Dictionary<string, object> parameters = null)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    if (parameters != null)
                    {
                        foreach (var param in parameters)
                        {
                            cmd.Parameters.AddWithValue(param.Key, param.Value);
                        }
                    }
                    return cmd.ExecuteNonQuery();
                }
            }
        }
    }
}