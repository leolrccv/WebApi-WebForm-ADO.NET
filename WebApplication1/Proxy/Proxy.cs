using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using WebApplication1.Data;
using WebApplication1.Util;

namespace WebApplication1.Proxy {
    public class Proxy {

        public void SaveLog(string msg) {
            new LogDB().Insert(msg);
        }
        public DataTable ReadLog() {
            var dt = new LogDB().Read();
            return dt;
        }
        
    }
}