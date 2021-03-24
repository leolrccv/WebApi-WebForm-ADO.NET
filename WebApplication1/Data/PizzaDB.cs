using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Web;
using WebApplication1.Model;
using WebApplication1.Util;

namespace WebApplication1.Data {
    public class PizzaDB {
        private static ConnectionDB _conn;
        public static void Insert(Pizza pizza) {
            _conn = new ConnectionDB();
            _conn.ExecQuery($"INSERT INTO PIZZA(Descricao, Valor) VALUES('{pizza.Descricao}', {pizza.Valor})");
            _conn.Close();
        }

        public static void Delete(string id) {
            _conn = new ConnectionDB();
            _conn.ExecQuery($"DELETE PIZZA WHERE ID = {id}");
            _conn.Close();
        }

        public static DataTable Read() {
            _conn = new ConnectionDB();
            var cmd = _conn.ExecQuery("SELECT * FROM PIZZA");
            _conn.Close();

            var dt = new DataTable();
            var da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            return dt;
        }

        public static DataTable ValorTotal() {
            _conn = new ConnectionDB();
            var cmd = _conn.ExecQuery("SELECT SUM(Valor) AS \"Valor Total\" FROM PIZZA");
            _conn.Close();

            var dt = new DataTable();
            var da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            return dt;
        }
        public List<Pizza> Select() {
            _conn = new ConnectionDB();
            var returnData = _conn.ExecQueryReturn("SELECT * FROM PIZZA");
            return TransformSQLReaderToList(returnData);

        }

        private List<Pizza> TransformSQLReaderToList(SqlDataReader returnData) {
            var list = new List<Pizza>();

            while (returnData.Read()) {
                var item = new Pizza(returnData["Descricao"].ToString(), decimal.Parse(returnData["Valor"].ToString())) {
                    Id = int.Parse(returnData["Id"].ToString())
                };

                list.Add(item);
            }
            return list;
        }
    }
}