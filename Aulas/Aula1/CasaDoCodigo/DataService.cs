using CasaDoCodigo.Models;
using CasaDoCodigo.Repositories;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace CasaDoCodigo
{
    public partial class Startup
    {
        class DataService : IDataService
        {
            private readonly ApplicationContext _context;
            private readonly IProdutoRepository _produtoRepostory;

            public DataService(ApplicationContext context, IProdutoRepository produtoRepostory)
            {
                _context = context;
                _produtoRepostory = produtoRepostory;
            }

            public void InicializaDB()
            {
                _context.Database.EnsureCreated();
                List<Livro> livros = GetLivros();
                _produtoRepostory.SaveProdutos(livros);
            }

            private static List<Livro> GetLivros()
            {
                var json = File.ReadAllText("livros.json");
                var livros = JsonConvert.DeserializeObject<List<Livro>>(json);
                return livros;
            }
        }
    }
}
