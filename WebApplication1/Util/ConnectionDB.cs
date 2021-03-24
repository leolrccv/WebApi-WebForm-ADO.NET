using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication1.Util {
    public class ConnectionDB {
        private static SqlConnection _conn;
        private SqlCommand _cmd;

        public ConnectionDB() {
            _conn = new SqlConnection(ConfigurationManager.ConnectionStrings["SQLServer"].ConnectionString);
            _conn.Open();
                
        }

        public SqlCommand ExecQuery(string query) {
            _cmd = new SqlCommand(query, _conn);
            _cmd.ExecuteNonQuery();
            return _cmd;

        }

        public void Close() {
            _conn.Close();
        }

        public SqlDataReader ExecQueryReturn(string query) {
            var cmd = new SqlCommand(query, _conn);
            return cmd.ExecuteReader();
        }
    }
}