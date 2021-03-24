using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using WebApplication1.Data;
using WebApplication1.Model;

namespace API.Controllers
{
    public class PizzaController : Controller
    {
        public IEnumerable<string> Get() {
            return new string[] { "value1", "value2" };
        }
        // GET api/values
        /*public IEnumerable<PizzaDB> Get() {
            var lista = ConverterParaLista<PizzaDB>(PizzaDB.Read());
            return lista;
        }

        public static List<T> ConverterParaLista<T>(DataTable dt) {
            var columnNames = dt.Columns.Cast<DataColumn>().Select(c => c.ColumnName.ToLower()).ToList();
            var properties = typeof(T).GetProperties();
            return dt.AsEnumerable().Select(row => {
                var objT = Activator.CreateInstance<T>();
                foreach (var pro in properties) {
                    if (columnNames.Contains(pro.Name.ToLower())) {
                        try {
                            pro.SetValue(objT, row[pro.Name]);
                        }
                        catch (Exception) { }
                    }
                }
                return objT;
            }).ToList();
        }*/

        public void Post([FromBody] Pizza pizza) {
            PizzaDB.Insert(pizza);
        }



    }
}