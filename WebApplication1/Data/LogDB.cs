using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebApplication1.Util;

namespace WebApplication1.Data {
    public class LogDB {
        private static ConnectionDB _conn;
        public void Insert(string msg) {
            _conn = new ConnectionDB();
            _conn.ExecQuery($"INSERT INTO LOG VALUES('{msg}')");
            _conn.Close();
        }
        public DataTable Read() {
            _conn = new ConnectionDB();
            var cmd = _conn.ExecQuery("SELECT * FROM LOG");
            _conn.Close();

            var dt = new DataTable();
            var da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            return dt;
        }
    }
}