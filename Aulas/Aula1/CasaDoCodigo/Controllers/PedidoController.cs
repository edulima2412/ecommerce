using CasaDoCodigo.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CasaDoCodigo.Controllers
{
    public class PedidoController : Controller
    {
        private readonly IProdutoRepository _produtoRepostory;

        public PedidoController(IProdutoRepository produtoRepostory)
        {
            _produtoRepostory = produtoRepostory;
        }

        public IActionResult Cadastro()
        {
            return View();
        }

        public IActionResult Carrossel()
        {
            return View(_produtoRepostory.GetProdutos());
        }

        public IActionResult Carrinho()
        {
            return View();
        }

        public IActionResult Resumo()
        {
            return View();
        }
    }
}
