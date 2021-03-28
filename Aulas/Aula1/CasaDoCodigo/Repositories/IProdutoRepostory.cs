using CasaDoCodigo.Models;
using System.Collections.Generic;

namespace CasaDoCodigo.Repositories
{
    public interface IProdutoRepostory
    {
        void SaveProdutos(List<Livro> livros);
        IList<Produto> GetProdutos();
    }
}