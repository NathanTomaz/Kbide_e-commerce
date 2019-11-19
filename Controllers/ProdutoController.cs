using System.Net.Mime;
using Kbide_desenvolvimento.Models;
using Microsoft.AspNetCore.Mvc;

namespace Kbide_desenvolvimento.Controllers
{
    public class ProdutoController : Controller
    {
        public ActionResult Visualizar(){

            Produto produto = GetProduto();
            
            return View(produto);
            //return new ContentResult() {Content = "<h3>Produto -> Visualizar<h3>", ContentType = "text/html"};
        }

        private Produto GetProduto(){

            return new Produto() {

                id = 1,
                Nome = "Playstation 5",
                Descricao = "Pré-venda",
                Valor = 9999.00M

            };
        }
    }
}