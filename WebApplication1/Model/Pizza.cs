using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Model {
    public class Pizza : Refeicao{
        public Pizza(string _descricao, decimal _valor) {
            Descricao = _descricao;
            Valor = _valor;
        }
    }
}