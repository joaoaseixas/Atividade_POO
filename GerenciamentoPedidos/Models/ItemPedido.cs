using System.ComponentModel.DataAnnotations;

namespace GerenciamentoPedidos.Models
{
    public class ItemPedido
    {
        public int Id { get; set; }

        [Required]
        public Produto Produto { get; set; } = new Produto();

        [Range(1, int.MaxValue, ErrorMessage = "Quantidade mínima é 1")]
        public int Quantidade { get; set; } = 1;

        public decimal Subtotal => Produto.Preco * Quantidade;
    }
}
