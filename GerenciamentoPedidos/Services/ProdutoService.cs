using GerenciamentoPedidos.Models;

namespace GerenciamentoPedidos.Services
{
    public class ProdutoService
    {
        private readonly List<Produto> _produtos = new()
        {
            new Produto{ Id=1, Nome="Teclado", Preco=150.00m, Categoria="Eletrônicos" },
            new Produto{ Id=2, Nome="Mouse",   Preco=80.00m,  Categoria="Eletrônicos" },
            new Produto{ Id=3, Nome="Caderno", Preco=20.00m,  Categoria="Papelaria" }
        };

        public Task<List<Produto>> ObterTodosProdutos() =>
            Task.FromResult(_produtos);

        public Task<Produto?> ObterProdutoPorId(int id) =>
            Task.FromResult(_produtos.FirstOrDefault(p => p.Id == id));
    }
}
