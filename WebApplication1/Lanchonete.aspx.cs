using System;
using WebApplication1.Data;
using WebApplication1.Model;

namespace WebApplication1 {
    public partial class Lanchonete : System.Web.UI.Page {

        protected void Page_Load(object sender, EventArgs e) {
            
        }

        protected void inserir_Click(object sender, EventArgs e) {
            ApagarTabela();

            try {
                var pizza = new Pizza(descricao.Text, decimal.Parse(valor.Text));
                PizzaDB.Insert(pizza);

                msg.Text = "Pizza inserida com sucesso!";
            }
            catch (Exception) {

                msg.Text = "Erro ao inserir a pizza";
            }
            finally {
                SaveLog(msg.Text);
            }

            ApagarCampos();
        }

        protected void consultar_Click(object sender, EventArgs e) {
            msg.Text = null;

            try {
                GVDados.DataSource = PizzaDB.Read();
                GVDados.DataBind();

                SaveLog("Dados consultados");
            }
            catch (Exception) {
                msg.Text = "Erro ao consultar os dados";
                SaveLog(msg.Text);
            }

            ApagarCampos();
        }

        protected void remover_Click(object sender, EventArgs e) {
            ApagarTabela();
            try {
                PizzaDB.Delete(id.Text);

                msg.Text = "Pizza removida com sucesso!";
            }
            catch (Exception) {

                msg.Text = "Erro ao remover a pizza";
            }
            finally {
                SaveLog(msg.Text);
            }

            ApagarCampos();
        }

        protected void valorTotal_Click(object sender, EventArgs e) {
            msg.Text = null;

            try {
                GVDados.DataSource = PizzaDB.ValorTotal();
                GVDados.DataBind();

                SaveLog("Valor Total Consultado");
            }
            catch (Exception) {

                msg.Text = "Erro ao consultar Valor Total";
                SaveLog(msg.Text);
            }
            
            ApagarCampos();
        }
       
        protected void log_Click(object sender, EventArgs e) {
            msg.Text = null;

            try {
                var dt = new Proxy.Proxy().ReadLog();
                GVDados.DataSource = dt;
                GVDados.DataBind();

                SaveLog("Logs consultados");
            }
            catch (Exception) {
                msg.Text = "Erro ao consultar os logs";
                SaveLog(msg.Text);
            }

            ApagarCampos();
        }
        
        private void SaveLog(string msg) => new Proxy.Proxy().SaveLog(msg);

        private void ApagarCampos() {
            id.Text = null;
            descricao.Text = null;
            valor.Text = null;
        }

        private void ApagarTabela() {
            GVDados.DataBind();
        }

        
    }
}