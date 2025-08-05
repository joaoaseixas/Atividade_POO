using System.ComponentModel.DataAnnotations;

namespace GerenciamentoPedidos.Models
{
    public class Pedido
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Cliente é obrigatório")]
        public Cliente Cliente { get; set; } = new Cliente();

        public DateTime DataPedido { get; set; } = DateTime.Now;

        public List<ItemPedido> Itens { get; set; } = new();

        public decimal Total => Itens.Sum(x => x.Subtotal);

        [Required]
        public string Status { get; set; } = "Pendente";
    }
}
