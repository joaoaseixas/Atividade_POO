using GerenciamentoPedidos.Models;

namespace GerenciamentoPedidos.Services
{
    public class PedidoService
    {
        private readonly List<Pedido> _pedidos = new();

        public Task<List<Pedido>> ObterTodosPedidos() =>
            Task.FromResult(_pedidos);

        public Task<Pedido?> ObterPedidoPorId(int id) =>
            Task.FromResult(_pedidos.FirstOrDefault(p => p.Id == id));

        public Task<Pedido> AdicionarPedido(Pedido pedido)
        {
            pedido.Id = _pedidos.Any() ? _pedidos.Max(p => p.Id) + 1 : 1;
            _pedidos.Add(pedido);
            return Task.FromResult(pedido);
        }

        public Task<Pedido> AtualizarPedido(Pedido pedido)
        {
            var idx = _pedidos.FindIndex(p => p.Id == pedido.Id);
            if (idx >= 0) _pedidos[idx] = pedido;
            return Task.FromResult(pedido);
        }

        public Task RemoverPedido(int id)
        {
            var ped = _pedidos.FirstOrDefault(p => p.Id == id);
            if (ped != null) _pedidos.Remove(ped);
            return Task.CompletedTask;
        }
    }
}
