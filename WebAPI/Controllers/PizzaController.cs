using System.Collections.Generic;
using System.Web.Http;
using WebApplication1.Data;
using WebApplication1.Model;

namespace WebAPI.Controllers
{
    public class PizzaController : ApiController {
        // GET: Pizza
        public IEnumerable<Pizza> Get() {
            var pizza = new PizzaDB().Select();
            return pizza;
        }

        public void Post([FromBody] Pizza pizza) {
            PizzaDB.Insert(pizza);
        }
    }
}