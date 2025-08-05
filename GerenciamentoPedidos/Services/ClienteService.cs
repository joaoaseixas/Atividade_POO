using GerenciamentoPedidos.Models;

namespace GerenciamentoPedidos.Services
{
    public class ClienteService
    {
        private readonly List<Cliente> _clientes = new()
        {
            new Cliente{ Id=1, Nome="João Silva", Email="joao@ex.com" },
            new Cliente{ Id=2, Nome="Maria Souza", Email="maria@ex.com" }
        };

        public Task<List<Cliente>> ObterTodosClientes() =>
            Task.FromResult(_clientes);

        public Task<Cliente?> ObterClientePorId(int id) =>
            Task.FromResult(_clientes.FirstOrDefault(c => c.Id == id));

        public Task<Cliente> AdicionarCliente(Cliente cliente)
        {
            cliente.Id = _clientes.Any() ? _clientes.Max(c => c.Id) + 1 : 1;
            _clientes.Add(cliente);
            return Task.FromResult(cliente);
        }
    }
}
