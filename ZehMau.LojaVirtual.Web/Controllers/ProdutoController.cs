using System;
using System.Collections.Generic;
using System.EnterpriseServices;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ZehMau.LojaVirtual.Dominio.Repositorio;

namespace ZehMau.LojaVirtual.Web.Controllers
{
    public class ProdutoController : Controller
    {
        // GET: Produto
        public ActionResult Index()
        {
            ProdutoRepositorio produtoRepositorio = new ProdutoRepositorio();
            var produtos = produtoRepositorio.Produtos.Take(10);

            return View(produtos);
        }
    }
}